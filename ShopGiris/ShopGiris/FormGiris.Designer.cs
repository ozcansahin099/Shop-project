namespace ShopGiris
{
    partial class FormGiris
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
            this.btnGiris = new System.Windows.Forms.Button();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(298, 157);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(84, 37);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giris";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(182, 107);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxSifre.TabIndex = 5;
            this.txtBoxSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(116, 110);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(28, 13);
            this.lblSifre.TabIndex = 3;
            this.lblSifre.Text = "Şifre";
            // 
            // txtBoxKullaniciAdi
            // 
            this.txtBoxKullaniciAdi.Location = new System.Drawing.Point(182, 57);
            this.txtBoxKullaniciAdi.Name = "txtBoxKullaniciAdi";
            this.txtBoxKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxKullaniciAdi.TabIndex = 6;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(116, 60);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(64, 13);
            this.lblKullaniciAdi.TabIndex = 4;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // FormGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 261);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtBoxKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Name = "FormGiris";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtBoxKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciAdi;
    }
}

