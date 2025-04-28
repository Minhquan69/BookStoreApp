# Tài liệu Cơ sở dữ liệu - BookStoreApp

## 1. Tổng quan
Cơ sở dữ liệu BookStoreApp được thiết kế để quản lý hệ thống bán sách trực tuyến, bao gồm quản lý sản phẩm, tài khoản người dùng, đơn hàng, khuyến mãi và đánh giá của khách hàng.

## 2. Các bảng dữ liệu

### Bảng chính

| Tên bảng | Mục đích | Cột chính |
|----------|----------|-----------|
| `SanPham` | Lưu thông tin sản phẩm (sách) | `MaSanPham`, `TenSanPham`, `GiaCa`, `TonKho`, `PhanLoai` |
| `NguoiDung` | Quản lý tài khoản khách hàng | `MaNguoiDung`, `TenNguoiDung`, `MatKhau`, `SDT`, `Email` |
| `NhanVien` | Quản lý tài khoản nhân viên | `MaNV`, `TenNhanVien`, `MatKhau`, `NgayVaoLam` |
| `HoaDonBan` | Lưu thông tin đơn hàng | `MaHDB`, `MaNV`, `MaNguoiDung`, `Ngayban`, `TongTien` |
| `ChiTietHDB` | Lưu chi tiết đơn hàng (sản phẩm trong mỗi đơn) | `MaHDB`, `MaSanPham`, `SoLuong`, `ThanhTien` |

### Bảng hỗ trợ

| Tên bảng | Mục đích | Cột chính |
|----------|----------|-----------|
| `GioHang` | Quản lý giỏ hàng | `MaGH`, `MaNguoiDung`, `TongSanPham` |
| `GioSanPham` | Theo dõi sản phẩm trong giỏ hàng | `MaGH`, `MaSanPham`, `SoLuong` |
| `KhuyenMai` | Quản lý chương trình khuyến mãi/giảm giá | `MaKM`, `TenKM`, `KM`, `SoTienKM` |
| `KhuyenMaiMM` | Bảng khuyến mãi bổ sung | `MaKM`, `TenKM`, `TrangThai` |
| `SanPhamKM` | Liên kết sản phẩm với khuyến mãi | `MaSanPham`, `MaKM`, `TGBatDau`, `TGKetThuc` |
| `KMNguoiDung` | Liên kết người dùng với khuyến mãi | `MaNguoiDung`, `MaKM`, `TGBatDau`, `TGKetThuc` |
| `DanhGia` | Lưu đánh giá sản phẩm | `MaDG`, `MaKH`, `MaSach`, `Rating`, `NhanXet` |

## 3. Mối quan hệ giữa các bảng

### Mối quan hệ chính:
- **NguoiDung - HoaDonBan**: Một-nhiều (Một khách hàng có thể có nhiều đơn hàng)
- **HoaDonBan - ChiTietHDB**: Một-nhiều (Một đơn hàng có thể chứa nhiều sản phẩm)
- **SanPham - ChiTietHDB**: Một-nhiều (Một sản phẩm có thể xuất hiện trong nhiều chi tiết đơn hàng)
- **NguoiDung - GioHang**: Một-một (Mỗi người dùng có một giỏ hàng)
- **GioHang - GioSanPham**: Một-nhiều (Một giỏ hàng có thể chứa nhiều sản phẩm)

### Mối quan hệ khuyến mãi:
- **KhuyenMai - SanPhamKM**: Một-nhiều (Một khuyến mãi có thể áp dụng cho nhiều sản phẩm)
- **KhuyenMaiMM - KMNguoiDung**: Một-nhiều (Một khuyến mãi có thể áp dụng cho nhiều người dùng)
- **SanPham - SanPhamKM**: Nhiều-nhiều (Sản phẩm có thể có nhiều khuyến mãi)
- **NguoiDung - KMNguoiDung**: Nhiều-nhiều (Người dùng có thể có nhiều khuyến mãi)

## 4. Tính năng chính

### Quản lý sản phẩm:
- Sản phẩm được phân loại bằng `PhanLoai`
- Theo dõi tồn kho với `TonKho`
- Hình ảnh sản phẩm lưu trong cột `Anh`
- Mô tả chi tiết trong cột `MoTa`

### Xử lý đơn hàng:
- Theo dõi đơn hàng đầy đủ với ngày tháng và tổng tiền
- Hỗ trợ giảm giá (`GiamGia` trong ChiTietHDB)
- Các trường tính toán `ThanhTien` (tổng mỗi mục) và `TongTien` (tổng đơn hàng)

### Hệ thống người dùng:
- Bảng riêng cho khách hàng (`NguoiDung`) và nhân viên (`NhanVien`)
- Lưu trữ mật khẩu (hiện đang lưu dạng plaintext - nên mã hóa)
- Thông tin hồ sơ người dùng (địa chỉ, điện thoại, ngày sinh)

### Hệ thống khuyến mãi:
- Nhiều loại khuyến mãi (giảm giá % hoặc số tiền cố định)
- Khuyến mãi có thời hạn với ngày bắt đầu/kết thúc
- Theo dõi khuyến mãi theo sản phẩm hoặc người dùng

### Hệ thống đánh giá:
- Hệ thống xếp hạng 5 sao (`Rating` từ 1-5)
- Đánh giá bằng văn bản trong cột `NhanXet`
- Đánh giá có gắn thời gian (`ThoiGianDG`)

## 5. Dữ liệu mẫu

Cơ sở dữ liệu bao gồm dữ liệu mẫu cho:
- 16 sản phẩm (sách)
- 10 khách hàng
- 10 nhân viên
- 20 đơn hàng với các mục chi tiết
- 10 chương trình khuyến mãi đang hoạt động
- Dữ liệu giỏ hàng cho tất cả khách hàng
- Đánh giá sản phẩm

## 6. Lưu ý bảo mật

**Quan trọng**: Hiện tại mật khẩu được lưu dạng plaintext (có thể thấy trong `NguoiDung.MatKhau` và `NhanVien.MatKhau`). Đối với môi trường production, cần:
1. Lưu hash mật khẩu thay vì plaintext
2. Triển khai hash mật khẩu đúng cách (bcrypt, PBKDF2, v.v.)
3. Thêm salt vào hash mật khẩu
4. Xem xét yêu cầu độ phức tạp của mật khẩu

## 7. Cải tiến đề xuất

1. **Bảo mật mật khẩu**: Triển khai hash mật khẩu đúng cách
2. **Vai trò người dùng**: Thêm kiểm soát truy cập dựa trên vai trò
3. **Trạng thái đơn hàng**: Thêm theo dõi trạng thái (Đang xử lý, Đã giao, v.v.)
4. **Quản lý địa chỉ**: Bảng riêng cho địa chỉ giao hàng
5. **Ghi nhật ký kiểm toán**: Theo dõi thay đổi dữ liệu nhạy cảm
6. **Xóa mềm**: Triển khai thay vì xóa vật lý
7. **Đánh chỉ mục**: Thêm chỉ mục cho các cột thường được truy vấn

Cơ sở dữ liệu này cung cấp nền tảng vững chắc cho ứng dụng bán sách trực tuyến với khả năng mở rộng để hỗ trợ các yêu cầu kinh doanh phức tạp hơn.