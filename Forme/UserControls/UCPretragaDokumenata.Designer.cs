
using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCPretragaDokumenata
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.cbNaziv = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvDokumenti = new System.Windows.Forms.DataGridView();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.btnStorniraj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvStavke = new System.Windows.Forms.DataGridView();
            this.txtPoslovniPartner = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(361, 30);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.Size = new System.Drawing.Size(167, 22);
            this.txtDatum.TabIndex = 2;
            // 
            // cbNaziv
            // 
            this.cbNaziv.FormattingEnabled = true;
            this.cbNaziv.Location = new System.Drawing.Point(120, 30);
            this.cbNaziv.Name = "cbNaziv";
            this.cbNaziv.Size = new System.Drawing.Size(167, 24);
            this.cbNaziv.TabIndex = 3;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(534, 21);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(132, 41);
            this.btnPretrazi.TabIndex = 4;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvDokumenti
            // 
            this.dgvDokumenti.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDokumenti.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvDokumenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDokumenti.Location = new System.Drawing.Point(70, 85);
            this.dgvDokumenti.Name = "dgvDokumenti";
            this.dgvDokumenti.RowHeadersWidth = 51;
            this.dgvDokumenti.RowTemplate.Height = 24;
            this.dgvDokumenti.Size = new System.Drawing.Size(659, 202);
            this.dgvDokumenti.TabIndex = 5;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(597, 372);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(132, 41);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Location = new System.Drawing.Point(597, 458);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(132, 41);
            this.btnStorniraj.TabIndex = 7;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvStavke);
            this.groupBox1.Controls.Add(this.txtPoslovniPartner);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(70, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 246);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji";
            // 
            // dgvStavke
            // 
            this.dgvStavke.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvStavke.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvStavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavke.Location = new System.Drawing.Point(37, 74);
            this.dgvStavke.Name = "dgvStavke";
            this.dgvStavke.ReadOnly = true;
            this.dgvStavke.RowHeadersWidth = 51;
            this.dgvStavke.RowTemplate.Height = 24;
            this.dgvStavke.Size = new System.Drawing.Size(442, 156);
            this.dgvStavke.TabIndex = 6;
            // 
            // txtPoslovniPartner
            // 
            this.txtPoslovniPartner.Location = new System.Drawing.Point(155, 29);
            this.txtPoslovniPartner.Name = "txtPoslovniPartner";
            this.txtPoslovniPartner.ReadOnly = true;
            this.txtPoslovniPartner.Size = new System.Drawing.Size(167, 22);
            this.txtPoslovniPartner.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Poslovni partner:";
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(671, 21);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(129, 41);
            this.btnResetuj.TabIndex = 9;
            this.btnResetuj.Text = "Resetuj filtere";
            this.btnResetuj.UseVisualStyleBackColor = true;
            // 
            // UCPretragaDokumenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvDokumenti);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.cbNaziv);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCPretragaDokumenata";
            this.Size = new System.Drawing.Size(803, 568);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.ComboBox cbNaziv;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvDokumenti;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.Button btnStorniraj;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvStavke;
        private System.Windows.Forms.TextBox txtPoslovniPartner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResetuj;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtDatum { get => txtDatum; set => txtDatum = value; }
        public ComboBox CbNaziv { get => cbNaziv; set => cbNaziv = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public DataGridView DgvDokumenti { get => dgvDokumenti; set => dgvDokumenti = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public Button BtnStorniraj { get => btnStorniraj; set => btnStorniraj = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public DataGridView DgvStavke { get => dgvStavke; set => dgvStavke = value; }
        public TextBox TxtPoslovniPartner { get => txtPoslovniPartner; set => txtPoslovniPartner = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Button BtnResetuj { get => btnResetuj; set => btnResetuj = value; }
    }
}
