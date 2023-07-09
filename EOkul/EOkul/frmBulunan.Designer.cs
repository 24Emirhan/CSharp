namespace EOkul
{
    partial class frmBulunan
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
            this.lbl_Bilgiler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Bilgiler
            // 
            this.lbl_Bilgiler.AutoSize = true;
            this.lbl_Bilgiler.Location = new System.Drawing.Point(58, 45);
            this.lbl_Bilgiler.Name = "lbl_Bilgiler";
            this.lbl_Bilgiler.Size = new System.Drawing.Size(50, 20);
            this.lbl_Bilgiler.TabIndex = 0;
            this.lbl_Bilgiler.Text = "label1";
            // 
            // frmBulunan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Bilgiler);
            this.Name = "frmBulunan";
            this.Text = "frmBulunan";
            this.Load += new System.EventHandler(this.frmBulunan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_Bilgiler;
    }
}