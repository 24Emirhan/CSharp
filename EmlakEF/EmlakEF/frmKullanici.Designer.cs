namespace EmlakEF
{
    partial class frmKullanici
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
            this.btn_Giris = new System.Windows.Forms.Button();
            this.txt_Kullanici = new System.Windows.Forms.TextBox();
            this.txt_Sifre = new System.Windows.Forms.TextBox();
            this.lbl_Kullanıcı = new System.Windows.Forms.Label();
            this.lbl_Sifre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(168, 169);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(94, 29);
            this.btn_Giris.TabIndex = 0;
            this.btn_Giris.Text = "Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // txt_Kullanici
            // 
            this.txt_Kullanici.Location = new System.Drawing.Point(151, 79);
            this.txt_Kullanici.Name = "txt_Kullanici";
            this.txt_Kullanici.Size = new System.Drawing.Size(125, 27);
            this.txt_Kullanici.TabIndex = 1;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Location = new System.Drawing.Point(151, 127);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.Size = new System.Drawing.Size(125, 27);
            this.txt_Sifre.TabIndex = 2;
            // 
            // lbl_Kullanıcı
            // 
            this.lbl_Kullanıcı.AutoSize = true;
            this.lbl_Kullanıcı.Location = new System.Drawing.Point(53, 82);
            this.lbl_Kullanıcı.Name = "lbl_Kullanıcı";
            this.lbl_Kullanıcı.Size = new System.Drawing.Size(95, 20);
            this.lbl_Kullanıcı.TabIndex = 3;
            this.lbl_Kullanıcı.Text = "Kullanıcı Adı:";
            // 
            // lbl_Sifre
            // 
            this.lbl_Sifre.AutoSize = true;
            this.lbl_Sifre.Location = new System.Drawing.Point(103, 130);
            this.lbl_Sifre.Name = "lbl_Sifre";
            this.lbl_Sifre.Size = new System.Drawing.Size(42, 20);
            this.lbl_Sifre.TabIndex = 4;
            this.lbl_Sifre.Text = "Şifre:";
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 292);
            this.Controls.Add(this.lbl_Sifre);
            this.Controls.Add(this.lbl_Kullanıcı);
            this.Controls.Add(this.txt_Sifre);
            this.Controls.Add(this.txt_Kullanici);
            this.Controls.Add(this.btn_Giris);
            this.Name = "frmKullanici";
            this.Text = "frmKullanici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.TextBox txt_Kullanici;
        private System.Windows.Forms.TextBox txt_Sifre;
        private System.Windows.Forms.Label lbl_Kullanıcı;
        private System.Windows.Forms.Label lbl_Sifre;
    }
}