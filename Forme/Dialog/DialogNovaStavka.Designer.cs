
using System.Windows.Forms;

namespace Forme.Dialog
{
    partial class DialogNovaStavka
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtJm = new System.Windows.Forms.TextBox();
            this.cbProizvod = new System.Windows.Forms.ComboBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtJm
            // 
            this.txtJm.Location = new System.Drawing.Point(211, 85);
            this.txtJm.Name = "txtJm";
            this.txtJm.ReadOnly = true;
            this.txtJm.Size = new System.Drawing.Size(177, 22);
            this.txtJm.TabIndex = 26;
            // 
            // cbProizvod
            // 
            this.cbProizvod.FormattingEnabled = true;
            this.cbProizvod.Location = new System.Drawing.Point(211, 31);
            this.cbProizvod.Name = "cbProizvod";
            this.cbProizvod.Size = new System.Drawing.Size(177, 24);
            this.cbProizvod.TabIndex = 25;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(167, 314);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(108, 42);
            this.btnDodaj.TabIndex = 24;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(211, 244);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(177, 22);
            this.txtIznos.TabIndex = 22;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(211, 187);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(177, 22);
            this.txtCena.TabIndex = 21;
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(211, 134);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(177, 22);
            this.txtKolicina.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Iznos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Kolicina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Jedinica mere:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proizvod:";
            // 
            // DialogNovaStavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 384);
            this.Controls.Add(this.txtJm);
            this.Controls.Add(this.cbProizvod);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtKolicina);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DialogNovaStavka";
            this.Text = "DialogNovaStavka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtJm;
        private System.Windows.Forms.ComboBox cbProizvod;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

        public TextBox TxtJm { get => txtJm; set => txtJm = value; }
        public ComboBox CbProizvod { get => cbProizvod; set => cbProizvod = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public TextBox TxtIznos { get => txtIznos; set => txtIznos = value; }
        public TextBox TxtCena { get => txtCena; set => txtCena = value; }
        public TextBox TxtKolicina { get => txtKolicina; set => txtKolicina = value; }
        public Label Label5 { get => label5; set => label5 = value; }
        public Label Label4 { get => label4; set => label4 = value; }
        public Label Label3 { get => label3; set => label3 = value; }
        public Label Label2 { get => label2; set => label2 = value; }
        public Label Label1 { get => label1; set => label1 = value; }
    }
}