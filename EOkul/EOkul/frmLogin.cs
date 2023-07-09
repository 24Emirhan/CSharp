namespace EOkul
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_Giris_Click(object sender, EventArgs e)
        {
            string Kullanici = txt_KullaniciAdi.Text;
            if (Kullanici == "Ogrenci")
            {
                var frmm = new frmOgrenciBilgi();
                frmm.Show();
            }
            else if (Kullanici == "Ogretmen")
            {
                var frmm = new frmOgrtmnGiris();
                frmm.Show();
            }
            else
            {
                MessageBox.Show("Hatalý giriþ yaptýnýz");
            }
        }
    }
}