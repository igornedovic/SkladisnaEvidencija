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

            uCPretragaProizvoda.BtnIzmeni.Click += BtnIzmeni_Click;
            uCPretragaProizvoda.BtnObrisi.Click += BtnObrisi_Click;

            uCPretragaProizvoda.BtnSacuvaj.Click += BtnSacuvaj_Click;
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

        private void Osvezi()
        {
            proizvodi = new BindingList<Proizvod>(Communication.Instance.SendRequestGetResult<List<Proizvod>>(Operation.UcitajProizvode));
            BtnResetuj_Click(this, EventArgs.Empty);
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validacija())
                {
                    return;
                }

                izabraniProizvod.Naziv = uCPretragaProizvoda.TxtNazivUpdate.Text;
                izabraniProizvod.UkupnaKolicina = int.Parse(uCPretragaProizvoda.TxtRaspolozivaKolicina.Text);
                izabraniProizvod.Opis = uCPretragaProizvoda.TxtOpis.Text;

                Communication.Instance.SendRequestNoResult(Operation.IzmeniProizvod, izabraniProizvod);
                Osvezi();
                MessageBox.Show("Sistem je izmenio podatke o proizvodu!");
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da izmeni podatke o proizvodu!");
            }
        }
        
        private bool Validacija()
        {
            bool uspesno = true;

            if (string.IsNullOrWhiteSpace(uCPretragaProizvoda.TxtNazivUpdate.Text))
            {
                uCPretragaProizvoda.TxtNazivUpdate.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCPretragaProizvoda.TxtNazivUpdate.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(uCPretragaProizvoda.TxtRaspolozivaKolicina.Text))
            {
                uCPretragaProizvoda.TxtRaspolozivaKolicina.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCPretragaProizvoda.TxtRaspolozivaKolicina.BackColor = Color.White;
            }

            if (string.IsNullOrWhiteSpace(uCPretragaProizvoda.TxtOpis.Text))
            {
                uCPretragaProizvoda.TxtOpis.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCPretragaProizvoda.TxtOpis.BackColor = Color.White;
            }

            return uspesno;
        }

        private void BtnObrisi_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            uCPretragaProizvoda.GroupBox1.Enabled = true;
            uCPretragaProizvoda.BtnSacuvaj.Enabled = false;

            uCPretragaProizvoda.TxtNazivUpdate.TextChanged += IzvrsenaPromena_Event;
            uCPretragaProizvoda.TxtRaspolozivaKolicina.TextChanged += IzvrsenaPromena_Event;
            uCPretragaProizvoda.TxtOpis.TextChanged += IzvrsenaPromena_Event;
        }

        private void IzvrsenaPromena_Event(object sender, EventArgs e)
        {
            uCPretragaProizvoda.BtnSacuvaj.Enabled = true;
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
            uCPretragaProizvoda.GroupBox1.Enabled = false;
            uCPretragaProizvoda.BtnIzmeni.Enabled = false;
            uCPretragaProizvoda.BtnObrisi.Enabled = false;

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
