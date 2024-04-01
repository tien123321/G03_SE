
namespace bookstore_management_app.View
{
    partial class ThongkehoadonbanView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongkehoadonbanView));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbThang = new System.Windows.Forms.ComboBox();
            this.cbNam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbTang = new System.Windows.Forms.RadioButton();
            this.rbMin = new System.Windows.Forms.RadioButton();
            this.rbGiam = new System.Windows.Forms.RadioButton();
            this.cbLoaiSX = new System.Windows.Forms.ComboBox();
            this.rbĐT = new System.Windows.Forms.RadioButton();
            this.rbNV = new System.Windows.Forms.RadioButton();
            this.rbKH = new System.Windows.Forms.RadioButton();
            this.btnHien = new System.Windows.Forms.Button();
            this.gbTheo = new System.Windows.Forms.GroupBox();
            this.crvDT = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox2.SuspendLayout();
            this.gbTheo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Năm";
            // 
            // cbThang
            // 
            this.cbThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbThang.FormattingEnabled = true;
            this.cbThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbThang.Location = new System.Drawing.Point(143, 91);
            this.cbThang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbThang.Name = "cbThang";
            this.cbThang.Size = new System.Drawing.Size(180, 28);
            this.cbThang.TabIndex = 15;
            // 
            // cbNam
            // 
            this.cbNam.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbNam.FormattingEnabled = true;
            this.cbNam.Location = new System.Drawing.Point(143, 51);
            this.cbNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbNam.Name = "cbNam";
            this.cbNam.Size = new System.Drawing.Size(180, 28);
            this.cbNam.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Loại";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rbMax);
            this.groupBox2.Controls.Add(this.rbTang);
            this.groupBox2.Controls.Add(this.rbMin);
            this.groupBox2.Controls.Add(this.rbGiam);
            this.groupBox2.Controls.Add(this.cbLoaiSX);
            this.groupBox2.Location = new System.Drawing.Point(342, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(260, 155);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sắp xếp";
            // 
            // rbMax
            // 
            this.rbMax.AutoSize = true;
            this.rbMax.Enabled = false;
            this.rbMax.Location = new System.Drawing.Point(24, 114);
            this.rbMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(99, 24);
            this.rbMax.TabIndex = 6;
            this.rbMax.TabStop = true;
            this.rbMax.Text = "Cao nhất";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbTang
            // 
            this.rbTang.AutoSize = true;
            this.rbTang.Enabled = false;
            this.rbTang.Location = new System.Drawing.Point(24, 72);
            this.rbTang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbTang.Name = "rbTang";
            this.rbTang.Size = new System.Drawing.Size(101, 24);
            this.rbTang.TabIndex = 4;
            this.rbTang.Text = "Tăng dần";
            this.rbTang.UseVisualStyleBackColor = true;
            // 
            // rbMin
            // 
            this.rbMin.AutoSize = true;
            this.rbMin.Enabled = false;
            this.rbMin.Location = new System.Drawing.Point(135, 114);
            this.rbMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbMin.Name = "rbMin";
            this.rbMin.Size = new System.Drawing.Size(106, 24);
            this.rbMin.TabIndex = 7;
            this.rbMin.TabStop = true;
            this.rbMin.Text = "Thấp nhất";
            this.rbMin.UseVisualStyleBackColor = true;
            // 
            // rbGiam
            // 
            this.rbGiam.AutoSize = true;
            this.rbGiam.Enabled = false;
            this.rbGiam.Location = new System.Drawing.Point(135, 71);
            this.rbGiam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbGiam.Name = "rbGiam";
            this.rbGiam.Size = new System.Drawing.Size(103, 24);
            this.rbGiam.TabIndex = 5;
            this.rbGiam.Text = "Giảm dần";
            this.rbGiam.UseVisualStyleBackColor = true;
            // 
            // cbLoaiSX
            // 
            this.cbLoaiSX.FormattingEnabled = true;
            this.cbLoaiSX.Items.AddRange(new object[] {
            "Số lượng",
            "Doanh thu"});
            this.cbLoaiSX.Location = new System.Drawing.Point(56, 25);
            this.cbLoaiSX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbLoaiSX.Name = "cbLoaiSX";
            this.cbLoaiSX.Size = new System.Drawing.Size(196, 28);
            this.cbLoaiSX.TabIndex = 3;
            // 
            // rbĐT
            // 
            this.rbĐT.AutoSize = true;
            this.rbĐT.Location = new System.Drawing.Point(24, 103);
            this.rbĐT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbĐT.Name = "rbĐT";
            this.rbĐT.Size = new System.Drawing.Size(106, 24);
            this.rbĐT.TabIndex = 10;
            this.rbĐT.TabStop = true;
            this.rbĐT.Text = "Điện thoại";
            this.rbĐT.UseVisualStyleBackColor = true;
            // 
            // rbNV
            // 
            this.rbNV.AutoSize = true;
            this.rbNV.Location = new System.Drawing.Point(24, 32);
            this.rbNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNV.Name = "rbNV";
            this.rbNV.Size = new System.Drawing.Size(104, 24);
            this.rbNV.TabIndex = 8;
            this.rbNV.TabStop = true;
            this.rbNV.Text = "Nhân viên";
            this.rbNV.UseVisualStyleBackColor = true;
            // 
            // rbKH
            // 
            this.rbKH.AutoSize = true;
            this.rbKH.Location = new System.Drawing.Point(24, 69);
            this.rbKH.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbKH.Name = "rbKH";
            this.rbKH.Size = new System.Drawing.Size(119, 24);
            this.rbKH.TabIndex = 9;
            this.rbKH.TabStop = true;
            this.rbKH.Text = "Khách hàng";
            this.rbKH.UseVisualStyleBackColor = true;
            // 
            // btnHien
            // 
            this.btnHien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHien.BackgroundImage")));
            this.btnHien.FlatAppearance.BorderSize = 0;
            this.btnHien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHien.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHien.Location = new System.Drawing.Point(803, 70);
            this.btnHien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHien.Name = "btnHien";
            this.btnHien.Size = new System.Drawing.Size(112, 35);
            this.btnHien.TabIndex = 18;
            this.btnHien.Text = "Hiện";
            this.btnHien.UseVisualStyleBackColor = true;
            // 
            // gbTheo
            // 
            this.gbTheo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbTheo.Controls.Add(this.rbĐT);
            this.gbTheo.Controls.Add(this.rbNV);
            this.gbTheo.Controls.Add(this.rbKH);
            this.gbTheo.Enabled = false;
            this.gbTheo.Location = new System.Drawing.Point(612, 10);
            this.gbTheo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTheo.Name = "gbTheo";
            this.gbTheo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbTheo.Size = new System.Drawing.Size(183, 155);
            this.gbTheo.TabIndex = 13;
            this.gbTheo.TabStop = false;
            this.gbTheo.Text = "Theo";
            // 
            // crvDT
            // 
            this.crvDT.ActiveViewIndex = -1;
            this.crvDT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvDT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvDT.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvDT.Location = new System.Drawing.Point(13, 175);
            this.crvDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.crvDT.Name = "crvDT";
            this.crvDT.Size = new System.Drawing.Size(1006, 361);
            this.crvDT.TabIndex = 20;
            this.crvDT.ToolPanelWidth = 300;
            // 
            // ThongkehoadonbanView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 550);
            this.Controls.Add(this.crvDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbThang);
            this.Controls.Add(this.cbNam);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnHien);
            this.Controls.Add(this.gbTheo);
            this.Name = "ThongkehoadonbanView";
            this.Text = "ThongkehoadonbanView";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbTheo.ResumeLayout(false);
            this.gbTheo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbThang;
        private System.Windows.Forms.ComboBox cbNam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbTang;
        private System.Windows.Forms.RadioButton rbMin;
        private System.Windows.Forms.RadioButton rbGiam;
        private System.Windows.Forms.ComboBox cbLoaiSX;
        private System.Windows.Forms.RadioButton rbĐT;
        private System.Windows.Forms.RadioButton rbNV;
        private System.Windows.Forms.RadioButton rbKH;
        private System.Windows.Forms.Button btnHien;
        private System.Windows.Forms.GroupBox gbTheo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvDT;
    }
}