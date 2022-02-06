
using System.Windows.Forms;

namespace Forme.UserControls
{
    partial class UCNovaStavka
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProizvod = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnOdbaci = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.cbJedinicaMere = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvod:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jedinica mere:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kolicina:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Iznos:";
            // 
            // txtProizvod
            // 
            this.txtProizvod.Location = new System.Drawing.Point(218, 59);
            this.txtProizvod.Name = "txtProizvod";
            this.txtProizvod.Size = new System.Drawing.Size(177, 22);
            this.txtProizvod.TabIndex = 5;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(218, 165);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(177, 22);
            this.txtKolicina.TabIndex = 7;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(218, 218);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(177, 22);
            this.txtCena.TabIndex = 8;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(218, 275);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(177, 22);
            this.txtIznos.TabIndex = 9;
            // 
            // btnOdbaci
            // 
            this.btnOdbaci.Location = new System.Drawing.Point(69, 346);
            this.btnOdbaci.Name = "btnOdbaci";
            this.btnOdbaci.Size = new System.Drawing.Size(108, 42);
            this.btnOdbaci.TabIndex = 10;
            this.btnOdbaci.Text = "Odbaci";
            this.btnOdbaci.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(287, 346);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 42);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // cbJedinicaMere
            // 
            this.cbJedinicaMere.FormattingEnabled = true;
            this.cbJedinicaMere.Location = new System.Drawing.Point(218, 113);
            this.cbJedinicaMere.Name = "cbJedinicaMere";
            this.cbJedinicaMere.Size = new System.Drawing.Size(177, 24);
            this.cbJedinicaMere.TabIndex = 12;
            // 
            // UCNovaStavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbJedinicaMere);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.btnOdbaci);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.txtProizvod);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCNovaStavka";
            this.Size = new System.Drawing.Size(465, 431);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProizvod;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Button btnOdbaci;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ComboBox cbJedinicaMere;

        public Label Label1 { get => label1; set => label1 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public TextBox TxtProizvod { get => txtProizvod; set => txtProizvod = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public Button BtnOdbaci { get => btnOdbaci; set => btnOdbaci = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public ComboBox CbJedinicaMere { get => cbJedinicaMere; set => cbJedinicaMere = value; }
    }
}
