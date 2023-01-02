namespace Personel_Kayit
{
    partial class FrmGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new System.Windows.Forms.TextBox();
            this.TxtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // TxtKullaniciAd
            // 
            this.TxtKullaniciAd.Location = new System.Drawing.Point(272, 142);
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Size = new System.Drawing.Size(159, 36);
            this.TxtKullaniciAd.TabIndex = 2;
            // 
            // TxtKullaniciSifre
            // 
            this.TxtKullaniciSifre.Location = new System.Drawing.Point(272, 199);
            this.TxtKullaniciSifre.Name = "TxtKullaniciSifre";
            this.TxtKullaniciSifre.Size = new System.Drawing.Size(159, 36);
            this.TxtKullaniciSifre.TabIndex = 3;
            this.TxtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel Takip Sistemi";
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.Location = new System.Drawing.Point(272, 261);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(159, 35);
            this.BtnGirisYap.TabIndex = 5;
            this.BtnGirisYap.Text = "Giriş Yap";
            this.BtnGirisYap.UseVisualStyleBackColor = true;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            // 
            // FrmGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(560, 461);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtKullaniciSifre);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmGiris";
            this.Text = "FrmGiris";
            this.Load += new System.EventHandler(this.FrmGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtKullaniciAd;
        private System.Windows.Forms.TextBox TxtKullaniciSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnGirisYap;
    }
}