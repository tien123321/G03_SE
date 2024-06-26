USE [QLBH_G08]
GO
/****** Object:  Table [dbo].[tblNhaxuatban]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhaxuatban](
	[PK_iNhaxuatban] [int] IDENTITY(1,1) NOT NULL,
	[sTennhaxuatban] [nvarchar](255) NULL,
	[sDiachi] [nvarchar](255) NULL,
	[sSDT] [varchar](15) NULL,
 CONSTRAINT [PrimaryKeyNhaxuatban] PRIMARY KEY CLUSTERED 
(
	[PK_iNhaxuatban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaisach]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaisach](
	[PK_iLoaisach] [int] IDENTITY(1,1) NOT NULL,
	[sTenloaisach] [nvarchar](100) NULL,
 CONSTRAINT [PrimaryKeyLoaisach] PRIMARY KEY CLUSTERED 
(
	[PK_iLoaisach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSach]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSach](
	[PK_iSach] [int] IDENTITY(1,1) NOT NULL,
	[sTensach] [nvarchar](100) NULL,
	[sTentacgia] [nvarchar](100) NULL,
	[iDongia] [int] NULL,
	[iSoluong] [int] NULL,
	[FK_iNhaxuatban] [int] NULL,
	[FK_iLoaisach] [int] NULL,
 CONSTRAINT [PrimaryKeySach] PRIMARY KEY CLUSTERED 
(
	[PK_iSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[tblSach_NhaXB]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[tblSach_NhaXB] as
select PK_iSach,sTensach,sTentacgia,sTenloaisach,sTennhaxuatban,iDongia,iSoluong from tblSach 
inner join tblLoaisach on tblLoaisach.PK_iLoaisach=tblSach.FK_iLoaisach
inner join tblNhaxuatban on tblNhaxuatban.PK_iNhaxuatban= tblSach.FK_iNhaxuatban
GO
/****** Object:  Table [dbo].[tblChitietHDB]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitietHDB](
	[FK_iSach] [int] NOT NULL,
	[FK_iMahoadonban] [int] NOT NULL,
	[iSoluongban] [int] NULL,
 CONSTRAINT [PrimaryKeyChitietHDB] PRIMARY KEY CLUSTERED 
(
	[FK_iSach] ASC,
	[FK_iMahoadonban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChitietPMH]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitietPMH](
	[FK_iSach] [int] NOT NULL,
	[FK_iMaphieumua] [int] NOT NULL,
	[iSoluongnhap] [int] NULL,
	[fGianhap] [float] NULL,
 CONSTRAINT [PrimaryKeyChitietPMH] PRIMARY KEY CLUSTERED 
(
	[FK_iSach] ASC,
	[FK_iMaphieumua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChitietPXK]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitietPXK](
	[FK_iSach] [int] NOT NULL,
	[FK_iMaphieuxuat] [int] NOT NULL,
	[iSoluong] [int] NULL,
 CONSTRAINT [PrimaryKeyChitietPXK] PRIMARY KEY CLUSTERED 
(
	[FK_iSach] ASC,
	[FK_iMaphieuxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblChitietPYC]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblChitietPYC](
	[FK_iSach] [int] NOT NULL,
	[FK_iMayeucaunhap] [int] NOT NULL,
	[iSoluongyeucau] [int] NULL,
 CONSTRAINT [PrimaryKeyChitietPYC] PRIMARY KEY CLUSTERED 
(
	[FK_iSach] ASC,
	[FK_iMayeucaunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblHoadonban]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblHoadonban](
	[PK_iMahoadonban] [int] IDENTITY(1,1) NOT NULL,
	[dNgaylap] [date] NULL,
	[FK_iNhanvien] [int] NULL,
	[FK_iKhachhang] [int] NULL,
 CONSTRAINT [PrimaryKeyHoadonban] PRIMARY KEY CLUSTERED 
(
	[PK_iMahoadonban] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblKhachhang]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblKhachhang](
	[PK_iKhachhang] [int] IDENTITY(1,1) NOT NULL,
	[sTenkhachhang] [nvarchar](50) NULL,
	[sDiachi] [nvarchar](100) NULL,
	[sSDTKH] [varchar](10) NULL,
 CONSTRAINT [PrimaryKeyKhachhang] PRIMARY KEY CLUSTERED 
(
	[PK_iKhachhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblLoaitaikhoan]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblLoaitaikhoan](
	[PK_iLoaitaikhoan] [int] IDENTITY(1,1) NOT NULL,
	[sTenloaitaikhoan] [varchar](100) NULL,
 CONSTRAINT [PrimaryKeyLoaitaikhoan] PRIMARY KEY CLUSTERED 
(
	[PK_iLoaitaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblNhanvien]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblNhanvien](
	[PK_iNhanvien] [int] IDENTITY(1,1) NOT NULL,
	[sTennhanvien] [nvarchar](70) NULL,
	[dNgaysinh] [date] NULL,
	[bGioitinh] [bit] NULL,
	[sQuequan] [nvarchar](255) NULL,
	[dNgayvaolam] [date] NULL,
	[sSDT] [varchar](10) NULL,
	[bTrangthai] [bit] NULL,
	[fLuong] [float] NULL,
 CONSTRAINT [PrimaryKeyNhanvien] PRIMARY KEY CLUSTERED 
(
	[PK_iNhanvien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieudoitra]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieudoitra](
	[PK_iMaphieu] [int] IDENTITY(1,1) NOT NULL,
	[dNgaylap] [date] NULL,
	[FK_iNhanvien] [int] NULL,
	[FK_iMahoadonban] [int] NULL,
 CONSTRAINT [PrimaryKeyPhieudoitra] PRIMARY KEY CLUSTERED 
(
	[PK_iMaphieu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieumuahang]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieumuahang](
	[PK_iMaphieumua] [int] IDENTITY(1,1) NOT NULL,
	[FK_iMayeucaunhap] [int] NULL,
	[FK_iNhanvien] [int] NULL,
	[dNgaylap] [date] NULL,
 CONSTRAINT [PrimaryKeyPhieumuahang] PRIMARY KEY CLUSTERED 
(
	[PK_iMaphieumua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuxuatkho]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuxuatkho](
	[PK_iMaphieuxuat] [int] IDENTITY(1,1) NOT NULL,
	[dNgaylap] [date] NULL,
	[FK_iNhanvien] [int] NULL,
 CONSTRAINT [PrimaryKeyPhieuxuatkho] PRIMARY KEY CLUSTERED 
(
	[PK_iMaphieuxuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblPhieuyeucau]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhieuyeucau](
	[PK_iMayeucaunhap] [int] IDENTITY(1,1) NOT NULL,
	[dNgaylap] [date] NULL,
	[FK_iNhanVien] [int] NULL,
 CONSTRAINT [PrimaryKeyPhieuyeucau] PRIMARY KEY CLUSTERED 
(
	[PK_iMayeucaunhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblTaikhoan]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblTaikhoan](
	[PK_iTaikhoan] [int] IDENTITY(1,1) NOT NULL,
	[sTendangnhap] [nvarchar](50) NULL,
	[FK_iNhanvien] [int] NULL,
	[FK_iLoaitaikhoan] [int] NULL,
	[sMatkhau] [varchar](50) NULL,
	[bTrangthai] [bit] NULL,
 CONSTRAINT [PrimaryKeyTaikhoan] PRIMARY KEY CLUSTERED 
(
	[PK_iTaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblChitietHDB] ([FK_iSach], [FK_iMahoadonban], [iSoluongban]) VALUES (2, 1, 1)
INSERT [dbo].[tblChitietHDB] ([FK_iSach], [FK_iMahoadonban], [iSoluongban]) VALUES (3, 2, 2)
INSERT [dbo].[tblChitietHDB] ([FK_iSach], [FK_iMahoadonban], [iSoluongban]) VALUES (4, 1, 1)
INSERT [dbo].[tblChitietHDB] ([FK_iSach], [FK_iMahoadonban], [iSoluongban]) VALUES (5, 2, 1)
GO
SET IDENTITY_INSERT [dbo].[tblHoadonban] ON 

INSERT [dbo].[tblHoadonban] ([PK_iMahoadonban], [dNgaylap], [FK_iNhanvien], [FK_iKhachhang]) VALUES (1, CAST(N'2023-03-21' AS Date), 1, 1)
INSERT [dbo].[tblHoadonban] ([PK_iMahoadonban], [dNgaylap], [FK_iNhanvien], [FK_iKhachhang]) VALUES (2, CAST(N'2023-03-21' AS Date), 1, 4)
SET IDENTITY_INSERT [dbo].[tblHoadonban] OFF
GO
SET IDENTITY_INSERT [dbo].[tblKhachhang] ON 

INSERT [dbo].[tblKhachhang] ([PK_iKhachhang], [sTenkhachhang], [sDiachi], [sSDTKH]) VALUES (1, N'Nguyễn Hữu Trí', N'Định Công, Hà Nội', N'0977913099')
INSERT [dbo].[tblKhachhang] ([PK_iKhachhang], [sTenkhachhang], [sDiachi], [sSDTKH]) VALUES (2, N'Phạm Hữu Mai', N'Hai Bà Trưng, Hà Nội', N'0977613099')
INSERT [dbo].[tblKhachhang] ([PK_iKhachhang], [sTenkhachhang], [sDiachi], [sSDTKH]) VALUES (3, N'Nguyễn Ngọc Ngạn', N'Ba Đình, Hà Nội', N'0979613099')
INSERT [dbo].[tblKhachhang] ([PK_iKhachhang], [sTenkhachhang], [sDiachi], [sSDTKH]) VALUES (4, N'Phạm Quang Thái', N'Ba Đình, Hà Nội', N'0972613099')
INSERT [dbo].[tblKhachhang] ([PK_iKhachhang], [sTenkhachhang], [sDiachi], [sSDTKH]) VALUES (5, N'Nguyễn Thị Đào', N'Thanh Xuân, Hà Nội', N'0973613099')
SET IDENTITY_INSERT [dbo].[tblKhachhang] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLoaisach] ON 

INSERT [dbo].[tblLoaisach] ([PK_iLoaisach], [sTenloaisach]) VALUES (1, N'Phát triển bản thân')
INSERT [dbo].[tblLoaisach] ([PK_iLoaisach], [sTenloaisach]) VALUES (2, N'Kinh Tế')
INSERT [dbo].[tblLoaisach] ([PK_iLoaisach], [sTenloaisach]) VALUES (3, N'Văn học việt nam')
INSERT [dbo].[tblLoaisach] ([PK_iLoaisach], [sTenloaisach]) VALUES (4, N'Văn học nước ngoài')
INSERT [dbo].[tblLoaisach] ([PK_iLoaisach], [sTenloaisach]) VALUES (5, N'Tâm lý')
SET IDENTITY_INSERT [dbo].[tblLoaisach] OFF
GO
SET IDENTITY_INSERT [dbo].[tblLoaitaikhoan] ON 

INSERT [dbo].[tblLoaitaikhoan] ([PK_iLoaitaikhoan], [sTenloaitaikhoan]) VALUES (1, N'ADMIN')
INSERT [dbo].[tblLoaitaikhoan] ([PK_iLoaitaikhoan], [sTenloaitaikhoan]) VALUES (2, N'MANAGER')
INSERT [dbo].[tblLoaitaikhoan] ([PK_iLoaitaikhoan], [sTenloaitaikhoan]) VALUES (3, N'WAREHOUSE_WORKER')
INSERT [dbo].[tblLoaitaikhoan] ([PK_iLoaitaikhoan], [sTenloaitaikhoan]) VALUES (4, N'SALESPERSON')
SET IDENTITY_INSERT [dbo].[tblLoaitaikhoan] OFF
GO
SET IDENTITY_INSERT [dbo].[tblNhanvien] ON 

INSERT [dbo].[tblNhanvien] ([PK_iNhanvien], [sTennhanvien], [dNgaysinh], [bGioitinh], [sQuequan], [dNgayvaolam], [sSDT], [bTrangthai], [fLuong]) VALUES (1, N'dinh huy khanh', CAST(N'2001-06-28' AS Date), 1, NULL, CAST(N'2020-01-01' AS Date), N'0977644111', 1, 5000000)
INSERT [dbo].[tblNhanvien] ([PK_iNhanvien], [sTennhanvien], [dNgaysinh], [bGioitinh], [sQuequan], [dNgayvaolam], [sSDT], [bTrangthai], [fLuong]) VALUES (2, N'Le Quang Minh', CAST(N'2001-06-01' AS Date), 1, NULL, CAST(N'2020-01-01' AS Date), N'0977644112', 1, 5000000)
INSERT [dbo].[tblNhanvien] ([PK_iNhanvien], [sTennhanvien], [dNgaysinh], [bGioitinh], [sQuequan], [dNgayvaolam], [sSDT], [bTrangthai], [fLuong]) VALUES (3, N'Bui Thi Yen', CAST(N'2001-06-02' AS Date), 0, NULL, CAST(N'2020-01-01' AS Date), N'0977644113', 1, 5000000)
INSERT [dbo].[tblNhanvien] ([PK_iNhanvien], [sTennhanvien], [dNgaysinh], [bGioitinh], [sQuequan], [dNgayvaolam], [sSDT], [bTrangthai], [fLuong]) VALUES (4, N'Nguyen thi Le', CAST(N'2001-06-03' AS Date), 0, NULL, CAST(N'2020-01-01' AS Date), N'0977644113', 1, 5000000)
SET IDENTITY_INSERT [dbo].[tblNhanvien] OFF
GO
SET IDENTITY_INSERT [dbo].[tblNhaxuatban] ON 

INSERT [dbo].[tblNhaxuatban] ([PK_iNhaxuatban], [sTennhaxuatban], [sDiachi], [sSDT]) VALUES (1, N'Thanh Nien', N'HaNoi', NULL)
INSERT [dbo].[tblNhaxuatban] ([PK_iNhaxuatban], [sTennhaxuatban], [sDiachi], [sSDT]) VALUES (2, N'Tien Phong', N'Ha Noi', NULL)
INSERT [dbo].[tblNhaxuatban] ([PK_iNhaxuatban], [sTennhaxuatban], [sDiachi], [sSDT]) VALUES (3, N'Sai Gon', N'Sai Gon', NULL)
SET IDENTITY_INSERT [dbo].[tblNhaxuatban] OFF
GO
SET IDENTITY_INSERT [dbo].[tblSach] ON 

INSERT [dbo].[tblSach] ([PK_iSach], [sTensach], [sTentacgia], [iDongia], [iSoluong], [FK_iNhaxuatban], [FK_iLoaisach]) VALUES (1, N'Chien Thang Con Quy Trong Ban', N'napoleon hill', 113000, 50, 1, 1)
INSERT [dbo].[tblSach] ([PK_iSach], [sTensach], [sTentacgia], [iDongia], [iSoluong], [FK_iNhaxuatban], [FK_iLoaisach]) VALUES (2, N'Tuổi Trẻ đáng giá bao nhiêu', N'Rosie Nguyễn', 65000, 50, 1, 1)
INSERT [dbo].[tblSach] ([PK_iSach], [sTensach], [sTentacgia], [iDongia], [iSoluong], [FK_iNhaxuatban], [FK_iLoaisach]) VALUES (3, N'Thiên Tài bên trái kẻ điên bên phải', N'Cao Minh', 115000, 50, 2, 5)
INSERT [dbo].[tblSach] ([PK_iSach], [sTensach], [sTentacgia], [iDongia], [iSoluong], [FK_iNhaxuatban], [FK_iLoaisach]) VALUES (4, N'Sổ tay nhà thôi miên tập 1', N'Cao Minh', 115000, 50, 2, 5)
INSERT [dbo].[tblSach] ([PK_iSach], [sTensach], [sTentacgia], [iDongia], [iSoluong], [FK_iNhaxuatban], [FK_iLoaisach]) VALUES (5, N'Sổ tay nhà thôi miên tập 2', N'Cao Minh', 115000, 50, 2, 5)
SET IDENTITY_INSERT [dbo].[tblSach] OFF
GO
SET IDENTITY_INSERT [dbo].[tblTaikhoan] ON 

INSERT [dbo].[tblTaikhoan] ([PK_iTaikhoan], [sTendangnhap], [FK_iNhanvien], [FK_iLoaitaikhoan], [sMatkhau], [bTrangthai]) VALUES (3, N'khanhdinh141', 1, 1, N'123456aA@', 1)
INSERT [dbo].[tblTaikhoan] ([PK_iTaikhoan], [sTendangnhap], [FK_iNhanvien], [FK_iLoaitaikhoan], [sMatkhau], [bTrangthai]) VALUES (4, N'lequangminh', 2, 2, N'123456aA@', 1)
INSERT [dbo].[tblTaikhoan] ([PK_iTaikhoan], [sTendangnhap], [FK_iNhanvien], [FK_iLoaitaikhoan], [sMatkhau], [bTrangthai]) VALUES (5, N'buiyen123', 3, 3, N'123456aA@', 1)
INSERT [dbo].[tblTaikhoan] ([PK_iTaikhoan], [sTendangnhap], [FK_iNhanvien], [FK_iLoaitaikhoan], [sMatkhau], [bTrangthai]) VALUES (6, N'nguyenle123', 4, 4, N'123456aA@', 1)
SET IDENTITY_INSERT [dbo].[tblTaikhoan] OFF
GO
ALTER TABLE [dbo].[tblTaikhoan] ADD  CONSTRAINT [df_Status]  DEFAULT ((1)) FOR [bTrangthai]
GO
ALTER TABLE [dbo].[tblChitietHDB]  WITH CHECK ADD  CONSTRAINT [FK_ChitietHDB_Hoadonban] FOREIGN KEY([FK_iMahoadonban])
REFERENCES [dbo].[tblHoadonban] ([PK_iMahoadonban])
GO
ALTER TABLE [dbo].[tblChitietHDB] CHECK CONSTRAINT [FK_ChitietHDB_Hoadonban]
GO
ALTER TABLE [dbo].[tblChitietHDB]  WITH CHECK ADD  CONSTRAINT [FK_ChitietHDB_Sach] FOREIGN KEY([FK_iSach])
REFERENCES [dbo].[tblSach] ([PK_iSach])
GO
ALTER TABLE [dbo].[tblChitietHDB] CHECK CONSTRAINT [FK_ChitietHDB_Sach]
GO
ALTER TABLE [dbo].[tblChitietPMH]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPMH_Phieumuahang] FOREIGN KEY([FK_iMaphieumua])
REFERENCES [dbo].[tblPhieumuahang] ([PK_iMaphieumua])
GO
ALTER TABLE [dbo].[tblChitietPMH] CHECK CONSTRAINT [FK_ChitietPMH_Phieumuahang]
GO
ALTER TABLE [dbo].[tblChitietPMH]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPMH_Sach] FOREIGN KEY([FK_iSach])
REFERENCES [dbo].[tblSach] ([PK_iSach])
GO
ALTER TABLE [dbo].[tblChitietPMH] CHECK CONSTRAINT [FK_ChitietPMH_Sach]
GO
ALTER TABLE [dbo].[tblChitietPXK]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPXK_Phieuxuatkho] FOREIGN KEY([FK_iMaphieuxuat])
REFERENCES [dbo].[tblPhieuxuatkho] ([PK_iMaphieuxuat])
GO
ALTER TABLE [dbo].[tblChitietPXK] CHECK CONSTRAINT [FK_ChitietPXK_Phieuxuatkho]
GO
ALTER TABLE [dbo].[tblChitietPXK]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPXK_Sach] FOREIGN KEY([FK_iSach])
REFERENCES [dbo].[tblSach] ([PK_iSach])
GO
ALTER TABLE [dbo].[tblChitietPXK] CHECK CONSTRAINT [FK_ChitietPXK_Sach]
GO
ALTER TABLE [dbo].[tblChitietPYC]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPYC_Phieuyeucau] FOREIGN KEY([FK_iMayeucaunhap])
REFERENCES [dbo].[tblPhieuyeucau] ([PK_iMayeucaunhap])
GO
ALTER TABLE [dbo].[tblChitietPYC] CHECK CONSTRAINT [FK_ChitietPYC_Phieuyeucau]
GO
ALTER TABLE [dbo].[tblChitietPYC]  WITH CHECK ADD  CONSTRAINT [FK_ChitietPYC_Sach] FOREIGN KEY([FK_iSach])
REFERENCES [dbo].[tblSach] ([PK_iSach])
GO
ALTER TABLE [dbo].[tblChitietPYC] CHECK CONSTRAINT [FK_ChitietPYC_Sach]
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_Hoadonban_Khachhang] FOREIGN KEY([FK_iKhachhang])
REFERENCES [dbo].[tblKhachhang] ([PK_iKhachhang])
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_Hoadonban_Khachhang]
GO
ALTER TABLE [dbo].[tblHoadonban]  WITH CHECK ADD  CONSTRAINT [FK_Hoadonban_Nhanvien] FOREIGN KEY([FK_iNhanvien])
REFERENCES [dbo].[tblNhanvien] ([PK_iNhanvien])
GO
ALTER TABLE [dbo].[tblHoadonban] CHECK CONSTRAINT [FK_Hoadonban_Nhanvien]
GO
ALTER TABLE [dbo].[tblPhieudoitra]  WITH CHECK ADD  CONSTRAINT [FK_Phieudoitra_Hoadonban] FOREIGN KEY([FK_iMahoadonban])
REFERENCES [dbo].[tblHoadonban] ([PK_iMahoadonban])
GO
ALTER TABLE [dbo].[tblPhieudoitra] CHECK CONSTRAINT [FK_Phieudoitra_Hoadonban]
GO
ALTER TABLE [dbo].[tblPhieudoitra]  WITH CHECK ADD  CONSTRAINT [FK_Phieudoitra_Nhanvien] FOREIGN KEY([FK_iNhanvien])
REFERENCES [dbo].[tblNhanvien] ([PK_iNhanvien])
GO
ALTER TABLE [dbo].[tblPhieudoitra] CHECK CONSTRAINT [FK_Phieudoitra_Nhanvien]
GO
ALTER TABLE [dbo].[tblPhieumuahang]  WITH CHECK ADD  CONSTRAINT [FK_Phieumuahang_Nhanvien] FOREIGN KEY([FK_iNhanvien])
REFERENCES [dbo].[tblNhanvien] ([PK_iNhanvien])
GO
ALTER TABLE [dbo].[tblPhieumuahang] CHECK CONSTRAINT [FK_Phieumuahang_Nhanvien]
GO
ALTER TABLE [dbo].[tblPhieumuahang]  WITH CHECK ADD  CONSTRAINT [FK_Phieumuahang_Phieuyeucau] FOREIGN KEY([FK_iMayeucaunhap])
REFERENCES [dbo].[tblPhieuyeucau] ([PK_iMayeucaunhap])
GO
ALTER TABLE [dbo].[tblPhieumuahang] CHECK CONSTRAINT [FK_Phieumuahang_Phieuyeucau]
GO
ALTER TABLE [dbo].[tblPhieuxuatkho]  WITH CHECK ADD  CONSTRAINT [FK_Phieuxuatkho_Nhanvien] FOREIGN KEY([FK_iNhanvien])
REFERENCES [dbo].[tblNhanvien] ([PK_iNhanvien])
GO
ALTER TABLE [dbo].[tblPhieuxuatkho] CHECK CONSTRAINT [FK_Phieuxuatkho_Nhanvien]
GO
ALTER TABLE [dbo].[tblPhieuyeucau]  WITH CHECK ADD  CONSTRAINT [FK_Phieuyeucau_Nhanvien] FOREIGN KEY([FK_iNhanVien])
REFERENCES [dbo].[tblNhanvien] ([PK_iNhanvien])
GO
ALTER TABLE [dbo].[tblPhieuyeucau] CHECK CONSTRAINT [FK_Phieuyeucau_Nhanvien]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_Loaisach] FOREIGN KEY([FK_iLoaisach])
REFERENCES [dbo].[tblLoaisach] ([PK_iLoaisach])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_Sach_Loaisach]
GO
ALTER TABLE [dbo].[tblSach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_Nhaxuatban] FOREIGN KEY([FK_iNhaxuatban])
REFERENCES [dbo].[tblNhaxuatban] ([PK_iNhaxuatban])
GO
ALTER TABLE [dbo].[tblSach] CHECK CONSTRAINT [FK_Sach_Nhaxuatban]
GO
ALTER TABLE [dbo].[tblTaikhoan]  WITH CHECK ADD  CONSTRAINT [FK_Taikhoan_Loaitaikhoan] FOREIGN KEY([FK_iLoaitaikhoan])
REFERENCES [dbo].[tblLoaitaikhoan] ([PK_iLoaitaikhoan])
GO
ALTER TABLE [dbo].[tblTaikhoan] CHECK CONSTRAINT [FK_Taikhoan_Loaitaikhoan]
GO
ALTER TABLE [dbo].[tblTaikhoan]  WITH CHECK ADD  CONSTRAINT [FK_Taikhoan_Nhanvien] FOREIGN KEY([FK_iNhanvien])
REFERENCES [dbo].[tblNhanvien] ([PK_iNhanvien])
GO
ALTER TABLE [dbo].[tblTaikhoan] CHECK CONSTRAINT [FK_Taikhoan_Nhanvien]
GO
/****** Object:  StoredProcedure [dbo].[prChangePassword]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[prChangePassword]( @username VARCHAR(256), @oldPassword VARCHAR(256),  @newPassword VARCHAR(256))
AS
	BEGIN
		UPDATE tblTaiKhoan
		SET sMatkhau = @newPassword
		WHERE sTendangnhap = @username AND sMatkhau = @oldPassword;
	END
GO
/****** Object:  StoredProcedure [dbo].[prGetAccount]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[prGetAccount]( @username VARCHAR(256), @password VARCHAR(256) )
AS
	BEGIN
		SELECT tk.sTendangnhap, ltk.sTenloaitaikhoan, tk.bTrangthai, tk.FK_iNhanvien
		FROM tblTaikhoan tk 
		JOIN tblLoaitaikhoan ltk ON ltk.PK_iLoaitaikhoan = tk.FK_iLoaitaikhoan
		JOIN tblNhanvien nv ON nv.PK_iNhanvien = tk.FK_iNhanvien 
		WHERE sTendangnhap = @username AND sMatkhau = @password;
	END
GO
/****** Object:  StoredProcedure [dbo].[sp_get_nhanvien]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_nhanvien]
AS
SELECT * FROM tblNhanvien
GO;
GO
/****** Object:  StoredProcedure [dbo].[sp_get_taikhoan]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_get_taikhoan]
AS
SELECT * FROM tblTaikhoan
GO;
GO
/****** Object:  StoredProcedure [dbo].[sp_insert_taikhoan]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_insert_taikhoan](
	@Tendangnhap nvarchar(50),
	@Manhanvien int,
	@Maloaitaikhoan int,
	@Matkhau varchar(50),
	@Trangthai bit
)
AS
begin
	begin
		INSERT INTO tblTaikhoan(sTendangnhap,FK_iNhanvien,FK_iLoaitaikhoan, sMatkhau, bTrangthai)
		VALUES (@Tendangnhap, @Manhanvien, @Maloaitaikhoan, @Matkhau, @Trangthai)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_nhanvien]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_update_nhanvien](
	@iNhanvien int,
	@sTennhanvien nvarchar(70),
	@dNgaysinh date,
	@bGioitinh bit, 
	@sQuequan nvarchar(255), 
	@dNgayvaolam date, 
	@sSDT varchar(10), 
	@bTrangthai bit, 
	@fLuong float
)
AS
begin
	UPDATE tblNhanvien
	SET sTennhanvien = @sTennhanvien,
		dNgaysinh = @dNgaysinh,
		bGioitinh = @bGioitinh,
		sQuequan = @sQuequan,
		dNgayvaolam = @dNgayvaolam,
		sSDT = @sSDT,
		bTrangthai = @bTrangthai,
		fLuong = @fLuong
	WHERE PK_iNhanvien = @iNhanvien
end
GO
/****** Object:  StoredProcedure [dbo].[sp_update_taikhoan]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_update_taikhoan](
	@Mataikhoan int,
	@Tendangnhap nvarchar(50),
	@Manhanvien int,
	@Maloaitaikhoan int,
	@Matkhau varchar(50),
	@Trangthai bit
)
AS
begin
	UPDATE tblTaikhoan
	SET FK_iLoaitaikhoan = @Maloaitaikhoan,
		sTendangnhap = @Tendangnhap,
		sMatkhau = @Matkhau,
		bTrangthai = @Trangthai
	WHERE PK_iTaikhoan = @Mataikhoan and FK_iNhanvien = @Manhanvien
end
GO
/****** Object:  StoredProcedure [dbo].[Sua_Sach]    Script Date: 22/03/2023 00:03:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Sua_Sach]
@PK_iSach int,
@sTensach nvarchar(100),
@sTentacgia nvarchar(100),
@iDongia int,
@iSoluong int,
@FK_iNhaxuatban int,
@FK_iLoaisach int
as
begin
update tblSach set
sTensach = @sTensach,
sTentacgia = @sTentacgia,
iDongia = @iDongia,
iSoluong=@iSoluong,
FK_iNhaxuatban=@FK_iNhaxuatban,
FK_iLoaisach=@FK_iLoaisach
where PK_iSach = @PK_iSach
end;
GO
