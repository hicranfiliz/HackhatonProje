
namespace HackhatonProje
{
    partial class FrmTekstil
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewtekstil = new System.Windows.Forms.DataGridView();
            this.btngoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.urunlerDataSet = new HackhatonProje.UrunlerDataSet();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UrunTableAdapter = new HackhatonProje.UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter();
            this.fillBy5ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy5ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtekstil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            this.fillBy5ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tekstil Ürünleri:";
            // 
            // dataGridViewtekstil
            // 
            this.dataGridViewtekstil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewtekstil.Location = new System.Drawing.Point(11, 57);
            this.dataGridViewtekstil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewtekstil.Name = "dataGridViewtekstil";
            this.dataGridViewtekstil.Size = new System.Drawing.Size(418, 124);
            this.dataGridViewtekstil.TabIndex = 1;
            // 
            // btngoster
            // 
            this.btngoster.Location = new System.Drawing.Point(145, 186);
            this.btngoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(132, 30);
            this.btngoster.TabIndex = 2;
            this.btngoster.Text = "Göster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.btngoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almak İstediğiniz Ürünü Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adedini Giriniz:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 295);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 27);
            this.textBox2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 326);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 26);
            this.button1.TabIndex = 7;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.urunlerDataSet, "Tbl_Urun.UrunAd", true));
            this.comboBox1.DataSource = this.tblUrunBindingSource;
            this.comboBox1.DisplayMember = "UrunAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(239, 259);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(132, 27);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.ValueMember = "UrunAd";
            // 
            // urunlerDataSet
            // 
            this.urunlerDataSet.DataSetName = "UrunlerDataSet";
            this.urunlerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUrunBindingSource
            // 
            this.tblUrunBindingSource.DataMember = "Tbl_Urun";
            this.tblUrunBindingSource.DataSource = this.urunlerDataSet;
            // 
            // tbl_UrunTableAdapter
            // 
            this.tbl_UrunTableAdapter.ClearBeforeFill = true;
            // 
            // fillBy5ToolStrip
            // 
            this.fillBy5ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy5ToolStripButton});
            this.fillBy5ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy5ToolStrip.Name = "fillBy5ToolStrip";
            this.fillBy5ToolStrip.Size = new System.Drawing.Size(449, 25);
            this.fillBy5ToolStrip.TabIndex = 9;
            this.fillBy5ToolStrip.Text = "fillBy5ToolStrip";
            // 
            // fillBy5ToolStripButton
            // 
            this.fillBy5ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy5ToolStripButton.Name = "fillBy5ToolStripButton";
            this.fillBy5ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy5ToolStripButton.Text = "FillBy5";
            this.fillBy5ToolStripButton.Click += new System.EventHandler(this.fillBy5ToolStripButton_Click);
            // 
            // FrmTekstil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(449, 408);
            this.Controls.Add(this.fillBy5ToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.dataGridViewtekstil);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmTekstil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTekstil";
            this.Load += new System.EventHandler(this.FrmTekstil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewtekstil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            this.fillBy5ToolStrip.ResumeLayout(false);
            this.fillBy5ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewtekstil;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private UrunlerDataSet urunlerDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter tbl_UrunTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy5ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy5ToolStripButton;
    }
}