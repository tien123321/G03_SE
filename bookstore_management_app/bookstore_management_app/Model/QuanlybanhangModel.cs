using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bookstore_management_app.Model
{
    class QuanlybanhangModel
    {
        private static string constr = System.Configuration.ConfigurationManager.ConnectionStrings["BanhangnhasachTienPhong"].ToString();
        public void QuanLy_BanHang_Load(System.Windows.Forms.ComboBox cbSDTKH, System.Windows.Forms.ComboBox cbMaDT)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {

                using (SqlCommand cmd = new SqlCommand("select * from tblKhachhang", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbSDTKH.DisplayMember = "sSDTKH";
                        cbSDTKH.ValueMember = "PK_iKhachhang";
                        dt.Rows.Add();
                        cbSDTKH.DataSource = dt;
                    }

                }

                using (SqlCommand cmd = new SqlCommand("select * from tblSach", cnn))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        cbMaDT.DisplayMember = "sTensach";
                        cbMaDT.ValueMember = "PK_iSach";
                        dt.Rows.Add();
                        cbMaDT.DataSource = dt;
                    }

                }

            }
        }
        public void cbSDTKH_setValue(MaskedTextBox mtbTenKH, MaskedTextBox mtbDiaChi,String Value)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblKhachhang where PK_iKhachhang = '" + Value + "'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tblKhachhang"))
                        {
                            ad.Fill(dt);
                            DataView v = new DataView(dt);
                            mtbTenKH.Text = (string) v[0]["sTenkhachhang"];
                            mtbDiaChi.Text = (string) v[0]["sDiachi"];

                        }
                    }
                }

            }
        }
        public void cbMaDT_setValue(MaskedTextBox mtbDacDiemDT, MaskedTextBox mtbDonGia, String Value)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblSach where PK_iSach = '" + Value + "'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable("tblSach"))
                        {
                            ad.Fill(dt);
                            DataView v = new DataView(dt);
                            mtbDacDiemDT.Text =(string)v[0]["sTentacgia"];
                            mtbDonGia.Text = v[0]["iDongia"].ToString();

                        }
                    }
                }

            }
        }
        public void btnThanhToan_Click(DataGridView dtgvBanhang, System.Windows.Forms.ComboBox cbSDTKH)
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                DateTime now = (DateTime.Now);
                string format = "yyyy-MM-dd";
                string sql = "insert into tblHoadonban (dNgaylap,FK_iNhanvien,FK_iKhachhang) values ('"+now.ToString(format)+"',"+1+","+ cbSDTKH.SelectedValue.ToString()+")";
                SqlCommand cmd = new SqlCommand(sql, cnn);
                cmd.ExecuteNonQuery();
                using (SqlCommand cmd_iHoadonban = new SqlCommand("Select TOP 1 PK_iMahoadonban from tblHoadonban Order by PK_iMahoadonban DESC", cnn))
                {
                    cmd_iHoadonban.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd_iHoadonban))
                    {
                        using (DataTable dt = new DataTable("tblHoadonban"))
                        {
                            ad.Fill(dt);
                            DataView v = new DataView(dt);
                            int idHoadonban = (int)v[0]["PK_iMahoadonban"];
                            if (dtgvBanhang.Rows.Count != 1)
                            {
                                for (int rows = 0; rows < dtgvBanhang.Rows.Count - 1; rows++)
                                {
                                    string sql_ctHoaDon = "insert into tblChitietHDB (FK_iSach,FK_iMahoadonban,iSoluongban) values ('" + dtgvBanhang.Rows[rows].Cells[0].Value.ToString() + "'," + idHoadonban.ToString() + "," + dtgvBanhang.Rows[rows].Cells[2].Value.ToString() + ")";
                                    SqlCommand cmd_ctHoaDon = new SqlCommand(sql_ctHoaDon, cnn);
                                    cmd_ctHoaDon.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    MessageBox.Show("Lưu hoá đơn thành công");
                }
                cnn.Close();
            }
        }
    }
}
