namespace Arac_Satis
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
            this.txt_IlanMarka = new System.Windows.Forms.TextBox();
            this.btn_AraclariBul = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marka Giriniz";
            // 
            // txt_IlanMarka
            // 
            this.txt_IlanMarka.Location = new System.Drawing.Point(22, 71);
            this.txt_IlanMarka.Name = "txt_IlanMarka";
            this.txt_IlanMarka.Size = new System.Drawing.Size(194, 27);
            this.txt_IlanMarka.TabIndex = 1;
            // 
            // btn_AraclariBul
            // 
            this.btn_AraclariBul.Location = new System.Drawing.Point(71, 113);
            this.btn_AraclariBul.Name = "btn_AraclariBul";
            this.btn_AraclariBul.Size = new System.Drawing.Size(94, 29);
            this.btn_AraclariBul.TabIndex = 3;
            this.btn_AraclariBul.Text = "Bul";
            this.btn_AraclariBul.UseVisualStyleBackColor = true;
            this.btn_AraclariBul.Click += new System.EventHandler(this.btn_AraclariBul_Click);
            // 
            // frmBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 194);
            this.Controls.Add(this.btn_AraclariBul);
            this.Controls.Add(this.txt_IlanMarka);
            this.Controls.Add(this.label1);
            this.Name = "frmBul";
            this.Text = "frmBul";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_IlanMarka;
        private Button btn_AraclariBul;
    }
}