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
    public partial class BanHangView : Form
    {
        QuanlybanhangController quanlybanhang;
        public BanHangView()
        {
            InitializeComponent();
            quanlybanhang = new QuanlybanhangController();
        }
        private static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["BanhangnhasachTienPhong"].ToString();
        private void btnLamMoiBH_Click(object sender, EventArgs e)
        {
            this.quanlybanhang.ResetValues(cbSDTKH, mtbTenKH, mtbDiaChi, cbMaDT, mtbDacDiemDT, mtbDonGia, nmudsoLuong, lTongtien, dtgvBanhang);
        }

        private void BanHang_Load(object sender, EventArgs e)
        {
            this.quanlybanhang.QuanLyBanHangLoad(cbSDTKH, cbMaDT);
            this.quanlybanhang.ResetValues(cbSDTKH, mtbTenKH, mtbDiaChi, cbMaDT, mtbDacDiemDT, mtbDonGia, nmudsoLuong, lTongtien, dtgvBanhang);
        }

        private void cbSDTKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSDTKH.SelectedValue.ToString() != "")
            {
                this.quanlybanhang.cbSDTKH_setValue(mtbTenKH, mtbDiaChi, cbSDTKH.SelectedValue.ToString());
            }
        }

        private void cbMaDT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbMaDT.SelectedValue.ToString()!="")
            {
                this.quanlybanhang.cbMaDT_setValue(mtbDacDiemDT, mtbDonGia, cbMaDT.SelectedValue.ToString());
            }    
        }

        private void btnThemBanHang_Click(object sender, EventArgs e)
        {
            this.quanlybanhang.btnThemBanHang_Click(dtgvBanhang, cbMaDT, nmudsoLuong, mtbDonGia,lTongtien);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            this.quanlybanhang.btnThanhToan_Click(dtgvBanhang, cbSDTKH);
        }

        private void BanHangView_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                TrangChuCuaHangView trangChuCuaHang = new TrangChuCuaHangView();
                this.Hide();
                trangChuCuaHang.ShowDialog();
                //this.Close();
            }
        }
    }
}
