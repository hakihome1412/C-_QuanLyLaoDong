USE [master]
GO
/****** Object:  Database [QLLaoDong]    Script Date: 12/2/2020 6:33:58 AM ******/
CREATE DATABASE [QLLaoDong]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLLaoDong', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLLaoDong.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLLaoDong_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QLLaoDong_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLLaoDong] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLLaoDong].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLLaoDong] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLLaoDong] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLLaoDong] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLLaoDong] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLLaoDong] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLLaoDong] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLLaoDong] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLLaoDong] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLLaoDong] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLLaoDong] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLLaoDong] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLLaoDong] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLLaoDong] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLLaoDong] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLLaoDong] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLLaoDong] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLLaoDong] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLLaoDong] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLLaoDong] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLLaoDong] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLLaoDong] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLLaoDong] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLLaoDong] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLLaoDong] SET  MULTI_USER 
GO
ALTER DATABASE [QLLaoDong] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLLaoDong] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLLaoDong] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLLaoDong] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLLaoDong] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLLaoDong]
GO
/****** Object:  Table [dbo].[CongTrinh]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongTrinh](
	[idCongTrinh] [nvarchar](50) NOT NULL,
	[tenCongTrinh] [nvarchar](200) NOT NULL,
	[diaChi] [nvarchar](200) NOT NULL,
	[ngayBatDau] [datetime] NOT NULL,
	[ngayKetThucDuKien] [datetime] NOT NULL,
	[ngayHoanThanh] [datetime] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
	[isDelete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCongTrinh] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CongViec]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CongViec](
	[idCongViec] [nvarchar](50) NOT NULL,
	[tenCongViec] [nvarchar](200) NOT NULL,
	[isDelete] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCongViec] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhSachChamCong]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachChamCong](
	[idChamCong] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [nvarchar](50) NOT NULL,
	[idPhanCong] [int] NOT NULL,
	[ngayChamcong] [date] NOT NULL,
	[trangThaiChamCong] [int] NOT NULL,
 CONSTRAINT [PK_DanhSachChamCong] PRIMARY KEY CLUSTERED 
(
	[idChamCong] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhSachCongViecCongTrinh]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachCongViecCongTrinh](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idCongTrinh] [nvarchar](50) NOT NULL,
	[idCongViec] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DanhSachPhanCong]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhSachPhanCong](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idNhanVien] [nvarchar](50) NOT NULL,
	[idDSCongViecCongTrinh] [int] NOT NULL,
	[ngayPhanCong] [datetime] NOT NULL,
	[ngayBatDau] [datetime] NOT NULL,
	[ngayKetThuc] [datetime] NOT NULL,
 CONSTRAINT [PK__DanhSach__3213E83FBA7C3F26] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[idNhanVien] [nvarchar](50) NOT NULL,
	[tenNhanVien] [nvarchar](200) NOT NULL,
	[diaChi] [nvarchar](200) NOT NULL,
	[sdt] [nvarchar](50) NOT NULL,
	[chucVu] [int] NOT NULL,
	[idPhongBan] [nvarchar](50) NOT NULL,
	[isDelete] [bit] NOT NULL,
 CONSTRAINT [PK__NhanVien__214E82585872DF71] PRIMARY KEY CLUSTERED 
(
	[idNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[idPhongBan] [nvarchar](50) NOT NULL,
	[tenPhongBan] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idPhongBan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 12/2/2020 6:33:58 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[idTaiKhoan] [nvarchar](50) NOT NULL,
	[matKhau] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idTaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[CongTrinh] ([idCongTrinh], [tenCongTrinh], [diaChi], [ngayBatDau], [ngayKetThucDuKien], [ngayHoanThanh], [trangThai], [isDelete]) VALUES (N'CT0001', N'Chung cư Gia Phú', N'234 Thoại Ngọc Hầu', CAST(N'2020-10-10 00:00:00.000' AS DateTime), CAST(N'2021-10-10 00:00:00.000' AS DateTime), CAST(N'1900-01-01 00:00:00.000' AS DateTime), N'Đang Thực Hiện', 0)
INSERT [dbo].[CongTrinh] ([idCongTrinh], [tenCongTrinh], [diaChi], [ngayBatDau], [ngayKetThucDuKien], [ngayHoanThanh], [trangThai], [isDelete]) VALUES (N'CT0002', N'VinMart+ Thảo Điền', N'11 Thảo Điền', CAST(N'2020-11-08 00:00:00.000' AS DateTime), CAST(N'2020-12-08 00:00:00.000' AS DateTime), CAST(N'1900-01-01 00:00:00.000' AS DateTime), N'Đang Thực Hiện', 0)
INSERT [dbo].[CongTrinh] ([idCongTrinh], [tenCongTrinh], [diaChi], [ngayBatDau], [ngayKetThucDuKien], [ngayHoanThanh], [trangThai], [isDelete]) VALUES (N'CT0003', N'Vinhome Grand Park', N'Nguyễn Xiển, Quận 9', CAST(N'2020-12-01 00:00:00.000' AS DateTime), CAST(N'2022-08-12 00:00:00.000' AS DateTime), CAST(N'1900-01-01 00:00:00.000' AS DateTime), N'Đang Thực Hiện', 0)
INSERT [dbo].[CongViec] ([idCongViec], [tenCongViec], [isDelete]) VALUES (N'CV0001', N'Lao công', 0)
INSERT [dbo].[CongViec] ([idCongViec], [tenCongViec], [isDelete]) VALUES (N'CV0002', N'Thợ sơn nước', 0)
INSERT [dbo].[CongViec] ([idCongViec], [tenCongViec], [isDelete]) VALUES (N'CV0003', N'Thiết kế bản vẽ', 0)
INSERT [dbo].[CongViec] ([idCongViec], [tenCongViec], [isDelete]) VALUES (N'CV0004', N'Thiết kế nội thất', 0)
INSERT [dbo].[CongViec] ([idCongViec], [tenCongViec], [isDelete]) VALUES (N'CV0005', N'Thợ phụ', 0)
INSERT [dbo].[CongViec] ([idCongViec], [tenCongViec], [isDelete]) VALUES (N'CV0006', N'Thầu', 0)
INSERT [dbo].[CongViec] ([idCongViec], [tenCongViec], [isDelete]) VALUES (N'CV0007', N'Chuyên viên giám sát', 0)

SET IDENTITY_INSERT [dbo].[DanhSachCongViecCongTrinh] ON 

INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (1, N'CT0001', N'CV0001')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (2, N'CT0001', N'CV0002')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (3, N'CT0001', N'CV0003')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (4, N'CT0001', N'CV0004')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (5, N'CT0001', N'CV0005')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (6, N'CT0001', N'CV0006')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (7, N'CT0002', N'CV0001')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (8, N'CT0002', N'CV0002')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (9, N'CT0002', N'CV0003')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (10, N'CT0003', N'CV0001')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (11, N'CT0003', N'CV0002')
INSERT [dbo].[DanhSachCongViecCongTrinh] ([id], [idCongTrinh], [idCongViec]) VALUES (12, N'CT0003', N'CV0003')
SET IDENTITY_INSERT [dbo].[DanhSachCongViecCongTrinh] OFF

INSERT [dbo].[NhanVien] ([idNhanVien], [tenNhanVien], [diaChi], [sdt], [chucVu], [idPhongBan], [isDelete]) VALUES (N'NV0001', N'Huỳnh Phúc Huy', N'12 Ny Sư Huỳnh Liên', N'0988772999', 0, N'PB0001', 0)
INSERT [dbo].[NhanVien] ([idNhanVien], [tenNhanVien], [diaChi], [sdt], [chucVu], [idPhongBan], [isDelete]) VALUES (N'NV0002', N'Trần Trung Hào', N'162 Nguyễn Thái Sơn', N'0938910451', 0, N'PB0003', 0)
INSERT [dbo].[NhanVien] ([idNhanVien], [tenNhanVien], [diaChi], [sdt], [chucVu], [idPhongBan], [isDelete]) VALUES (N'NV0003', N'Nguyễn Hồng Quang', N'888 Quang Trung', N'0938884761', 1, N'PB0001', 0)
INSERT [dbo].[NhanVien] ([idNhanVien], [tenNhanVien], [diaChi], [sdt], [chucVu], [idPhongBan], [isDelete]) VALUES (N'NV0004', N'Đào Anh Duy', N'98 Thống Nhất', N'0977444555', 1, N'PB0003', 0)
INSERT [dbo].[NhanVien] ([idNhanVien], [tenNhanVien], [diaChi], [sdt], [chucVu], [idPhongBan], [isDelete]) VALUES (N'NV0005', N'Nguyễn Hoàng Anh Thư', N'281 Đình Phong Phú', N'0755727208', 0, N'PB0001', 0)
INSERT [dbo].[NhanVien] ([idNhanVien], [tenNhanVien], [diaChi], [sdt], [chucVu], [idPhongBan], [isDelete]) VALUES (N'NV0006', N'Huỳnh Anh khang', N'ádasd', N'12312313', 1, N'PB0002', 1)
INSERT [dbo].[NhanVien] ([idNhanVien], [tenNhanVien], [diaChi], [sdt], [chucVu], [idPhongBan], [isDelete]) VALUES (N'NV0007', N'Dao Dinh Dung', N'Ftown3 FPT Software', N'0987555444', 1, N'PB0001', 0)
INSERT [dbo].[PhongBan] ([idPhongBan], [tenPhongBan]) VALUES (N'PB0001', N'Dự án')
INSERT [dbo].[PhongBan] ([idPhongBan], [tenPhongBan]) VALUES (N'PB0002', N'Kế toán')
INSERT [dbo].[PhongBan] ([idPhongBan], [tenPhongBan]) VALUES (N'PB0003', N'Kinh doanh')
INSERT [dbo].[PhongBan] ([idPhongBan], [tenPhongBan]) VALUES (N'PB0004', N'Kĩ thuật')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [matKhau]) VALUES (N'NV0001', N'123')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [matKhau]) VALUES (N'NV0002', N'123')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [matKhau]) VALUES (N'NV0003', N'456')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [matKhau]) VALUES (N'NV0004', N'123')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [matKhau]) VALUES (N'NV0005', N'123')
INSERT [dbo].[TaiKhoan] ([idTaiKhoan], [matKhau]) VALUES (N'NV0006', N'123')
ALTER TABLE [dbo].[DanhSachChamCong]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachChamCong_DanhSachPhanCong] FOREIGN KEY([idPhanCong])
REFERENCES [dbo].[DanhSachPhanCong] ([id])
GO
ALTER TABLE [dbo].[DanhSachChamCong] CHECK CONSTRAINT [FK_DanhSachChamCong_DanhSachPhanCong]
GO
ALTER TABLE [dbo].[DanhSachChamCong]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachChamCong_NhanVien] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[DanhSachChamCong] CHECK CONSTRAINT [FK_DanhSachChamCong_NhanVien]
GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongTrinh] FOREIGN KEY([idCongTrinh])
REFERENCES [dbo].[CongTrinh] ([idCongTrinh])
GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh] CHECK CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongTrinh]
GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongViec] FOREIGN KEY([idCongViec])
REFERENCES [dbo].[CongViec] ([idCongViec])
GO
ALTER TABLE [dbo].[DanhSachCongViecCongTrinh] CHECK CONSTRAINT [FK_DanhSachCongViecCongTrinh_CongViec]
GO
ALTER TABLE [dbo].[DanhSachPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhanCong_DanhSachCongViecCongTrinh] FOREIGN KEY([idDSCongViecCongTrinh])
REFERENCES [dbo].[DanhSachCongViecCongTrinh] ([id])
GO
ALTER TABLE [dbo].[DanhSachPhanCong] CHECK CONSTRAINT [FK_DanhSachPhanCong_DanhSachCongViecCongTrinh]
GO
ALTER TABLE [dbo].[DanhSachPhanCong]  WITH CHECK ADD  CONSTRAINT [FK_DanhSachPhanCong_NhanVien] FOREIGN KEY([idNhanVien])
REFERENCES [dbo].[NhanVien] ([idNhanVien])
GO
ALTER TABLE [dbo].[DanhSachPhanCong] CHECK CONSTRAINT [FK_DanhSachPhanCong_NhanVien]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([idPhongBan])
REFERENCES [dbo].[PhongBan] ([idPhongBan])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
USE [master]
GO
ALTER DATABASE [QLLaoDong] SET  READ_WRITE 
GO
