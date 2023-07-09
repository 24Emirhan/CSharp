namespace EmlakEF
{
    partial class frmIlanlar
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
            this.btn_Bul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_IlanNo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Bul
            // 
            this.btn_Bul.Location = new System.Drawing.Point(341, 45);
            this.btn_Bul.Name = "btn_Bul";
            this.btn_Bul.Size = new System.Drawing.Size(94, 29);
            this.btn_Bul.TabIndex = 0;
            this.btn_Bul.Text = "bul";
            this.btn_Bul.UseVisualStyleBackColor = true;
            this.btn_Bul.Click += new System.EventHandler(this.btn_Bul_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlan No giriniz:";
            // 
            // txt_IlanNo
            // 
            this.txt_IlanNo.Location = new System.Drawing.Point(192, 46);
            this.txt_IlanNo.Name = "txt_IlanNo";
            this.txt_IlanNo.Size = new System.Drawing.Size(125, 27);
            this.txt_IlanNo.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(800, 327);
            this.dataGridView1.TabIndex = 3;
            // 
            // frmIlanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_IlanNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Bul);
            this.Name = "frmIlanlar";
            this.Text = "frmIlanlar";
            this.Load += new System.EventHandler(this.frmIlanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Bul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_IlanNo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}