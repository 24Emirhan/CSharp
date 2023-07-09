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
    public partial class frmBul : Form
    {
        frmKayit frm;
        public frmBul(frmKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        public frmBul()
        {
            InitializeComponent();
        }

        private void btn_AraclariBul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new AracDbContext())
                {

                    var sonuc = from i in ctx.Arabalar
                                where i.Marka == txt_IlanMarka.Text.Trim()
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
