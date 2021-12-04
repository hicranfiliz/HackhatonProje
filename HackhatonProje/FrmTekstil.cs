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
    public partial class FrmTekstil : Form
    {
        public FrmTekstil()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void btngoster_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun where UrunTur='Tekstil'", bgl.baglanti());
            da.Fill(dt);
            dataGridViewtekstil.DataSource = dt;
        }

        public int UrunMiktari;
        public int UrunFiyat;

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 4)
            {
                UrunMiktari = Convert.ToInt32(textBox2.Text);
                UrunFiyat = UrunMiktari * 500;


            }
            else if (comboBox1.SelectedIndex == 5)
            {
                UrunFiyat = 0;
                UrunMiktari = Convert.ToInt32(textBox2.Text);
                UrunFiyat = UrunMiktari * 250;


            }
            else if (comboBox1.SelectedIndex == 9)
            {
                UrunFiyat = 0;
                UrunMiktari = Convert.ToInt32(textBox2.Text);
                UrunFiyat = UrunMiktari * 400;


            }
            else if (comboBox1.SelectedIndex == 10)
            {
                UrunMiktari = Convert.ToInt32(textBox2.Text);
                UrunFiyat = UrunMiktari * 100;


            }
            MessageBox.Show("Ödemeniz Gereken Tutar: " + UrunFiyat);

        }

        private void FrmTekstil_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunlerDataSet.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter.Fill(this.urunlerDataSet.Tbl_Urun);

        }

        private void fillBy5ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UrunTableAdapter.FillBy5(this.urunlerDataSet.Tbl_Urun);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
