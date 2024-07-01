using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Khai báo thêm
using The_Pizza_Company.DAO;

namespace The_Pizza_Company
{
    public partial class fsignin : Form
    {
        public fsignin()
        {
            InitializeComponent();
        }


        private void fsignin_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool checkAccount (string ac)
        {
            // Ký tự từ a-z, A-Z, 0-9 và từ 6-24 ký tự
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{5-24}$");
        }
        public bool checkEmail (string em)
        {
            // Biểu thức chính quy: ^...$
            // \w: a-z, A-Z, 0-9, _...
            return Regex.IsMatch(em, @"^[\w]{3,20}@gmail.com(.vn)$");
        }

        public bool checkStaffID(string StID)
        {
            // Biểu thức chính quy: ^...$
            // \w: a-z, A-Z, 0-9, _...
            return Regex.IsMatch(StID, @"^[0-9]}$");
        }

        Modify modify = new Modify();


        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPosition.Text == "CASHIER")
            {

            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string firstName = txbFirstName.Text;
            string lastName = txbLastName.Text;
            int staffID;
            string WorkPlace = cbWorkPlace.Text;
            string position = cbPosition.Text;

            string usName = txbUserName.Text;
            string psWord = txbPassword.Text;
            string rePsWord = txbRePassword.Text;
            
            if (txbStaffCode.Text != "")
            {
                staffID = int.Parse(txbStaffCode.Text);
                if (modify.Accounts($"SELECT * FROM ACCOUNT WHERE StaffID = '{staffID}'").Count != 0) {
                    MessageBox.Show("Mã nhân viên đã được đăng ký"); 
                    return; 
                }
                try
                {
                    string query = "INSERT INTO ACCOUNT (firstName, lastName, staffID, Position, WorkPlace, UserName, psWord) VALUES " +
                                 $"(N'{firstName}', N'{lastName}', {staffID}, '{position}', N'{WorkPlace}', N'{usName}', N'{psWord}')";
                    ExQuery exq = new ExQuery();
                    exq.insertData(query);
                } 
                catch
                {
                    MessageBox.Show("Tên tài khoản đã được đăng ký, vui lòng đăng nhập hoặc liên hệ quản lý để được cấp lại mật khẩu");
                    return;
                }
                if (rePsWord != psWord) { MessageBox.Show("Mật khẩu nhập lại không đúng!"); return; }

            }
            else
            {
                if (rePsWord != psWord) { MessageBox.Show("Mật khẩu nhập lại không đúng!"); return; }
                try
                {
                    string query = "INSERT INTO ACCOUNT (firstName, lastName, position, WorkPlace, UserName, psWord) VALUES " +
                                  $"(N'{firstName}', N'{lastName}', '{position}', N'{WorkPlace}', N'{usName}', N'{psWord}')";
                    ExQuery exq = new ExQuery();
                    exq.insertData(query);
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản đã được đăng ký, vui lòng đăng nhập hoặc liên hệ quản lý để được cấp lại mật khẩu");
                    return;
                }
                if (rePsWord != psWord) { MessageBox.Show("Mật khẩu nhập lại không đúng!"); return; }
            }






            MessageBox.Show("Đăng ký tài khoản thành công!");
            this.Close();
        }

        
    }
}

