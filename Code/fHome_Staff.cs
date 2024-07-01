using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Pizza_Company.Staff;

namespace The_Pizza_Company
{
    public partial class fHome_Staff : Form
    {
        public fHome_Staff()
        {
            InitializeComponent();
        }

        private void quảnLýBànToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyBan f = new fQuanLyBan();
            f.ShowDialog();
        }

        private void fHome_Staff_Load(object sender, EventArgs e)
        {

        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccount_Information f = new fAccount_Information();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void lịchLàmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fLichLam f = new fLichLam();
            this.Hide(); f.ShowDialog(); this.Show();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
