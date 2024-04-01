using bookstore_management_app.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookstore_management_app.Controller
{
    class QuanlybanhangController
    {
        private QuanlybanhangModel quanlybanhang;
        public QuanlybanhangController()
        { this.quanlybanhang = new QuanlybanhangModel(); }
        public void QuanLyBanHangLoad(ComboBox cbSDTKH, ComboBox cbMaDT)
        {
            this.quanlybanhang.QuanLy_BanHang_Load(cbSDTKH, cbMaDT);
        }
        public void ResetValues(ComboBox cbSDTKH,MaskedTextBox mtbTenKH,MaskedTextBox mtbDiaChi,ComboBox cbMaDT,MaskedTextBox mtbDacDiemDT,MaskedTextBox mtbDonGia,NumericUpDown nmudsoLuong, Label lTongtien , DataGridView dtgvBanhang)
        {
            cbSDTKH.Text = "";
            mtbTenKH.Text = "";
            mtbDiaChi.Text = "";
            cbMaDT.Text = "";
            mtbDacDiemDT.Text = "";
            mtbDonGia.Text = "";
            nmudsoLuong.Value = 1;
            dtgvBanhang.DataSource = null;
            dtgvBanhang.Rows.Clear();
            lTongtien.Text = "0đ";


        }
        public void cbSDTKH_setValue(MaskedTextBox mtbTenKH, MaskedTextBox mtbDiaChi,String Value)
        {
            this.quanlybanhang.cbSDTKH_setValue(mtbTenKH, mtbDiaChi,Value );
        }
        public void cbMaDT_setValue(MaskedTextBox mtbDacDiemDT, MaskedTextBox mtbDonGia, String Value)
        {
            this.quanlybanhang.cbMaDT_setValue(mtbDacDiemDT, mtbDonGia, Value );
        }
        public void btnThemBanHang_Click(DataGridView dtgvBanhang, ComboBox cbMaDT, NumericUpDown nmudsoLuong, MaskedTextBox mtbDonGia, Label lTongtien)
        {
            if (dtgvBanhang.Rows.Count != 1)
            {
                for (int rows = 0; rows < dtgvBanhang.Rows.Count - 1; rows++)
                {
                    if (dtgvBanhang.Rows[rows].Cells[0].Value.ToString().Equals(cbMaDT.SelectedValue.ToString()))
                    {
                        int sl = int.Parse(dtgvBanhang.Rows[rows].Cells[2].Value.ToString());
                        sl = sl + int.Parse(nmudsoLuong.Value.ToString());
                        dtgvBanhang.Rows[rows].Cells[2].Value = sl.ToString();

                        double price = double.Parse(dtgvBanhang.Rows[rows].Cells[3].Value.ToString());
                        dtgvBanhang.Rows[rows].Cells[4].Value = (price * sl).ToString();
                        return;
                    }
                }
            }
            double thanhtien = int.Parse(nmudsoLuong.Value.ToString()) * int.Parse(mtbDonGia.Text);
            String[] row = new string[] { cbMaDT.SelectedValue.ToString(), cbMaDT.Text, nmudsoLuong.Value.ToString(), mtbDonGia.Text, thanhtien.ToString() };
            dtgvBanhang.Rows.Add(row);
            double tongtien = 0;
            if (dtgvBanhang.Rows.Count != 1)
            {
                for (int rows = 0; rows < dtgvBanhang.Rows.Count - 1; rows++)
                {
                    tongtien += int.Parse(dtgvBanhang.Rows[rows].Cells[4].Value.ToString());
                }
            }
            lTongtien.Text = tongtien.ToString();
        }
        public void btnThanhToan_Click(DataGridView dtgvBanhang, ComboBox cbSDTKH)
        {
            this.quanlybanhang.btnThanhToan_Click(dtgvBanhang,cbSDTKH);
        }
    }
}
