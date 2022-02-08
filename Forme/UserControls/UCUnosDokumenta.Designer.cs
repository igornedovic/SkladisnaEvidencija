
using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCUnosDokumenta
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPib = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPib = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.cboxPravnoLice = new System.Windows.Forms.CheckBox();
            this.cboxFizickoLice = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.cbNaziv = new System.Windows.Forms.ComboBox();
            this.btnNovaStavka = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.txtUkupno = new System.Windows.Forms.TextBox();
            this.lblUkupno = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(86, 31);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 17);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(695, 31);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(53, 17);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPib);
            this.groupBox1.Controls.Add(this.txtFirma);
            this.groupBox1.Controls.Add(this.txtAdresa);
            this.groupBox1.Controls.Add(this.txtPrezime);
            this.groupBox1.Controls.Add(this.txtIme);
            this.groupBox1.Controls.Add(this.lblAdresa);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPib);
            this.groupBox1.Controls.Add(this.lblFirma);
            this.groupBox1.Controls.Add(this.lblPrezime);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.cboxPravnoLice);
            this.groupBox1.Controls.Add(this.cboxFizickoLice);
            this.groupBox1.Location = new System.Drawing.Point(359, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poslovni Partner";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(364, 129);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(181, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPib
            // 
            this.txtPib.Location = new System.Drawing.Point(364, 90);
            this.txtPib.Name = "txtPib";
            this.txtPib.Size = new System.Drawing.Size(181, 22);
            this.txtPib.TabIndex = 9;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(364, 55);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(181, 22);
            this.txtFirma.TabIndex = 8;
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(217, 171);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(181, 22);
            this.txtAdresa.TabIndex = 7;
            // 
            // txtPrezime
            // 
            this.txtPrezime.Location = new System.Drawing.Point(89, 92);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(181, 22);
            this.txtPrezime.TabIndex = 7;
            // 
            // txtIme
            // 
            this.txtIme.Location = new System.Drawing.Point(89, 55);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(181, 22);
            this.txtIme.TabIndex = 7;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(154, 174);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(57, 17);
            this.lblAdresa.TabIndex = 7;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(276, 132);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblPib
            // 
            this.lblPib.AutoSize = true;
            this.lblPib.Location = new System.Drawing.Point(276, 95);
            this.lblPib.Name = "lblPib";
            this.lblPib.Size = new System.Drawing.Size(33, 17);
            this.lblPib.TabIndex = 6;
            this.lblPib.Text = "PIB:";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(276, 58);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(82, 17);
            this.lblFirma.TabIndex = 5;
            this.lblFirma.Text = "Naziv firme:";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(28, 95);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(63, 17);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(28, 58);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(34, 17);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime:";
            // 
            // cboxPravnoLice
            // 
            this.cboxPravnoLice.AutoSize = true;
            this.cboxPravnoLice.Location = new System.Drawing.Point(279, 21);
            this.cboxPravnoLice.Name = "cboxPravnoLice";
            this.cboxPravnoLice.Size = new System.Drawing.Size(100, 21);
            this.cboxPravnoLice.TabIndex = 1;
            this.cboxPravnoLice.Text = "Pravno lice";
            this.cboxPravnoLice.UseVisualStyleBackColor = true;
            // 
            // cboxFizickoLice
            // 
            this.cboxFizickoLice.AutoSize = true;
            this.cboxFizickoLice.Location = new System.Drawing.Point(31, 21);
            this.cboxFizickoLice.Name = "cboxFizickoLice";
            this.cboxFizickoLice.Size = new System.Drawing.Size(98, 21);
            this.cboxFizickoLice.TabIndex = 0;
            this.cboxFizickoLice.Text = "Fizicko lice";
            this.cboxFizickoLice.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(754, 28);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(181, 22);
            this.txtDatum.TabIndex = 5;
            // 
            // cbNaziv
            // 
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(139, 28);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(193, 24);
            this.cbNaziv.TabIndex = 6;
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.Location = new System.Drawing.Point(139, 160);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(119, 46);
            this.btnNovaStavka.TabIndex = 7;
            this.btnNovaStavka.Text = "Nova stavka";
            this.btnNovaStavka.UseVisualStyleBackColor = true;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(139, 229);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(119, 46);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi stavku";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // dgvStavke
            // 
            this.dgvStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(89, 307);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(846, 150);
            this.dgvStavke.TabIndex = 9;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Location = new System.Drawing.Point(754, 472);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(181, 22);
            this.txtUkupno.TabIndex = 11;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Location = new System.Drawing.Point(635, 475);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(98, 17);
            this.lblUkupno.TabIndex = 10;
            this.lblUkupno.Text = "Ukupan iznos:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(212, 475);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(181, 22);
            this.txtStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(80, 478);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(126, 17);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status dokumenta:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(451, 500);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(119, 46);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // UCUnosDokumenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtUkupno);
            this.Controls.Add(this.lblUkupno);
            this.Controls.Add(this.dgvStavke);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnNovaStavka);
            this.Controls.Add(this.cbNaziv);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UCUnosDokumenta";
            this.Size = new System.Drawing.Size(1032, 549);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPib;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPib;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.CheckBox cboxPravnoLice;
        private System.Windows.Forms.CheckBox cboxFizickoLice;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.ComboBox cbNaziv;
        private System.Windows.Forms.Button btnNovaStavka;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.TextBox txtUkupno;
        private System.Windows.Forms.Label lblUkupno;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSacuvaj;

        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtPib { get => txtPib; set => txtPib = value; }
        public TextBox TxtFirma { get => txtFirma; set => txtFirma = value; }
        public TextBox TxtAdresa { get => txtAdresa; set => txtAdresa = value; }
        public TextBox TxtPrezime { get => txtPrezime; set => txtPrezime = value; }
        public TextBox TxtIme { get => txtIme; set => txtIme = value; }
        public Label LblAdresa { get => lblAdresa; set => lblAdresa = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblPib { get => lblPib; set => lblPib = value; }
        public Label LblFirma { get => lblFirma; set => lblFirma = value; }
        public Label LblPrezime { get => lblPrezime; set => lblPrezime = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public CheckBox CboxPravnoLice { get => cboxPravnoLice; set => cboxPravnoLice = value; }
        public CheckBox CboxFizickoLice { get => cboxFizickoLice; set => cboxFizickoLice = value; }
        public ContextMenuStrip ContextMenuStrip1 { get => contextMenuStrip1; set => contextMenuStrip1 = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public ComboBox CbNaziv { get => cbNaziv; set => cbNaziv = value; }
        public Button BtnNovaStavka { get => btnNovaStavka; set => btnNovaStavka = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public TextBox TxtUkupno { get => txtUkupno; set => txtUkupno = value; }
        public Label LblUkupno { get => lblUkupno; set => lblUkupno = value; }
        public TextBox TxtStatus { get => txtStatus; set => txtStatus = value; }
        public Label LblStatus { get => lblStatus; set => lblStatus = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
    }
}
