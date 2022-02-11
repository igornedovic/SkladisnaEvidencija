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
    public class PretragaDokumenataController
    {
        private UCPretragaDokumenata uCPretragaDokumenata;
        private BindingList<Dokument> dokumenti;
        private BindingList<Dokument> dokumentiPretraga;
        private Dokument dokumentZaPretragu = new Dokument();
        private Dokument izabraniDokument;
        private BindingList<StavkaDokumenta> stavke;
        private DialogNovaStavka dialog;

        public PretragaDokumenataController(UCPretragaDokumenata uCPretragaDokumenata)
        {
            this.uCPretragaDokumenata = uCPretragaDokumenata;
        }

        internal void Init()
        {
            uCPretragaDokumenata.CbNaziv.DataSource = Enum.GetValues(typeof(NazivDokumenta));

            dokumenti = new BindingList<Dokument>(Communication.Instance.SendRequestGetResult<List<Dokument>>(Operation.UcitajMagacinskeDokumente));
            uCPretragaDokumenata.DgvDokumenti.DataSource = dokumenti;

            PrilagodiTabelu();

            uCPretragaDokumenata.BtnPretrazi.Click += BtnPretrazi_Click;
            uCPretragaDokumenata.BtnResetuj.Click += BtnResetuj_Click;
            uCPretragaDokumenata.BtnDetalji.Click += BtnDetalji_Click;
            uCPretragaDokumenata.BtnIzmeni.Click += BtnIzmeni_Click;
            uCPretragaDokumenata.BtnNovaStavka.Click += BtnNovaStavka_Click;
        }

        private void PrilagodiTabelu()
        {
            uCPretragaDokumenata.DgvDokumenti.Columns["DokumentId"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["TableName"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["InsertValues"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["PrimaryKey"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["ForeignKey"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["Criteria"].Visible = false;

            uCPretragaDokumenata.DgvDokumenti.Columns["Datum"].DefaultCellStyle.Format = "dd.MM.yyyy";
            
        }

        private void BtnNovaStavka_Click(object sender, EventArgs e)
        {
            dialog = new DialogNovaStavka();

            dialog.BtnDodaj.Click += BtnDodaj_Click;


            if (dialog.ShowDialog() == DialogResult.OK)
            {
                izabraniDokument.UkupanIznos = stavke.Sum(s => s.Iznos);
            }

            uCPretragaDokumenata.BtnSacuvaj.Enabled = true;
            dialog.Dispose();
        }

        private void BtnDodaj_Click(object sender, EventArgs e)
        {
            if (!ValidacijaStavke())
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

        internal bool ValidacijaStavke()
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

        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            uCPretragaDokumenata.GroupBox1.Enabled = true;
            uCPretragaDokumenata.BtnSacuvaj.Enabled = false;
        }
        private void BtnDetalji_Click(object sender, EventArgs e)
        {
            if (uCPretragaDokumenata.DgvDokumenti.SelectedRows.Count == 0)
            {
                MessageBox.Show("Izaberite dokument u tabeli za koji zelite da ucitate podatke!");
                return;
            }

            uCPretragaDokumenata.GroupBox1.Enabled = false;

            izabraniDokument = (Dokument)uCPretragaDokumenata.DgvDokumenti.SelectedRows[0].DataBoundItem;
            izabraniDokument = Communication.Instance.SendRequestGetResult<Dokument>(Operation.UcitajMagacinskiDokument, izabraniDokument);

            stavke = new BindingList<StavkaDokumenta>(izabraniDokument.StavkeDokumenta);
            uCPretragaDokumenata.DgvStavke.DataSource = stavke;

            uCPretragaDokumenata.DgvStavke.Columns["DokumentId"].Visible = false;
            uCPretragaDokumenata.DgvStavke.Columns["TableName"].Visible = false;
            uCPretragaDokumenata.DgvStavke.Columns["InsertValues"].Visible = false;
            uCPretragaDokumenata.DgvStavke.Columns["PrimaryKey"].Visible = false;
            uCPretragaDokumenata.DgvStavke.Columns["ForeignKey"].Visible = false;
            uCPretragaDokumenata.DgvStavke.Columns["Criteria"].Visible = false;

        }
        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            uCPretragaDokumenata.GroupBox1.Enabled = false;

            uCPretragaDokumenata.CbNaziv.SelectedIndex = 0;
            uCPretragaDokumenata.TxtDatum.Text = "";

            uCPretragaDokumenata.BtnPretrazi.Enabled = true;

            uCPretragaDokumenata.DgvDokumenti.DataSource = null;
            uCPretragaDokumenata.DgvDokumenti.DataSource = dokumenti;

            PrilagodiTabelu();
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if(!ValidacijaPretrage())
            {
                return;
            }

            uCPretragaDokumenata.GroupBox1.Enabled = false;

            dokumentZaPretragu.NazivDokumenta = (NazivDokumenta)uCPretragaDokumenata.CbNaziv.SelectedItem;
            dokumentZaPretragu.Datum = DateTime.ParseExact(uCPretragaDokumenata.TxtDatum.Text, "dd.MM.yyyy", null); 

            dokumentiPretraga = new BindingList<Dokument>(Communication.Instance.SendRequestGetResult<List<Dokument>>(Operation.PretraziMagacinskeDokumente, dokumentZaPretragu));
            
            uCPretragaDokumenata.DgvDokumenti.DataSource = null;
            foreach (Dokument dok in dokumentiPretraga)
            {
                if (dok.PoslovniPartner.TableName == "FizickoLice")
                {
                    dok.PoslovniPartner = (FizickoLice)dok.PoslovniPartner;

                }
                else
                {
                    dok.PoslovniPartner = (PravnoLice)dok.PoslovniPartner;
                }
            }

            uCPretragaDokumenata.DgvDokumenti.DataSource = dokumentiPretraga;


            //if (izabraniDokument.PoslovniPartner.TableName == "FizickoLice")
            //{
            //    uCPretragaDokumenata.TxtPoslovniPartner.Text = ((FizickoLice)izabraniDokument.PoslovniPartner).ToString();
            //}
            //else
            //{
            //    uCPretragaDokumenata.TxtPoslovniPartner.Text = ((PravnoLice)izabraniDokument.PoslovniPartner).ToString();

            //}

            PrilagodiTabelu();

            if (dokumentiPretraga != null && dokumentiPretraga.Count > 0)
            {
                MessageBox.Show("Sistem je pronasao magacinske dokumente po zadatom kriterijumu!");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da pronadje magacinske dokumente po zadatom kriterijumu!");
            }

            uCPretragaDokumenata.BtnPretrazi.Enabled = false;

        }

        private bool ValidacijaPretrage()
        {
            bool uspesno = true;

            if (uCPretragaDokumenata.CbNaziv.SelectedItem == null)
            {
                uCPretragaDokumenata.CbNaziv.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCPretragaDokumenata.CbNaziv.BackColor = Color.White;
            }


            if (string.IsNullOrWhiteSpace(uCPretragaDokumenata.TxtDatum.Text) || !DateTime.TryParseExact(uCPretragaDokumenata.TxtDatum.Text, "dd.MM.yyyy", null, DateTimeStyles.None, out _))
            {
                uCPretragaDokumenata.TxtDatum.BackColor = Color.Salmon;
                uspesno = false;
            }
            else
            {
                uCPretragaDokumenata.TxtDatum.BackColor = Color.White;
            }

            return uspesno;
        }
    }
}
