namespace Arac_Satis
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
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.btn_Bul = new System.Windows.Forms.Button();
            this.btn_Sil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_IlanNo = new System.Windows.Forms.TextBox();
            this.txt_Marka = new System.Windows.Forms.TextBox();
            this.txt_Model = new System.Windows.Forms.TextBox();
            this.txt_Kilometre = new System.Windows.Forms.TextBox();
            this.txt_Fiyat = new System.Windows.Forms.TextBox();
            this.txt_Tramer = new System.Windows.Forms.TextBox();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(425, 97);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(94, 29);
            this.btn_Kaydet.TabIndex = 0;
            this.btn_Kaydet.Text = "Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btn_Kaydet_Click);
            // 
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(425, 148);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(94, 29);
            this.btn_Bul.TabIndex = 1;
            this.btn_Bul.Text = "İlanlar";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(425, 254);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(94, 29);
            this.btn_Sil.TabIndex = 2;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Güncellemek için ilan numarası giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(212, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(190, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kilometre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tramer:";
            // 
            // txt_IlanNo
            // 
            this.txt_IlanNo.Location = new System.Drawing.Point(274, 83);
            this.txt_IlanNo.Name = "txt_IlanNo";
            this.txt_IlanNo.Size = new System.Drawing.Size(125, 27);
            this.txt_IlanNo.TabIndex = 9;
            // 
            // txt_Marka
            // 
            this.txt_Marka.Location = new System.Drawing.Point(274, 118);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.Size = new System.Drawing.Size(125, 27);
            this.txt_Marka.TabIndex = 10;
            // 
            // txt_Model
            // 
            this.txt_Model.Location = new System.Drawing.Point(274, 154);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.Size = new System.Drawing.Size(125, 27);
            this.txt_Model.TabIndex = 11;
            // 
            // txt_Kilometre
            // 
            this.txt_Kilometre.Location = new System.Drawing.Point(274, 191);
            this.txt_Kilometre.Name = "txt_Kilometre";
            this.txt_Kilometre.Size = new System.Drawing.Size(125, 27);
            this.txt_Kilometre.TabIndex = 12;
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Location = new System.Drawing.Point(274, 229);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.Size = new System.Drawing.Size(125, 27);
            this.txt_Fiyat.TabIndex = 13;
            // 
            // txt_Tramer
            // 
            this.txt_Tramer.Location = new System.Drawing.Point(274, 267);
            this.txt_Tramer.Name = "txt_Tramer";
            this.txt_Tramer.Size = new System.Drawing.Size(125, 27);
            this.txt_Tramer.TabIndex = 14;
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(425, 201);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(94, 29);
            this.btn_Guncelle.TabIndex = 15;
            this.btn_Guncelle.Text = "Güncelle";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // frmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 398);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.txt_Tramer);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.txt_Kilometre);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.txt_IlanNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.btn_Bul);
            this.Controls.Add(this.btn_Kaydet);
            this.Name = "frmKayit";
            this.Text = "frmKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Kaydet;
        private Button btn_Bul;
        private Button btn_Sil;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_IlanNo;
        private TextBox txt_Marka;
        private TextBox txt_Model;
        private TextBox txt_Kilometre;
        private TextBox txt_Fiyat;
        private TextBox txt_Tramer;
        private Button btn_Guncelle;
    }
}