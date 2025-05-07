# BookStoreApp

## Giới Thiệu Về App

**BookStoreApp** là một ứng dụng quản lý bán sách được phát triển để hỗ trợ quản trị viên và người dùng trong việc quản lý sách, đơn hàng và giao dịch. Với một giao diện người dùng thân thiện và dễ sử dụng, **BookStoreApp** cung cấp các tính năng quản lý hiệu quả cho các cửa hàng bán sách trực tuyến. Người dùng có thể dễ dàng tìm kiếm sách, xem chi tiết, và thực hiện giao dịch, trong khi quản trị viên có thể theo dõi thông tin sản phẩm, đơn hàng và khách hàng.

## Screenshots

![Screenshot 1](path_to_screenshot_1.png)
*Giao diện chính của ứng dụng*

![Screenshot 2](path_to_screenshot_2.png)
*Trang quản lý sản phẩm cho quản trị viên*

![Screenshot 3](path_to_screenshot_3.png)
*Trang giỏ hàng của người dùng*

## Tính Năng Nổi Bật

### Đối Với Admin:

* **Quản lý sản phẩm**: Thêm, sửa, xóa sách trong cửa hàng.
* **Quản lý đơn hàng**: Theo dõi đơn hàng của khách hàng và trạng thái giao hàng.
* **Quản lý khách hàng**: Quản lý thông tin người dùng và các giao dịch của họ.
* **Báo cáo doanh thu**: Xem báo cáo tổng quan về doanh thu theo thời gian.

### Đối Với Người Dùng:

* **Duyệt sách**: Dễ dàng tìm kiếm và duyệt qua các thể loại sách khác nhau.
* **Giỏ hàng**: Thêm sách vào giỏ hàng và thực hiện thanh toán dễ dàng.
* **Xem chi tiết sách**: Xem thông tin chi tiết, đánh giá và các thông tin bổ sung về sách.
* **Đánh giá và nhận xét**: Để lại nhận xét và đánh giá cho các sách đã mua.

## Công Nghệ Nền Tảng

* **Ngôn ngữ lập trình**: C#, WinForms
* **Cơ sở dữ liệu**: SQL Server (hoặc tùy chỉnh nếu có)
* **Thư viện**: Guna.UI2 (Để tạo giao diện người dùng hiện đại)
* **Web API**: (Nếu có, sẽ dùng ASP.NET Core)
* **Quản lý mã nguồn**: Git (và GitHub)

## Hướng Dẫn Cài Đặt Dự Án

### Cài Đặt Yêu Cầu:

1. **Visual Studio 2022** hoặc phiên bản mới hơn.
2. **.NET Framework 4.7.2** trở lên.
3. **SQL Server** hoặc bất kỳ cơ sở dữ liệu tương thích nào (nếu sử dụng cơ sở dữ liệu khác).
4. **Cài đặt Guna.UI2**: Sử dụng NuGet Package Manager trong Visual Studio để cài đặt Guna.UI2.

### Cài Đặt Dự Án:

1. **Clone dự án từ GitHub**:

   ```bash
   git clone https://github.com/username/BookStoreApp.git
   ```

2. **Mở dự án trong Visual Studio**:

   * Mở `BookStoreApp.sln` trong Visual Studio.

3. **Cài đặt các thư viện phụ thuộc**:

   * Mở **NuGet Package Manager** trong Visual Studio và cài đặt các gói phụ thuộc nếu chưa cài.
   * Cài đặt `Guna.UI2` qua NuGet:

     ```bash
     Install-Package Guna.UI2
     ```

4. **Cấu hình Cơ Sở Dữ Liệu**:

   * Tạo cơ sở dữ liệu trong SQL Server.
   * Cập nhật chuỗi kết nối trong tệp `App.config`:

     ```xml
     <connectionStrings>
       <add name="DbConnection" connectionString="Data Source=SERVER_NAME;Initial Catalog=BookStoreDb;Integrated Security=True" providerName="System.Data.SqlClient" />
     </connectionStrings>
     ```

5. **Chạy Ứng Dụng**:

   * Sau khi cài đặt và cấu hình xong, bạn có thể chạy ứng dụng từ Visual Studio.
   * Đảm bảo rằng cơ sở dữ liệu đã được khởi tạo đúng cách trước khi chạy ứng dụng.

### Cấu Hình và Tùy Chỉnh:

* Bạn có thể thay đổi các giá trị trong file cấu hình `App.config` để tùy chỉnh ứng dụng theo yêu cầu của bạn.

## Đóng Góp

Nếu bạn muốn đóng góp vào dự án, hãy tạo một pull request với các thay đổi của bạn. Đảm bảo rằng bạn đã kiểm tra kỹ mã nguồn và ứng dụng trước khi gửi pull request.

---

Hy vọng mẫu README trên sẽ giúp bạn xây dựng một tài liệu chi tiết và đầy đủ cho dự án **BookStoreApp** của mình. Nếu cần thêm hỗ trợ, đừng ngần ngại yêu cầu!
