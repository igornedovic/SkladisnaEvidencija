
using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCPretragaProizvoda
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvProizvodi = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivUpdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRaspolozivaKolicina = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.RichTextBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDetalji = new System.Windows.Forms.Button();
            this.btnResetuj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv sadrzi:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(146, 30);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(363, 19);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(113, 44);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.AllowUserToAddRows = false;
            this.dgvProizvodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProizvodi.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(54, 88);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(550, 192);
            this.dgvProizvodi.TabIndex = 3;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Enabled = false;
            this.btnObrisi.Location = new System.Drawing.Point(54, 303);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(113, 50);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv:";
            // 
            // txtNazivUpdate
            // 
            this.txtNazivUpdate.Location = new System.Drawing.Point(6, 67);
            this.txtNazivUpdate.Name = "txtNazivUpdate";
            this.txtNazivUpdate.Size = new System.Drawing.Size(200, 22);
            this.txtNazivUpdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raspoloziva kolicina:";
            // 
            // txtRaspolozivaKolicina
            // 
            this.txtRaspolozivaKolicina.Location = new System.Drawing.Point(6, 122);
            this.txtRaspolozivaKolicina.Name = "txtRaspolozivaKolicina";
            this.txtRaspolozivaKolicina.Size = new System.Drawing.Size(200, 22);
            this.txtRaspolozivaKolicina.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(6, 181);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 146);
            this.txtOpis.TabIndex = 10;
            this.txtOpis.Text = "";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Enabled = false;
            this.btnIzmeni.Location = new System.Drawing.Point(205, 303);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(113, 50);
            this.btnIzmeni.TabIndex = 11;
            this.btnIzmeni.Text = "Omoguci izmene";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSacuvaj);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNazivUpdate);
            this.groupBox1.Controls.Add(this.txtOpis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRaspolozivaKolicina);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(639, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 349);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji";
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(239, 233);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(113, 50);
            this.btnSacuvaj.TabIndex = 12;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            // 
            // btnDetalji
            // 
            this.btnDetalji.Location = new System.Drawing.Point(639, 103);
            this.btnDetalji.Name = "btnDetalji";
            this.btnDetalji.Size = new System.Drawing.Size(113, 50);
            this.btnDetalji.TabIndex = 13;
            this.btnDetalji.Text = "Detalji";
            this.btnDetalji.UseVisualStyleBackColor = true;
            // 
            // btnResetuj
            // 
            this.btnResetuj.Location = new System.Drawing.Point(491, 19);
            this.btnResetuj.Name = "btnResetuj";
            this.btnResetuj.Size = new System.Drawing.Size(113, 44);
            this.btnResetuj.TabIndex = 14;
            this.btnResetuj.Text = "Resetuj filter";
            this.btnResetuj.UseVisualStyleBackColor = true;
            // 
            // UCPretragaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnResetuj);
            this.Controls.Add(this.btnDetalji);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "UCPretragaProizvoda";
            this.Size = new System.Drawing.Size(1032, 560);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvProizvodi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRaspolozivaKolicina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtOpis;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDetalji;
        private System.Windows.Forms.Button btnResetuj;

        public Label Label1 { get => label1; set => label1 = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public DataGridView DgvProizvodi { get => dgvProizvodi; set => dgvProizvodi = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public TextBox TxtNazivUpdate { get => txtNazivUpdate; set => txtNazivUpdate = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public TextBox TxtRaspolozivaKolicina { get => txtRaspolozivaKolicina; set => txtRaspolozivaKolicina = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public RichTextBox TxtOpis { get => txtOpis; set => txtOpis = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public GroupBox GroupBox1 { get => groupBox1; set => groupBox1 = value; }
        public Button BtnSacuvaj { get => btnSacuvaj; set => btnSacuvaj = value; }
        public Button BtnDetalji { get => btnDetalji; set => btnDetalji = value; }
        public Button BtnResetuj { get => btnResetuj; set => btnResetuj = value; }
    }
}
