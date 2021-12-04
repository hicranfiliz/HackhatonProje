using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HackhatonProje
{
    public partial class FrmMusteriGiris : Form
    {
        public FrmMusteriGiris()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMusteriKayit fr = new FrmMusteriKayit();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmUrunSec fr = new FrmUrunSec();
            fr.Show();
            this.Hide();
        }
    }
}
