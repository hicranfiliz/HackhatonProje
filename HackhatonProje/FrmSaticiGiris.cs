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
    public partial class FrmSaticiGiris : Form
    {
        public FrmSaticiGiris()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmSaticiKayit fr = new FrmSaticiKayit();
            fr.Show();
            
        }


        public string KullaniciAd;
        

        private void btngirisyap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From Tbl_SaticiBilgi Where SaticiKullaniciAdi=@p1 and SaticiSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciad.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            KullaniciAd = txtKullaniciad.Text;
            if (dr.Read())
            {
                FrmUrunEkleGor fr = new FrmUrunEkleGor();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ya da Şifre");
            }
            bgl.baglanti().Close();
        }

        private void FrmSaticiGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
