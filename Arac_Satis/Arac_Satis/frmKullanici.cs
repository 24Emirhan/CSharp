using Arac_Satis.Model;

namespace Arac_Satis
{
    public partial class frmKullanici : Form
    {
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            using (var ctx = new AracDbContext())
            {
                var sonuc = from u in ctx.Users
                            where u.UserName == txt_Kullanici.Text.Trim()
                            select u;
                var kullanici = sonuc.FirstOrDefault();
                if (kullanici != null)
                {
                    string Kullanici_Adi = txt_Kullanici.Text = kullanici.UserName.Trim();
                    string Sifre = txt_Sifre.Text = kullanici.Password.Trim();
                    if (Kullanici_Adi == txt_Kullanici.Text.Trim() && Sifre == txt_Sifre.Text.Trim())
                    {
                        frmKayit frm = new frmKayit(kullanici);
                        frm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Hatalý giriþ yaptýnýz!!");
                    }
                }
            }
        }
    }
}