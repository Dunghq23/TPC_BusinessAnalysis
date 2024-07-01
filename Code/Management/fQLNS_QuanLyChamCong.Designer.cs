namespace The_Pizza_Company.Management
{
    partial class fQLNS_QuanLyChamCong
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
            this.tcQuanLyChamCong = new System.Windows.Forms.TabControl();
            this.tgBangCaLamViec = new System.Windows.Forms.TabPage();
            this.tpPhanTichChamCong = new System.Windows.Forms.TabPage();
            this.tpChamCong = new System.Windows.Forms.TabPage();
            this.tpBaoCaoChamCong = new System.Windows.Forms.TabPage();
            this.tcQuanLyChamCong.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcQuanLyChamCong
            // 
            this.tcQuanLyChamCong.Controls.Add(this.tgBangCaLamViec);
            this.tcQuanLyChamCong.Controls.Add(this.tpPhanTichChamCong);
            this.tcQuanLyChamCong.Controls.Add(this.tpChamCong);
            this.tcQuanLyChamCong.Controls.Add(this.tpBaoCaoChamCong);
            this.tcQuanLyChamCong.Location = new System.Drawing.Point(13, 13);
            this.tcQuanLyChamCong.Name = "tcQuanLyChamCong";
            this.tcQuanLyChamCong.SelectedIndex = 0;
            this.tcQuanLyChamCong.Size = new System.Drawing.Size(833, 512);
            this.tcQuanLyChamCong.TabIndex = 0;
            // 
            // tgBangCaLamViec
            // 
            this.tgBangCaLamViec.Location = new System.Drawing.Point(4, 25);
            this.tgBangCaLamViec.Name = "tgBangCaLamViec";
            this.tgBangCaLamViec.Padding = new System.Windows.Forms.Padding(3);
            this.tgBangCaLamViec.Size = new System.Drawing.Size(825, 483);
            this.tgBangCaLamViec.TabIndex = 0;
            this.tgBangCaLamViec.Text = "Bảng ca làm việc";
            this.tgBangCaLamViec.UseVisualStyleBackColor = true;
            // 
            // tpPhanTichChamCong
            // 
            this.tpPhanTichChamCong.Location = new System.Drawing.Point(4, 25);
            this.tpPhanTichChamCong.Name = "tpPhanTichChamCong";
            this.tpPhanTichChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tpPhanTichChamCong.Size = new System.Drawing.Size(825, 483);
            this.tpPhanTichChamCong.TabIndex = 1;
            this.tpPhanTichChamCong.Text = "Phân tích chấm công";
            this.tpPhanTichChamCong.UseVisualStyleBackColor = true;
            // 
            // tpChamCong
            // 
            this.tpChamCong.Location = new System.Drawing.Point(4, 25);
            this.tpChamCong.Name = "tpChamCong";
            this.tpChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tpChamCong.Size = new System.Drawing.Size(825, 483);
            this.tpChamCong.TabIndex = 2;
            this.tpChamCong.Text = "Chấm công";
            this.tpChamCong.UseVisualStyleBackColor = true;
            // 
            // tpBaoCaoChamCong
            // 
            this.tpBaoCaoChamCong.Location = new System.Drawing.Point(4, 25);
            this.tpBaoCaoChamCong.Name = "tpBaoCaoChamCong";
            this.tpBaoCaoChamCong.Padding = new System.Windows.Forms.Padding(3);
            this.tpBaoCaoChamCong.Size = new System.Drawing.Size(825, 483);
            this.tpBaoCaoChamCong.TabIndex = 3;
            this.tpBaoCaoChamCong.Text = "Báo cáo chấm công";
            this.tpBaoCaoChamCong.UseVisualStyleBackColor = true;
            // 
            // fQLNS_QuanLyChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 537);
            this.Controls.Add(this.tcQuanLyChamCong);
            this.Name = "fQLNS_QuanLyChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chấm công";
            this.tcQuanLyChamCong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcQuanLyChamCong;
        private System.Windows.Forms.TabPage tgBangCaLamViec;
        private System.Windows.Forms.TabPage tpPhanTichChamCong;
        private System.Windows.Forms.TabPage tpChamCong;
        private System.Windows.Forms.TabPage tpBaoCaoChamCong;
    }
}