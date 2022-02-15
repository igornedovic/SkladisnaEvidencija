using Forme.Dialog;
using Forme.ServerCommunication;
using Projekat.Common.Communication;
using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forme.GUIController
{
    public class NovaStavkaController
    {
        private DialogNovaStavka dialog;

        public NovaStavkaController(DialogNovaStavka dialog)
        {
            this.dialog = dialog;
        }

        internal void Init()
        {
            dialog.CbProizvod.DataSource = Communication.Instance.SendRequestGetResult<List<Proizvod>>(Operation.UcitajProizvode);
            UslovZaOtpremnicu();

            dialog.CbProizvod.SelectedIndexChanged += CbProizvod_SelectedIndexChanged;
            dialog.TxtKolicina.TextChanged += AzurirajIznos_TextChanged;
            dialog.TxtCena.TextChanged += AzurirajIznos_TextChanged;
            dialog.BtnDodaj.Click += BtnDodaj_Click;
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

        private void CbProizvod_SelectedIndexChanged(object sender, EventArgs e)
        {

            UslovZaOtpremnicu();
  
        }

        private void UslovZaOtpremnicu()
        {
            try
            {
                Session.SessionData.Instance.TrenutniProizvod = (Proizvod)dialog.CbProizvod.SelectedItem;

                if (Session.SessionData.Instance.NazivDokumenta == NazivDokumenta.Otpremnica)
                {
                    dialog.LblNapomena.Text = $"Napomena: Ukupna raspoloziva kolicina ovog proizvoda je " +
                        $"{Session.SessionData.Instance.TrenutniProizvod.UkupnaKolicina}!";
                    dialog.LblNapomena.Visible = true;
                }

                dialog.TxtJm.Text = Session.SessionData.Instance.TrenutniProizvod.JedinicaMere.Naziv;
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Greska: " + ex.Message);
            }
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaStavke())
            {
                return;
            }


            StavkaDokumenta stavka = new StavkaDokumenta();
            stavka.RbStavke = Session.SessionData.Instance.StavkeDokumenta.Count + 1;
            stavka.Proizvod = (Proizvod)dialog.CbProizvod.SelectedItem;
            stavka.Kolicina = int.Parse(dialog.TxtKolicina.Text);
            stavka.Cena = double.Parse(dialog.TxtCena.Text);
            stavka.Iznos = stavka.Kolicina * stavka.Cena;

            if (Session.SessionData.Instance.NazivDokumenta == NazivDokumenta.Prijemnica)
            {
                stavka.Proizvod.UkupnaKolicina += stavka.Kolicina;
            }
            else
            {
                stavka.Proizvod.UkupnaKolicina -= stavka.Kolicina;
            }

            if (!Session.SessionData.Instance.StavkeDokumenta.Contains(stavka))
            {
                Session.SessionData.Instance.StavkeDokumenta.Add(stavka);
                dialog.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Vec ste uneli stavku koja se odnosi na dati proizvod! " +
                    "Mozete obrisati postojecu stavku i uneti novu za isti proizvod", "Upozorenje",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

            bool uslovZaOtpremnicu = (Session.SessionData.Instance.NazivDokumenta == NazivDokumenta.Otpremnica)
                                        && (kolicina > Session.SessionData.Instance.TrenutniProizvod.UkupnaKolicina);

            if (kolicina <= 0 || uslovZaOtpremnicu)
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
    }
}
