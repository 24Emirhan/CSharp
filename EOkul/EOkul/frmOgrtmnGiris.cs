using EOkul.Model;
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
    public enum KayıtDurumu
    {
        Insert,
        Update
    }
    public partial class frmOgrtmnGiris : Form
    {
        public KayıtDurumu Durumu = KayıtDurumu.Insert;
        public int urunid;
        public frmOgrtmnGiris()
        {
            InitializeComponent();
        }

        private void btn_Kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var ctx = new OkulDbContext())
                {
                    double matOrt = (((double.Parse(txt_MatVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_MatFinal.Text.Trim()) * 60) / 100)));
                    double fizikOrt = (((double.Parse(txt_FizikVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_FizikFinal.Text.Trim()) * 60) / 100)));
                    double kimyaOrt = (((double.Parse(txt_KimyaVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_KimyaFinal.Text.Trim()) * 60) / 100)));
                    double biyolojiOrt = (((double.Parse(txt_BiyolojiVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_BiyolojiFinal.Text.Trim()) * 60) / 100)));
                    double turkceOrt = (((double.Parse(txt_TurkceVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_TurkceFinal.Text.Trim()) * 60) / 100)));
                    switch (Durumu)
                    {
                        case KayıtDurumu.Insert:
                            var Not = new Ders
                            {
                                Adi = txt_Adi.Text.Trim(),
                                Numarasi = txt_Numarasi.Text.Trim(),
                                MatOrt = matOrt,
                                FizikOrt = fizikOrt,
                                KimyaOrt = kimyaOrt,
                                BiyolojiOrt = biyolojiOrt,
                                TurkceOrt = turkceOrt,
                            };
                            ctx.Add(Not);
                            break;
                        case KayıtDurumu.Update:
                            var bulunanOgrenci = ctx.Dersler.Find(urunid);
                            if (bulunanOgrenci != null)
                            {
                                bulunanOgrenci.Adi = txt_Adi.Text.Trim();
                                bulunanOgrenci.Numarasi = txt_Numarasi.Text.Trim();
                                bulunanOgrenci.MatOrt = (((double.Parse(txt_MatVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_MatFinal.Text.Trim()) * 60) / 100)));
                                bulunanOgrenci.FizikOrt = (((double.Parse(txt_FizikVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_FizikFinal.Text.Trim()) * 60) / 100)));
                                bulunanOgrenci.KimyaOrt = (((double.Parse(txt_KimyaVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_KimyaFinal.Text.Trim()) * 60) / 100)));
                                bulunanOgrenci.BiyolojiOrt = (((double.Parse(txt_BiyolojiVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_BiyolojiFinal.Text.Trim()) * 60) / 100)));
                                bulunanOgrenci.TurkceOrt = (((double.Parse(txt_TurkceVize.Text.Trim()) * 40) / 100) + (((double.Parse(txt_TurkceFinal.Text.Trim()) * 60) / 100)));
                            }
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

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {

        }
    }
}
