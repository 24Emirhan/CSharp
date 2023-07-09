namespace EmlakEF
{
    partial class frmBul
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
            this.txtilanNo = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "İlan No Giriniz";
            // 
            // txtilanNo
            // 
            this.txtilanNo.Location = new System.Drawing.Point(22, 73);
            this.txtilanNo.Name = "txtilanNo";
            this.txtilanNo.Size = new System.Drawing.Size(264, 27);
            this.txtilanNo.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(146, 125);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(140, 40);
            this.btnBul.TabIndex = 2;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(22, 125);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(118, 40);
            this.btn_guncelle.TabIndex = 3;
            this.btn_guncelle.Text = "Güncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // frmBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 226);
            this.Controls.Add(this.btn_guncelle);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.txtilanNo);
            this.Controls.Add(this.label1);
            this.Name = "frmBul";
            this.Text = "frmBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtilanNo;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btn_guncelle;
    }
}