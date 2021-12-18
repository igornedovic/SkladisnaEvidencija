
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(323, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(382, 30);
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
            this.btnPretrazi.Location = new System.Drawing.Point(597, 21);
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
            this.dgvDokumenti.Location = new System.Drawing.Point(70, 86);
            this.dgvDokumenti.Name = "dgvDokumenti";
            this.dgvDokumenti.RowHeadersWidth = 51;
            this.dgvDokumenti.RowTemplate.Height = 24;
            this.dgvDokumenti.Size = new System.Drawing.Size(659, 202);
            this.dgvDokumenti.TabIndex = 5;
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(70, 327);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(132, 41);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            // 
            // btnStorniraj
            // 
            this.btnStorniraj.Location = new System.Drawing.Point(597, 327);
            this.btnStorniraj.Name = "btnStorniraj";
            this.btnStorniraj.Size = new System.Drawing.Size(132, 41);
            this.btnStorniraj.TabIndex = 7;
            this.btnStorniraj.Text = "Storniraj";
            this.btnStorniraj.UseVisualStyleBackColor = true;
            // 
            // UCPretragaDokumenata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStorniraj);
            this.Controls.Add(this.btnIzmeni);
            this.Controls.Add(this.dgvDokumenti);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.cbNaziv);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UCPretragaDokumenata";
            this.Size = new System.Drawing.Size(785, 408);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDokumenti)).EndInit();
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
    }
}
