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

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new AracDbContext())
                {
                    switch (Durumu)
                    {
                        case KayıtDurumu.Insert:
                            var araba = new Araba
                            {
                                IlanNo = int.Parse(txt_IlanNo.Text.Trim()),
                                Marka = txt_Marka.Text.Trim(),
                                Model = txt_Model.Text.Trim(),
                                Kilometre = double.Parse(txt_Kilometre.Text.Trim()),
                                Fiyat = double.Parse(txt_Fiyat.Text.Trim()),
                                Tramer = double.Parse(txt_Tramer.Text.Trim()),
                            };
                            ctx.Add(araba);
                            break;
                        case KayıtDurumu.Update:
                            var buluunanAraba = ctx.Arabalar.Find(urunid);
                            if (buluunanAraba != null)
                            {
                                buluunanAraba.IlanNo = int.Parse(txt_IlanNo.Text.Trim());
                                buluunanAraba.Marka = txt_Marka.Text.Trim();
                                buluunanAraba.Model = txt_Model.Text.Trim();
                                buluunanAraba.Kilometre = double.Parse(txt_Kilometre.Text.Trim());
                                buluunanAraba.Fiyat = double.Parse(txt_Fiyat.Text.Trim());
                                buluunanAraba.Tramer = double.Parse(txt_Tramer.Text.Trim());
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

        private void btn_Bul_Click(object sender, EventArgs e)
        {
            frmIlanlar frm = new frmIlanlar();
            frm.Show();
        }

        private void btn_Sil_Click(object sender, EventArgs e)
        {
            using (var ctx = new AracDbContext())
            {
                var arabaBilgisi = ctx.Arabalar.Find(urunid);
                if (arabaBilgisi != null)
                {
                    txt_IlanNo.Text = arabaBilgisi.IlanNo.ToString();
                    txt_Marka.Text = arabaBilgisi.Marka.ToString();
                    txt_Model.Text = arabaBilgisi.Model.ToString();
                    txt_Kilometre.Text = arabaBilgisi.Kilometre.ToString();
                    txt_Fiyat.Text = arabaBilgisi.Fiyat.ToString();
                    txt_Tramer.Text = arabaBilgisi.Tramer.ToString();
                    ctx.Arabalar.Remove(arabaBilgisi);
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

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            using (var ctx = new AracDbContext())
            {
                var sonuc = from i in ctx.Arabalar
                            where i.IlanNo == int.Parse(txt_IlanNo.Text.Trim())
                            select i;
                var araba = sonuc.FirstOrDefault();
                if (araba != null)
                {
                    urunid = araba.Id;
                    txt_IlanNo.Text = araba.IlanNo.ToString();
                    txt_Marka.Text = araba.Marka.ToString();
                    txt_Model.Text = araba.Model.ToString();
                    txt_Kilometre.Text = araba.Kilometre.ToString();
                    txt_Fiyat.Text = araba.Fiyat.ToString();
                    txt_Tramer.Text = araba.Tramer.ToString();
                    Durumu = KayıtDurumu.Update;
                }
                else
                {
                    MessageBox.Show("Araç Bulunamadı");
                }
                
            }
        }
    }
}
