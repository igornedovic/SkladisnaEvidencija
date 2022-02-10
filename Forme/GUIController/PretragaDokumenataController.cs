﻿using Forme.ServerCommunication;
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
        private BindingList<StavkaDokumenta> stavke;

        public PretragaDokumenataController(UCPretragaDokumenata uCPretragaDokumenata)
        {
            this.uCPretragaDokumenata = uCPretragaDokumenata;
        }

        internal void Init()
        {
            uCPretragaDokumenata.CbNaziv.DataSource = Enum.GetValues(typeof(NazivDokumenta));

            dokumenti = new BindingList<Dokument>(Communication.Instance.SendRequestGetResult<List<Dokument>>(Operation.UcitajMagacinskeDokumente));
            uCPretragaDokumenata.DgvDokumenti.DataSource = dokumenti;

            uCPretragaDokumenata.DgvDokumenti.Columns["DokumentId"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["PoslovniPartner"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["TableName"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["InsertValues"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["PrimaryKey"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["ForeignKey"].Visible = false;
            uCPretragaDokumenata.DgvDokumenti.Columns["Criteria"].Visible = false;

            uCPretragaDokumenata.BtnPretrazi.Click += BtnPretrazi_Click;
            uCPretragaDokumenata.BtnResetuj.Click += BtnResetuj_Click;
        }

        private void BtnResetuj_Click(object sender, EventArgs e)
        {
            uCPretragaDokumenata.CbNaziv.SelectedIndex = 0;
            uCPretragaDokumenata.TxtDatum.Text = "";

            uCPretragaDokumenata.DgvDokumenti.DataSource = null;
            uCPretragaDokumenata.DgvDokumenti.DataSource = dokumenti;
        }

        private void BtnPretrazi_Click(object sender, EventArgs e)
        {
            if(!ValidacijaPretrage())
            {
                return;
            }

            dokumentZaPretragu.NazivDokumenta = (NazivDokumenta)uCPretragaDokumenata.CbNaziv.SelectedItem;
            dokumentZaPretragu.Datum = DateTime.ParseExact(uCPretragaDokumenata.TxtDatum.Text, "dd.MM.yyyy", null); 

            dokumentiPretraga = new BindingList<Dokument>(Communication.Instance.SendRequestGetResult<List<Dokument>>(Operation.PretraziMagacinskeDokumente, dokumentZaPretragu));
            uCPretragaDokumenata.DgvDokumenti.DataSource = null;
            uCPretragaDokumenata.DgvDokumenti.DataSource = dokumentiPretraga;

            if (dokumentiPretraga != null && dokumentiPretraga.Count > 0)
            {
                MessageBox.Show("Sistem je pronasao magacinske dokumente po zadatom kriterijumu!");
            }
            else
            {
                MessageBox.Show("Sistem ne moze da pronadje magacinske dokumente po zadatom kriterijumu!");
            }

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
