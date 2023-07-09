using Arac_Satis.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arac_Satis
{
    public partial class frmIlanlar : Form
    {
        public frmIlanlar()
        {
            InitializeComponent();
        }

        private void frmIlanlar_Load(object sender, EventArgs e)
        {
            using (var ctx = new AracDbContext())
            {
                //"SELECT * FROM Dersler"
                List<Araba> arabalar = ctx.Arabalar.ToList();
                dataGridView1.DataSource = arabalar;
            }
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new AracDbContext())
                {

                    var sonuc = from i in ctx.Arabalar
                                where i.Marka == txt_Marka.Text.Trim()
                                select i;
                    List<Araba> arabalar = new List<Araba>();

                    foreach (var araba in sonuc)
                    {
                        arabalar.Add(araba);
                    }

                    if (arabalar != null)
                    {
                        var frmm = new frmBilgiler(arabalar);
                        frmm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Araba Bulunamadı");
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
    }
}
