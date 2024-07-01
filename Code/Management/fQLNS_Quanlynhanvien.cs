using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Pizza_Company.DAO;

namespace The_Pizza_Company.Management
{
    public partial class fQLNS_QuanLyNhanVien : Form
    {
        public fQLNS_QuanLyNhanVien()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void txbHo_TextChanged(object sender, EventArgs e)
        {
            txbHoTen.Clear();
            txbHoTen.Text += (txbHo.Text + " " + txbTen.Text);
        }

        private void txbTen_TextChanged(object sender, EventArgs e)
        {
            txbHoTen.Clear();
            txbHoTen.Text += (txbHo.Text + " " + txbTen.Text);
        }

        string ConvertDATE (DateTimePicker dt)
        {
            string day = dt.Value.Day.ToString();
            string thang = dt.Value.Month.ToString();
            string nam = dt.Value.Year.ToString();
            return nam + "/" + thang + "/" + day;
        }

        void clear()
        {
            txbMaNV.Clear();
            txbHo.Clear();
            txbTen.Clear();
            txbHoTen.Clear();
            cbCoSoLamViec.SelectedIndex = -1;
            cbViTri.SelectedIndex = -1;
        }

        ExQuery exq = new ExQuery();
        void LoadDataGridView()
        {
            
            string DSNV = "SELECT * FROM NHANVIEN";
            dtgvDSNV.DataSource = exq.ExcuteQuery(DSNV);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int MaNV = int.Parse(txbMaNV.Text);
            string Ho = txbHo.Text;
            string Ten = txbTen.Text;
            string HoTen = txbHoTen.Text;
            string ngaySinh = ConvertDATE(dtpkNgaySinh);
            string vitri = cbViTri.Text;
            string ngaylamviec = ConvertDATE(dtpkngaybatdau);
            string coSo = cbCoSoLamViec.Text;

            string query = $"INSERT INTO NHANVIEN VALUES ({MaNV}, N'{Ho}', N'{Ten}', N'{HoTen}', '{ngaySinh}', N'{vitri}', '{ngaylamviec}', N'{coSo}')";
            try
            {
                exq.insertData(query);
                clear();
                MessageBox.Show("Thêm nhân viên thành công!");
                LoadDataGridView();
            }
            catch
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                txbMaNV.Clear(); txbMaNV.Focus();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int MaNV = int.Parse(txbMaNV.Text);
            string Ho = txbHo.Text;
            string Ten = txbTen.Text;
            string HoTen = txbHoTen.Text;
            string ngaySinh = ConvertDATE(dtpkNgaySinh);
            string vitri = cbViTri.Text;
            string ngaylamviec = ConvertDATE(dtpkngaybatdau);
            string coSo = cbCoSoLamViec.Text;

            string query = $"UPDATE NHANVIEN SET " +
                           $"StaffID = {MaNV}, Firstname = N'{Ho}', LastName = N'{Ten}', Fullname = N'{HoTen}', " +
                           $"birthofdate = '{ngaySinh}', position = N'{vitri}', StartWorkDay = '{ngaylamviec}', WorkPlace = N'{coSo}' " +
                           $"WHERE StaffID = '{MaNV}'";
            exq.editData(query);
            clear();
            LoadDataGridView();
            MessageBox.Show("Sửa thông tin thành công!");
            
        }

        private void dtgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgvDSNV.CurrentCell.RowIndex;
            txbMaNV.Text = dtgvDSNV.Rows[index].Cells[0].Value.ToString();
            txbHo.Text = dtgvDSNV.Rows[index].Cells[1].Value.ToString();
            txbTen.Text = dtgvDSNV.Rows[index].Cells[2].Value.ToString();
            txbHoTen.Text = dtgvDSNV.Rows[index].Cells[3].Value.ToString();
            dtpkNgaySinh.Text = dtgvDSNV.Rows[index].Cells[4].Value.ToString();
            cbViTri.Text = dtgvDSNV.Rows[index].Cells[5].Value.ToString();
            dtpkngaybatdau.Text = dtgvDSNV.Rows[index].Cells[6].Value.ToString();
            cbCoSoLamViec.Text = dtgvDSNV.Rows[index].Cells[7].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int MaNV = int.Parse(txbMaNV.Text);
            string query = $"DELETE FROM NHANVIEN WHERE StaffID = {MaNV}";
            exq.deleteData(query);
            MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
            LoadDataGridView();
        }
    }
}
