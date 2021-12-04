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
    public partial class FrmUrunEkleGor : Form
    {
        public FrmUrunEkleGor()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            FrmurunKayit fr = new FrmurunKayit();
            fr.Show();
            this.Hide();
        }

       public  String KullaniciAd;


        private void button2_Click(object sender, EventArgs e)
        {
            FrmUrunleriGor fr = new FrmUrunleriGor();
            fr.Show();

            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun where SaticiKullaniciAd=" + KullaniciAd,bgl.baglanti());
            //da.Fill(dt);
            
        }
    }
}
