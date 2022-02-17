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
    public class PretragaDokumenataController
    {
        private UCPretragaDokumenata uCPretragaDokumenata;
        private BindingList<Dokument> dokumenti;
        private BindingList<Dokument> dokumentiPretraga;
        private Dokument dokumentZaPretragu = new Dokument();
        private Dokument izabraniDokument;
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
            uCPretragaDokumenata.BtnStorniraj.Click += BtnStorniraj_Click;

            uCPretragaDokumenata.BtnNovaStavka.Click += BtnNovaStavka_Click;
            uCPretragaDokumenata.BtnObrisiStavku.Click += BtnObrisiStavku_Click;

            uCPretragaDokumenata.BtnSacuvaj.Click += BtnSacuvaj_Click;
        }

        private void PrilagodiTabelu()
        {
            uCPretragaDokumenata.DgvDokumenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            uCPretragaDokumenata.DgvDokumenti.ColumnHeadersDefaultCellStyle.Font = new Font("Sagoe UI", 10.2F, FontStyle.Bold);
            uCPretragaDokumenata.DgvDokumenti.DefaultCellStyle.Font = new Font("Sagoe UI", 9.2F, FontStyle.Bold);
            uCPretragaDokumenata.DgvDokumenti.Columns["DokumentId"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["TableName"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["InsertValues"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["PrimaryKey"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["ForeignKey"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["WhereCondition"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["SetValues"].Visible = false;

            uCPretragaDokumenata.DgvDokumenti.Columns["Datum"].DefaultCellStyle.Format = "dd.MM.yyyy";
            
        }

        private void OsveziNakonIzmene()
        {  
            dokumenti = new BindingList<Dokument>(Communication.Instance.SendRequestGetResult<List<Dokument>>(Operation.UcitajMagacinskeDokumente));
            BtnResetuj_Click(this, EventArgs.Empty);
        }

        private void BtnSacuvaj_Click(object sender, EventArgs e)
        {
            try
            {
                izabraniDokument.Datum = DateTime.ParseExact(DateTime.Now.ToString("dd.MM.yyyy"), "dd.MM.yyyy", null);
                izabraniDokument.Status = "Izmenjeno";
                izabraniDokument.StavkeDokumenta = SessionData.Instance.StavkeDokumenta.ToList();
                izabraniDokument.UkupanIznos = izabraniDokument.StavkeDokumenta.Sum(s => s.Iznos);

                Communication.Instance.SendRequestNoResult(Operation.IzmeniMagacinskiDokument, izabraniDokument);
                OsveziNakonIzmene();
                MessageBox.Show("Sistem je izmenio podatke o magacinskom dokumentu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da izmeni podatke o magacinskom dokumentu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnObrisiStavku_Click(object sender, EventArgs e)
        {

            if (uCPretragaDokumenata.DgvStavke.SelectedRows.Count == 0 || uCPretragaDokumenata.DgvStavke.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite stavku iz tabele koju zelite da obrisete!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StavkaDokumenta izabranaStavka = (StavkaDokumenta)uCPretragaDokumenata.DgvStavke.SelectedRows[0].DataBoundItem;

            SessionData.Instance.StavkeDokumenta.Remove(izabranaStavka);

            for (int i = 0; i < SessionData.Instance.StavkeDokumenta.Count; i++)
            {
                SessionData.Instance.StavkeDokumenta[i].RbStavke = i + 1;
            }

            uCPretragaDokumenata.BtnSacuvaj.Enabled = true;


        }

        private void BtnNovaStavka_Click(object sender, EventArgs e)
        {
            dialog = new DialogNovaStavka();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                uCPretragaDokumenata.BtnSacuvaj.Enabled = true;
                dialog.Dispose();
            }
        }


        private void BtnIzmeni_Click(object sender, EventArgs e)
        {
            uCPretragaDokumenata.GroupBox1.Enabled = true;
            uCPretragaDokumenata.BtnSacuvaj.Enabled = false;
        }

        private void BtnStorniraj_Click(object sender, EventArgs e)
        {
            try
            {
                Communication.Instance.SendRequestNoResult(Operation.StornirajMagacinskiDokument, izabraniDokument);
                OsveziNakonIzmene();
                MessageBox.Show("Sistem je stornirao magacinski dokument!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da stornira magacinski dokument!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnDetalji_Click(object sender, EventArgs e)
        {
            try
            {
                if (uCPretragaDokumenata.DgvDokumenti.SelectedRows.Count == 0 || uCPretragaDokumenata.DgvDokumenti.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Izaberite dokument u tabeli za koji zelite da ucitate podatke!", "Upozorenje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                uCPretragaDokumenata.GroupBox1.Enabled = false;
                uCPretragaDokumenata.BtnIzmeni.Enabled = true;
                uCPretragaDokumenata.BtnStorniraj.Enabled = true;

                izabraniDokument = (Dokument)uCPretragaDokumenata.DgvDokumenti.SelectedRows[0].DataBoundItem;
                izabraniDokument = Communication.Instance.SendRequestGetResult<Dokument>(Operation.UcitajMagacinskiDokument, izabraniDokument);

                SessionData.Instance.StavkeDokumenta = new BindingList<StavkaDokumenta>(izabraniDokument.StavkeDokumenta);
                uCPretragaDokumenata.DgvStavke.DataSource = SessionData.Instance.StavkeDokumenta;

                uCPretragaDokumenata.DgvStavke.Columns["DokumentId"].Visible = false;
                uCPretragaDokumenata.DgvStavke.Columns["TableName"].Visible = false;
                uCPretragaDokumenata.DgvStavke.Columns["InsertValues"].Visible = false;
                uCPretragaDokumenata.DgvStavke.Columns["PrimaryKey"].Visible = false;
                uCPretragaDokumenata.DgvStavke.Columns["ForeignKey"].Visible = false;
                uCPretragaDokumenata.DgvStavke.Columns["WhereCondition"].Visible = false;
                uCPretragaDokumenata.DgvStavke.Columns["SetValues"].Visible = false;

                MessageBox.Show("Sistem je ucitao podatke o magacinskom dokumentu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Sistem ne moze da ucita podatke o magacinskom dokumentu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            uCPretragaDokumenata.GroupBox1.Enabled = false;
            uCPretragaDokumenata.BtnIzmeni.Enabled = false;
            uCPretragaDokumenata.BtnStorniraj.Enabled = false;

            uCPretragaDokumenata.CbNaziv.SelectedIndex = 0;
            uCPretragaDokumenata.TxtDatum.Text = "";

            uCPretragaDokumenata.BtnPretrazi.Enabled = true;

            uCPretragaDokumenata.DgvStavke.DataSource = null;
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

            PrilagodiTabelu();

            if (dokumentiPretraga != null && dokumentiPretraga.Count > 0)
            {
                MessageBox.Show("Sistem je pronasao magacinske dokumente po zadatom kriterijumu!", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sistem ne moze da pronadje magacinske dokumente po zadatom kriterijumu!", "Greska", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
