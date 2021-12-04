
namespace HackhatonProje
{
    partial class FrmMaden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridViewmaden = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btngoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunadetsec = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.urunlerDataSet = new HackhatonProje.UrunlerDataSet();
            this.tbl_UrunTableAdapter = new HackhatonProje.UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter();
            this.fillBy2ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy2ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmaden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).BeginInit();
            this.fillBy2ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewmaden
            // 
            this.dataGridViewmaden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmaden.Location = new System.Drawing.Point(15, 61);
            this.dataGridViewmaden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewmaden.Name = "dataGridViewmaden";
            this.dataGridViewmaden.Size = new System.Drawing.Size(467, 124);
            this.dataGridViewmaden.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Madenler:";
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(153, 190);
            this.btngoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(119, 29);
            this.btngoster.TabIndex = 2;
            this.btngoster.Text = "Göster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almak İstediğiniz Ürünü Giriniz: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Adedini Giriniz: ";
            // 
            // txturunadetsec
            // 
            this.txturunadetsec.Location = new System.Drawing.Point(247, 291);
            this.txturunadetsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txturunadetsec.Name = "txturunadetsec";
            this.txturunadetsec.Size = new System.Drawing.Size(161, 27);
            this.txturunadetsec.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tblUrunBindingSource, "UrunAd", true));
            this.comboBox1.DataSource = this.tblUrunBindingSource;
            this.comboBox1.DisplayMember = "UrunAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(247, 255);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 27);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.ValueMember = "UrunAd";
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "Tbl_Urun";
            this.tblUrunBindingSource.DataSource = this.urunlerDataSet;
            // 
            // urunlerDataSet
            // 
            this.urunlerDataSet.DataSetName = "UrunlerDataSet";
            this.urunlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UrunTableAdapter
            // 
            this.tbl_UrunTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy2ToolStrip
            // 
            this.fillBy2ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy2ToolStripButton});
            this.fillBy2ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy2ToolStrip.Name = "fillBy2ToolStrip";
            this.fillBy2ToolStrip.Size = new System.Drawing.Size(494, 25);
            this.fillBy2ToolStrip.TabIndex = 8;
            this.fillBy2ToolStrip.Text = "fillBy2ToolStrip";
            // 
            // fillBy2ToolStripButton
            // 
            this.fillBy2ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy2ToolStripButton.Name = "fillBy2ToolStripButton";
            this.fillBy2ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy2ToolStripButton.Text = "FillBy2";
            this.fillBy2ToolStripButton.Click += new System.EventHandler(this.fillBy2ToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(247, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMaden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(494, 398);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillBy2ToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txturunadetsec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewmaden);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMaden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMaden";
            this.Load += new System.EventHandler(this.FrmMaden_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmaden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).EndInit();
            this.fillBy2ToolStrip.ResumeLayout(false);
            this.fillBy2ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewmaden;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txturunadetsec;
        private System.Windows.Forms.ComboBox comboBox1;
        private UrunlerDataSet urunlerDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter tbl_UrunTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy2ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy2ToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}