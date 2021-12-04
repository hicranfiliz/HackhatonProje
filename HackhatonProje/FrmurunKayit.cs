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
    public partial class FrmurunKayit : Form
    {
        public FrmurunKayit()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Urun(UrunAd,UrunFiyat,UrunTur,UrunStok) values (@p2,@p3,@p4,@p5)", bgl.baglanti());
            
            komut.Parameters.AddWithValue("@p2", txtUrunAd.Text);
            komut.Parameters.AddWithValue("@p3", txtfiyat.Text);
            komut.Parameters.AddWithValue("@p4", cmbkategori.Text);
            komut.Parameters.AddWithValue("@p5", txtstok.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün Kaydınız Yapıldı.");
            FrmUrunEkleGor fr = new FrmUrunEkleGor();
            fr.Show();
            this.Hide();
        }

        private void FrmurunKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
