using Forme.Dialog;
using Forme.ServerCommunication;
using Forme.Session;
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
            SessionData.Instance.NazivDokumenta = (NazivDokumenta)uCUnosDokumenta.CbNaziv.SelectedItem;
            SessionData.Instance.DodatiProizvodi = new List<Proizvod>();
            SessionData.Instance.StavkeDokumenta = new BindingList<StavkaDokumenta>();
            partneri = Communication.Instance.SendRequestGetResult<List<PoslovniPartner>>(Operation.UcitajPoslovnePartnere);

            uCUnosDokumenta.DgvStavke.DataSource = SessionData.Instance.StavkeDokumenta;
            uCUnosDokumenta.DgvStavke.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uCUnosDokumenta.DgvStavke.ColumnHeadersDefaultCellStyle.Font = new Font("Sagoe UI", 10.2F, FontStyle.Bold);
            uCUnosDokumenta.DgvStavke.DefaultCellStyle.Font = new Font("Sagoe UI", 9.2F, FontStyle.Bold);
            uCUnosDokumenta.DgvStavke.Columns["DokumentId"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["TableName"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["InsertValues"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["PrimaryKey"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["ForeignKey"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["WhereCondition"].Visible = false;
            uCUnosDokumenta.DgvStavke.Columns["SetValues"].Visible = false;


            uCUnosDokumenta.CbNaziv.SelectedIndexChanged += CbNaziv_SelectedIndexChanged;
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

                dokument.StavkeDokumenta = SessionData.Instance.StavkeDokumenta.ToList();

                foreach (StavkaDokumenta stavka in dokument.StavkeDokumenta)
                {
                    // izmena kolicine proizvoda
                    Communication.Instance.SendRequestNoResult(Operation.IzmeniProizvod, stavka.Proizvod);
                }

                Communication.Instance.SendRequestNoResult(Operation.UnesiMagacinskiDokument, dokument);
                MessageBox.Show("Magacinski dokument je sacuvan!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da sacuva magacinski dokument!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

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

            if (SessionData.Instance.StavkeDokumenta.Count == 0)
            {
                MessageBox.Show("Morate uneti barem jednu stavku!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                uspesno = false;
            }

            return uspesno;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                StavkaDokumenta izabranaStavka = (StavkaDokumenta)uCUnosDokumenta.DgvStavke.SelectedRows[0].DataBoundItem;

                SessionData.Instance.StavkeDokumenta.Remove(izabranaStavka);

                for (int i = 0; i < SessionData.Instance.StavkeDokumenta.Count; i++)
                {
                    SessionData.Instance.StavkeDokumenta[i].RbStavke = i + 1;
                }

                uCUnosDokumenta.TxtUkupno.Text = SessionData.Instance.StavkeDokumenta.Sum(s => s.Iznos).ToString();


                SessionData.Instance.DodatiProizvodi.Remove(izabranaStavka.Proizvod);
            }
            catch (Exception)
            {
                MessageBox.Show("Odaberite stavku iz tabele koju zelite da obrisete!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }

        }

        private void BtnNovaStavka_Click(object sender, EventArgs e)
        {
            uCUnosDokumenta.CbNaziv.Enabled = false;
            dialog = new DialogNovaStavka();


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                uCUnosDokumenta.TxtUkupno.Text = SessionData.Instance.StavkeDokumenta.Sum(s => s.Iznos).ToString();
                dialog.Dispose();
            }
        }

        private void CboxPravnoLice_CheckedChanged(object sender, EventArgs e)
        {
            if (uCUnosDokumenta.CboxPravnoLice.Checked)
            {
                //uCUnosDokumenta.CboxFizickoLice.Enabled = false;
                uCUnosDokumenta.CboxFizickoLice.CheckState = CheckState.Unchecked;
                uCUnosDokumenta.CbImePrezime.Text = "";
                uCUnosDokumenta.TxtAdresaFl.Text = "";

                uCUnosDokumenta.CbFirma.Enabled = true;
                uCUnosDokumenta.TxtPib.Enabled = true;
                uCUnosDokumenta.TxtEmail.Enabled = true;
                uCUnosDokumenta.TxtAdresaPl.Enabled = true;

                uCUnosDokumenta.CbFirma.DataSource = partneri.Where(p => p.TableName == "PravnoLice").ToList();
                PrikaziDetaljeOPravnomLicu();
                uCUnosDokumenta.CbFirma.SelectedIndexChanged += CbFirma_SelectedIndexChanged;
            }
            else
            {
                uCUnosDokumenta.CbFirma.Text = "";
                uCUnosDokumenta.TxtPib.Text = "";
                uCUnosDokumenta.TxtEmail.Text = "";
                uCUnosDokumenta.TxtAdresaPl.Text = "";
            }
        }

        private void CbFirma_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziDetaljeOPravnomLicu();
        }

        private void PrikaziDetaljeOPravnomLicu()
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
            if (uCUnosDokumenta.CboxFizickoLice.Checked)
            {
                //uCUnosDokumenta.CboxPravnoLice.Enabled = false;
                uCUnosDokumenta.CboxPravnoLice.CheckState = CheckState.Unchecked;
                uCUnosDokumenta.CbFirma.Text = "";
                uCUnosDokumenta.TxtPib.Text = "";
                uCUnosDokumenta.TxtEmail.Text = "";
                uCUnosDokumenta.TxtAdresaPl.Text = "";

                uCUnosDokumenta.CbImePrezime.Enabled = true;
                uCUnosDokumenta.TxtAdresaFl.Enabled = true;

                uCUnosDokumenta.CbImePrezime.DataSource = partneri.Where(p => p.TableName == "FizickoLice").ToList();
                PrikaziDetaljeOFizickomLicu();
                uCUnosDokumenta.CbImePrezime.SelectedIndexChanged += CbImePrezime_SelectedIndexChanged;
            }
            else
            {
                uCUnosDokumenta.CbImePrezime.Text = "";
                uCUnosDokumenta.TxtAdresaFl.Text = "";
            }

        }

        private void CbImePrezime_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrikaziDetaljeOFizickomLicu();
        }

        private void PrikaziDetaljeOFizickomLicu()
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

        private void CbNaziv_SelectedIndexChanged(object sender, EventArgs e)
        {
            SessionData.Instance.NazivDokumenta = (NazivDokumenta)uCUnosDokumenta.CbNaziv.SelectedItem;
        }
    }
}
