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
            dialog.CbProizvod.DataSource = Communication.Instance.SendRequestGetResult<List<Proizvod>>(Operation.UcitajProizvode);
            dialog.CbProizvod.SelectedIndexChanged += CbProizvod_SelectedIndexChanged;
            dialog.TxtKolicina.TextChanged += AzurirajIznos_TextChanged;
            dialog.TxtCena.TextChanged += AzurirajIznos_TextChanged;
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
                MessageBox.Show("Greska: " + ex.Message);
            }
        }
    }
}
