using bookstore_management_app.Controller;
using bookstore_management_app.Util;
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bookstore_management_app
{
    public partial class LoginView : Form
    {

        AuthenController authenController;
        public LoginView()
        {
            InitializeComponent();
            authenController = new AuthenController(); 
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            string username = textUsername.Text;
            string password = textPassword.Text;
            int status = 0;
            if (!validateAccount(username, password))
            {
                return;
            }
            bool isCheckAccount = authenController.login(username, password);
            status = Authorize.Instance.Status;


            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Test Performance dang nhap: " + elapsedTime);

            if (isCheckAccount && status == (int) ACCOUNT_STATUS.ACTIVATE)
            {
                Form home = new TrangChuCuaHangView();
                this.Hide();
                home.ShowDialog();
                this.Close();   
            }
            else if (status == (int)ACCOUNT_STATUS.DEACTIVATE)
            {
                MessageBox.Show("Tài khoản của bạn đã bị khóa, vui lòng liên hệ quản trị viên nếu có sai sót", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '\u25CF';
        }

        private bool validateAccount(string username, string password)
        {
            Regex validateGuidRegex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,20}$");
            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (username.Length < 6)
            {
                MessageBox.Show("Tên đăng nhập phải có ít nhất 6 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!validateGuidRegex.IsMatch(password))
            {
                MessageBox.Show("Mật khẩu phải thỏa mãn có ít nhất 8 kí tự, nhiều nhất 20 kí tự và ít nhất 1 kí tự viết hoa, 1 kí tự viết thường, 1 kí tự đặc biệt, 1 kí tự số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }
    }
}
