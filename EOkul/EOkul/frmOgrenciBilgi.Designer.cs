namespace EOkul
{
    partial class frmOgrenciBilgi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_OgrenciAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Numara = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 137);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(801, 301);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_OgrenciAra
            // 
            this.btn_OgrenciAra.Location = new System.Drawing.Point(357, 13);
            this.btn_OgrenciAra.Name = "btn_OgrenciAra";
            this.btn_OgrenciAra.Size = new System.Drawing.Size(94, 29);
            this.btn_OgrenciAra.TabIndex = 6;
            this.btn_OgrenciAra.Text = "Ara";
            this.btn_OgrenciAra.UseVisualStyleBackColor = true;
            this.btn_OgrenciAra.Click += new System.EventHandler(this.btn_OgrenciAra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Öğrenci Numarası Giriniz";
            // 
            // txt_Numara
            // 
            this.txt_Numara.Location = new System.Drawing.Point(206, 14);
            this.txt_Numara.Name = "txt_Numara";
            this.txt_Numara.Size = new System.Drawing.Size(125, 27);
            this.txt_Numara.TabIndex = 4;
            // 
            // frmOgrenciBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_OgrenciAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Numara);
            this.Name = "frmOgrenciBilgi";
            this.Text = "frmOgrenciBilgi";
            this.Load += new System.EventHandler(this.frmOgrenciBilgi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_OgrenciAra;
        private Label label1;
        private TextBox txt_Numara;
    }
}