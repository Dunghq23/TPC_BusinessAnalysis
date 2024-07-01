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
using The_Pizza_Company.Management;

namespace The_Pizza_Company
{
    public partial class fHome_Management : Form
    {
        public fHome_Management()
        {
            InitializeComponent();
        }

        private void fHome_Management_Load(object sender, EventArgs e)
        {
            DateTime dT = DateTime.Now;
            lbDate.Text = dT.ToString("dd/MM/yyyy");

            lbHello.Text = lbHello.Text;
            
        }

        

        private void quảnLýNhânSựToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fQLNS_QuanLyNhanVien f = new fQLNS_QuanLyNhanVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void quảnLýChấmCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLNS_QuanLyChamCong f = new fQLNS_QuanLyChamCong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngKýTàiKhoảnChoNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fsignin f = new fsignin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQLTK_XemThongTinTK f = new fQLTK_XemThongTinTK();
            f.ShowDialog();
        }
    }
}
