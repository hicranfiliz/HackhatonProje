
namespace HackhatonProje
{
    partial class FrmMeyve
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
            this.dataGridViewmeyve = new System.Windows.Forms.DataGridView();
            this.btngoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.urunlerDataSet = new HackhatonProje.UrunlerDataSet();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UrunTableAdapter = new HackhatonProje.UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter();
            this.fillBy3ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy3ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmeyve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            this.fillBy3ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Meyveler:";
            // 
            // dataGridViewmeyve
            // 
            this.dataGridViewmeyve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewmeyve.Location = new System.Drawing.Point(17, 52);
            this.dataGridViewmeyve.Name = "dataGridViewmeyve";
            this.dataGridViewmeyve.Size = new System.Drawing.Size(443, 150);
            this.dataGridViewmeyve.TabIndex = 1;
            // 
            // btngoster
            // 
            this.btngoster.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngoster.Location = new System.Drawing.Point(169, 208);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(102, 32);
            this.btngoster.TabIndex = 2;
            this.btngoster.Text = "Göster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(13, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almak İstediğiniz Ürünü Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(97, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adedini Giriniz:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(271, 306);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 27);
            this.textBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.urunlerDataSet, "Tbl_Urun.UrunAd", true));
            this.comboBox1.DataSource = this.tblUrunBindingSource;
            this.comboBox1.DisplayMember = "UrunAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 269);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 27);
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
            // fillBy3ToolStrip
            // 
            this.fillBy3ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy3ToolStripButton});
            this.fillBy3ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy3ToolStrip.Name = "fillBy3ToolStrip";
            this.fillBy3ToolStrip.Size = new System.Drawing.Size(480, 25);
            this.fillBy3ToolStrip.TabIndex = 9;
            this.fillBy3ToolStrip.Text = "fillBy3ToolStrip";
            // 
            // fillBy3ToolStripButton
            // 
            this.fillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy3ToolStripButton.Name = "fillBy3ToolStripButton";
            this.fillBy3ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy3ToolStripButton.Text = "FillBy3";
            this.fillBy3ToolStripButton.Click += new System.EventHandler(this.fillBy3ToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 32);
            this.button1.TabIndex = 10;
            this.button1.Text = "ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmMeyve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(480, 404);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillBy3ToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngoster);
            this.Controls.Add(this.dataGridViewmeyve);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMeyve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMeyve";
            this.Load += new System.EventHandler(this.FrmMeyve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewmeyve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            this.fillBy3ToolStrip.ResumeLayout(false);
            this.fillBy3ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewmeyve;
        private System.Windows.Forms.Button btngoster;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private UrunlerDataSet urunlerDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter tbl_UrunTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy3ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy3ToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}