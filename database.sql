USE [master]
GO

CREATE DATABASE QlNhanSu
USE [QlNhanSu]
GO
/****** Object:  Table [BaoHiem]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [BaoHiem](
	[MaNhanVien] [varchar](5) NOT NULL,
	[LoaiBaoHiem] [nvarchar](50) NULL,
	[SoThe] [varchar](20) NULL,
	[NgayCap] [date] NULL,
	[NgayHetHan] [date] NULL,
	[NoiCap] [nvarchar](100) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [ChamCong]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ChamCong](
	[MaNhanVien] [varchar](5) NOT NULL,
	[Ngay] [date] NOT NULL,
	[TinhTrang] [nvarchar](20) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [ChucVu]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ChucVu](
	[MaCV] [varchar](5) NOT NULL,
	[TenCv] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [HopDong]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [HopDong](
	[MaHD] [varchar](5) NOT NULL,
	[NgayVaoLam] [date] NOT NULL,
	[HeSoLuong] [int] NOT NULL,
	[MaCV] [varchar](5) NOT NULL,
	[MaPB] [varchar](5) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Luong]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Luong](
	[HeSoLuong] [int] NOT NULL,
	[LuongCB] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HeSoLuong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [NhanVien]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [NhanVien](
	[MaNhanVien] [varchar](5) NOT NULL,
	[MaPB] [varchar](5) NOT NULL,
	[MaHD] [varchar](5) NULL,
	[HeSoLuong] [int] NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[SoCM] [varchar](20) NOT NULL,
	[DienThoai] [varchar](20) NOT NULL,
	[TrinhDoHV] [nvarchar](30) NOT NULL,
	[DiaChi] [nvarchar](max) NOT NULL,
	[Email] [varchar](50) NULL,
	[ngayvaolam] [date] NULL,
	[maCV] [varchar](5) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [PhongBan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [PhongBan](
	[MaPB] [varchar](5) NOT NULL,
	[TenPB] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Taikhoan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Taikhoan](
	[MaNhanVien] [varchar](5) NOT NULL,
	[TenDangNhap] [nvarchar](50) NOT NULL,
	[MatKhau] [nvarchar](50) NOT NULL,
	[TenQuyenHan] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ThuongPhat]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ThuongPhat](
	[MaNhanVien] [varchar](5) NOT NULL,
	[Loai] [nvarchar](50) NULL,
	[Tien] [int] NULL,
	[LyDo] [nvarchar](max) NULL,
	[Ngay] [date] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [BaoHiem] ([MaNhanVien], [LoaiBaoHiem], [SoThe], [NgayCap], [NgayHetHan], [NoiCap]) VALUES (N'NV01', N'Bảo Hiểm Y Tế', N'YT0003', CAST(N'2021-01-01' AS Date), CAST(N'2021-11-11' AS Date), N'HCM')
INSERT [BaoHiem] ([MaNhanVien], [LoaiBaoHiem], [SoThe], [NgayCap], [NgayHetHan], [NoiCap]) VALUES (N'NV02', N'Bảo Hiểm Y Tế', N'BH1234', CAST(N'2021-02-10' AS Date), CAST(N'2021-05-16' AS Date), N'TP.HCM')
INSERT [BaoHiem] ([MaNhanVien], [LoaiBaoHiem], [SoThe], [NgayCap], [NgayHetHan], [NoiCap]) VALUES (N'NV03', N'Bảo Hiểm Thân Thể', N'TT0004', CAST(N'2020-12-28' AS Date), CAST(N'2021-06-03' AS Date), N'HCM')
INSERT [BaoHiem] ([MaNhanVien], [LoaiBaoHiem], [SoThe], [NgayCap], [NgayHetHan], [NoiCap]) VALUES (N'NV04', N'Bảo Hiểm Thân Thể', N'BH01', CAST(N'2021-04-25' AS Date), CAST(N'2021-05-21' AS Date), N'ABC')
GO
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV01', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV02', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV03', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV04', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV05', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV06', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV07', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV08', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV09', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV10', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV11', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV12', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV13', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV14', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV15', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV16', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV17', CAST(N'2021-05-14' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV01', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV02', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV03', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV04', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV05', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV06', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV07', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV08', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV09', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV10', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV11', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV12', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV13', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV14', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV15', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV16', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV17', CAST(N'2021-05-16' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV01', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV02', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV03', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV04', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV05', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV06', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV07', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV08', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV09', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV10', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV11', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV12', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV13', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV14', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV15', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV16', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV17', CAST(N'2021-05-18' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV01', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV02', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV03', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV04', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV05', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV06', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV07', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV08', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV09', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV10', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV11', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV12', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV13', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV14', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV15', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV16', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV17', CAST(N'2021-05-20' AS Date), NULL)
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV01', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV02', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV03', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV04', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV05', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV06', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV07', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV08', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV09', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV10', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV11', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV12', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV13', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV14', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV15', CAST(N'2021-05-21' AS Date), N'Nghỉ Không Phép')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV16', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV17', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV18', CAST(N'2021-05-21' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV01', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV02', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV03', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV04', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV05', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV06', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV07', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV08', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV09', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV10', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV11', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV12', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV13', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV14', CAST(N'2021-05-13' AS Date), N'Đi Làm')
GO
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV15', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV16', CAST(N'2021-05-13' AS Date), N'Đi Làm')
INSERT [ChamCong] ([MaNhanVien], [Ngay], [TinhTrang]) VALUES (N'NV17', CAST(N'2021-05-13' AS Date), N'Đi Làm')
GO
INSERT [ChucVu] ([MaCV], [TenCv]) VALUES (N'CV01', N'Giám Đốc')
INSERT [ChucVu] ([MaCV], [TenCv]) VALUES (N'CV02', N'Phó Giám Đốc')
INSERT [ChucVu] ([MaCV], [TenCv]) VALUES (N'CV03', N'Trưởng Phòng')
INSERT [ChucVu] ([MaCV], [TenCv]) VALUES (N'CV04', N'Phó Phòng')
INSERT [ChucVu] ([MaCV], [TenCv]) VALUES (N'CV05', N'Nhân Viên')
INSERT [ChucVu] ([MaCV], [TenCv]) VALUES (N'CV06', N'Kỹ thuật')
GO
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD01', CAST(N'2014-01-25' AS Date), 10, N'CV01', N'PB01')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD02', CAST(N'2014-01-25' AS Date), 9, N'CV02', N'PB02')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD03', CAST(N'2014-01-25' AS Date), 8, N'CV03', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD04', CAST(N'2014-01-25' AS Date), 8, N'CV03', N'PB04')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD05', CAST(N'2014-01-25' AS Date), 8, N'CV03', N'PB05')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD06', CAST(N'2014-01-25' AS Date), 7, N'CV04', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD07', CAST(N'2014-01-25' AS Date), 7, N'CV04', N'PB04')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD08', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD09', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD10', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD11', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD12', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD13', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB03')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD14', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB04')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD15', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB04')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD16', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB05')
INSERT [HopDong] ([MaHD], [NgayVaoLam], [HeSoLuong], [MaCV], [MaPB]) VALUES (N'HD17', CAST(N'2014-01-25' AS Date), 6, N'CV05', N'PB05')
GO
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (1, 3500001)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (2, 3700000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (3, 100000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (4, 4000000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (5, 4500000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (6, 5000000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (7, 7000000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (8, 10000000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (9, 12000000)
INSERT [Luong] ([HeSoLuong], [LuongCB]) VALUES (10, 16000000)
GO
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV01', N'PB04', N'HD01', 10, N'Nguyễn Thị Lệ Thu', N'Nữ', CAST(N'2021-05-20' AS Date), N'8888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', CAST(N'2021-05-20' AS Date), N'CV01')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV02', N'PB02', N'HD02', 9, N'Nguyễn Quốc Tuấn', N'Nam', CAST(N'2021-05-05' AS Date), N'123456', N'1638345699', N'Đại Học', N'An Hiệp, Quỳnh Phụ, Thái Bình', N'phamthanhluan9c@gmail.com', CAST(N'2021-05-05' AS Date), N'CV02')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV03', N'PB01', N'HD03', 8, N'Trương Minh Sang', N'Nam', CAST(N'2021-05-06' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', CAST(N'2021-05-06' AS Date), N'CV03')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV04', N'PB04', N'HD04', 8, N'Nguyễn Thị Lệ Thu', N'Nữ', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV03')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV05', N'PB05', N'HD05', 8, N'Trần Minh Siêu', N'Nam', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV03')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV06', N'PB03', N'HD06', 7, N'Trần Ngọc Tuyết', N'Nữ', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV04')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV07', N'PB05', N'HD07', 7, N'Nguyễn Hữu Minh', N'Nam', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV04')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV08', N'PB03', N'HD08', 6, N'Huỳnh Thị Yến Lê', N'Nữ', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV09', N'PB03', N'HD09', 6, N'Nguyễn Thị Kim Thoa', N'Nữ', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV10', N'PB03', N'HD10', 6, N'Nguyễn Thị Bích Hằng', N'Nữ', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV11', N'PB03', N'HD11', 6, N'Hồ Mạnh Tiến', N'Nam', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV12', N'PB03', N'HD12', 6, N'Nguyễn Tăng Quốc', N'Nam', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV13', N'PB04', N'HD13', 6, N'Lê Thị Tịnh', N'Nữ', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV14', N'PB04', N'HD14', 6, N'Bùi Thị Sương', N'Nữ', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV15', N'PB05', N'HD15', 6, N'Bùi Văn Long', N'Nam', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV16', N'PB05', N'HD16', 6, N'Đỗ Hữu Tiến', N'Nam', CAST(N'1985-09-02' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', NULL, N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV17', N'PB01', N'HD17', 6, N'Phạm Văn MạnhB', N'Nam', CAST(N'2021-05-16' AS Date), N'88888888', N'1638345699', N'Đại Học', N'Biên Hòa, Đồng nai', N'phamthanhluan9c@gmail.com', CAST(N'2021-05-16' AS Date), N'CV05')
INSERT [NhanVien] ([MaNhanVien], [MaPB], [MaHD], [HeSoLuong], [TenNV], [GioiTinh], [NgaySinh], [SoCM], [DienThoai], [TrinhDoHV], [DiaChi], [Email], [ngayvaolam], [maCV]) VALUES (N'NV18', N'PB01', NULL, 3, N'Nguyễn Đăng Trình', N'Nam', CAST(N'2021-05-21' AS Date), N'0.21355445', N'0131513515', N'Đại học', N'Thiên đàng', N'dangtrinh.nguyen2001@gmail.com', CAST(N'2021-05-21' AS Date), N'CV05')
GO
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'PB01', N'Phòng Giám Đốc')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'PB02', N'Phòng Phó Giám Đốc')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'PB03', N'Phòng Kinh Doanh 1')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'PB04', N'Phòng Kế Toán')
INSERT [PhongBan] ([MaPB], [TenPB]) VALUES (N'PB05', N'Phòng Kỹ Thuật')
GO
INSERT [Taikhoan] ([MaNhanVien], [TenDangNhap], [MatKhau], [TenQuyenHan]) VALUES (N'NV01', N'admin', N'admin', N'Super Admin')
INSERT [Taikhoan] ([MaNhanVien], [TenDangNhap], [MatKhau], [TenQuyenHan]) VALUES (N'NV02', N'admin1', N'admin', N'Admin')
INSERT [Taikhoan] ([MaNhanVien], [TenDangNhap], [MatKhau], [TenQuyenHan]) VALUES (N'NV10', N'user', N'123456', N'User')
GO
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV03', N'Phạt', 100000, N'Đến muộn', CAST(N'2020-06-28' AS Date))
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV01', N'Thưởng', 10000, N'OT', CAST(N'2020-06-28' AS Date))
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV08', N'Phạt', 100015, N'fsgdc', CAST(N'2020-06-28' AS Date))
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV01', N'Thưởng', 10000, N'ABC', CAST(N'2021-05-14' AS Date))
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV08', N'Thưởng', 1000, N'ABC', CAST(N'2020-12-31' AS Date))
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV08', N'Phạt', 1000, N'ABCDEF', CAST(N'2021-05-14' AS Date))
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV01', N'Phạt', 100000, N'Ăn vụng', CAST(N'2021-05-16' AS Date))
INSERT [ThuongPhat] ([MaNhanVien], [Loai], [Tien], [LyDo], [Ngay]) VALUES (N'NV01', N'Phạt', 100000, N'Không hoàn thành nhiệm vụ tháng', CAST(N'2021-05-20' AS Date))
GO
ALTER TABLE [BaoHiem]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [NhanVien] ([MaNhanVien])
GO
ALTER TABLE [ChamCong]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [NhanVien] ([MaNhanVien])
GO
ALTER TABLE [HopDong]  WITH CHECK ADD FOREIGN KEY([HeSoLuong])
REFERENCES [Luong] ([HeSoLuong])
GO
ALTER TABLE [HopDong]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [ChucVu] ([MaCV])
GO
ALTER TABLE [HopDong]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [PhongBan] ([MaPB])
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD FOREIGN KEY([HeSoLuong])
REFERENCES [Luong] ([HeSoLuong])
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [HopDong] ([MaHD])
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [PhongBan] ([MaPB])
GO
ALTER TABLE [NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_nhanvien_macv] FOREIGN KEY([maCV])
REFERENCES [ChucVu] ([MaCV])
GO
ALTER TABLE [NhanVien] CHECK CONSTRAINT [fk_nhanvien_macv]
GO
ALTER TABLE [Taikhoan]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [NhanVien] ([MaNhanVien])
GO
ALTER TABLE [ThuongPhat]  WITH CHECK ADD FOREIGN KEY([MaNhanVien])
REFERENCES [NhanVien] ([MaNhanVien])
GO
/****** Object:  StoredProcedure [CapNhatChucVu]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [CapNhatChucVu]
@macvold varchar(5),
@macvnew varchar(5),
@tencv nvarchar(50)
as
		update ChucVu set MaCV = @macvnew, TenCV = @tencv where MaCV = @macvold
GO
/****** Object:  StoredProcedure [CapNhatLuong]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [CapNhatLuong]
@hesoluong int,
@luongcb int
as
	Update Luong set LuongCB = @luongcb where HeSoLuong = @hesoluong

-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [CapNhatPhongBan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [CapNhatPhongBan]
@maphongold varchar(5),
@maphongnew varchar(5),
@tenphong nvarchar(20)
as
	update PhongBan set MaPB = @maphongnew, TenPB = @tenphong
	where MaPB = @maphongold
GO
/****** Object:  StoredProcedure [DangNhap]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [DangNhap]
@taikhoan nvarchar(50),
@matkhau nvarchar(50)
as
begin
select * from TaiKhoan where TenDangNhap = @taikhoan and MatKhau = @matkhau
end
GO
/****** Object:  StoredProcedure [DemSoNgayLam]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [DemSoNgayLam]
@manv varchar(5),
@ngaydau datetime,
@ngaycuoi datetime
as
	select MaNhanVien
	from ChamCong 
	where MaNhanVien = @manv and TinhTrang = N'Đi Làm' and (Ngay >= @ngaydau and Ngay <= @ngaycuoi)


-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [DoiMatKhau]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [DoiMatKhau]
@taikhoan nvarchar(50),
@matkhaumoi nvarchar(50)
as
	update TaiKhoan set  MatKhau = @matkhaumoi
	where TenDangNhap = @taikhoan
GO
/****** Object:  StoredProcedure [HienPhongBan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [HienPhongBan]
as
		select PhongBan.MaPB, TenPB, count(NhanVien.MaPB) as SoNV
		from PhongBan left join NhanVien on PhongBan.MaPB = NhanVien.MaPB
		GROUP BY PhongBan.MaPB, TenPB
GO
/****** Object:  StoredProcedure [LayBaoHiem]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [LayBaoHiem]
@ma varchar(5),
@loaibh nvarchar(50)
as
	if(@ma = '0')
	begin
		select NhanVien.MaNhanVien, TenNV, LoaiBaoHiem, NgayHetHan
		from NhanVien left join BaoHiem on NhanVien.MaNhanVien = BaoHiem.MaNhanVien
	end
	else
	begin
		select NhanVien.MaNhanVien, TenNV, LoaiBaoHiem, SoThe, NgayCap, NgayHetHan, NoiCap
		from NhanVien left join BaoHiem on NhanVien.MaNhanVien = BaoHiem.MaNhanVien
		where NhanVien.MaNhanVien = @ma and LoaiBaoHiem = @loaibh
	end
---------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [LayChamCong]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [LayChamCong]
@ngay date
as
begin
	select ChamCong.MaNhanVien, NhanVien.TenNV, TinhTrang 
	from ChamCong inner join NhanVien on ChamCong.MaNhanVien = NhanVien.MaNhanVien
	where Ngay = @ngay
end


-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [LayChucVu]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [LayChucVu]
as
		select MaCV, TenCv from ChucVu
GO
/****** Object:  StoredProcedure [LayChucVuTuMaNV]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [LayChucVuTuMaNV]
@manv varchar(5)
as
	select TenCV from (NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join ChucVu on HopDong.MaCV = ChucVu.MaCV
	where MaNhanVien = @manv
GO
/****** Object:  StoredProcedure [LayLuongCBTuHSL]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [LayLuongCBTuHSL]
@hsl int
as
	select LuongCB from Luong where HeSoLuong = @hsl

-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [layMaCVTuTenCV]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [layMaCVTuTenCV]
@tencv nvarchar(100)
as
	if(exists(select TenCV from ChucVu where TenCV = @tencv))
	begin
		select MaCV from ChucVu where TenCV = @tencv
	end
	else
		return 'a'
GO
/****** Object:  StoredProcedure [layMaNVTuTenNV]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [layMaNVTuTenNV]
as
begin
	select MaNhanVien,TenNV, '' as Loai, '' as Tien, '' as LyDo, getDate() as Ngay
	from NhanVien
end-----------------------------------------------------
GO
/****** Object:  StoredProcedure [layMaPBTuTenPB]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------Bảng Phòng Ban-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------

Create Proc [layMaPBTuTenPB]
@tenpb nvarchar(100)
as
	if(exists(select TenPB from PhongBan where TenPB = @tenpb))
	begin
		select MaPB from PhongBan where TenPB = @tenpb
	end
	else
		select err = 1

-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [LayNhanVienTuMaPB]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [LayNhanVienTuMaPB]--'0','12-1-2016', '12-30-2016'
@ngaydau date,
@ngaycuoi date
as
begin
	select NhanVien.MaNhanVien,TenNV, Loai, Tien, LyDo, Ngay
	from NhanVien left join ThuongPhat on NhanVien.MaNhanVien = ThuongPhat.MaNhanVien
	where (Ngay >= @ngaydau and Ngay <= @ngaycuoi) or Ngay is null
end---------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [LayThongTinNV]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [LayThongTinNV]
as
begin
	select MaNhanVien, TenNV, GioiTinh, C.TenCV 
	from NhanVien N, ChucVu C
	where C.MaCV = N.maCV
end
GO
/****** Object:  StoredProcedure [LayTienThuong]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [LayTienThuong]
@manv varchar(5),
@loai varchar(10),
@ngaydau datetime,
@ngaycuoi datetime
as
	if (@loai = 'T')
	begin
		select sum(Tien) as 'T' from ThuongPhat
		where MaNhanVien = @manv and Loai = N'Thưởng' and (Ngay >= @ngaydau and Ngay <= @ngaycuoi)
		group by MaNhanVien
	end
	
	else 
	begin
		select sum(Tien) as 'P' from ThuongPhat
		where MaNhanVien = @manv and Loai = N'Phạt' and (Ngay >= @ngaydau and Ngay <= @ngaycuoi)
		group by MaNhanVien
	end
GO
/****** Object:  StoredProcedure [NvCoTK]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [NvCoTK]
as
begin
	select NhanVien.MaNhanVien, TenNV, TenDangNhap, MatKhau, TenQuyenHan
	from NhanVien right join Taikhoan on NhanVien.MaNhanVien = Taikhoan.MaNhanVien
end
-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [NvCTaiKhoan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [NvCTaiKhoan]
as
begin
	select NhanVien.MaNhanVien, TenNV, ChucVu.TenCv 
	from ((NhanVien inner join HopDong on NhanVien.MaHD = HopDong.MaHD) inner join ChucVu on HopDong.MaCV = ChucVu.MaCV) 
		left join Taikhoan on NhanVien.MaNhanVien = Taikhoan.MaNhanVien
	where TenDangNhap is null
end
GO
/****** Object:  StoredProcedure [SuaBaoHiem]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [SuaBaoHiem]
@manv varchar(5),
@loaibhcu nvarchar(50),
@loaibhmoi nvarchar(50),
@sothe varchar(20),
@ngaycap date,
@ngayhethan date,
@noicap nvarchar(100)
as
	update BaoHiem set MaNhanVien = @manv, LoaiBaoHiem = @loaibhmoi, SoThe = @sothe, NgayCap = @ngaycap, NgayHetHan = @ngayhethan, NoiCap = @noicap
	where MaNhanVien = @manv and LoaiBaohiem = @loaibhcu

---------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [SuaNhanVien]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [SuaNhanVien]
@manv varchar(5),
@tennv nvarchar(50),
@mapb varchar(5),
@hesoluong int,
@gioitinh nvarchar(5),
@ngaysinh date,
@socm varchar(20),
@sodt varchar(20),
@trinhdo nvarchar(50),
@diachi nvarchar(100),
@email nvarchar(50),
@ngayvaolam date,
@macv varchar(5)

as
	update NhanVien
	set manhanvien = @manv,TenNV=  @tennv,MaPB =  @mapb,HeSoLuong =  @hesoluong,GioiTinh =  @gioitinh,NgaySinh =  @ngaysinh,SoCM = @socm,DienThoai =  @sodt,TrinhDoHV =  @trinhdo,DiaChi =  @diachi,Email = @email,ngayvaolam =  @ngayvaolam, macv = @macv
	where MaNhanVien = @manv
GO
/****** Object:  StoredProcedure [ThemBaoHiem]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [ThemBaoHiem]
@manv varchar(5),
@loaibh nvarchar(50),
@sothe varchar(20),
@ngaycap date,
@ngayhethan date,
@noicap nvarchar(100)
as
	insert into BaoHiem(MaNhanVien, LoaiBaoHiem, SoThe, NgayCap, NgayHetHan, NoiCap) values(@manv, @loaibh, @sothe, @ngaycap, @ngayhethan, @noicap)

---------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [ThemChamCong]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [ThemChamCong]
@manv varchar(5),
@ngay date,
@tinhtrang Nvarchar(20)
as
	update ChamCong
	set TinhTrang = @tinhtrang
	where MaNhanVien = @manv and Ngay = @ngay
	
GO
/****** Object:  StoredProcedure [ThemChamCong_MacDinh]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Proc [ThemChamCong_MacDinh]
@ngay date
as
	insert into ChamCong(MaNhanVien, Ngay) 
	select MaNhanVien,getDate() 
	from NhanVien
begin
	select ChamCong.MaNhanVien, NhanVien.TenNV, TinhTrang 
	from ChamCong inner join NhanVien on ChamCong.MaNhanVien = NhanVien.MaNhanVien
	where Ngay = @ngay
end
	
GO
/****** Object:  StoredProcedure [ThemChucVu]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [ThemChucVu]
@macv varchar(5),
@tencv nvarchar(50)
as
	insert into ChucVu(MaCV, TenCv) values(@macv, @tencv)

----------------------------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [ThemNhanVien]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [ThemNhanVien]
@manv varchar(5),
@tennv nvarchar(50),
@mapb varchar(5),
@hesoluong int,
@gioitinh nvarchar(5),
@ngaysinh date,
@socm varchar(20),
@sodt varchar(20),
@trinhdo nvarchar(50),
@diachi nvarchar(100),
@email nvarchar(50),
@ngayvaolam date,
@macv varchar(5)
as
	insert into NhanVien(MaNhanVien, TenNV, MaPB, HeSoLuong, GioiTinh, NgaySinh, SoCM, DienThoai, TrinhDoHV, DiaChi, Email, ngayvaolam, maCV)
	values (@manv, @tennv, @mapb, @hesoluong, @gioitinh, @ngaysinh, @socm, @sodt, @trinhdo, @diachi, @email,@ngayvaolam,@macv)
GO
/****** Object:  StoredProcedure [ThemPhongBan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [ThemPhongBan]
@maphong varchar(5),
@tenphong nvarchar(20)
as
	if(not exists(select MaPB from PhongBan where MaPB = @maphong))
	begin
		insert into PhongBan(MaPB, TenPB) values(@maphong, @tenphong)
	end
	else
		select err = 1


-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [ThemTaiKhoan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [ThemTaiKhoan]
@manv varchar(5),
@taikhoan nvarchar(50),
@matkhau nvarchar(50),
@tenquyenhan nvarchar(20)
as
if(not exists(select TenDangNhap from Taikhoan where TenDangNhap = @taikhoan))
begin
	insert into Taikhoan(MaNhanVien, TenDangNhap, MatKhau, TenQuyenHan)
			values(@manv, @taikhoan,@matkhau, @tenquyenhan)
end
GO
/****** Object:  StoredProcedure [ThemThuongPhat]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [ThemThuongPhat]
@manv varchar(5),
@loai nvarchar(100),
@tien int,
@lydo nvarchar(100),
@ngay date
as
	insert into ThuongPhat(MaNhanVien, Loai, Tien, LyDo, Ngay) values(@manv, @loai, @tien, @lydo, @ngay)

------------------------------------------------------------------------------------------------------------------------------------------------------
-----------------------------------------------------------ctChucVu-----------------------------------------------------------------------------
------------------------------------------------------------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [ThongTinNhanVien]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [ThongTinNhanVien]
@MaNhanVien nvarchar(5)
as
	select MaNhanVien, TenNV, P.TenPB, C.TenCV, GioiTinh, DiaChi, SoCM, DienThoai, TrinhDoHV, Email, HeSoLuong  
	from NhanVien N ,ChucVu C, PhongBan P
	where MaNhanVien = @MaNhanVien and N.maCV = C.MaCV and P.MaPB = N.MaPB
GO
/****** Object:  StoredProcedure [Thongtinnhanvien1]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [Thongtinnhanvien1]
as
begin
	select TenNV, Email
	from NhanVien 	
end
GO
/****** Object:  StoredProcedure [tkNhanVien]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [tkNhanVien]
@tukhoa nvarchar(100)
as
	select MaNhanVien, TenNV, GioiTinh, C.TenCV 
	from  NhanVien N, PhongBan P, ChucVu C
	where (TenNV like '%'+@tukhoa+'%' or SoCM like '%'+@tukhoa+'%' or DienThoai like '%'+@tukhoa+'%' or TrinhDoHV like '%'+@tukhoa+'%' or DiaChi like '%'+@tukhoa+'%' 
		or Email like '%'+@tukhoa+'%' or TenCv like '%'+@tukhoa+'%' or TenPB like '%'+@tukhoa+'%') and C.MaCV = N.maCV and N.MaPB = P.MaPB
GO
/****** Object:  StoredProcedure [TongLuongNV]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE proc [TongLuongNV]
@ma varchar(5)
as
if(@ma = '0')
begin
	select MaNhanVien, TenNV, NhanVien.HeSoLuong, '0' as NL, '0' as T, '0' as P, '0' as TL
	From NhanVien inner join Luong on NhanVien.HeSoLuong = Luong.HeSoLuong
end
else 
begin
	select LuongCB from NhanVien inner join Luong on NhanVien.HeSoLuong = Luong.HeSoLuong
	where MaNhanVien = @ma
end

-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [XoaBaoHiem]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [XoaBaoHiem]
@manv varchar(5),
@loaibh nvarchar(50)
as
	delete BaoHiem where MaNhanVien = @manv and LoaiBaohiem = @loaibh

---------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [XoaChamCongTheoNgay]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [XoaChamCongTheoNgay]
@ngay date
as
	delete ChamCong where Ngay = @ngay


-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [XoaChucVu]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [XoaChucVu]
@macv varchar(5)
as
	delete ChucVu where maCV = @macv
GO
/****** Object:  StoredProcedure [XoaNhanVien]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [XoaNhanVien]
@manv varchar(5)
as
	if(exists(select MaNhanVien from NhanVien where MaNhanVien = @manv))
	begin
		delete NhanVien where MaNhanVien = @manv
	end
	else 
		select err = 1
-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [XoaPhongBan]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create Proc [XoaPhongBan]
@maphong varchar(5)
as
	if((not exists(select MaPB from NhanVien where MaPB = @maphong)) and (not exists (Select MaPB from HopDong where MaPB = @maphong)))
	begin
		delete PhongBan where MaPB = @maphong
	end
	else
		select err = 1

-------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [XoaThuongPhat]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [XoaThuongPhat]
@manv varchar(5),
@loai nvarchar(100),
@tien int,
@lydo nvarchar(100),
@ngay datetime
as
	delete ThuongPhat where (MaNhanVien = @manv and Loai = @loai and Tien = @tien and LyDo = @lydo and Ngay = @ngay)

------------------------------------------------------------------------------------------------
GO
/****** Object:  StoredProcedure [XoaTK]    Script Date: 5/21/2021 7:34:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create Proc [XoaTK]
@ma varchar(5)
as
	delete Taikhoan where MaNhanVien = @ma

-------------------------------------------------------------------------------------------------
GO
