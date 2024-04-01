using bookstore_management_app.Controller;
using bookstore_management_app.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore_management_app.View
{
    public partial class changePasswordView : Form
    {
        private AuthenController authenController;
        public changePasswordView()
        {
            InitializeComponent();
            this.authenController = new AuthenController();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string oldPassword = txtOldPassword.Text;
            string newPassword = txtNewPassword.Text;
            string reNewPassword = txtReNewPassword.Text;

            if (!validatePassword(oldPassword, newPassword, reNewPassword))
            {
                return;
            }
            bool rowsAffected = authenController.changePassword(oldPassword, newPassword);
            if (!rowsAffected)
            {
                MessageBox.Show("có lỗi xảy ra khi đổi mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Authorize.Instance.clearSession();
            Form home = new LoginView();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private bool validatePassword(string oldPassword, string newPassword, string reNewPassword)
        {
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$");

            if (oldPassword == string.Empty || newPassword == string.Empty || reNewPassword == string.Empty)
            {
                MessageBox.Show("Thiếu thông tin bắt buộc", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (reNewPassword != newPassword)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            if (!validateGuidRegex.IsMatch(oldPassword) || !validateGuidRegex.IsMatch(newPassword) || !validateGuidRegex.IsMatch(reNewPassword))
            {
                MessageBox.Show("Mật khẩu phải thỏa mãn có ít nhất 8 kí tự, nhiêu nhất 20 kí tự và ít nhất 1 kí tự viết hoa, 1 kí tự viết thường, 1 kí tự đặc biệt, 1 kí tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void txtOldPassword_TextChanged(object sender, EventArgs e)
        {
            txtOldPassword.PasswordChar = '\u25CF';
        }

        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '\u25CF';
        }

        private void txtReNewPassword_TextChanged(object sender, EventArgs e)
        {
            txtReNewPassword.PasswordChar = '\u25CF';
        }

        private void changePasswordView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                TrangChuCuaHangView trangChuCuaHang = new TrangChuCuaHangView();
                this.Hide();
                trangChuCuaHang.ShowDialog();
                //this.Close();
            }
        }
    }
}
