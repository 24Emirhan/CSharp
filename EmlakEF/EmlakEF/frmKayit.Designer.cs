namespace EmlakEF
{
    partial class frmKayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtilan = new System.Windows.Forms.TextBox();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.txtKatNo = new System.Windows.Forms.TextBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtSemt = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnBul = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.lbl_kullanici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oda Sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "KatNo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Semt";
            // 
            // txtilan
            // 
            this.txtilan.Location = new System.Drawing.Point(159, 80);
            this.txtilan.MaxLength = 20;
            this.txtilan.Name = "txtilan";
            this.txtilan.Size = new System.Drawing.Size(189, 27);
            this.txtilan.TabIndex = 5;
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.Location = new System.Drawing.Point(159, 149);
            this.txtOdaSayisi.MaxLength = 20;
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(189, 27);
            this.txtOdaSayisi.TabIndex = 6;
            // 
            // txtKatNo
            // 
            this.txtKatNo.Location = new System.Drawing.Point(159, 214);
            this.txtKatNo.MaxLength = 20;
            this.txtKatNo.Name = "txtKatNo";
            this.txtKatNo.Size = new System.Drawing.Size(189, 27);
            this.txtKatNo.TabIndex = 7;
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(159, 277);
            this.txtAlan.MaxLength = 200;
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(189, 27);
            this.txtAlan.TabIndex = 8;
            // 
            // txtSemt
            // 
            this.txtSemt.Location = new System.Drawing.Point(159, 342);
            this.txtSemt.MaxLength = 200;
            this.txtSemt.Name = "txtSemt";
            this.txtSemt.Size = new System.Drawing.Size(189, 27);
            this.txtSemt.TabIndex = 9;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(444, 135);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(160, 46);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(444, 217);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(160, 46);
            this.btnBul.TabIndex = 11;
            this.btnBul.Text = "İlanlar";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(444, 304);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(160, 46);
            this.btn_Sil.TabIndex = 12;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // lbl_kullanici
            // 
            this.lbl_kullanici.AutoSize = true;
            this.lbl_kullanici.Location = new System.Drawing.Point(137, 21);
            this.lbl_kullanici.Name = "lbl_kullanici";
            this.lbl_kullanici.Size = new System.Drawing.Size(118, 20);
            this.lbl_kullanici.TabIndex = 13;
            this.lbl_kullanici.Text = "kullanıcı bilgileri";
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 402);
            this.Controls.Add(this.lbl_kullanici);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSemt);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtKatNo);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.txtilan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKayit";
            this.Text = "frmKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBul;
        public System.Windows.Forms.TextBox txtilan;
        public System.Windows.Forms.TextBox txtOdaSayisi;
        public System.Windows.Forms.TextBox txtKatNo;
        public System.Windows.Forms.TextBox txtAlan;
        public System.Windows.Forms.TextBox txtSemt;
        private System.Windows.Forms.Label lbl_kullanici;
        public System.Windows.Forms.Button btnKaydet;
        public System.Windows.Forms.Button btn_Sil;
    }
}