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
    public partial class frmBulunan : Form
    {
        Ders ders;

        public frmBulunan(Ders ders)
        {
            InitializeComponent();
            this.ders = ders;

        }
        public frmBulunan()
        {
            InitializeComponent();
        }

        private void frmBulunan_Load(object sender, EventArgs e)
        {
            lbl_Bilgiler.Text = $"Adı => {ders.Adi}\n" +
                                $"Numarası => {ders.Numarasi}\n" +
                                $"Matematik Ortalması => {ders.MatOrt}\n" +
                                $"Türkçe Ortalaması => {ders.TurkceOrt}\n" +
                                $"Fizk Ortalaması => {ders.FizikOrt}\n" +
                                $"Kimya Ortalaması => {ders.KimyaOrt}\n" +
                                $"Biyoloji Ortalaması => {ders.BiyolojiOrt}\n";
        }
    }
}
