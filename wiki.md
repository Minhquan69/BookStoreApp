# BookStoreApp Wiki

## Giới Thiệu
BookStoreApp là một ứng dụng quản lý bán sách trực tuyến được phát triển bằng C# Windows Forms. Ứng dụng cung cấp giải pháp toàn diện cho việc quản lý cửa hàng sách trực tuyến, từ quản lý sản phẩm đến xử lý đơn hàng và báo cáo doanh thu.

## Mục Lục
- [Tính Năng](#tính-năng)
- [Kiến Trúc](#kiến-trúc)
- [Cài Đặt](#cài-đặt)
- [Hướng Dẫn Sử Dụng](#hướng-dẫn-sử-dụng)
- [API Documentation](#api-documentation)
- [Quy Trình Phát Triển](#quy-trình-phát-triển)
- [Bảo Mật](#bảo-mật)
- [Tối Ưu Hóa](#tối-ưu-hóa)

## Tính Năng

### Cho Người Dùng
1. **Quản Lý Tài Khoản**
   - Đăng ký tài khoản mới
   - Đăng nhập/Đăng xuất
   - Cập nhật thông tin cá nhân
   - Đổi mật khẩu

2. **Mua Sắm**
   - Xem danh sách sách
   - Tìm kiếm và lọc sách
   - Xem chi tiết sách
   - Thêm vào giỏ hàng
   - Quản lý giỏ hàng
   - Thanh toán
   - Xuất hóa đơn

3. **Quản Lý Đơn Hàng**
   - Xem lịch sử mua hàng
   - Chi tiết đơn hàng
   - Xuất báo cáo lịch sử

### Cho Quản Trị Viên
1. **Quản Lý Sản Phẩm**
   - Thêm/Sửa/Xóa sách
   - Quản lý kho
   - Quản lý khuyến mãi

2. **Quản Lý Khách Hàng**
   - Xem danh sách khách hàng
   - Chi tiết khách hàng
   - Lịch sử mua hàng

3. **Báo Cáo & Thống Kê**
   - Thống kê doanh thu
   - Báo cáo chi tiêu khách hàng
   - Xuất báo cáo

## Kiến Trúc

### Cấu Trúc Thư Mục
```
BookStoreApp/
├── Classes/                 # Chứa các class cốt lõi
├── ViewNguoiMua/           # Giao diện người dùng
├── Sign/                   # Xử lý đăng nhập/đăng ký
├── System/                 # Các class hệ thống
├── Images/                 # Tài nguyên hình ảnh
├── HomeFrm.cs             # Giao diện admin
└── Resources/             # Tài nguyên khác
```

### Các Class Chính
1. **DataBaseProcess.cs**
   - Xử lý kết nối database
   - Thực thi truy vấn
   - Quản lý transaction

2. **SanPham.cs**
   - Model cho sản phẩm
   - Quản lý thông tin sách

3. **UserInfo.cs**
   - Model cho thông tin người dùng
   - Quản lý thông tin khách hàng

4. **DanhSachSanPham.cs**
   - Quản lý danh sách sản phẩm
   - Xử lý tìm kiếm và lọc

## Cài Đặt

### Yêu Cầu Hệ Thống
- Windows 10 trở lên
- .NET Framework 4.7.2
- SQL Server 2019
- Visual Studio 2019 trở lên

### Các Bước Cài Đặt
1. Clone repository:
```bash
git clone https://github.com/Minhquan69/BookStoreApp.git
```

2. Khôi phục database:
- Mở SQL Server Management Studio
- Restore file backup từ thư mục Database

3. Cấu hình connection string:
- Mở file App.config
- Cập nhật connection string phù hợp

4. Build và chạy ứng dụng:
- Mở solution trong Visual Studio
- Build solution
- Chạy ứng dụng

## Hướng Dẫn Sử Dụng

### Đăng Nhập
1. Mở ứng dụng
2. Nhập số điện thoại và mật khẩu
3. Chọn "Đăng Nhập"

### Mua Hàng
1. Xem danh sách sách
2. Chọn sách muốn mua
3. Thêm vào giỏ hàng
4. Kiểm tra giỏ hàng
5. Thanh toán

### Quản Lý Đơn Hàng
1. Vào mục "Lịch Sử Mua Hàng"
2. Xem danh sách đơn hàng
3. Chọn đơn hàng để xem chi tiết

## API Documentation

### Database Schema

#### Bảng KhachHang
```sql
CREATE TABLE [dbo].[KhachHang](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [MaKH] AS ('KH'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
    [TenKhachHang] [nvarchar](50) NULL,
    [GioiTinh] [nvarchar](5) NULL,
    [DiaChi] [nvarchar](150) NULL,
    [NgaySinh] [datetime] NULL,
    [SDT] [varchar](10) NULL,
    [Anh] [nvarchar](200) NULL,
    [MatKhau] [nvarchar](20) NULL,
    PRIMARY KEY ([MaKH])
)
```

#### Bảng Sach
```sql
CREATE TABLE [dbo].[Sach](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [MaSach] AS ('S'+right('0000'+CONVERT([varchar],[Id]),(4))) PERSISTED NOT NULL,
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
    PRIMARY KEY ([MaSach])
)
```

#### Bảng HoaDonBan
```sql
CREATE TABLE [dbo].[HoaDonBan](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [MaHDB] AS ('HDB'+right('0000'+CONVERT([varchar],[Id]),(4))) PERSISTED NOT NULL,
    [MaNV] [varchar](5) NULL,
    [MaKH] [varchar](5) NULL,
    [Ngayban] [datetime] NULL,
    [TongTien] [decimal](10, 2) NULL,
    [PhuongThucThanhToan] [nvarchar](100) NULL,
    PRIMARY KEY ([MaHDB])
)
```

#### Bảng ChiTietHDB
```sql
CREATE TABLE [dbo].[ChiTietHDB](
    [MaHDB] [varchar](7) NULL,
    [MaSach] [varchar](5) NULL,
    [SoLuong] [int] NULL,
    [KhuyenMai] [decimal](10, 2) NULL
)
```

#### Bảng GioHang
```sql
CREATE TABLE [dbo].[GioHang](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [MaGH] AS ('GH'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
    [MaKH] [varchar](5) NULL,
    [TongSanPham] [int] NULL,
    PRIMARY KEY ([MaGH])
)
```

#### Bảng GioSanPham
```sql
CREATE TABLE [dbo].[GioSanPham](
    [MaGH] [varchar](5) NULL,
    [MaSach] [varchar](5) NULL,
    [SoLuong] [int] NULL
)
```

#### Bảng KhuyenMai
```sql
CREATE TABLE [dbo].[KhuyenMai](
    [MaSach] [varchar](5) NULL,
    [ThoigianBatDau] [datetime] NULL,
    [ThoiGianKetThuc] [datetime] NULL,
    [KM] [decimal](18, 2) NULL
)
```

#### Bảng NhanVien
```sql
CREATE TABLE [dbo].[NhanVien](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [MaNV] AS ('NV'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
    [TenNhanVien] [nvarchar](50) NULL,
    [GioiTinh] [nvarchar](5) NULL,
    [DiaChi] [nvarchar](150) NULL,
    [NgaySinh] [datetime] NULL,
    [SDT] [varchar](10) NULL,
    [NgayVaoLam] [datetime] NULL,
    [Anh] [nvarchar](200) NULL,
    [MatKhau] [nvarchar](20) NULL,
    PRIMARY KEY ([MaNV])
)
```

#### Bảng TheLoai
```sql
CREATE TABLE [dbo].[TheLoai](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [MaTheLoai] AS ('TL'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
    [TenTheLoai] [nvarchar](100) NULL,
    PRIMARY KEY ([MaTheLoai])
)
```

#### Bảng NhaXuatBan
```sql
CREATE TABLE [dbo].[NhaXuatBan](
    [ID] [int] IDENTITY(1,1) NOT NULL,
    [MaNXB] AS ('NXB'+right('000'+CONVERT([varchar],[Id]),(3))) PERSISTED NOT NULL,
    [TenNXB] [nvarchar](100) NULL,
    PRIMARY KEY ([MaNXB])
)
```

### Các Phương Thức Chính

#### DataBaseProcess.cs
```csharp
public class DataBaseProcess
{
    // Kết nối database
    public SqlConnection GetConnection()
    
    // Thực thi truy vấn
    public DataTable DataReader(string sql)
    
    // Thực thi transaction
    public void ExecuteTransactionQuery(string query, Dictionary<string, object> parameters)
    
    // Kiểm tra tồn tại
    public bool Exist(string sql)
    
    // Thực thi câu lệnh thay đổi dữ liệu
    public int DataChange(string sql)
    
    // Thực thi scalar query
    public object ExecuteScalar(string sql)
}
```

### Các Truy Vấn Quan Trọng

#### Đăng Nhập
```sql
-- Kiểm tra đăng nhập khách hàng
SELECT * FROM KhachHang WHERE SDT = @sdt AND MatKhau = @matkhau

-- Kiểm tra đăng nhập nhân viên
SELECT * FROM NhanVien WHERE SDT = @sdt AND MatKhau = @matkhau
```

#### Quản Lý Giỏ Hàng
```sql
-- Lấy thông tin giỏ hàng
SELECT giohang.magh, giosanpham.Masach, sach.tensach, sach.tacgia, 
       sach.dongia, sach.Anh,
       CASE
           WHEN khuyenmai.Masach IS NOT NULL
                AND GETDATE() BETWEEN khuyenmai.ThoigianBatDau AND khuyenmai.ThoiGianKetThuc
           THEN khuyenmai.km
           ELSE 0
       END AS km
FROM giohang 
JOIN giosanpham ON giohang.magh = giosanpham.magh 
JOIN sach ON sach.Masach = giosanpham.Masach
LEFT JOIN khuyenmai ON sach.Masach = khuyenmai.Masach
WHERE giohang.MaKH = @userName
```

#### Tạo Đơn Hàng
```sql
-- Tạo hóa đơn mới
INSERT INTO HoaDonBan (MaNV, MaKH, Ngayban, TongTien, PhuongThucThanhToan)
VALUES (@maNV, @maKH, GETDATE(), @tongTien, @phuongThuc)

-- Thêm chi tiết hóa đơn
INSERT INTO ChiTietHDB (MaHDB, MaSach, SoLuong, KhuyenMai)
VALUES (@maHDB, @maSach, @soLuong, @khuyenMai)
```

## Quy Trình Phát Triển

### Quy Ước Code
1. **Đặt Tên**
   - PascalCase cho class và method
   - camelCase cho biến
   - UPPER_CASE cho hằng số

2. **Comment**
   - Sử dụng XML documentation
   - Comment cho các method phức tạp
   - Mô tả rõ ràng các tham số

3. **Exception Handling**
   - Sử dụng try-catch
   - Log lỗi
   - Thông báo người dùng

### Quy Trình Git
1. **Branch**
   - main: code production
   - develop: code development
   - feature/*: tính năng mới
   - bugfix/*: sửa lỗi

2. **Commit Message**
   - feat: tính năng mới
   - fix: sửa lỗi
   - docs: cập nhật tài liệu
   - style: định dạng code
   - refactor: tái cấu trúc

## Bảo Mật

### Xác Thực
- Mật khẩu được mã hóa
- Kiểm tra session
- Phân quyền người dùng

### Dữ Liệu
- Sử dụng parameterized queries
- Validate input
- Backup dữ liệu định kỳ

## Tối Ưu Hóa

### Performance
1. **Database**
   - Index cho các cột tìm kiếm
   - Tối ưu query
   - Connection pooling

2. **UI**
   - Lazy loading
   - Caching
   - Async operations

### Code
1. **Clean Code**
   - SOLID principles
   - DRY principle
   - KISS principle

2. **Testing**
   - Unit test
   - Integration test
   - UI test

## Đóng Góp
Chúng tôi rất hoan nghênh mọi đóng góp từ cộng đồng. Vui lòng:
1. Fork repository
2. Tạo branch mới
3. Commit thay đổi
4. Push lên branch
5. Tạo Pull Request

## Liên Hệ
- Email: your-email@example.com
- GitHub: [your-username](https://github.com/your-username)
- Website: [your-website.com](https://your-website.com)

## License
MIT License - Xem file [LICENSE](LICENSE) để biết thêm chi tiết. 