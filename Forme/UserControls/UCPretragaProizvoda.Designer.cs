
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(104, 30);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(200, 22);
            this.txtNaziv.TabIndex = 1;
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(345, 19);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(113, 44);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // dgvProizvodi
            // 
            this.dgvProizvodi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvProizvodi.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.dgvProizvodi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProizvodi.Location = new System.Drawing.Point(54, 98);
            this.dgvProizvodi.Name = "dgvProizvodi";
            this.dgvProizvodi.RowHeadersWidth = 51;
            this.dgvProizvodi.RowTemplate.Height = 24;
            this.dgvProizvodi.Size = new System.Drawing.Size(507, 192);
            this.dgvProizvodi.TabIndex = 3;
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(583, 169);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(113, 50);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obrisi";
            this.btnObrisi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Naziv:";
            // 
            // txtNazivUpdate
            // 
            this.txtNazivUpdate.Location = new System.Drawing.Point(54, 350);
            this.txtNazivUpdate.Name = "txtNazivUpdate";
            this.txtNazivUpdate.Size = new System.Drawing.Size(200, 22);
            this.txtNazivUpdate.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Raspoloziva kolicina:";
            // 
            // txtRaspolozivaKolicina
            // 
            this.txtRaspolozivaKolicina.Location = new System.Drawing.Point(54, 406);
            this.txtRaspolozivaKolicina.Name = "txtRaspolozivaKolicina";
            this.txtRaspolozivaKolicina.Size = new System.Drawing.Size(200, 22);
            this.txtRaspolozivaKolicina.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 441);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(54, 461);
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(200, 122);
            this.txtOpis.TabIndex = 10;
            this.txtOpis.Text = "";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(309, 424);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(113, 50);
            this.btnIzmeni.TabIndex = 11;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // UCPretragaProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRaspolozivaKolicina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNazivUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvProizvodi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label1);
            this.Name = "UCPretragaProizvoda";
            this.Size = new System.Drawing.Size(716, 605);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProizvodi)).EndInit();
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
    }
}
