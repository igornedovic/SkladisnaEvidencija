using Forme.Dialog;
using Forme.ServerCommunication;
using Forme.UserControls;
using Projekat.Common.Communication;
using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIController
{
    public class UnosDokumentaController
    {
        private UCUnosDokumenta uCUnosDokumenta;
        private Dokument dokument = new Dokument();
        private BindingList<StavkaDokumenta> stavke = new BindingList<StavkaDokumenta>();
        private DialogNovaStavka dialog;
        private List<PoslovniPartner> partneri = new List<PoslovniPartner>();

        public UnosDokumentaController(UCUnosDokumenta uCUnosDokumenta)
        {
            this.uCUnosDokumenta = uCUnosDokumenta;
        }

        internal void Init()
        {
            uCUnosDokumenta.CbImePrezime.Enabled = false;
            uCUnosDokumenta.TxtAdresaFl.Enabled = false;
            uCUnosDokumenta.CbFirma.Enabled = false;
            uCUnosDokumenta.TxtPib.Enabled = false;
            uCUnosDokumenta.TxtEmail.Enabled = false;
            uCUnosDokumenta.TxtAdresaPl.Enabled = false;


            uCUnosDokumenta.CbNaziv.DataSource = Enum.GetValues(typeof(NazivDokumenta));
            partneri = Communication.Instance.SendRequestGetResult<List<PoslovniPartner>>(Operation.UcitajPoslovnePartnere);

            uCUnosDokumenta.DgvStavke.DataSource = stavke;
            uCUnosDokumenta.DgvStavke.Columns["DokumentId"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["TableName"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["InsertValues"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["PrimaryKey"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["ForeignKey"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["Criteria"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["Set"].Visible = false;


            uCUnosDokumenta.CboxFizickoLice.CheckedChanged += CboxFizickoLice_CheckedChanged;
            uCUnosDokumenta.CboxPravnoLice.CheckedChanged += CboxPravnoLice_CheckedChanged;

            uCUnosDokumenta.BtnNovaStavka.Click += BtnNovaStavka_Click;
            uCUnosDokumenta.BtnObrisi.Click += BtnObrisi_Click;

            uCUnosDokumenta.BtnSacuvaj.Click += BtnSacuvaj_Click;
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidacijaDokumenta())
                {
                    return;
                }

                dokument.NazivDokumenta = (NazivDokumenta)uCUnosDokumenta.CbNaziv.SelectedItem;
                dokument.Datum = DateTime.ParseExact(uCUnosDokumenta.TxtDatum.Text, "dd.MM.yyyy", null);
                dokument.UkupanIznos = double.Parse(uCUnosDokumenta.TxtUkupno.Text);
                dokument.Status = uCUnosDokumenta.TxtStatus.Text;

                if (uCUnosDokumenta.CboxFizickoLice.Checked)
                {
                    dokument.PoslovniPartner = (FizickoLice)uCUnosDokumenta.CbImePrezime.SelectedItem;
                }
                else
                {
                    dokument.PoslovniPartner = (PravnoLice)uCUnosDokumenta.CbFirma.SelectedItem;
                }

                dokument.StavkeDokumenta = stavke.ToList();

                Communication.Instance.SendRequestNoResult(Operation.UnesiMagacinskiDokument, dokument);
                MessageBox.Show("Magacinski dokument je sacuvan!");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da sacuva magacinski dokument!");
            }

        }

        // morate uneti barem jednu stavku
        private bool ValidacijaDokumenta()
        {
            bool uspesno = true;
            if (uCUnosDokumenta.CbNaziv.SelectedItem == null)
            {
                uCUnosDokumenta.CbNaziv.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCUnosDokumenta.CbNaziv.BackColor = Color.White;
            }
            if (!DateTime.TryParseExact(uCUnosDokumenta.TxtDatum.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out _))
            {
                uCUnosDokumenta.TxtDatum.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCUnosDokumenta.TxtDatum.BackColor = Color.White;
            }
            // validacija poslovnog partnera - fizicko lice
            if(uCUnosDokumenta.CboxFizickoLice.Checked && !uCUnosDokumenta.CboxPravnoLice.Checked)
            {
                uCUnosDokumenta.CboxFizickoLice.BackColor = Color.White;
                uCUnosDokumenta.CboxPravnoLice.BackColor = Color.White;

                if (uCUnosDokumenta.CbImePrezime.SelectedItem == null)
                {
                    uCUnosDokumenta.CbImePrezime.BackColor = Color.Salmon;
                    uspesno = false;
                }
                else
                {
                    uCUnosDokumenta.CbImePrezime.BackColor = Color.White;
                }

                if (string.IsNullOrWhiteSpace(uCUnosDokumenta.TxtAdresaFl.Text))
                {
                    uCUnosDokumenta.TxtAdresaFl.BackColor = Color.Salmon;
                    uspesno = false;
                }
                else
                {
                    uCUnosDokumenta.TxtAdresaFl.BackColor = Color.White;
                }
            } // validacija poslovnog partnera - pravno lice
            else if (!uCUnosDokumenta.CboxFizickoLice.Checked && uCUnosDokumenta.CboxPravnoLice.Checked)
            {
                uCUnosDokumenta.CboxFizickoLice.BackColor = Color.White;
                uCUnosDokumenta.CboxPravnoLice.BackColor = Color.White;

                if (uCUnosDokumenta.CbFirma.SelectedItem == null)
                {
                    uCUnosDokumenta.CbFirma.BackColor = Color.Salmon;
                    uspesno = false;
                }
                else
                {
                    uCUnosDokumenta.CbFirma.BackColor = Color.White;
                }

                if (string.IsNullOrWhiteSpace(uCUnosDokumenta.TxtPib.Text))
                {
                    uCUnosDokumenta.TxtPib.BackColor = Color.Salmon;
                    uspesno = false;
                }
                else
                {
                    uCUnosDokumenta.TxtPib.BackColor = Color.White;

                }
                if (string.IsNullOrWhiteSpace(uCUnosDokumenta.TxtEmail.Text))
                {
                    uCUnosDokumenta.TxtEmail.BackColor = Color.Salmon;
                    uspesno = false;
                }
                else
                {
                    uCUnosDokumenta.TxtEmail.BackColor = Color.White;
                }
                if (string.IsNullOrWhiteSpace(uCUnosDokumenta.TxtAdresaPl.Text))
                {
                    uCUnosDokumenta.TxtAdresaPl.BackColor = Color.Salmon;
                    uspesno = false;
                }
                else
                {
                    uCUnosDokumenta.TxtAdresaPl.BackColor = Color.White;
                }
            }
            else
            {
                uCUnosDokumenta.CboxFizickoLice.BackColor = Color.Salmon;
                uCUnosDokumenta.CboxPravnoLice.BackColor = Color.Salmon;
                uspesno = false;
            }

            if(stavke.Count == 0)
            {
                MessageBox.Show("Morate uneti barem jednu stavku!");
                uspesno = false;
            }

            if(string.IsNullOrWhiteSpace(uCUnosDokumenta.TxtStatus.Text))
            {
                uCUnosDokumenta.TxtStatus.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCUnosDokumenta.TxtStatus.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(uCUnosDokumenta.TxtUkupno.Text))
            {
                uCUnosDokumenta.TxtUkupno.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCUnosDokumenta.TxtUkupno.BackColor = Color.White;
            }

            return uspesno;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                StavkaDokumenta izabranaStavka = (StavkaDokumenta)uCUnosDokumenta.DgvStavke.SelectedRows[0].DataBoundItem;


                stavke.Remove(izabranaStavka);

                for (int i = 0; i < stavke.Count; i++)
                {
                    stavke[i].RbStavke = i + 1;
                }

                uCUnosDokumenta.TxtUkupno.Text = stavke.Sum(s => s.Iznos).ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele koju zelite da obrisete!");
                
            }

        }

        private void BtnNovaStavka_Click(object sender, EventArgs e)
        {
            dialog = new DialogNovaStavka();
            dialog.BtnDodaj.Click += BtnDodaj_Click;
            

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                uCUnosDokumenta.TxtUkupno.Text = stavke.Sum(s => s.Iznos).ToString();
            }

            dialog.Dispose();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if(!ValidacijaStavke())
            {
                return;
            }

            
            StavkaDokumenta stavka = new StavkaDokumenta();
            stavka.RbStavke = stavke.Count + 1;
            stavka.Proizvod = (Proizvod)dialog.CbProizvod.SelectedItem;
            stavka.Kolicina = int.Parse(dialog.TxtKolicina.Text);
            stavka.Cena = double.Parse(dialog.TxtCena.Text);
            stavka.Iznos = stavka.Kolicina * stavka.Cena;

            stavke.Add(stavka);

            dialog.DialogResult = DialogResult.OK;
        }

        private bool ValidacijaStavke()
        {
            bool uspesno = true;
            if (dialog.CbProizvod.SelectedItem == null)
            {
                dialog.CbProizvod.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                dialog.CbProizvod.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(dialog.TxtJm.Text))
            {
                dialog.TxtJm.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                dialog.TxtJm.BackColor = Color.White;
            }

            if (!int.TryParse(dialog.TxtKolicina.Text, out int kolicina))
            {
                dialog.TxtKolicina.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                dialog.TxtKolicina.BackColor = Color.White;
            }

            if (kolicina <= 0)
            {
                dialog.TxtKolicina.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                dialog.TxtKolicina.BackColor = Color.White;
            }

            if (!double.TryParse(dialog.TxtCena.Text, out double cena))
            {
                dialog.TxtCena.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                dialog.TxtCena.BackColor = Color.White;
            }

            if (cena <= 0)
            {
                dialog.TxtCena.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                dialog.TxtKolicina.BackColor = Color.White;
            }

            if (string.IsNullOrEmpty(dialog.TxtIznos.Text))
            {
                dialog.TxtIznos.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                dialog.TxtIznos.BackColor = Color.White;
            }

            return uspesno;
        }

        private void CboxPravnoLice_CheckedChanged(object sender, EventArgs e)
        {
            uCUnosDokumenta.CboxFizickoLice.Enabled = false;
            uCUnosDokumenta.CbFirma.Enabled = true;
            uCUnosDokumenta.TxtPib.Enabled = true;
            uCUnosDokumenta.TxtEmail.Enabled = true;
            uCUnosDokumenta.TxtAdresaPl.Enabled = true;

            uCUnosDokumenta.CbFirma.DataSource = partneri.Where(p => p.TableName == "PravnoLice").ToList();
            uCUnosDokumenta.CbFirma.SelectedIndexChanged += CbFirma_SelectedIndexChanged;
        }

        private void CbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (uCUnosDokumenta.CbFirma.SelectedItem != null)
                {
                    PravnoLice pl = (PravnoLice)uCUnosDokumenta.CbFirma.SelectedItem;
                    uCUnosDokumenta.TxtPib.Text = pl.PIB;
                    uCUnosDokumenta.TxtEmail.Text = pl.Email;
                    uCUnosDokumenta.TxtAdresaPl.Text = pl.Adresa;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Greska: " + ex.Message);

            }
        }

        private void CboxFizickoLice_CheckedChanged(object sender, EventArgs e)
        {
            uCUnosDokumenta.CboxPravnoLice.Enabled = false;
            uCUnosDokumenta.CbImePrezime.Enabled = true;
            uCUnosDokumenta.TxtAdresaFl.Enabled = true;

            uCUnosDokumenta.CbImePrezime.DataSource = partneri.Where(p => p.TableName == "FizickoLice").ToList();
            uCUnosDokumenta.CbImePrezime.SelectedIndexChanged += CbImePrezime_SelectedIndexChanged;
        }

        private void CbImePrezime_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (uCUnosDokumenta.CbImePrezime.SelectedItem != null)
                {
                    FizickoLice fl = (FizickoLice)uCUnosDokumenta.CbImePrezime.SelectedItem;
                    uCUnosDokumenta.TxtAdresaFl.Text = fl.Adresa;
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Greska: " + ex.Message);

            }
        }
    }
}
