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
using bookstore_management_app.Model;
using System.Diagnostics;

namespace bookstore_management_app.Controller
{

    class QuanlysachController
    {
        private QuanlysachModel  quanlysach;
        public QuanlysachController()
        {
            this.quanlysach = new QuanlysachModel();
        }

        public void ThemSachController(string mtbTenDT, string mtbRom, string mtbGiaFrom, string soluong, string cBHangSX, string comboBox3, DataGridView dataGridView1)
        {
            this.quanlysach.btnThemDT_Click(mtbTenDT,mtbRom, mtbGiaFrom, soluong,cBHangSX,comboBox3,dataGridView1);
        }

        public void SuaSach(string mtbTenDT, string mtbRom, string mtbGiaFrom, string soluong, string cBHangSX, string comboBox3, DataGridView dataGridView1)
        {
            this.quanlysach.btnSuaDT_Click(mtbTenDT,mtbRom,mtbGiaFrom,soluong, cBHangSX, comboBox3, dataGridView1);
        }

        public void XoaSach(string mtbRom, DataGridView dataGridView1)
        {
            this.quanlysach.btnXoaDT_Click(mtbRom,dataGridView1);
        }

        public void TimKiemSach(string mtbTenDT, string mtbRom, string mtbGiaFrom, string soluong, string cBHangSX, string comboBox3, DataGridView dataGridView1)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            this.quanlysach.btnTimKiemDT_Click(mtbTenDT,mtbRom,mtbGiaFrom,soluong, cBHangSX, comboBox3, dataGridView1);

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            Console.WriteLine("Test Performance search book: " + elapsedTime);
        }

        public void QuanLyLoad(ComboBox cBHangSX, ComboBox comboBox3, DataGridView dataGridView1)
        {
            this.quanlysach.QuanLy_Load(cBHangSX,comboBox3,dataGridView1);
        }

        public void hienSach(DataGridView dataGridView1)
        {
            this.quanlysach.hienSach(dataGridView1);
        }

        public bool checktensach(string tenSach)
        {
            return this.quanlysach.checktensach(tenSach);
        }
    }
}
