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
    public partial class frmBul : Form
    {
        frmKayit frm;
        public frmBul(frmKayit frm)
        {
            InitializeComponent();
            this.frm = frm;
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new EvDbContext())
                {
                    var sonuc = from i in ctx.Evler
                                where i.IlanNo == int.Parse(txtilanNo.Text.Trim())
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

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (var ctx = new EvDbContext())
            {
                var sonuc = from i in ctx.Evler
                            where i.IlanNo == int.Parse(txtilanNo.Text.Trim())
                            select i;
                var ev = sonuc.FirstOrDefault();
                if (ev != null)
                {
                    frm.txtilan.Text = ev.IlanNo.ToString();
                    frm.txtOdaSayisi.Text = ev.OdaSayisi.ToString();
                    frm.txtKatNo.Text = ev.KatNo.ToString();
                    frm.txtAlan.Text = ev.Alan;
                    frm.txtSemt.Text = ev.Semt;
                    frm.urunid = ev.Id;
                    frm.Durumu = KayıtDurumu.Update;
                }
                else
                {
                    MessageBox.Show("Ev Bulunamadı");
                }
                this.Close();
            }
        }
    }
}
