
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUnosDokumenta));
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdresaPl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.cbImePrezime = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPib = new System.Windows.Forms.TextBox();
            this.txtAdresaFl = new System.Windows.Forms.TextBox();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPib = new System.Windows.Forms.Label();
            this.lblFirma = new System.Windows.Forms.Label();
            this.lblIme = new System.Windows.Forms.Label();
            this.cboxPravnoLice = new System.Windows.Forms.CheckBox();
            this.cboxFizickoLice = new System.Windows.Forms.CheckBox();
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(317, 45);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(63, 23);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatum.Location = new System.Drawing.Point(778, 45);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(72, 23);
            this.lblDatum.TabIndex = 1;
            this.lblDatum.Text = "Datum:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdresaPl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbFirma);
            this.groupBox1.Controls.Add(this.cbImePrezime);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtPib);
            this.groupBox1.Controls.Add(this.txtAdresaFl);
            this.groupBox1.Controls.Add(this.lblAdresa);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblPib);
            this.groupBox1.Controls.Add(this.lblFirma);
            this.groupBox1.Controls.Add(this.lblIme);
            this.groupBox1.Controls.Add(this.cboxPravnoLice);
            this.groupBox1.Controls.Add(this.cboxFizickoLice);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(255, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Poslovni Partner";
            // 
            // txtAdresaPl
            // 
            this.txtAdresaPl.Location = new System.Drawing.Point(525, 178);
            this.txtAdresaPl.Name = "txtAdresaPl";
            this.txtAdresaPl.ReadOnly = true;
            this.txtAdresaPl.Size = new System.Drawing.Size(255, 30);
            this.txtAdresaPl.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Adresa:";
            // 
            // cbFirma
            // 
            this.cbFirma.Enabled = false;
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Location = new System.Drawing.Point(525, 69);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(255, 31);
            this.cbFirma.TabIndex = 12;
            // 
            // cbImePrezime
            // 
            this.cbImePrezime.Enabled = false;
            this.cbImePrezime.FormattingEnabled = true;
            this.cbImePrezime.Location = new System.Drawing.Point(151, 66);
            this.cbImePrezime.Name = "cbImePrezime";
            this.cbImePrezime.Size = new System.Drawing.Size(236, 31);
            this.cbImePrezime.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(525, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(255, 30);
            this.txtEmail.TabIndex = 10;
            // 
            // txtPib
            // 
            this.txtPib.Location = new System.Drawing.Point(525, 104);
            this.txtPib.Name = "txtPib";
            this.txtPib.ReadOnly = true;
            this.txtPib.Size = new System.Drawing.Size(255, 30);
            this.txtPib.TabIndex = 9;
            // 
            // txtAdresaFl
            // 
            this.txtAdresaFl.Location = new System.Drawing.Point(151, 103);
            this.txtAdresaFl.Name = "txtAdresaFl";
            this.txtAdresaFl.ReadOnly = true;
            this.txtAdresaFl.Size = new System.Drawing.Size(236, 30);
            this.txtAdresaFl.TabIndex = 7;
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(11, 106);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(74, 23);
            this.lblAdresa.TabIndex = 7;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(393, 143);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 23);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblPib
            // 
            this.lblPib.AutoSize = true;
            this.lblPib.Location = new System.Drawing.Point(393, 107);
            this.lblPib.Name = "lblPib";
            this.lblPib.Size = new System.Drawing.Size(44, 23);
            this.lblPib.TabIndex = 6;
            this.lblPib.Text = "PIB:";
            // 
            // lblFirma
            // 
            this.lblFirma.AutoSize = true;
            this.lblFirma.Location = new System.Drawing.Point(392, 72);
            this.lblFirma.Name = "lblFirma";
            this.lblFirma.Size = new System.Drawing.Size(113, 23);
            this.lblFirma.TabIndex = 5;
            this.lblFirma.Text = "Naziv firme:";
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(11, 72);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(130, 23);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime i prezime:";
            // 
            // cboxPravnoLice
            // 
            this.cboxPravnoLice.AutoSize = true;
            this.cboxPravnoLice.Location = new System.Drawing.Point(396, 39);
            this.cboxPravnoLice.Name = "cboxPravnoLice";
            this.cboxPravnoLice.Size = new System.Drawing.Size(125, 27);
            this.cboxPravnoLice.TabIndex = 1;
            this.cboxPravnoLice.Text = "Pravno lice";
            this.cboxPravnoLice.UseVisualStyleBackColor = true;
            // 
            // cboxFizickoLice
            // 
            this.cboxFizickoLice.AutoSize = true;
            this.cboxFizickoLice.Location = new System.Drawing.Point(15, 39);
            this.cboxFizickoLice.Name = "cboxFizickoLice";
            this.cboxFizickoLice.Size = new System.Drawing.Size(122, 27);
            this.cboxFizickoLice.TabIndex = 0;
            this.cboxFizickoLice.Text = "Fizicko lice";
            this.cboxFizickoLice.UseVisualStyleBackColor = true;
            // 
            // txtDatum
            // 
            this.txtDatum.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatum.Location = new System.Drawing.Point(869, 42);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(181, 30);
            this.txtDatum.TabIndex = 5;
            // 
            // cbNaziv
            // 
            this.cbNaziv.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(406, 42);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(193, 31);
            this.cbNaziv.TabIndex = 6;
            // 
            // btnNovaStavka
            // 
            this.btnNovaStavka.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnNovaStavka.FlatAppearance.BorderSize = 0;
            this.btnNovaStavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaStavka.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovaStavka.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNovaStavka.Location = new System.Drawing.Point(57, 194);
            this.btnNovaStavka.Name = "btnNovaStavka";
            this.btnNovaStavka.Size = new System.Drawing.Size(167, 58);
            this.btnNovaStavka.TabIndex = 7;
            this.btnNovaStavka.Text = "Nova stavka";
            this.btnNovaStavka.UseVisualStyleBackColor = false;
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnObrisi.FlatAppearance.BorderSize = 0;
            this.btnObrisi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObrisi.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.Control;
            this.btnObrisi.Location = new System.Drawing.Point(57, 277);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(167, 58);
            this.btnObrisi.TabIndex = 8;
            this.btnObrisi.Text = "Obrisi stavku";
            this.btnObrisi.UseVisualStyleBackColor = false;
            // 
            // dgvStavke
            // 
            this.dgvStavke.AllowUserToAddRows = false;
            this.dgvStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStavke.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(21, 358);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(1029, 150);
            this.dgvStavke.TabIndex = 9;
            // 
            // txtUkupno
            // 
            this.txtUkupno.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUkupno.Location = new System.Drawing.Point(869, 530);
            this.txtUkupno.Name = "txtUkupno";
            this.txtUkupno.ReadOnly = true;
            this.txtUkupno.Size = new System.Drawing.Size(181, 30);
            this.txtUkupno.TabIndex = 11;
            // 
            // lblUkupno
            // 
            this.lblUkupno.AutoSize = true;
            this.lblUkupno.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUkupno.Location = new System.Drawing.Point(717, 533);
            this.lblUkupno.Name = "lblUkupno";
            this.lblUkupno.Size = new System.Drawing.Size(130, 23);
            this.lblUkupno.TabIndex = 10;
            this.lblUkupno.Text = "Ukupan iznos:";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStatus.Location = new System.Drawing.Point(255, 530);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(181, 30);
            this.txtStatus.TabIndex = 13;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(53, 533);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(170, 23);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status dokumenta:";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(135)))), ((int)(((byte)(245)))));
            this.btnSacuvaj.FlatAppearance.BorderSize = 0;
            this.btnSacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSacuvaj.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSacuvaj.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSacuvaj.Location = new System.Drawing.Point(500, 562);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(167, 58);
            this.btnSacuvaj.TabIndex = 14;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // UCUnosDokumenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
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
            this.Size = new System.Drawing.Size(1070, 630);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPib;
        private System.Windows.Forms.TextBox txtAdresaFl;
        private System.Windows.Forms.Label lblAdresa;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPib;
        private System.Windows.Forms.Label lblFirma;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.CheckBox cboxPravnoLice;
        private System.Windows.Forms.CheckBox cboxFizickoLice;
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
        private ComboBox cbFirma;
        private ComboBox cbImePrezime;
        private TextBox txtAdresaPl;
        private Label label1;
        private PictureBox pictureBox1;

        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblDatum { get => lblDatum; set => lblDatum = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public TextBox TxtEmail { get => txtEmail; set => txtEmail = value; }
        public TextBox TxtPib { get => txtPib; set => txtPib = value; }
        public ComboBox CbFirma { get => cbFirma; set => cbFirma = value; }
        public TextBox TxtAdresaFl { get => txtAdresaFl; set => txtAdresaFl = value; }
        public TextBox TxtAdresaPl { get => txtAdresaPl; set => txtAdresaPl = value; }
        public ComboBox CbImePrezime { get => cbImePrezime; set => cbImePrezime = value; }
        public Label LblAdresa { get => lblAdresa; set => lblAdresa = value; }
        public Label LblEmail { get => lblEmail; set => lblEmail = value; }
        public Label LblPib { get => lblPib; set => lblPib = value; }
        public Label LblFirma { get => lblFirma; set => lblFirma = value; }
        public Label LblIme { get => lblIme; set => lblIme = value; }
        public CheckBox CboxPravnoLice { get => cboxPravnoLice; set => cboxPravnoLice = value; }
        public CheckBox CboxFizickoLice { get => cboxFizickoLice; set => cboxFizickoLice = value; }
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
