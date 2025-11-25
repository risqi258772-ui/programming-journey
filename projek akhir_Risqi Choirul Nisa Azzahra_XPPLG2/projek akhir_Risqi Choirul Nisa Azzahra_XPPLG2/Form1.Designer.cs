namespace projek_akhir_Risqi_Choirul_Nisa_Azzahra_XPPLG2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tbKursi = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbJmlBeli = new TextBox();
            label6 = new Label();
            btnCancel = new Button();
            tbTotal = new TextBox();
            btnBayar = new Button();
            label7 = new Label();
            label8 = new Label();
            tbTanggal = new TextBox();
            label9 = new Label();
            tbTotalBayar = new TextBox();
            label10 = new Label();
            TbKembalian = new TextBox();
            cbHargaSatuan = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(397, 12);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 307);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(31, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(310, 30);
            label1.TabIndex = 1;
            label1.Text = "= TIKET BIOSKOP TOTORO =";
           
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(184, 28);
            label2.TabIndex = 2;
            label2.Text = "No.Kursi               :";
            
            // 
            // tbKursi
            // 
            tbKursi.Location = new Point(212, 84);
            tbKursi.Name = "tbKursi";
            tbKursi.Size = new Size(150, 34);
            tbKursi.TabIndex = 3;
            tbKursi.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 4;
            label3.Text = "Harga Satuan        :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 182);
            label4.Name = "label4";
            label4.Size = new Size(193, 28);
            label4.TabIndex = 5;
            label4.Text = " Jumlah Beli           :";
            // 
            // tbJmlBeli
            // 
            tbJmlBeli.Location = new Point(212, 182);
            tbJmlBeli.Name = "tbJmlBeli";
            tbJmlBeli.Size = new Size(150, 34);
            tbJmlBeli.TabIndex = 8;
            tbJmlBeli.TextChanged += tbJmlBeli_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 229);
            label6.Name = "label6";
            label6.Size = new Size(180, 28);
            label6.TabIndex = 10;
            label6.Text = "Total Harga          :";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ActiveBorder;
            btnCancel.Location = new Point(49, 436);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += button2_Click;
            // 
            // tbTotal
            // 
            tbTotal.Location = new Point(212, 229);
            tbTotal.Name = "tbTotal";
            tbTotal.Size = new Size(150, 34);
            tbTotal.TabIndex = 13;
            // 
            // btnBayar
            // 
            btnBayar.BackColor = SystemColors.ControlDark;
            btnBayar.Location = new Point(212, 436);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(112, 34);
            btnBayar.TabIndex = 14;
            btnBayar.Text = "Bayar";
            btnBayar.UseVisualStyleBackColor = false;
            btnBayar.Click += button3_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ActiveCaption;
            label7.Location = new Point(514, 332);
            label7.Name = "label7";
            label7.Size = new Size(193, 28);
            label7.TabIndex = 15;
            label7.Text = "== THANK YOU ==";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(514, 458);
            label8.Name = "label8";
            label8.Size = new Size(93, 28);
            label8.TabIndex = 16;
            label8.Text = "Tanggal :";
            // 
            // tbTanggal
            // 
            tbTanggal.Location = new Point(625, 460);
            tbTanggal.Name = "tbTanggal";
            tbTanggal.Size = new Size(243, 34);
            tbTanggal.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 280);
            label9.Name = "label9";
            label9.Size = new Size(181, 28);
            label9.TabIndex = 18;
            label9.Text = "Total Bayar           :";
            // 
            // tbTotalBayar
            // 
            tbTotalBayar.Location = new Point(212, 285);
            tbTotalBayar.Name = "tbTotalBayar";
            tbTotalBayar.Size = new Size(150, 34);
            tbTotalBayar.TabIndex = 19;
            tbTotalBayar.TextChanged += tbTotalBayar_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 332);
            label10.Name = "label10";
            label10.Size = new Size(178, 28);
            label10.TabIndex = 20;
            label10.Text = "Kembalian           :";
            
            // 
            // TbKembalian
            // 
            TbKembalian.Location = new Point(212, 332);
            TbKembalian.Name = "TbKembalian";
            TbKembalian.Size = new Size(150, 34);
            TbKembalian.TabIndex = 21;
            // 
            // cbHargaSatuan
            // 
            cbHargaSatuan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbHargaSatuan.FormattingEnabled = true;
            cbHargaSatuan.Location = new Point(212, 132);
            cbHargaSatuan.Name = "cbHargaSatuan";
            cbHargaSatuan.Size = new Size(150, 36);
            cbHargaSatuan.TabIndex = 22;
            cbHargaSatuan.SelectedIndexChanged += cbHargaSatuan_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 504);
            Controls.Add(cbHargaSatuan);
            Controls.Add(TbKembalian);
            Controls.Add(label10);
            Controls.Add(tbTotalBayar);
            Controls.Add(label9);
            Controls.Add(tbTanggal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnBayar);
            Controls.Add(tbTotal);
            Controls.Add(btnCancel);
            Controls.Add(label6);
            Controls.Add(tbJmlBeli);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbKursi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Cursor = Cursors.IBeam;
            Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "   ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox tbKursi;
        private Label label3;
        private Label label4;
        private TextBox tbJmlBeli;
        private Label label6;
        private Button btnCancel;
        private TextBox tbTotal;
        private Button btnBayar;
        private Label label7;
        private Label label8;
        private TextBox tbTanggal;
        private Label label9;
        private TextBox tbTotalBayar;
        private Label label10;
        private TextBox TbKembalian;
        private ComboBox cbHargaSatuan;
    }
}
