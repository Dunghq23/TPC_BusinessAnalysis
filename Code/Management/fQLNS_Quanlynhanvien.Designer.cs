namespace The_Pizza_Company.Management
{
    partial class fQLNS_QuanLyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQLNS_QuanLyNhanVien));
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbHo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCoSoLamViec = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpkngaybatdau = new System.Windows.Forms.DateTimePicker();
            this.cbViTri = new System.Windows.Forms.ComboBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvDSNV = new System.Windows.Forms.DataGridView();
            this.dtpkNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(175, 93);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(194, 22);
            this.txbTen.TabIndex = 2;
            this.txbTen.TextChanged += new System.EventHandler(this.txbTen_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Tên";
            // 
            // txbHo
            // 
            this.txbHo.Location = new System.Drawing.Point(175, 59);
            this.txbHo.Name = "txbHo";
            this.txbHo.Size = new System.Drawing.Size(194, 22);
            this.txbHo.TabIndex = 1;
            this.txbHo.TextChanged += new System.EventHandler(this.txbHo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Họ";
            // 
            // cbCoSoLamViec
            // 
            this.cbCoSoLamViec.FormattingEnabled = true;
            this.cbCoSoLamViec.Items.AddRange(new object[] {
            "TPC Vincom Trần Duy Hưng",
            "TPC Linh Đàm",
            "TPC Vincom Royal City",
            "TPC Cầu giấy",
            "TPC Nguyễn Văn Lộc",
            "TPC Đoàn Trần Nghiệp",
            "TPC Vincom Times City",
            "TPC Xuân Diệu"});
            this.cbCoSoLamViec.Location = new System.Drawing.Point(572, 120);
            this.cbCoSoLamViec.Name = "cbCoSoLamViec";
            this.cbCoSoLamViec.Size = new System.Drawing.Size(194, 24);
            this.cbCoSoLamViec.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(411, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cơ sở làm việc:";
            // 
            // dtpkngaybatdau
            // 
            this.dtpkngaybatdau.Location = new System.Drawing.Point(572, 89);
            this.dtpkngaybatdau.Name = "dtpkngaybatdau";
            this.dtpkngaybatdau.Size = new System.Drawing.Size(194, 22);
            this.dtpkngaybatdau.TabIndex = 6;
            // 
            // cbViTri
            // 
            this.cbViTri.FormattingEnabled = true;
            this.cbViTri.Items.AddRange(new object[] {
            "Parttime 1",
            "Parttime 2",
            "Parttime 3",
            "Fulltime 1",
            "Fulltime 2",
            "Fulltime 3",
            "Shift Supervisor",
            "ARGM1",
            "ARGM2",
            "RGM"});
            this.cbViTri.Location = new System.Drawing.Point(572, 55);
            this.cbViTri.Name = "cbViTri";
            this.cbViTri.Size = new System.Drawing.Size(194, 24);
            this.cbViTri.TabIndex = 5;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(175, 121);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.ReadOnly = true;
            this.txbHoTen.Size = new System.Drawing.Size(194, 22);
            this.txbHoTen.TabIndex = 3;
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(175, 22);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(194, 22);
            this.txbMaNV.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(411, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày bắt đầu làm việc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(411, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vị trí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhân viên:";
            // 
            // dtgvDSNV
            // 
            this.dtgvDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgvDSNV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSNV.Location = new System.Drawing.Point(12, 183);
            this.dtgvDSNV.Name = "dtgvDSNV";
            this.dtgvDSNV.RowHeadersWidth = 51;
            this.dtgvDSNV.RowTemplate.Height = 24;
            this.dtgvDSNV.Size = new System.Drawing.Size(1153, 539);
            this.dtgvDSNV.TabIndex = 11;
            this.dtgvDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSNV_CellClick);
            // 
            // dtpkNgaySinh
            // 
            this.dtpkNgaySinh.Location = new System.Drawing.Point(572, 26);
            this.dtpkNgaySinh.Name = "dtpkNgaySinh";
            this.dtpkNgaySinh.Size = new System.Drawing.Size(194, 22);
            this.dtpkNgaySinh.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(411, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "Ngày sinh";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(86, 49);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(3, 58);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(86, 49);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(3, 113);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(86, 51);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txbHo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpkNgaySinh);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbMaNV);
            this.panel1.Controls.Add(this.cbCoSoLamViec);
            this.panel1.Controls.Add(this.txbHoTen);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbTen);
            this.panel1.Controls.Add(this.dtpkngaybatdau);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbViTri);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 165);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnSua);
            this.panel2.Controls.Add(this.btnThem);
            this.panel2.Location = new System.Drawing.Point(819, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(93, 164);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(918, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // fQLNS_QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1177, 734);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dtgvDSNV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fQLNS_QuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhân viên";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSNV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbCoSoLamViec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpkngaybatdau;
        private System.Windows.Forms.ComboBox cbViTri;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvDSNV;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbHo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DateTimePicker dtpkNgaySinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}