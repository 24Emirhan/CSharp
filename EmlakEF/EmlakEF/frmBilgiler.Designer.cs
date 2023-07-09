namespace EmlakEF
{
    partial class frmBilgiler
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
            this.lblBilgiler = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBilgiler
            // 
            this.lblBilgiler.AutoSize = true;
            this.lblBilgiler.Location = new System.Drawing.Point(104, 92);
            this.lblBilgiler.Name = "lblBilgiler";
            this.lblBilgiler.Size = new System.Drawing.Size(50, 20);
            this.lblBilgiler.TabIndex = 1;
            this.lblBilgiler.Text = "label1";
            // 
            // frmBilgiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 395);
            this.Controls.Add(this.lblBilgiler);
            this.Name = "frmBilgiler";
            this.Text = "frmBilgiler";
            this.Load += new System.EventHandler(this.frmBilgiler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBilgiler;
    }
}