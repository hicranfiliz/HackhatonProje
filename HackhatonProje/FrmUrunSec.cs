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
    public partial class FrmUrunSec : Form
    {
        public FrmUrunSec()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMaden fr = new FrmMaden();
            fr.Show();

            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun where UrunTur='Maden'", bgl.baglanti());
            //da.Fill(dt);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmTekstil fr = new FrmTekstil();
            fr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmSebze fr = new FrmSebze();
            fr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmMeyve fr = new FrmMeyve();
            fr.Show();
        }
    }
}
