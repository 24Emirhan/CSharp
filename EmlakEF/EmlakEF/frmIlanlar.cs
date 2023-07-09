using EmlakEF.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmlakEF
{
    public partial class frmIlanlar : Form
    {
        public frmIlanlar()
        {
            InitializeComponent();
        }

        private void frmIlanlar_Load(object sender, EventArgs e)
        {
            using (var ctx = new EvDbContext())
            {
            
                List<Ev> evler = ctx.Evler.ToList();
                dataGridView1.DataSource = evler;
            }
        }

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new EvDbContext())
                {
                    var sonuc = from i in ctx.Evler
                                where i.IlanNo == int.Parse(txt_IlanNo.Text.Trim())
                                select i;
                    var ev = sonuc.FirstOrDefault();
                    if (ev != null)
                    {
                        var frmm = new frmBilgiler(ev);
                        frmm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Ev Bulunamadı");
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
