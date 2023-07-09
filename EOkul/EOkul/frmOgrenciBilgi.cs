using EOkul.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOkul
{
    public partial class frmOgrenciBilgi : Form
    {
        public frmOgrenciBilgi()
        {
            InitializeComponent();
        }

        private void btn_OgrenciAra_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new OkulDbContext())
                {
                    var sonuc = from i in ctx.Dersler
                                where i.Numarasi == txt_Numara.Text.Trim()
                                select i;
                    var ders = sonuc.FirstOrDefault();
                    if (ders != null)
                    {
                        var frmm = new frmBulunan(ders);
                        frmm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Öğrenci Bulunamadı");
                    }
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bul Exception Hatası");
                throw;
            }
        }

        private void frmOgrenciBilgi_Load(object sender, EventArgs e)
        {
            using (var ctx = new OkulDbContext())
            {
                //"SELECT * FROM Dersler"
                List<Ders> dersler = ctx.Dersler.ToList();
                dataGridView1.DataSource = dersler;
            }
        }
    }
}
