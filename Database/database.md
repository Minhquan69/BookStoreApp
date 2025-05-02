## CSDL - Hệ thống quản lý nhà sách (BookStoreApp)

### I. Mục đích và chức năng tổng thể

Cơ sở dữ liệu (CSDL) được thiết kế nhằm phục vụ quản lý toàn bộ hoạt động kinh doanh sách trong hệ thống BookStoreApp, bao gồm:

* Quản lý thông tin sách, thể loại, nhà xuất bản.
* Quản lý khách hàng và giỏ hàng.
* Quản lý nhân viên, phân công lịch làm việc theo ca.
* Quản lý hóa đơn bán hàng, chi tiết sản phẩm trong từng hóa đơn.
* Quản lý khuyến mãi theo từng đầu sách.

### II. Mô tả chi tiết các bảng

#### 1. `Sach`

* Quản lý thông tin chi tiết về sách: tên sách, tác giả, thể loại, giá, số lượng, file tài liệu đi kèm...
* Khóa chính: `MaSach`
* Khóa ngoại: `MaTheLoai`, `MaNXB`

#### 2. `TheLoai`

* Lưu thông tin các thể loại sách.
* Khóa chính: `MaTheLoai`

#### 3. `NhaXuatBan`

* Thông tin nhà xuất bản: tên NXB.
* Khóa chính: `MaNXB`

#### 4. `KhachHang`

* Thông tin khách hàng: tên, giới tính, địa chỉ, số điện thoại...
* Khóa chính: `MaKH`

#### 5. `NhanVien`

* Thông tin nhân viên: tên, giới tính, số điện thoại, ngày vào làm...
* Khóa chính: `MaNV`

#### 6. `CaLamViec`

* Thông tin về ca làm việc: tên ca, giờ bắt đầu - kết thúc.
* Khóa chính: `MaCa`

#### 7. `PhanCong`

* Lưu phân công ca làm việc theo tháng/năm.
* Khóa chính: `MaPhanCong`
* Khóa ngoại: `MaNV`, `MaCa`

#### 8. `GioHang`

* Quản lý giỏ hàng theo từng khách hàng.
* Khóa chính: `MaGH`
* Khóa ngoại: `MaKH`

#### 9. `GioSanPham`

* Chi tiết các sản phẩm trong giỏ hàng.
* Không có khóa chính rõ ràng (nên thiết kế khóa chính ghép `MaGH`, `MaSach`).
* Khóa ngoại: `MaGH`, `MaSach`

#### 10. `HoaDonBan`

* Quản lý các hóa đơn bán sách.
* Khóa chính: `MaHDB`
* Khóa ngoại: `MaNV`, `MaKH`

#### 11. `ChiTietHDB`

* Danh sách sản phẩm và số lượng từng sản phẩm trong hóa đơn.
* Không có khóa chính rõ ràng (nên thiết kế khóa chính ghép `MaHDB`, `MaSach`).
* Khóa ngoại: `MaHDB`, `MaSach`

#### 12. `KhuyenMai`

* Quản lý các chương trình khuyến mãi theo từng sách và thời gian.
* Không có khóa chính rõ ràng (nên thêm cột ID hoặc ghép `MaSach` + `ThoiGianBatDau`).

### III. Quan hệ giữa các bảng

* `Sach` liên kết với `TheLoai` qua `MaTheLoai`, với `NhaXuatBan` qua `MaNXB`.
* `GioHang` liên kết với `KhachHang` qua `MaKH`, `GioSanPham` liên kết với `GioHang` và `Sach`.
* `HoaDonBan` liên kết với `NhanVien`, `KhachHang`, và `ChiTietHDB`.
* `ChiTietHDB` liên kết với `HoaDonBan`, `Sach`.
* `PhanCong` liên kết với `NhanVien`, `CaLamViec`.
* `KhuyenMai` liên kết với `Sach`.

### IV. Đề xuất cải tiến cho người phát triển sau

1. **Chuẩn hóa khóa chính:**

   * Nên định nghĩa khóa chính rõ ràng cho các bảng `GioSanPham`, `ChiTietHDB`, `KhuyenMai` bằng khóa ghép hoặc thêm cột `ID`.

2. **Ràng buộc toàn vẹn dữ liệu:**

   * Bổ sung các `NOT NULL`, `CHECK`, và `DEFAULT` hợp lý để đảm bảo tính toàn vẹn dữ liệu.

3. **Tối ưu hóa truy vấn:**

   * Tạo các chỉ mục phụ (index) cho các trường hay truy vấn như `TenSach`, `TenKhachHang`, `NgayBan`, `MaKH`, `MaSach`...

4. **Tách bảng người dùng chung:**

   * Xem xét tách một bảng `TaiKhoan` chung cho `NhanVien` và `KhachHang`, giúp dễ quản lý đăng nhập, phân quyền.

5. **Thêm bảng đơn vị giao hàng (nếu cần):**

   * Nếu sau này triển khai giao hàng, có thể thêm bảng `DonViGiaoHang`, `DonHang`, và theo dõi trạng thái đơn hàng.

6. **Lịch sử giao dịch và thống kê:**

   * Xây dựng bảng `LichSuThanhToan`, `BaoCaoBanHang` để phục vụ thống kê và truy vết.

7. **Tách file nhập liệu và tải lên:**

   * Đưa phần file (PDF, xem thử) trong bảng `Sach` ra bảng riêng để quản lý file hiệu quả hơn.

8. **Chuyển sang chuẩn hóa 3NF:**

   * Kiểm tra lại toàn bộ CSDL để đảm bảo không có lặp dữ liệu và phụ thuộc bắc cầu.
