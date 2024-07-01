using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Pizza_Company.DAO;

namespace The_Pizza_Company
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void rbMemoriesPassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        Modify modify = new Modify();

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usName = txbUserName.Text;
            string psWord = txbPassWord.Text;
            if (usName.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); txbUserName.Focus(); }
            else if (psWord.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); txbPassWord.Focus(); }
            else
            {
                string query = $"SELECT * FROM ACCOUNT " +
                               $"WHERE UserName = '{usName}' AND PsWord = '{psWord}'";

                string query_position = $"SELECT position FROM ACCOUNT " +
                                  $"WHERE UserName = '{usName}' AND PsWord = '{psWord}'";

                

                if (modify.Accounts(query).Count != 0)
                {
                    GetDATA g = new GetDATA();
                    string position = g.getStringData(query_position);
                    if (position == "PARTTIME 1" || position == "PARTTIME 2" || position == "PARTTIME 3" ||
                        position == "FULLTIME 1" || position == "FULLTIME 2" || position == "FULLTIME 3")
                    {
                        fHome_Staff f = new fHome_Staff();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (position == "CASHIER")
                    {

                    }
                    else if (position == "RIDER")
                    {

                    }
                    else
                    {
                        fHome_Management f = new fHome_Management();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }


        }

        private void lblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void pnLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPassWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
