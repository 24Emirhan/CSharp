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
    public partial class frmBilgiler : Form
    {

        List<Araba> arabalar;

        public frmBilgiler(List<Araba> arabalar)
        {
            InitializeComponent();
            this.arabalar = arabalar;

        }
        public frmBilgiler()
        {
            InitializeComponent();
        }

        private void frmBilgiler_Load(object sender, EventArgs e)
        {
            //string arabaMetin = "";
            //foreach (var araba in arabalar)
            //{
            //    arabaMetin += "İlan No =>" + araba.IlanNo + "\n"+
            //                  "Marka => " + araba.Marka + "\n"+ 
            //                  "Model=> " + araba.Model + "\n"+
            //                  "Kilometre => " + araba.Kilometre+ "\n"+
            //                  "Fiyat => " + araba.Fiyat + "\n"+
            //                  "Tramer => " + araba.Tramer + "\n"+
            //                  "***************************************" + "\n";
            //}

            dataGridView1.DataSource = arabalar;
            
        }
    }
}
