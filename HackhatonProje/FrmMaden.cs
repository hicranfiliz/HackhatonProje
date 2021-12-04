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
    public partial class FrmMaden : Form
    {
        public FrmMaden()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void FrmMaden_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunlerDataSet.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter.Fill(this.urunlerDataSet.Tbl_Urun);
            // TODO: Bu kod satırı 'urunlerDataSet.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter.Fill(this.urunlerDataSet.Tbl_Urun);
            //SqlCommand komut = new SqlCommand("Select * From Tbl_Urunler where UrunTur=@p1", bgl.baglanti());
            //SqlDataAdapter adapt = new SqlDataAdapter(komut);
            //DataSet ds = new DataSet();
            //adapt.Fill(ds);
            //bgl.baglanti()

            //DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urunler where UrunTur=@p1", bgl.baglanti());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun where UrunTur='Maden'", bgl.baglanti());
            da.Fill(dt);
            dataGridViewmaden.DataSource = dt;
            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UrunTableAdapter.FillBy(this.urunlerDataSet.Tbl_Urun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UrunTableAdapter.FillBy1(this.urunlerDataSet.Tbl_Urun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UrunTableAdapter.FillBy2(this.urunlerDataSet.Tbl_Urun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        public int UrunMiktari;
        public int UrunFiyat;

        private void button1_Click_1(object sender, EventArgs e)
        {
           

            if (comboBox1.SelectedIndex == 0)
            {
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
                UrunFiyat = UrunMiktari * 200;


            }
            else if (comboBox1.SelectedIndex == 1)
            {
               UrunFiyat = 0;
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
                UrunFiyat = UrunMiktari * 30;


            }
            else if (comboBox1.SelectedIndex == 2)
            {
             UrunFiyat = 0;
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
              UrunFiyat = UrunMiktari * 800;


            }
            else if (comboBox1.SelectedIndex == 3)
            {
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
              UrunFiyat = UrunMiktari * 1200;


            }
            MessageBox.Show("Ödemeniz Gereken Tutar: " + UrunFiyat);
          


        }
    }
}
