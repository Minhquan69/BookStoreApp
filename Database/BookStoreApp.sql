IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'BookStoreApp')
BEGIN
    CREATE DATABASE BookStoreApp;
END
GO

USE BookStoreApp;
GO
/****** Object:  Table [dbo].[CaLamViec]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaLamViec](
	[MaCa] [int] IDENTITY(1,1) NOT NULL,
	[TenCa] [nvarchar](50) NOT NULL,
	[GioBatDau] [time](0) NOT NULL,
	[GioKetThuc] [time](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHDB]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHDB](
	[MaHDB] [varchar](7) NULL,
	[MaSach] [varchar](5) NULL,
	[SoLuong] [int] NULL,
	[KhuyenMai] [decimal](10, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioHang]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaGH]  AS ('GH'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
	[MaKH] [varchar](5) NULL,
	[TongSanPham] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GioSanPham]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GioSanPham](
	[MaGH] [varchar](5) NULL,
	[MaSach] [varchar](5) NULL,
	[SoLuong] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDonBan]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaHDB]  AS ('HDB'+right('0000'+CONVERT([varchar],[Id]),(4))) PERSISTED NOT NULL,
	[MaNV] [varchar](5) NULL,
	[MaKH] [varchar](5) NULL,
	[Ngayban] [datetime] NULL,
	[TongTien] [decimal](10, 2) NULL,
	[PhuongThucThanhToan] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHDB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaKH]  AS ('KH'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
	[TenKhachHang] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[NgaySinh] [datetime] NULL,
	[SDT] [varchar](10) NULL,
	[Anh] [nvarchar](200) NULL,
	[MatKhau] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[MaSach] [varchar](5) NULL,
	[ThoigianBatDau] [datetime] NULL,
	[ThoiGianKetThuc] [datetime] NULL,
	[KM] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNV]  AS ('NV'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
	[TenNhanVien] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](5) NULL,
	[DiaChi] [nvarchar](150) NULL,
	[NgaySinh] [datetime] NULL,
	[SDT] [varchar](10) NULL,
	[NgayVaoLam] [datetime] NULL,
	[Anh] [nvarchar](200) NULL,
	[MatKhau] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaXuatBan]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaXuatBan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNXB]  AS ('NXB'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
	[TenNXB] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanCong]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanCong](
	[MaPhanCong] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [varchar](5) NULL,
	[MaCa] [int] NOT NULL,
	[ThangLamViec] [tinyint] NOT NULL,
	[NamLamViec] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPhanCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaSach]  AS ('S'+right('0000'+CONVERT([varchar],[Id]),(4))) PERSISTED NOT NULL,
	[TenSach] [nvarchar](200) NOT NULL,
	[TacGia] [nvarchar](150) NULL,
	[MaTheLoai] [varchar](5) NULL,
	[MaNXB] [varchar](6) NULL,
	[DonGia] [decimal](18, 2) NOT NULL,
	[SoLuong] [int] NULL,
	[SoTrang] [int] NULL,
	[Anh] [nvarchar](200) NULL,
	[FileSach] [nvarchar](200) NULL,
	[FileXemThu] [nvarchar](200) NULL,
	[GioiThieu] [nvarchar](max) NULL,
	[ThoiGianPhatHanh] [datetime] NULL,
	[LanXB] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 02/05/2025 21:53:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaTheLoai]  AS ('TL'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
	[TenTheLoai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CaLamViec] ON 

INSERT [dbo].[CaLamViec] ([MaCa], [TenCa], [GioBatDau], [GioKetThuc]) VALUES (1, N'Ca Sáng', CAST(N'06:00:00' AS Time), CAST(N'12:00:00' AS Time))
INSERT [dbo].[CaLamViec] ([MaCa], [TenCa], [GioBatDau], [GioKetThuc]) VALUES (2, N'Ca Chiều', CAST(N'12:00:00' AS Time), CAST(N'18:00:00' AS Time))
INSERT [dbo].[CaLamViec] ([MaCa], [TenCa], [GioBatDau], [GioKetThuc]) VALUES (3, N'Ca Tối', CAST(N'18:00:00' AS Time), CAST(N'23:00:00' AS Time))
INSERT [dbo].[CaLamViec] ([MaCa], [TenCa], [GioBatDau], [GioKetThuc]) VALUES (4, N'Ca Đêm', CAST(N'23:00:00' AS Time), CAST(N'06:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[CaLamViec] OFF
GO
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0001', N'S0001', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0001', N'S0002', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0002', N'S0003', 1, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0002', N'S0004', 1, CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0003', N'S0005', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0003', N'S0006', 1, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0004', N'S0007', 1, CAST(6000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0004', N'S0008', 1, CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0005', N'S0009', 1, CAST(70000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0005', N'S0010', 1, CAST(5000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0006', N'S0001', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0006', N'S0003', 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0007', N'S0002', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0007', N'S0005', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0008', N'S0006', 1, CAST(10000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0008', N'S0007', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0009', N'S0004', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0009', N'S0010', 1, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0010', N'S0008', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0010', N'S0009', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0011', N'S0010', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0011', N'S0011', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0012', N'S0012', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0012', N'S0013', 1, CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0013', N'S0014', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0013', N'S0015', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0014', N'S0016', 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0014', N'S0017', 1, CAST(60000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0015', N'S0018', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0015', N'S0019', 1, CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0016', N'S0020', 1, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0016', N'S0021', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0017', N'S0022', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0017', N'S0023', 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0018', N'S0024', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0018', N'S0025', 1, CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0019', N'S0026', 1, CAST(37000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0019', N'S0027', 1, CAST(28000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0020', N'S0028', 1, CAST(12000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0020', N'S0029', 1, CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0021', N'S0030', 1, CAST(60000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0021', N'S0031', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0022', N'S0032', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0022', N'S0033', 1, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0023', N'S0034', 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0023', N'S0035', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0024', N'S0036', 1, CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0024', N'S0037', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0025', N'S0038', 1, CAST(37000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0025', N'S0039', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0026', N'S0040', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0026', N'S0010', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0027', N'S0011', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0027', N'S0012', 1, CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0028', N'S0013', 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0028', N'S0014', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0029', N'S0015', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0029', N'S0016', 1, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0030', N'S0017', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0030', N'S0018', 1, CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0020', N'S0019', 1, CAST(12000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0021', N'S0020', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0022', N'S0021', 1, CAST(28000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0022', N'S0022', 1, CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0023', N'S0023', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0023', N'S0024', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0024', N'S0025', 1, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0024', N'S0026', 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0025', N'S0027', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0025', N'S0028', 1, CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0026', N'S0029', 1, CAST(20000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0026', N'S0030', 1, CAST(30000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0027', N'S0031', 1, CAST(45000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0027', N'S0032', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0028', N'S0033', 1, CAST(37000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0028', N'S0034', 1, CAST(15000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0029', N'S0035', 1, CAST(25000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0029', N'S0036', 1, CAST(50000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0030', N'S0037', 1, CAST(40000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0030', N'S0038', 1, CAST(35000.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0031', N'S0007', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0031', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0032', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0033', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0034', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0035', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0039', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0040', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0042', N'S0002', 1, CAST(-9985.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0036', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0037', N'S0004', 1, CAST(-9995.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0038', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0038', N'S0002', 1, CAST(-9985.00 AS Decimal(10, 2)))
INSERT [dbo].[ChiTietHDB] ([MaHDB], [MaSach], [SoLuong], [KhuyenMai]) VALUES (N'HDB0041', N'S0001', 1, CAST(-9990.00 AS Decimal(10, 2)))
GO
SET IDENTITY_INSERT [dbo].[GioHang] ON 

INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (1, N'KH001', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (2, N'KH002', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (3, N'KH003', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (4, N'KH004', 6)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (5, N'KH005', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (6, N'KH006', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (7, N'KH007', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (8, N'KH008', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (9, N'KH009', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (10, N'KH010', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (11, N'KH011', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (12, N'KH012', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (13, N'KH013', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (14, N'KH014', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (15, N'KH015', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (16, N'KH016', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (17, N'KH017', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (18, N'KH018', 2)
INSERT [dbo].[GioHang] ([ID], [MaKH], [TongSanPham]) VALUES (19, N'KH019', 2)
SET IDENTITY_INSERT [dbo].[GioHang] OFF
GO
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH001', N'S0001', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH001', N'S0002', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH002', N'S0003', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH002', N'S0004', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH003', N'S0005', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH003', N'S0006', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH005', N'S0009', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH005', N'S0010', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH006', N'S0001', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH006', N'S0011', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH007', N'S0002', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH007', N'S0003', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH008', N'S0004', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH008', N'S0012', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH009', N'S0005', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH009', N'S0013', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH010', N'S0006', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH010', N'S0014', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH011', N'S0007', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH011', N'S0015', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH012', N'S0008', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH012', N'S0016', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH013', N'S0009', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH013', N'S0017', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH014', N'S0010', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH014', N'S0018', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH015', N'S0001', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH015', N'S0002', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH016', N'S0003', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH016', N'S0019', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH017', N'S0004', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH017', N'S0020', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH018', N'S0005', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH018', N'S0021', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH019', N'S0006', 1)
INSERT [dbo].[GioSanPham] ([MaGH], [MaSach], [SoLuong]) VALUES (N'GH019', N'S0022', 1)
GO
SET IDENTITY_INSERT [dbo].[HoaDonBan] ON 

INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (1, N'NV001', N'KH001', CAST(N'2024-11-01T21:00:00.000' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (2, N'NV002', N'KH001', CAST(N'2024-11-02T10:00:00.000' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (3, N'NV003', N'KH001', CAST(N'2024-11-03T09:30:00.000' AS DateTime), CAST(95000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (4, N'NV004', N'KH001', CAST(N'2024-11-04T11:00:00.000' AS DateTime), CAST(64000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (5, N'NV005', N'KH001', CAST(N'2024-11-05T02:30:00.000' AS DateTime), CAST(100000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (6, N'NV006', N'KH006', CAST(N'2024-11-06T00:00:00.000' AS DateTime), CAST(110000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (7, N'NV007', N'KH007', CAST(N'2024-11-07T00:00:00.000' AS DateTime), CAST(95000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (8, N'NV008', N'KH008', CAST(N'2024-11-08T00:00:00.000' AS DateTime), CAST(105000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (9, N'NV009', N'KH009', CAST(N'2024-11-09T00:00:00.000' AS DateTime), CAST(60000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (10, N'NV010', N'KH010', CAST(N'2024-11-10T00:00:00.000' AS DateTime), CAST(25000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (11, N'NV001', N'KH001', CAST(N'2024-11-01T09:15:00.000' AS DateTime), CAST(15000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (12, N'NV002', N'KH002', CAST(N'2024-11-02T10:30:00.000' AS DateTime), CAST(85000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (13, N'NV003', N'KH003', CAST(N'2024-11-03T11:45:00.000' AS DateTime), CAST(200000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (14, N'NV004', N'KH004', CAST(N'2024-11-04T12:00:00.000' AS DateTime), CAST(15000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (15, N'NV005', N'KH005', CAST(N'2024-11-05T13:30:00.000' AS DateTime), CAST(45000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (16, N'NV006', N'KH006', CAST(N'2024-11-06T14:45:00.000' AS DateTime), CAST(5000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (17, N'NV007', N'KH007', CAST(N'2024-11-07T15:00:00.000' AS DateTime), CAST(140000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (18, N'NV008', N'KH008', CAST(N'2024-11-08T16:30:00.000' AS DateTime), CAST(45000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (19, N'NV009', N'KH009', CAST(N'2024-11-09T17:15:00.000' AS DateTime), CAST(40000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (20, N'NV010', N'KH010', CAST(N'2024-11-10T18:00:00.000' AS DateTime), CAST(236000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (21, N'NV001', N'KH011', CAST(N'2024-11-11T09:45:00.000' AS DateTime), CAST(60000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (22, N'NV002', N'KH012', CAST(N'2024-11-12T10:00:00.000' AS DateTime), CAST(-8000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (23, N'NV003', N'KH013', CAST(N'2024-11-13T11:30:00.000' AS DateTime), CAST(165000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (24, N'NV004', N'KH014', CAST(N'2024-11-14T12:15:00.000' AS DateTime), CAST(70000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (25, N'NV005', N'KH015', CAST(N'2024-11-15T13:00:00.000' AS DateTime), CAST(28000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (26, N'NV006', N'KH001', CAST(N'2024-11-16T14:30:00.000' AS DateTime), CAST(175000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (27, N'NV007', N'KH002', CAST(N'2024-11-17T15:45:00.000' AS DateTime), CAST(140000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (28, N'NV008', N'KH003', CAST(N'2024-11-18T16:00:00.000' AS DateTime), CAST(118000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (29, N'NV009', N'KH004', CAST(N'2024-11-19T17:30:00.000' AS DateTime), CAST(80000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (30, N'NV010', N'KH005', CAST(N'2024-11-20T18:15:00.000' AS DateTime), CAST(20000.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (31, N'NV004', N'KH004', CAST(N'2024-11-26T00:05:29.033' AS DateTime), CAST(169980.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (32, N'NV004', N'KH004', CAST(N'2024-11-26T00:08:23.023' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (33, N'NV004', N'KH004', CAST(N'2024-11-26T00:09:16.630' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (34, N'NV004', N'KH004', CAST(N'2024-11-26T00:12:38.517' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (35, N'NV004', N'KH004', CAST(N'2024-11-26T00:13:48.530' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (36, N'NV004', N'KH004', CAST(N'2024-11-26T01:42:21.477' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (37, N'NV004', N'KH004', CAST(N'2024-11-26T01:43:13.543' AS DateTime), CAST(69995.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (38, N'NV004', N'KH004', CAST(N'2024-11-26T01:47:43.203' AS DateTime), CAST(179975.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (39, N'NV004', N'KH004', CAST(N'2024-11-26T01:49:09.447' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (40, N'NV004', N'KH004', CAST(N'2024-11-26T01:52:53.447' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (41, N'NV004', N'KH004', CAST(N'2024-11-26T01:54:34.390' AS DateTime), CAST(84990.00 AS Decimal(10, 2)), N'Chuyển khoản')
INSERT [dbo].[HoaDonBan] ([ID], [MaNV], [MaKH], [Ngayban], [TongTien], [PhuongThucThanhToan]) VALUES (42, N'NV004', N'KH004', CAST(N'2024-11-26T01:55:37.177' AS DateTime), CAST(94985.00 AS Decimal(10, 2)), N'Chuyển khoản')
SET IDENTITY_INSERT [dbo].[HoaDonBan] OFF
GO
SET IDENTITY_INSERT [dbo].[KhachHang] ON 

INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (1, N'Đào Minh Quân', N'Nam', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'1990-01-15T00:00:00.000' AS DateTime), N'0912345678', N'MQ.jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (2, N'Trần Thị B', N'Nữ', N'136 Đ. Xuân Thủy, Dịch Vọng Hậu, Cầu Giấy, Hà Nội', CAST(N'1991-02-20T00:00:00.000' AS DateTime), N'0923456789', N'G02.jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (3, N'Phan Quang C', N'Nam', N'Km9 Đ. Nguyễn Trãi, P. Văn Quán, Nam Từ Liêm, Hà Nội', CAST(N'1992-03-10T00:00:00.000' AS DateTime), N'0934567890', N'Reader (261).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (4, N'Lê Minh Dũng A', N'Nam', N'số 144 đường Xuân Thủy, phường Dịch Vọng Hậu, Quận Cầu Giấy, Hà Nội.', CAST(N'1993-04-05T00:00:00.000' AS DateTime), N'0945678901', N'jack.jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (5, N'Ngô Thu E', N'Nữ', N'Số 1 Đại Cồ Việt, Bách Khoa, Hai Bà Trưng, Hà Nội;', CAST(N'1994-05-18T00:00:00.000' AS DateTime), N'0956789012', N'G03.jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (6, N'Vũ Tiến F', N'Nam', N'207 Giải Phóng, Đồng Tâm, Hai Bà Trưng, Hà Nội', CAST(N'1995-06-30T00:00:00.000' AS DateTime), N'0967890123', N'Reader (259).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (7, N'Hồ Thị G', N'Nữ', N'91 Láng Chùa Quận, Láng Thượng, Đống Đa, Hà Nội', CAST(N'1996-07-25T00:00:00.000' AS DateTime), N'0978901234', N'Reader (2).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (8, N'Hoàng Văn H', N'Nam', N'số 1 Tôn Thất Tùng, Kim Liên, Đống Đa, Hà Nội', CAST(N'1997-08-22T00:00:00.000' AS DateTime), N'0989012345', N'Reader (252).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (9, N'Trần Minh I', N'Nam', N'69 Phường Chùa Láng, Láng Thượng, Đống Đa, Hà Nội', CAST(N'1998-09-11T00:00:00.000' AS DateTime), N'0990123456', N'Reader (253).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (10, N'Đỗ Thu J', N'Nữ', N'87 Nguyễn Chí Thanh, Láng Thượng, Đống Đa, Hà Nội', CAST(N'1999-10-12T00:00:00.000' AS DateTime), N'0901234567', N'Reader (4).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (11, N'Nguyễn Thị K', N'Nữ', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'2000-11-15T00:00:00.000' AS DateTime), N'0912345670', N'Reader (7).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (12, N'Phan Quang L', N'Nam', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'2001-12-05T00:00:00.000' AS DateTime), N'0923456781', N'Reader (194).jpeg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (13, N'Vũ Tài M', N'Nam', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'2002-01-14T00:00:00.000' AS DateTime), N'0934567892', N'Reader (221).jpeg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (14, N'Hồ Minh N', N'Nam', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'2003-02-19T00:00:00.000' AS DateTime), N'0945678903', N'Reader (222).jpeg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (15, N'Hoàng Thị O', N'Nữ', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'2004-03-13T00:00:00.000' AS DateTime), N'0956789014', N'Reader (12).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (16, N'Trần Thi P', N'Nữ', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'2005-04-26T00:00:00.000' AS DateTime), N'0967890125', N'Reader (212).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (17, N'Nguyễn Thiên Q', N'Nam', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'1990-05-10T00:00:00.000' AS DateTime), N'0978901235', N'Reader (16).jpg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (18, N'Trần Quốc R', N'Nam', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'1991-06-12T00:00:00.000' AS DateTime), N'0989012346', N'Reader (229).jpeg', N'123')
INSERT [dbo].[KhachHang] ([ID], [TenKhachHang], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [Anh], [MatKhau]) VALUES (19, N'Vũ Minh S', N'Nam', N'3 Đ. Cầu Giấy, Ngọc Khánh, Đống Đa, Hà Nội', CAST(N'1992-07-22T00:00:00.000' AS DateTime), N'0990123457', N'Reader (223).jpeg', N'123')
SET IDENTITY_INSERT [dbo].[KhachHang] OFF
GO
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0001', CAST(N'2024-11-01T00:00:00.000' AS DateTime), CAST(N'2026-11-30T00:00:00.000' AS DateTime), CAST(20.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0002', CAST(N'2024-11-05T00:00:00.000' AS DateTime), CAST(N'2024-11-25T00:00:00.000' AS DateTime), CAST(15.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0003', CAST(N'2024-12-14T00:00:00.000' AS DateTime), CAST(N'2025-01-02T00:00:00.000' AS DateTime), CAST(20.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0004', CAST(N'2024-11-15T00:00:00.000' AS DateTime), CAST(N'2024-11-30T00:00:00.000' AS DateTime), CAST(5.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0005', CAST(N'2024-11-01T00:00:00.000' AS DateTime), CAST(N'2024-11-15T00:00:00.000' AS DateTime), CAST(30.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0006', CAST(N'2024-11-05T00:00:00.000' AS DateTime), CAST(N'2024-11-20T00:00:00.000' AS DateTime), CAST(25.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0007', CAST(N'2024-11-01T00:00:00.000' AS DateTime), CAST(N'2024-11-30T00:00:00.000' AS DateTime), CAST(10.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0008', CAST(N'2024-11-10T00:00:00.000' AS DateTime), CAST(N'2024-11-25T00:00:00.000' AS DateTime), CAST(12.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0009', CAST(N'2024-11-01T00:00:00.000' AS DateTime), CAST(N'2024-11-15T00:00:00.000' AS DateTime), CAST(18.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0023', CAST(N'2025-05-01T00:00:00.000' AS DateTime), CAST(N'2025-05-15T00:00:00.000' AS DateTime), CAST(50.00 AS Decimal(18, 2)))
INSERT [dbo].[KhuyenMai] ([MaSach], [ThoigianBatDau], [ThoiGianKetThuc], [KM]) VALUES (N'S0069', CAST(N'2025-06-01T00:00:00.000' AS DateTime), CAST(N'2025-07-01T00:00:00.000' AS DateTime), CAST(60.00 AS Decimal(18, 2)))
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (1, N'Nguyễn Văn A', N'Nam', N'Hà Nội', CAST(N'1990-01-15T00:00:00.000' AS DateTime), N'0973002887', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'nvA.jpg', N'123')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (2, N'Trần Thị B', N'Nữ', N'Hồ Chí Minh', CAST(N'1992-02-20T00:00:00.000' AS DateTime), N'0976543210', CAST(N'2021-02-15T00:00:00.000' AS DateTime), N'nvB.jpg', N'password456')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (3, N'Lê Minh C', N'Nam', N'Đà Nẵng', CAST(N'1988-03-10T00:00:00.000' AS DateTime), N'0965432109', CAST(N'2020-03-01T00:00:00.000' AS DateTime), N'nvC.jpg', N'password789')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (4, N'Phan Thị D', N'Nữ', N'Hải Phòng', CAST(N'1995-04-05T00:00:00.000' AS DateTime), N'0954321098', CAST(N'2021-04-10T00:00:00.000' AS DateTime), N'nvD.jpg', N'password321')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (5, N'Vũ Thành E', N'Nam', N'Cần Thơ', CAST(N'1993-05-25T00:00:00.000' AS DateTime), N'0943210987', CAST(N'2020-06-15T00:00:00.000' AS DateTime), N'nvE.jpg', N'password654')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (6, N'Đỗ Minh F', N'Nam', N'Hà Nội', CAST(N'1991-06-12T00:00:00.000' AS DateTime), N'0932109876', CAST(N'2022-07-01T00:00:00.000' AS DateTime), N'nvF.jpg', N'password987')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (7, N'Bùi Thị G', N'Nữ', N'Hồ Chí Minh', CAST(N'1994-07-30T00:00:00.000' AS DateTime), N'0921098765', CAST(N'2021-08-20T00:00:00.000' AS DateTime), N'nvG.jpg', N'password234')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (8, N'Ngô Thành H', N'Nam', N'Đà Nẵng', CAST(N'1989-08-15T00:00:00.000' AS DateTime), N'0910987654', CAST(N'2020-09-10T00:00:00.000' AS DateTime), N'nvH.jpg', N'password567')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (9, N'Phạm Thanh I', N'Nữ', N'Hải Phòng', CAST(N'1992-09-22T00:00:00.000' AS DateTime), N'0909876543', CAST(N'2021-10-05T00:00:00.000' AS DateTime), N'nvI.jpg', N'password890')
INSERT [dbo].[NhanVien] ([ID], [TenNhanVien], [GioiTinh], [DiaChi], [NgaySinh], [SDT], [NgayVaoLam], [Anh], [MatKhau]) VALUES (10, N'Mai Minh J', N'Nam', N'Cần Thơ', CAST(N'1996-10-18T00:00:00.000' AS DateTime), N'0898765432', CAST(N'2022-11-01T00:00:00.000' AS DateTime), N'nvJ.jpg', N'password135')
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
SET IDENTITY_INSERT [dbo].[NhaXuatBan] ON 

INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (1, N'Nhà Xuất Bản Kim Đồng')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (2, N'Nhà Xuất Bản Giáo Dục Việt Nam')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (3, N'Nhà Xuất Bản Trẻ')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (4, N'Nhà Xuất Bản Văn Học')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (5, N'Nhà Xuất Bản Khoa Học Kỹ Thuật')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (6, N'Nhà Xuất Bản Lao Động')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (7, N'Nhà Xuất Bản Phụ Nữ')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (8, N'Nhà Xuất Bản Thanh Niên')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (9, N'Nhà Xuất Bản Tổng Hợp')
INSERT [dbo].[NhaXuatBan] ([ID], [TenNXB]) VALUES (10, N'Nhà Xuất Bản Chính Trị Quốc Gia')
SET IDENTITY_INSERT [dbo].[NhaXuatBan] OFF
GO
SET IDENTITY_INSERT [dbo].[PhanCong] ON 

INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (1, N'NV001', 1, 11, 2024)
INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (2, N'NV002', 2, 11, 2024)
INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (3, N'NV003', 3, 11, 2024)
INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (4, N'NV004', 4, 11, 2024)
INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (5, N'NV005', 1, 12, 2024)
INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (6, N'NV006', 2, 12, 2024)
INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (7, N'NV007', 3, 12, 2024)
INSERT [dbo].[PhanCong] ([MaPhanCong], [MaNV], [MaCa], [ThangLamViec], [NamLamViec]) VALUES (8, N'NV008', 4, 12, 2024)
SET IDENTITY_INSERT [dbo].[PhanCong] OFF
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (1, N'Nhật ký trong tù', N'Hồ Chí Minh', N'TL001', N'NXB001', CAST(75000.00 AS Decimal(18, 2)), 36, 200, N'bia_nhat_ky_trong_tu_file_in-b1_85cc447380214791a8a7d74603ef46a1.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Nhật ký trong tù là một tác phẩm văn học đặc sắc, tập hợp những bài thơ được Chủ tịch Hồ Chí Minh sáng tác trong thời gian bị giam cầm. Tác phẩm phản ánh tinh thần yêu nước, ý chí kiên cường và niềm tin mãnh liệt vào tương lai tươi sáng của dân tộc. Đây không chỉ là một tác phẩm văn học mà còn là một nguồn cảm hứng bất tận cho các thế hệ người Việt Nam.', CAST(N'2025-04-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (2, N'Tuổi thơ dữ dội', N'Phùng Quán', N'TL002', N'NXB002', CAST(85000.00 AS Decimal(18, 2)), 38, 320, N'tuoi-tho-du-doi-t1_ad11ae5e364d4fd1a3e563754f8df81d_42b5d030cfdd4f06bd7c68650fd113cb_master.jpg', N'13586-tuoi-tho-du-doi-thuviensach.vn.pdf', N'13586-tuoi-tho-du-doi-thuviensach.vn.pdf', N'Tuổi thơ dữ dội là câu chuyện đầy cảm xúc về những cậu bé dũng cảm tham gia vào kháng chiến chống Pháp. Tác phẩm của Phùng Quán không chỉ tái hiện cuộc chiến đấu anh dũng mà còn khắc họa sâu sắc tâm hồn trong sáng và tinh thần yêu nước mãnh liệt của những nhân vật nhỏ tuổi, khiến người đọc không thể không xúc động.', CAST(N'2025-04-18T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (3, N'Mắt biếc', N'Nguyễn Nhật Ánh', N'TL003', N'NXB003', CAST(90000.00 AS Decimal(18, 2)), 60, 250, N'mat-biec_bia-mem_in-lan-thu-44 (400 x 500).jpg', N'4886-mat-biec-thuviensach.vn.pdf', N'4886-mat-biec-thuviensach.vn.pdf', N'Mắt biếc là một tác phẩm nổi tiếng của nhà văn Nguyễn Nhật Ánh, kể về mối tình đơn phương của Ngạn dành cho Hà Lan - người con gái với đôi mắt đẹp mê hồn. Cuốn sách mang lại cho người đọc cảm giác bồi hồi, nhớ nhung về những năm tháng tuổi trẻ và tình yêu trong sáng nhưng đầy tiếc nuối.', CAST(N'2026-01-15T00:00:00.000' AS DateTime), 7)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (4, N'Chiếc lá cuối cùng', N'O.Henry', N'TL004', N'NXB004', CAST(60000.00 AS Decimal(18, 2)), 29, 120, N'Chieclacuoicung.jpg', N'7868-chiec-la-cuoi-cung-thuviensach.vn.pdf', N'7868-chiec-la-cuoi-cung-thuviensach.vn.pdf', N'Chiếc lá cuối cùng của O.Henry là một câu chuyện ngắn đầy cảm động, kể về tình bạn, sự hy sinh và ý chí sống mãnh liệt. Qua hình ảnh chiếc lá không bao giờ rụng, tác giả gửi gắm thông điệp mạnh mẽ về niềm hy vọng và sức mạnh vượt qua khó khăn trong cuộc sống.', CAST(N'1907-10-01T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (5, N'Dế Mèn phiêu lưu ký', N'Tô Hoài', N'TL005', N'NXB005', CAST(65000.00 AS Decimal(18, 2)), 50, 180, N'demenphieuluuky.jpg', N'1095-de-men-phieu-luu-ky-thuviensach.vn.pdf', N'1095-de-men-phieu-luu-ky-thuviensach.vn.pdf', N'Dế Mèn phiêu lưu ký là tác phẩm gắn liền với tuổi thơ của nhiều thế hệ bạn đọc. Câu chuyện xoay quanh cuộc phiêu lưu của chú Dế Mèn, mang đến những bài học sâu sắc về tình bạn, lòng dũng cảm và trách nhiệm đối với cộng đồng. Tác phẩm không chỉ hấp dẫn thiếu nhi mà còn để lại ấn tượng mạnh mẽ cho người lớn.', CAST(N'1941-07-10T00:00:00.000' AS DateTime), 10)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (6, N'Đất rừng phương Nam', N'Đoàn Giỏi', N'TL006', N'NXB006', CAST(70000.00 AS Decimal(18, 2)), 40, 230, N'DatRungPhuongNam.jpg', N'2713-dat-rung-phuong-nam-thuviensach.vn.pdf', N'2713-dat-rung-phuong-nam-thuviensach.vn.pdf', N'Đất rừng phương Nam là một tác phẩm kinh điển của văn học Việt Nam, đưa người đọc vào khung cảnh thiên nhiên hùng vĩ của miền Tây Nam Bộ. Tác giả Đoàn Giỏi khắc họa cuộc sống của người dân nơi đây với tình yêu thiên nhiên và những giá trị văn hóa đặc sắc, để lại ấn tượng sâu đậm trong lòng người đọc.', CAST(N'1957-11-20T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (7, N'Người lái đò sông Đà', N'Nguyễn Tuân', N'TL001', N'NXB007', CAST(75000.00 AS Decimal(18, 2)), 41, 300, N'NguoiLaiDoSongDa.jpg', N'nguoi_lai_Đo_song_Đa.pdf', N'nguoi_lai_Đo_song_Đa.pdf', N'Người lái đò sông Đà là một trong những tác phẩm tiêu biểu của Nguyễn Tuân, ca ngợi vẻ đẹp hùng vĩ của sông Đà và sự tài hoa, dũng cảm của người lái đò. Tác phẩm thể hiện lòng yêu nước sâu sắc và khát khao chinh phục thiên nhiên của con người Việt Nam.', CAST(N'1960-03-15T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (8, N'Vợ chồng A Phủ', N'Tô Hoài', N'TL002', N'NXB008', CAST(0.00 AS Decimal(18, 2)), 30, 200, N'vo-chong-a-phu.jpg', N'vo_chong_a_phu.pdf', N'vo_chong_a_phu.pdf', N'Vợ chồng A Phủ là một tác phẩm xuất sắc của Tô Hoài, phản ánh cuộc sống khổ cực và sự vươn lên của đồng bào miền núi Tây Bắc dưới ách áp bức. Tác phẩm để lại ấn tượng sâu sắc bởi cách xây dựng nhân vật sống động và những hình ảnh thiên nhiên hùng vĩ.', CAST(N'1952-09-01T00:00:00.000' AS DateTime), 8)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (9, N'Số đỏ', N'Vũ Trọng Phụng', N'TL003', N'NXB009', CAST(85000.00 AS Decimal(18, 2)), 40, 250, N'SoDo.jpg', N'7817-so-do-thuviensach.vn.pdf', N'7817-so-do-thuviensach.vn.pdf', N'Số đỏ của Vũ Trọng Phụng là một kiệt tác trào phúng, phản ánh chân thực xã hội Việt Nam thời thuộc địa. Với giọng văn châm biếm sắc sảo, tác phẩm mang đến cái nhìn sâu sắc về thực trạng đạo đức và lối sống của con người trong thời kỳ này.', CAST(N'1936-06-10T00:00:00.000' AS DateTime), 12)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (10, N'Chí Phèo', N'Nam Cao', N'TL004', N'NXB010', CAST(90000.00 AS Decimal(18, 2)), 50, 280, N'chi-pheo_72e3f1370e484cf49b0fc94ee4ce0f80_master.jpg', N'8701-chi-pheo-thuviensach.vn.pdf', N'8701-chi-pheo-thuviensach.vn.pdf', N'Chí Phèo là tác phẩm nổi bật của nhà văn Nam Cao, khắc họa bi kịch của con người trong xã hội phong kiến tàn bạo. Qua nhân vật Chí Phèo, tác giả gửi gắm thông điệp về quyền sống, quyền hạnh phúc và khát vọng làm người của những con người cùng khổ.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 9)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (11, N'Thằng gù nhà thờ Đức Bà', N'Victor Hugo', N'TL001', N'NXB001', CAST(0.00 AS Decimal(18, 2)), 30, 400, N'nha-tho-duc-ba-paris-bia-cung-jpeg.jpg', N'1014-nha-tho-duc-ba-paris-thuviensach.vn.pdf', N'1014-nha-tho-duc-ba-paris-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (12, N'Chiến tranh và hòa bình', N'Leo Tolstoy', N'TL002', N'NXB002', CAST(150000.00 AS Decimal(18, 2)), 20, 1200, N'chien-tranh-va-hoa-binh.jpg', N'1012-chien-tranh-va-hoa-binh-thuviensach.vn.pdf', N'1012-chien-tranh-va-hoa-binh-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'2026-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (13, N'Không gia đình', N'Hector Malot', N'TL003', N'NXB003', CAST(0.00 AS Decimal(18, 2)), 35, 450, N'KhongGiaDinh.jpg', N'996-khong-gia-dinh-thuviensach.vn.pdf', N'996-khong-gia-dinh-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (14, N'Những người khốn khổ', N'Victor Hugo', N'TL004', N'NXB004', CAST(140000.00 AS Decimal(18, 2)), 25, 950, N'NhungNguoiKhonKho.jpg', N'7867-nhung-nguoi-khon-kho-thuviensach.vn.pdf', N'7867-nhung-nguoi-khon-kho-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (15, N'Cuốn theo chiều gió', N'Margaret Mitchell', N'TL005', N'NXB005', CAST(130000.00 AS Decimal(18, 2)), 20, 750, N'CuonTheoChieuGio.jpg', N'995-cuon-theo-chieu-gio-thuviensach.vn.pdf', N'995-cuon-theo-chieu-gio-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'2025-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (16, N'Tội ác và trừng phạt', N'Fyodor Dostoevsky', N'TL006', N'NXB006', CAST(0.00 AS Decimal(18, 2)), 15, 600, N'Toiacvahinhphat.jpg', N'7832-toi-ac-va-trung-phat-thuviensach.vn.pdf', N'7832-toi-ac-va-trung-phat-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (17, N'Đồi gió hú', N'Emily Brontë', N'TL001', N'NXB007', CAST(90000.00 AS Decimal(18, 2)), 40, 400, N'2020_11_17_15_30_41_1-390x510.jpg', N'1000-doi-gio-hu-thuviensach.vn.pdf', N'1000-doi-gio-hu-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (18, N'Ông già và biển cả', N'Ernest Hemingway', N'TL002', N'NXB008', CAST(0.00 AS Decimal(18, 2)), 50, 200, N'OngGiaVaBienCa.jpg', N'997-ong-gia-va-bien-ca-thuviensach.vn.pdf', N'997-ong-gia-va-bien-ca-thuviensach.vn.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (19, N'1984', N'George Orwell', N'TL003', N'NXB009', CAST(100000.00 AS Decimal(18, 2)), 60, 350, N'1984.jpg', N'1011-1984-thuviensach.vn.pdf', N'1011-1984-thuviensach.vn.pdf', N'1984 là tiểu thuyết dystopian nổi tiếng của George Orwell, một lời cảnh báo sâu sắc về chủ nghĩa toàn trị và sự mất tự do cá nhân.', CAST(N'2024-12-05T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (20, N'Nhà giả kim', N'Paulo Coelho', N'TL004', N'NXB010', CAST(95000.00 AS Decimal(18, 2)), 30, 250, N'nhagiakim.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (21, N'Anna Karenina', N'Leo Tolstoy', N'TL001', N'NXB001', CAST(0.00 AS Decimal(18, 2)), 30, 650, N'anna.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (22, N'Shakespeare – 4 vở kịch nổi tiếng', N'William Shakespeare', N'TL002', N'NXB002', CAST(90000.00 AS Decimal(18, 2)), 40, 500, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (23, N'Moby-Dick', N'Herman Melville', N'TL003', N'NXB003', CAST(100000.00 AS Decimal(18, 2)), 35, 600, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'2025-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (24, N'Bảo tàng tự sát', N'Shane Acker', N'TL004', N'NXB004', CAST(110000.00 AS Decimal(18, 2)), 50, 350, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (25, N'Kẻ hủy diệt', N'Philip K. Dick', N'TL005', N'NXB005', CAST(0.00 AS Decimal(18, 2)), 45, 450, N'kehuydiet.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (26, N'Máu và mật', N'Tom Rob Smith', N'TL006', N'NXB006', CAST(105000.00 AS Decimal(18, 2)), 60, 400, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'2025-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (27, N'Mùa hè sôi động', N'Mark Haddon', N'TL001', N'NXB007', CAST(0.00 AS Decimal(18, 2)), 35, 280, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (28, N'Harry Potter và hòn đá phù thủy', N'J.K. Rowling', N'TL002', N'NXB008', CAST(85000.00 AS Decimal(18, 2)), 70, 400, N'harry.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (29, N'The Great Gatsby', N'F. Scott Fitzgerald', N'TL003', N'NXB009', CAST(100000.00 AS Decimal(18, 2)), 50, 180, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (30, N'Giết con chim nhại', N'Harper Lee', N'TL004', N'NXB010', CAST(0.00 AS Decimal(18, 2)), 60, 340, N'gietconchimnhai.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (31, N'Văn học Việt Nam hiện đại', N'Nhiều tác giả', N'TL001', N'NXB001', CAST(90000.00 AS Decimal(18, 2)), 50, 300, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'2025-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (32, N'Hai đứa trẻ', N'Tô Hoài', N'TL002', N'NXB002', CAST(65000.00 AS Decimal(18, 2)), 40, 150, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'2025-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (33, N'Muôn kiếp nhân sinh', N'Lương Ngọc Châu', N'TL003', N'NXB003', CAST(0.00 AS Decimal(18, 2)), 45, 220, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (34, N'Bên thắng cuộc', N'Hồ Quang Hưng', N'TL004', N'NXB004', CAST(75000.00 AS Decimal(18, 2)), 40, 180, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (35, N'Về quê', N'Nguyễn Quang Sáng', N'TL005', N'NXB005', CAST(0.00 AS Decimal(18, 2)), 30, 210, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (36, N'Tôi thấy hoa vàng trên cỏ xanh', N'Nguyễn Nhật Ánh', N'TL006', N'NXB006', CAST(95000.00 AS Decimal(18, 2)), 50, 280, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (37, N'Biển sâu không ngủ', N'Trần Hữu Dũng', N'TL001', N'NXB007', CAST(0.00 AS Decimal(18, 2)), 40, 250, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (38, N'Chuyện cổ tích', N'Phan Bội Châu', N'TL002', N'NXB008', CAST(70000.00 AS Decimal(18, 2)), 45, 180, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (39, N'Những ngôi sao xa xôi', N'Lê Minh Khuê', N'TL003', N'NXB009', CAST(0.00 AS Decimal(18, 2)), 30, 210, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (40, N'Về quê', N'Nguyễn Quang Sáng', N'TL004', N'NXB010', CAST(95000.00 AS Decimal(18, 2)), 40, 260, N'veque.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'2026-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (41, N'Tiếng gọi nơi hoang dã', N'Jack London', N'TL005', N'NXB001', CAST(105000.00 AS Decimal(18, 2)), 30, 250, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (42, N'Mắt biếc', N'Nguyễn Nhật Ánh', N'TL006', N'NXB002', CAST(0.00 AS Decimal(18, 2)), 50, 300, N'matbiec.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Mắt biếc là một tác phẩm nổi tiếng của nhà văn Nguyễn Nhật Ánh, kể về mối tình đơn phương của Ngạn dành cho Hà Lan - người con gái với đôi mắt đẹp mê hồn. Cuốn sách mang lại cho người đọc cảm giác bồi hồi, nhớ nhung về những năm tháng tuổi trẻ và tình yêu trong sáng nhưng đầy tiếc nuối.', CAST(N'1990-01-15T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (43, N'Mai mốt', N'Nguyễn Nhật Ánh', N'TL001', N'NXB003', CAST(75000.00 AS Decimal(18, 2)), 60, 250, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (44, N'Chân dung một tình yêu', N'Nguyễn Huy Thiệp', N'TL002', N'NXB004', CAST(0.00 AS Decimal(18, 2)), 45, 350, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (45, N'Tình yêu xa xôi', N'Trần Thùy Mai', N'TL003', N'NXB005', CAST(80000.00 AS Decimal(18, 2)), 40, 220, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (47, N'Gặp gỡ cuối tuần', N'Nguyễn Huy Thiệp', N'TL001', N'NXB001', CAST(75000.00 AS Decimal(18, 2)), 45, 220, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (48, N'Khát vọng', N'Trương Công Kỉnh', N'TL002', N'NXB002', CAST(0.00 AS Decimal(18, 2)), 40, 250, N'khatvong.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (49, N'Sông dài', N'Nguyễn Thi', N'TL003', N'NXB003', CAST(0.00 AS Decimal(18, 2)), 50, 300, N'songdai.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (50, N'Hai số phận', N'Nguyễn Ngọc Tư', N'TL004', N'NXB004', CAST(75000.00 AS Decimal(18, 2)), 35, 280, N'haisophan.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (51, N'Tôi thấy hoa vàng trên cỏ xanh', N'Nguyễn Nhật Ánh', N'TL005', N'NXB005', CAST(80000.00 AS Decimal(18, 2)), 55, 320, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (52, N'Từ điển Tiếng Việt', N'Việt Nam', N'TL006', N'NXB006', CAST(0.00 AS Decimal(18, 2)), 30, 1500, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (53, N'Thị Kính', N'Nguyễn Du', N'TL007', N'NXB007', CAST(85000.00 AS Decimal(18, 2)), 40, 200, N'thikinh.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (54, N'Pháp luật và cuộc sống', N'Phan Châu Trinh', N'TL008', N'NXB008', CAST(0.00 AS Decimal(18, 2)), 45, 250, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (55, N'Về quê', N'Nguyễn Công Hoan', N'TL009', N'NXB009', CAST(85000.00 AS Decimal(18, 2)), 50, 270, N'veque.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (56, N'Đoàn thuyền đánh cá', N'Tố Hữu', N'TL010', N'NXB010', CAST(0.00 AS Decimal(18, 2)), 40, 180, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (57, N'Anh em nhà Karamazov', N'Fyodor Dostoevsky', N'TL001', N'NXB001', CAST(95000.00 AS Decimal(18, 2)), 30, 800, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (58, N'Những con chim giận dữ', N'William Peter Blatty', N'TL002', N'NXB002', CAST(0.00 AS Decimal(18, 2)), 35, 300, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (59, N'Trên con đường dài', N'Stieg Larsson', N'TL003', N'NXB003', CAST(120000.00 AS Decimal(18, 2)), 25, 500, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (60, N'Mặt trời mọc phía Đông', N'Edgar Allan Poe', N'TL004', N'NXB004', CAST(90000.00 AS Decimal(18, 2)), 30, 350, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (61, N'Mối quan hệ là gì?', N'Dale Carnegie', N'TL005', N'NXB005', CAST(110000.00 AS Decimal(18, 2)), 40, 250, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người. Qua từng trang sách, độc giả sẽ tìm thấy những bài học quý giá về cuộc sống, sự kiên trì và sức mạnh nội tâm.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (62, N'Mối quan hệ của tôi với bạn', N'Cheryl Strayed', N'TL006', N'NXB006', CAST(95000.00 AS Decimal(18, 2)), 45, 300, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Mối quan hệ của tôi với bạn là cuốn sách sâu sắc của Cheryl Strayed, khám phá những cung bậc cảm xúc trong các mối quan hệ và cách chúng ta tìm thấy ý nghĩa trong cuộc sống.', CAST(N'2024-10-15T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (63, N'Khi ánh sáng tắt', N'Haruki Murakami', N'TL007', N'NXB007', CAST(120000.00 AS Decimal(18, 2)), 25, 350, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Khi ánh sáng tắt là một tác phẩm đầy cảm xúc của Haruki Murakami, nói về hành trình tìm kiếm ánh sáng nội tâm giữa bóng tối của cuộc sống.', CAST(N'2024-10-20T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (65, N'Phản diện', N'Paulo Coelho', N'TL009', N'NXB009', CAST(100000.00 AS Decimal(18, 2)), 50, 280, N'phandien.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Phản diện là cuốn tiểu thuyết triết học sâu sắc của Paulo Coelho, mở ra những suy ngẫm về bản chất thiện ác trong mỗi con người.', CAST(N'2024-11-05T00:00:00.000' AS DateTime), 4)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (66, N'Những người hạnh phúc', N'Graham Greene', N'TL010', N'NXB010', CAST(95000.00 AS Decimal(18, 2)), 30, 400, N'nhungnguoihanhphuc.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Những người hạnh phúc là câu chuyện đầy xúc cảm của Graham Greene, đưa người đọc vào hành trình khám phá hạnh phúc thực sự trong cuộc sống.', CAST(N'2024-11-10T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (67, N'Mù', N'Hermann Hesse', N'TL001', N'NXB001', CAST(80000.00 AS Decimal(18, 2)), 30, 250, N'mu.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Mù của Hermann Hesse là một tác phẩm cổ điển, đặt ra câu hỏi lớn về sự mù quáng trong tâm hồn con người và cách vượt qua nó.', CAST(N'2026-11-15T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (68, N'1984', N'George Orwell', N'TL002', N'NXB002', CAST(85000.00 AS Decimal(18, 2)), 40, 330, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'1984 là tiểu thuyết dystopian nổi tiếng của George Orwell, một lời cảnh báo sâu sắc về chủ nghĩa toàn trị và sự mất tự do cá nhân.', CAST(N'2024-12-05T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (69, N'Bão tố', N'J.K. Rowling', N'TL003', N'NXB003', CAST(95000.00 AS Decimal(18, 2)), 35, 450, N'baoto.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Bão tố của J.K. Rowling là câu chuyện phiêu lưu hấp dẫn, đậm chất kỳ ảo, đưa người đọc vào thế giới của những trận chiến và phép thuật.', CAST(N'2026-12-10T00:00:00.000' AS DateTime), 6)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (70, N'Kẻ giết người', N'Agatha Christie', N'TL004', N'NXB004', CAST(80000.00 AS Decimal(18, 2)), 45, 300, N'kegietnguoi.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Kẻ giết người của Agatha Christie là một câu chuyện trinh thám đầy bất ngờ, với những nút thắt ly kỳ mà chỉ bậc thầy mới tạo ra.', CAST(N'2024-12-20T00:00:00.000' AS DateTime), 7)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (71, N'Thế giới hoàn hảo', N'Albert Einstein', N'TL005', N'NXB005', CAST(100000.00 AS Decimal(18, 2)), 50, 250, N'bia.jpg', N'nhat_ky_trong_tu.pdf', N'nhat_ky_trong_tu.pdf', N'Cuốn sách này mang đến những câu chuyện đầy cảm hứng, khơi dậy niềm tin vào khả năng vượt qua thử thách của con người.', CAST(N'1941-02-20T00:00:00.000' AS DateTime), 5)
INSERT [dbo].[Sach] ([ID], [TenSach], [TacGia], [MaTheLoai], [MaNXB], [DonGia], [SoLuong], [SoTrang], [Anh], [FileSach], [FileXemThu], [GioiThieu], [ThoiGianPhatHanh], [LanXB]) VALUES (72, N'aaaa', N'a', N'TL002', N'NXB001', CAST(5.00 AS Decimal(18, 2)), NULL, 5, N'1984.jpg', N'995-cuon-theo-chieu-gio-thuviensach.vn.pdf', N'995-cuon-theo-chieu-gio-thuviensach.vn.pdf', N'a', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
SET IDENTITY_INSERT [dbo].[TheLoai] ON 

INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (1, N'Tiểu thuyết')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (2, N'Truyện ngắn')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (3, N'Sách giáo khoa')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (4, N'Sách tham khảo')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (5, N'Sách thiếu nhi')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (6, N'Sách khoa học')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (7, N'Sách lịch sử')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (8, N'Sách kinh tế')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (9, N'Sách kỹ năng sống')
INSERT [dbo].[TheLoai] ([ID], [TenTheLoai]) VALUES (10, N'Sách ngoại ngữ')
SET IDENTITY_INSERT [dbo].[TheLoai] OFF
GO
ALTER TABLE [dbo].[ChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDB.MaHDB] FOREIGN KEY([MaHDB])
REFERENCES [dbo].[HoaDonBan] ([MaHDB])
GO
ALTER TABLE [dbo].[ChiTietHDB] CHECK CONSTRAINT [FK_ChiTietHDB.MaHDB]
GO
ALTER TABLE [dbo].[ChiTietHDB]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHDB.MaSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[ChiTietHDB] CHECK CONSTRAINT [FK_ChiTietHDB.MaSach]
GO
ALTER TABLE [dbo].[GioHang]  WITH CHECK ADD  CONSTRAINT [FK_GioHang.MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[GioHang] CHECK CONSTRAINT [FK_GioHang.MaKH]
GO
ALTER TABLE [dbo].[GioSanPham]  WITH CHECK ADD  CONSTRAINT [FK_GioSanPham.MaGH] FOREIGN KEY([MaGH])
REFERENCES [dbo].[GioHang] ([MaGH])
GO
ALTER TABLE [dbo].[GioSanPham] CHECK CONSTRAINT [FK_GioSanPham.MaGH]
GO
ALTER TABLE [dbo].[GioSanPham]  WITH CHECK ADD  CONSTRAINT [FK_GioSanPham.MaSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[GioSanPham] CHECK CONSTRAINT [FK_GioSanPham.MaSach]
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan.MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan.MaKH]
GO
ALTER TABLE [dbo].[HoaDonBan]  WITH CHECK ADD  CONSTRAINT [FK_HoaDonBan.MaNV] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDonBan] CHECK CONSTRAINT [FK_HoaDonBan.MaNV]
GO
ALTER TABLE [dbo].[KhuyenMai]  WITH CHECK ADD  CONSTRAINT [FK_KhuyenMai.MaSach] FOREIGN KEY([MaSach])
REFERENCES [dbo].[Sach] ([MaSach])
GO
ALTER TABLE [dbo].[KhuyenMai] CHECK CONSTRAINT [FK_KhuyenMai.MaSach]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD FOREIGN KEY([MaCa])
REFERENCES [dbo].[CaLamViec] ([MaCa])
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach.MaNXB] FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NhaXuatBan] ([MaNXB])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach.MaNXB]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach.MaTheLoai] FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach.MaTheLoai]
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD CHECK  (([NamLamViec]>=(2000)))
GO
ALTER TABLE [dbo].[PhanCong]  WITH CHECK ADD CHECK  (([ThangLamViec]>=(1) AND [ThangLamViec]<=(12)))
GO
