
namespace HackhatonProje
{
    partial class FrmSebze
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
            this.dataGridViewsebze = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btngostr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txturunadetsec = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.urunlerDataSet = new HackhatonProje.UrunlerDataSet();
            this.tblUrunBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UrunTableAdapter = new HackhatonProje.UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter();
            this.fillBy4ToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillBy4ToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsebze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).BeginInit();
            this.fillBy4ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewsebze
            // 
            this.dataGridViewsebze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewsebze.Location = new System.Drawing.Point(14, 50);
            this.dataGridViewsebze.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewsebze.Name = "dataGridViewsebze";
            this.dataGridViewsebze.Size = new System.Drawing.Size(436, 134);
            this.dataGridViewsebze.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sebzeler:";
            // 
            // btngostr
            // 
            this.btngostr.Location = new System.Drawing.Point(160, 188);
            this.btngostr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btngostr.Name = "btngostr";
            this.btngostr.Size = new System.Drawing.Size(120, 33);
            this.btngostr.TabIndex = 2;
            this.btngostr.Text = "Göster";
            this.btngostr.UseVisualStyleBackColor = true;
            this.btngostr.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Almak İstediğiniz Ürünüz Giriniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ürün Adediniz Giriniz:";
            // 
            // txturunadetsec
            // 
            this.txturunadetsec.Location = new System.Drawing.Point(250, 288);
            this.txturunadetsec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txturunadetsec.Name = "txturunadetsec";
            this.txturunadetsec.Size = new System.Drawing.Size(134, 27);
            this.txturunadetsec.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.urunlerDataSet, "Tbl_Urun.UrunAd", true));
            this.comboBox1.DataSource = this.tblUrunBindingSource;
            this.comboBox1.DisplayMember = "UrunAd";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 256);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 27);
            this.comboBox1.TabIndex = 7;
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
            // fillBy4ToolStrip
            // 
            this.fillBy4ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillBy4ToolStripButton});
            this.fillBy4ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy4ToolStrip.Name = "fillBy4ToolStrip";
            this.fillBy4ToolStrip.Size = new System.Drawing.Size(470, 25);
            this.fillBy4ToolStrip.TabIndex = 8;
            this.fillBy4ToolStrip.Text = "fillBy4ToolStrip";
            // 
            // fillBy4ToolStripButton
            // 
            this.fillBy4ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy4ToolStripButton.Name = "fillBy4ToolStripButton";
            this.fillBy4ToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillBy4ToolStripButton.Text = "FillBy4";
            this.fillBy4ToolStripButton.Click += new System.EventHandler(this.fillBy4ToolStripButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(250, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ürün Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmSebze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(470, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillBy4ToolStrip);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txturunadetsec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btngostr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewsebze);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSebze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSebze";
            this.Load += new System.EventHandler(this.FrmSebze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewsebze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUrunBindingSource)).EndInit();
            this.fillBy4ToolStrip.ResumeLayout(false);
            this.fillBy4ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewsebze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btngostr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txturunadetsec;
        private System.Windows.Forms.ComboBox comboBox1;
        private UrunlerDataSet urunlerDataSet;
        private System.Windows.Forms.BindingSource tblUrunBindingSource;
        private UrunlerDataSetTableAdapters.Tbl_UrunTableAdapter tbl_UrunTableAdapter;
        private System.Windows.Forms.ToolStrip fillBy4ToolStrip;
        private System.Windows.Forms.ToolStripButton fillBy4ToolStripButton;
        private System.Windows.Forms.Button button1;
    }
}