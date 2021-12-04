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
    public partial class FrmSebze : Form
    {
        public FrmSebze()
        {
            InitializeComponent();
        }

        ClassSqlBaglantisi bgl = new ClassSqlBaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun where UrunTur='Sebze'", bgl.baglanti());
            da.Fill(dt);
            dataGridViewsebze.DataSource = dt;

        }

        private void FrmSebze_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'urunlerDataSet.Tbl_Urun' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_UrunTableAdapter.Fill(this.urunlerDataSet.Tbl_Urun);

        }

        private void fillBy4ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_UrunTableAdapter.FillBy4(this.urunlerDataSet.Tbl_Urun);
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
            if (comboBox1.SelectedIndex == 6)
            {
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
                UrunFiyat = UrunMiktari * 5;


            }
            else if (comboBox1.SelectedIndex == 11)
            {
                UrunFiyat = 0;
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
                UrunFiyat = UrunMiktari * 2;


            }
            else if (comboBox1.SelectedIndex == 12)
            {
                UrunFiyat = 0;
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
                UrunFiyat = UrunMiktari * 4;


            }
            else if (comboBox1.SelectedIndex == 13)
            {
                UrunMiktari = Convert.ToInt32(txturunadetsec.Text);
                UrunFiyat = UrunMiktari * 3;


            }
            MessageBox.Show("Ödemeniz Gereken Tutar: " + UrunFiyat);

        }
    }
}
