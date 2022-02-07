using Forme.Dialog;
using Forme.ServerCommunication;
using Forme.UserControls;
using Projekat.Common.Communication;
using Projekat.Common.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forme.GUIController
{
    public class UnosDokumentaController
    {
        private UCUnosDokumenta uCUnosDokumenta;
        private Dokument dokument = new Dokument();
        private BindingList<StavkaDokumenta> stavke = new BindingList<StavkaDokumenta>();
        private DialogNovaStavka dialog;
        private StavkaDokumenta stavka;
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
            uCUnosDokumenta.CboxFizickoLice.CheckedChanged += CboxFizickoLice_CheckedChanged;
            uCUnosDokumenta.CboxPravnoLice.CheckedChanged += CboxPravnoLice_CheckedChanged;

            uCUnosDokumenta.BtnDodaj.Click += BtnDodaj_Click;
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            dialog = new DialogNovaStavka();
            dialog.CbProizvod.DataSource = Communication.Instance.SendRequestGetResult<List<Proizvod>>(Operation.UcitajProizvode);
            dialog.CbProizvod.SelectedIndexChanged += CbProizvod_SelectedIndexChanged;
            dialog.ShowDialog();
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
