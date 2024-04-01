using bookstore_management_app.Util;
using bookstore_management_app.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore_management_app.Controller
{
    public partial class TrangChuCuaHangView : Form
    {
        public TrangChuCuaHangView()
        {
            InitializeComponent();
        }

        private void ItemChangePassword_Click(object sender, EventArgs e)
        {
            /*List<string> Roles = new List<string>() { "ADMIN" };
            if (!Authorize.Instance.isCheckRole(Roles))
            {
                MessageBox.Show("Bạn không có quyền truy cập, vui lòng liên hệ quản trị viên để cấp quyền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }*/
            Form home = new changePasswordView();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void đăngXuấtItem_Click(object sender, EventArgs e)
        {
            Authorize.Instance.clearSession();
            Form home = new LoginView();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form home = new QuanLyCuaHangView();
            this.Hide();
            home.ShowDialog();
            this.Close();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // Form home = new BanHangView();
           // this.Hide();
           // home.ShowDialog();
           // this.Close();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ThongkehoadonView thongkehoadon = new ThongkehoadonView();
           // this.Hide();
           //thongkehoadon.ShowDialog();
           // this.Close();
        }
    }
}
