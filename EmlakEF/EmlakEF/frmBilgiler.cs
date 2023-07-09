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
    public partial class frmBilgiler : Form
    {
        Ev ev;

        public frmBilgiler(Ev ev)
        {
            InitializeComponent();
            this.ev = ev;

        }


        private void frmBilgiler_Load(object sender, EventArgs e)
        {

            lblBilgiler.Text = $"İlan No: {ev.IlanNo}\n" +
                               $"Oda Sayısı: {ev.OdaSayisi}\n" +
                               $"Kat No: {ev.KatNo}\n" +
                               $"Alan: {ev.Alan}\n" +
                               $"Semt: {ev.Semt}";
        }
    }
}
