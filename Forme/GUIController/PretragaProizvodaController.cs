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
    public class PretragaProizvodaController
    {
        private UCPretragaProizvoda uCPretragaProizvoda;
        private BindingList<Proizvod> proizvodi;
        private Proizvod proizvodZaPretragu = new Proizvod();
        private BindingList<Proizvod> proizvodiPretraga;
        private Proizvod izabraniProizvod;

        public PretragaProizvodaController(UCPretragaProizvoda uCPretragaProizvoda)
        {
            this.uCPretragaProizvoda = uCPretragaProizvoda;
        }

        internal void Init()
        {
            proizvodi = new BindingList<Proizvod>(Communication.Instance.SendRequestGetResult<List<Proizvod>>(Operation.UcitajProizvode));
            uCPretragaProizvoda.DgvProizvodi.DataSource = proizvodi;

            PrilagodiTabelu();

            uCPretragaProizvoda.BtnPretrazi.Click += BtnPretrazi_Click;
            uCPretragaProizvoda.BtnResetuj.Click += BtnResetuj_Click;

            uCPretragaProizvoda.BtnDetalji.Click += BtnDetalji_Click;
        }

        private void PrilagodiTabelu()
        {
            uCPretragaProizvoda.DgvProizvodi.Columns["ProizvodId"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["Opis"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["JedinicaMere"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["TableName"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["InsertValues"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["PrimaryKey"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["ForeignKey"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["Criteria"].Visible = false;
            uCPretragaProizvoda.DgvProizvodi.Columns["Set"].Visible = false;
        }

        private void BtnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                if (uCPretragaProizvoda.DgvProizvodi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Izaberite proizvod u tabeli za koji zelite da ucitate podatke!");
                    return;
                }

                izabraniProizvod = (Proizvod)uCPretragaProizvoda.DgvProizvodi.SelectedRows[0].DataBoundItem;
                izabraniProizvod = Communication.Instance.SendRequestGetResult<Proizvod>(Operation.UcitajProizvod, izabraniProizvod);

                MessageBox.Show("Sistem je ucitao podatke o proizvodu!");

                uCPretragaProizvoda.TxtNazivUpdate.Text = izabraniProizvod.Naziv;
                uCPretragaProizvoda.TxtJm.Text = izabraniProizvod.JedinicaMere.Naziv;
                uCPretragaProizvoda.TxtRaspolozivaKolicina.Text = izabraniProizvod.UkupnaKolicina.ToString();
                uCPretragaProizvoda.TxtOpis.Text = izabraniProizvod.Opis;

                uCPretragaProizvoda.BtnIzmeni.Enabled = true;
                uCPretragaProizvoda.BtnObrisi.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita podatke o proizvodu!");
            }
        }

        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            uCPretragaProizvoda.TxtNaziv.Text = "";

            uCPretragaProizvoda.BtnPretrazi.Enabled = true;

            uCPretragaProizvoda.DgvProizvodi.DataSource = null;
            uCPretragaProizvoda.DgvProizvodi.DataSource = proizvodi;
            PrilagodiTabelu();
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uCPretragaProizvoda.TxtNaziv.Text))
            {
                uCPretragaProizvoda.TxtNaziv.BackColor = Color.Salmon;
                return;
            }
            else
            {
                uCPretragaProizvoda.TxtNaziv.BackColor = Color.White;
            }

            proizvodZaPretragu.Naziv = uCPretragaProizvoda.TxtNaziv.Text;
            proizvodiPretraga = new BindingList<Proizvod>(Communication.Instance.SendRequestGetResult<List<Proizvod>>(Operation.PretraziProizvode, proizvodZaPretragu));

            uCPretragaProizvoda.DgvProizvodi.DataSource = null;
            uCPretragaProizvoda.DgvProizvodi.DataSource = proizvodiPretraga;
            PrilagodiTabelu();

            if (proizvodiPretraga != null && proizvodiPretraga.Count > 0)
            {
                MessageBox.Show("Sistem je pronasao proizvode po trazenom kriterijumu!");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da pronadje proizvode po zadatom kriterijumu!");
            }

            uCPretragaProizvoda.BtnPretrazi.Enabled = false;
        }
    }
}
