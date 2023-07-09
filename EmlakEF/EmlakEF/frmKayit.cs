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
    public enum KayıtDurumu
    {
        Insert,
        Update
    }
    public partial class frmKayit : Form
    {
        
        public KayıtDurumu Durumu = KayıtDurumu.Insert;
        public int urunid;
        User kullanici;
        public frmKayit()
        {
            InitializeComponent();

        }
        public frmKayit(User kullanici)
        {
            InitializeComponent();
            this.kullanici = kullanici;

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new EvDbContext())
                {
                    switch (Durumu)
                    {
                        case KayıtDurumu.Insert:
                            var ev = new Ev
                            {
                                Alan = txtAlan.Text.Trim(),
                                Semt = txtSemt.Text.Trim(),
                                IlanNo = int.Parse(txtilan.Text.Trim()),
                                OdaSayisi = int.Parse(txtOdaSayisi.Text.Trim()),
                                KatNo = int.Parse(txtKatNo.Text.Trim())
                            };
                            ctx.Add(ev);
                            break;
                        case KayıtDurumu.Update:
                            var bulunanEv = ctx.Evler.Find(urunid);
                            if (bulunanEv != null)
                            {
                                bulunanEv.Alan = txtAlan.Text.Trim();
                                bulunanEv.Semt = txtSemt.Text.Trim();
                                bulunanEv.IlanNo = int.Parse(txtilan.Text.Trim());
                                bulunanEv.OdaSayisi = int.Parse(txtOdaSayisi.Text.Trim());
                                bulunanEv.KatNo = int.Parse(txtKatNo.Text.Trim());
                            };
                            break;
                        default:
                            break;
                    }                    
                    int sonuc = ctx.SaveChanges();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Basarili Eklendi");
                        Clean();
                    }
                    else
                    {
                        MessageBox.Show("Ekleme Basarisiz");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme Exception Hatası");
                throw;
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
                frmIlanlar frm = new frmIlanlar();
                frm.Show();   
        }


        void Clean()
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = String.Empty;
                }
            }
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            using (var ctx = new EvDbContext())
            {
                var evBil = ctx.Evler.Find(urunid);
                if (evBil != null)
                {
                    txtilan.Text = evBil.IlanNo.ToString();
                    txtOdaSayisi.Text = evBil.OdaSayisi.ToString();
                    txtKatNo.Text = evBil.KatNo.ToString();
                    txtAlan.Text = evBil.Alan;
                    txtSemt.Text = evBil.Semt;             
                    ctx.Evler.Remove(evBil);
                }
                int sonuc = ctx.SaveChanges();
                DialogResult dialogResult = MessageBox.Show("KAYDI SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNZ?", "Kaydı Sil", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && sonuc > 0)
                {
                    MessageBox.Show("Kayıt Silindi");
                    Clean();
                    Durumu = KayıtDurumu.Insert;
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Kayıt Silinemedi");
                }
            }
        }

       
    }
}
