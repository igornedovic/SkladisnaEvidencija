using Forme.Dialog;
using Forme.ServerCommunication;
using Forme.UserControls;
using Projekat.Common.Communication;
using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
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

        public UnosDokumentaController(UCUnosDokumenta uCUnosDokumenta)
        {
            this.uCUnosDokumenta = uCUnosDokumenta;
        }

        internal void Init()
        {
            uCUnosDokumenta.TxtIme.Enabled = false;
            uCUnosDokumenta.TxtPrezime.Enabled = false;
            uCUnosDokumenta.TxtFirma.Enabled = false;
            uCUnosDokumenta.TxtPib.Enabled = false;
            uCUnosDokumenta.TxtEmail.Enabled = false;
            uCUnosDokumenta.TxtAdresa.Enabled = false;


            uCUnosDokumenta.CbNaziv.DataSource = Enum.GetValues(typeof(NazivDokumenta));
            uCUnosDokumenta.DgvStavke.DataSource = stavke;
            uCUnosDokumenta.DgvStavke.Columns[0].Visible = false;
            uCUnosDokumenta.CboxFizickoLice.CheckedChanged += CboxFizickoLice_CheckedChanged;
            uCUnosDokumenta.CboxPravnoLice.CheckedChanged += CboxPravnoLice_CheckedChanged;

            uCUnosDokumenta.BtnNovaStavka.Click += BtnNovaStavka_Click;
            uCUnosDokumenta.BtnObrisi.Click += BtnObrisi_Click;
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
            catch (Exception ex)
            {
                MessageBox.Show("Odaberite stavku iz tabele koju zelite da obrisete! " + ex.Message);
                
            }

        }

        private void BtnNovaStavka_Click(object sender, EventArgs e)
        {
            dialog = new DialogNovaStavka();
            dialog.CbProizvod.DataSource = Communication.Instance.SendRequestGetResult<List<Proizvod>>(Operation.UcitajProizvode);
            dialog.CbProizvod.SelectedIndexChanged += CbProizvod_SelectedIndexChanged;
            dialog.TxtKolicina.TextChanged += AzurirajIznos_TextChanged;
            dialog.TxtCena.TextChanged += AzurirajIznos_TextChanged;
            dialog.BtnDodaj.Click += BtnDodaj_Click;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                uCUnosDokumenta.TxtUkupno.Text = stavke.Sum(s => s.Iznos).ToString();
            }

            dialog.Dispose();
        }

        private void AzurirajIznos_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(dialog.TxtKolicina.Text) && !string.IsNullOrEmpty(dialog.TxtCena.Text))
                {
                    int kolicina = int.Parse(dialog.TxtKolicina.Text);
                    double cena = double.Parse(dialog.TxtCena.Text);

                    dialog.TxtIznos.Text = (kolicina * cena).ToString();
                }
                else
                {
                    dialog.TxtIznos.Text = "";
                }
            }
            catch (FormatException ex)
            {
                dialog.TxtIznos.Text = "";
                MessageBox.Show("Greska! " + ex.Message);
            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if(!ValidacijaStavke())
            {
                return;
            }

            // dodati ako stavka sa istim proizvodom postoji u listi, azurirati kolicinu proizvoda
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

        private void CbProizvod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dialog.CbProizvod.SelectedItem != null)
                {
                    Proizvod proizvod = (Proizvod)dialog.CbProizvod.SelectedItem;
                    dialog.TxtJm.Text = proizvod.JedinicaMere.Naziv;
                }

            }
            catch (FormatException ex)
            {
                System.Windows.Forms.MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void CboxPravnoLice_CheckedChanged(object sender, EventArgs e)
        {
            uCUnosDokumenta.CboxFizickoLice.Enabled = false;
            uCUnosDokumenta.TxtFirma.Enabled = true;
            uCUnosDokumenta.TxtPib.Enabled = true;
            uCUnosDokumenta.TxtEmail.Enabled = true;
            uCUnosDokumenta.TxtAdresa.Enabled = true;

            dokument.PoslovniPartner = new PravnoLice();
        }

        private void CboxFizickoLice_CheckedChanged(object sender, EventArgs e)
        {
            uCUnosDokumenta.CboxPravnoLice.Enabled = false;
            uCUnosDokumenta.TxtIme.Enabled = true;
            uCUnosDokumenta.TxtPrezime.Enabled = true;
            uCUnosDokumenta.TxtAdresa.Enabled = true;

            dokument.PoslovniPartner = new FizickoLice();
        }
    }
}
