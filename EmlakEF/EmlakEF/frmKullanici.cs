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
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            
            using(var ctx = new EvDbContext())
            {
                var sonuc = from u in ctx.Users
                            where u.UserName== txt_Kullanici.Text.Trim()
                            select u;
                var kullanici = sonuc.FirstOrDefault();
                if (kullanici != null)
                {
                    string Kullanici_Adi =  kullanici.UserName.Trim();
                    string Sifre =  kullanici.Password.Trim();
                    if(Kullanici_Adi == txt_Kullanici.Text.Trim() && Sifre == txt_Sifre.Text.Trim())
                    {
                        frmKayit frm = new frmKayit(kullanici);                        
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hatalı giriş yaptınız!!");
                    }
                }
            }
            
        }

        
    }
}
