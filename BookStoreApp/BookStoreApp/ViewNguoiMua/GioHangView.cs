using BookStoreApp.Classes;
using BookStoreApp.Sign;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BookStoreApp.ViewNguoiMua
{
    public partial class GioHangView : UserControl
    {
        private string userName = SignIn.userName;
        private readonly DataBaseProcess db = new DataBaseProcess();
        private decimal totalPrice = 0; // Tổng tiền
        private int totalItems = 0; // Số mặt hàng (theo ID sản phẩm)
        private List<string> selectedMasach = new List<string>();


        public GioHangView()
        {
            InitializeComponent();
            LoadGioHang();
        
        }

        // Hàm Load Giỏ Hàng
        public void LoadGioHang()
        {
            try
            {
                // Truy vấn dữ liệu giỏ hàng
                string query = @"
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
                        WHERE giohang.MaKH = @userName";

                var parameters = new Dictionary<string, object>
                    {
                        { "@userName", userName }
                    };

                DataTable cartData = db.DataRead(query, parameters);

                string imagePath = System.Windows.Forms.Application.StartupPath + "\\AnhSP";


                panelChuaCacSanPham.AutoScroll = true;
                panelChuaCacSanPham.Controls.Clear();

                if (cartData.Rows.Count == 0)
                {
                    MessageBox.Show("Không có sản phẩm trong giỏ hàng!");
                    return;
                }

                int yOffset = 10;
                foreach (DataRow row in cartData.Rows)
                {
                    Panel panelSanPham = CreateSanPhamPanel(row, imagePath, yOffset);
                    panelChuaCacSanPham.Controls.Add(panelSanPham);
                    yOffset += panelSanPham.Height + 10;
                }

                panelChuaCacSanPham.AutoScrollMinSize = new Size(panelChuaCacSanPham.Width, yOffset);
                panelChuaCacSanPham.Height = Math.Min(yOffset, 300);

                ValidateInputsAndCalculate(); // Cập nhật tổng tiền
                UpdateTotalItems();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải giỏ hàng: " + ex.Message);
            }
        }

        private Panel CreateSanPhamPanel(DataRow row, string imagePath, int yOffset)
        {
            int panelWidth = panelChuaCacSanPham.Width - 25;

            Panel panelSanPham = new Panel
            {
                Width = panelWidth,
                Height = 150,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(10, yOffset)
            };

            // CheckBox
            CheckBox checkBox = new CheckBox
            {
                Location = new Point(10, 120),
                Text = "Chọn sản phẩm"
            };
            checkBox.CheckedChanged += (sender, e) => ValidateInputsAndCalculate();

            // PictureBox
            PictureBox pictureBox = new PictureBox
            {
                Width = 100,
                Height = 100,
                Location = new Point(10, 10),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = LoadProductImage(row["Anh"], imagePath)
            };

            decimal donGia = Convert.ToDecimal(row["dongia"]);
            decimal tyLeKM = Convert.ToDecimal(row["KM"]);
            decimal giaGiam = donGia - (donGia * tyLeKM / 100);

            // Labels
            Label lblTenSach = CreateLabel($"Tên sách: {row["tensach"]}", new Point(120, 10));
            Label lblTacGia = CreateLabel($"Tác giả: {row["tacgia"]}", new Point(120, 40));
            Label lblGiaGoc = CreateLabel($"Giá gốc: {donGia:N0} VND", new Point(120, 70));
            Label lblGiaGiam = CreateLabel($"Giá giảm: {giaGiam:N0} VND (-{tyLeKM}%)", new Point(120, 100));

            // Add controls to panel
            panelSanPham.Controls.AddRange(new Control[] {
        checkBox, pictureBox, lblTenSach, lblTacGia, lblGiaGoc, lblGiaGiam
    });

            // Lưu thông tin sản phẩm trong `Tag`
            panelSanPham.Tag = new
            {
                Magh = row["magh"].ToString(),
                Masach = row["Masach"].ToString(),
                GiaGiam = giaGiam
            };

            return panelSanPham;
        }

        private void ValidateInputsAndCalculate()
        {
            totalPrice = 0;

            foreach (Control control in panelChuaCacSanPham.Controls)
            {
                if (control is Panel panel)
                {
                    var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();

                    if (checkBox != null && checkBox.Checked)
                    {
                        var panelInfo = (dynamic)panel.Tag;
                        decimal giaGiam = panelInfo.GiaGiam;
                        totalPrice += giaGiam; // Mặc định mỗi sản phẩm là số lượng 1
                    }
                }
            }

            labelTongTien.Text = $"Tổng tiền: {totalPrice:N0} VND";
            labelTongTien.Font = new Font("Arial", 10, FontStyle.Bold);
        }
        private void UpdateTotalPrice()
        {
            totalPrice = 0;
            foreach (Control control in panelChuaCacSanPham.Controls)
            {
                if (control is Panel panel)
                {
                    var numericUpDown = panel.Controls.OfType<NumericUpDown>().FirstOrDefault();
                    var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    var lblGiaCa = panel.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Text.Contains("Giá"));

                    if (numericUpDown != null && checkBox != null && lblGiaCa != null && checkBox.Checked)
                    {
                        string priceText = lblGiaCa.Text.Replace("Giá:", "").Replace("VND", "").Trim();
                        if (decimal.TryParse(new string(priceText.Where(char.IsDigit).ToArray()), out decimal price))
                        {
                            totalPrice += price * numericUpDown.Value;
                        }
                    }
                }
            }

            labelTongTien.Text = $"Tổng tiền: {totalPrice:#,##0} VND";
        }
        private void checkBoxTatCa_CheckedChanged(object sender, EventArgs e)
        {
            // Nếu checkbox không được chọn thì bỏ qua
            if (!checkBoxTatCa.Checked)
            {
                // Bỏ chọn tất cả sản phẩm nếu checkbox Tất cả không được chọn
                foreach (Control control in panelChuaCacSanPham.Controls)
                {
                    if (control is Panel panel)
                    {
                        var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                        if (checkBox != null)
                        {
                            checkBox.Checked = false;
                        }
                    }
                }
                return;
            }


            // Chọn tất cả sản phẩm nếu dữ liệu hợp lệ
            foreach (Control control in panelChuaCacSanPham.Controls)
            {
                if (control is Panel panel)
                {
                    var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (checkBox != null)
                    {
                        checkBox.Checked = true;
                    }
                }
            }
        }


        private Label CreateLabel(string text, Point location)
        {
            return new Label
            {
                Text = text,
                Location = location,
                AutoSize = true
            };
        }

        private Image LoadProductImage(object imageNameObj, string imagePath)
        {
            string defaultImage = Path.Combine(imagePath, "default.jpg");
            if (imageNameObj != DBNull.Value)
            {
                string fileName = imageNameObj.ToString();
                string fullPath = Path.Combine(imagePath, fileName);

                if (File.Exists(fullPath))
                {
                    return Image.FromFile(fullPath);
                }
            }
            return File.Exists(defaultImage) ? Image.FromFile(defaultImage) : null;
        }

        private void UpdateTotalItems()
        {
            totalItems = panelChuaCacSanPham.Controls.OfType<Panel>().Count();
            textBoxSoMatHang.Text = totalItems.ToString();
        }

        private void btnMuaHang_Click(object sender, EventArgs e)
        {
            bool hasSelectedItems = false;
            selectedMasach.Clear();

            // Kiểm tra xem có sản phẩm nào được chọn không
            foreach (Control control in panelChuaCacSanPham.Controls)
            {
                if (control is Panel panel)
                {
                    var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (checkBox != null && checkBox.Checked)
                    {
                        hasSelectedItems = true;
                        var productInfo = (dynamic)panel.Tag;
                        selectedMasach.Add(productInfo.Masach);
                    }
                }
            }

            if (!hasSelectedItems)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một sản phẩm để mua.", "Thông báo",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form hóa đơn và truyền danh sách mã sách đã chọn
            Form parentForm = this.FindForm(); // Tìm form cha
            parentForm?.Close(); // Đóng form cha nếu tồn tại
            HoaDonView hoaDonView = new HoaDonView(selectedMasach);
            hoaDonView.TopMost = true;
            hoaDonView.Show();


        }




        private bool UpdateProductQuantityInCart(string maGH, string Masach, int newQuantity)
        {
            string query = $"UPDATE giosanpham SET soluong = {newQuantity} WHERE magh = '{maGH}' AND Masach = '{Masach}'";
            int rowsAffected = db.ExecuteNonQuery(query);

            return rowsAffected > 0; // Trả về true nếu cập nhật thành công
        }


        // Thêm hàm xóa sản phẩm khỏi giỏ hàng
        private void DeleteProductFromCart(string maGH, string Masach)
        {
            string query = $"DELETE FROM giosanpham WHERE magh = '{maGH}' AND Masach = '{Masach}'";
            int rowsAffected = db.ExecuteNonQuery(query);

            if (rowsAffected > 0)
            {
                MessageBox.Show("Sản phẩm đã được xóa khỏi giỏ hàng.");
            }
            else
            {
                MessageBox.Show("Không thể xóa sản phẩm khỏi giỏ hàng. Vui lòng thử lại.");
            }

            // Cập nhật lại giỏ hàng sau khi xóa
            LoadGioHang();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có checkbox nào được chọn không
            bool hasSelectedItems = false;
            foreach (Control control in panelChuaCacSanPham.Controls)
            {
                if (control is Panel panel)
                {
                    var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (checkBox != null && checkBox.Checked)
                    {
                        hasSelectedItems = true;
                        break;
                    }
                }
            }

            // Nếu không có sản phẩm nào được chọn, hiển thị thông báo và thoát
            if (!hasSelectedItems)
            {
                MessageBox.Show("Chưa chọn sản phẩm xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Nếu có sản phẩm được chọn, tiếp tục với quá trình xóa
            List<Panel> panelsToRemove = new List<Panel>();

            foreach (Control control in panelChuaCacSanPham.Controls)
            {
                if (control is Panel panel)
                {
                    var checkBox = panel.Controls.OfType<CheckBox>().FirstOrDefault();
                    if (checkBox != null && checkBox.Checked)
                    {
                        var productInfo = (dynamic)panel.Tag;
                        string maGH = productInfo.Magh;
                        string Masach = productInfo.Masach;

                        DeleteProductFromCart(maGH, Masach);
                        panelsToRemove.Add(panel);
                    }
                }
            }

            // Xóa các panel đã được đánh dấu
            foreach (var panel in panelsToRemove)
            {
                RemovePanelFromCart(panel);
            }

            // Tải lại danh sách giỏ hàng sau khi xóa
            LoadGioHang();
        }


        private void RemovePanelFromCart(Panel panelToRemove)
        {
            // Xóa panel được chọn
            panelChuaCacSanPham.Controls.Remove(panelToRemove);
            panelToRemove.Dispose();

            // Sắp xếp lại các panel còn lại và tính toán chiều cao mới
            var remainingPanels = panelChuaCacSanPham.Controls.OfType<Panel>().OrderBy(p => p.Top).ToList();
            int yOffset = 10;
            int totalHeight = 0;

            foreach (Panel panel in remainingPanels)
            {
                panel.Location = new Point(10, yOffset);
                yOffset += panel.Height + 10;
                totalHeight = panel.Bottom + 10;
            }

            // Cập nhật kích thước của panel cha
            panelChuaCacSanPham.Height = Math.Max(totalHeight, 300); // Giữ chiều cao tối thiểu 300
            panelChuaCacSanPham.AutoScrollMinSize = new Size(0, totalHeight);

            // Đặt lại vị trí cuộn về đầu nếu cần
            panelChuaCacSanPham.VerticalScroll.Value = 0;

            // Buộc panel cập nhật giao diện
            panelChuaCacSanPham.PerformLayout();
            panelChuaCacSanPham.Refresh();

            // Cập nhật tổng số mặt hàng và tổng tiền
            UpdateTotalItems();
            UpdateTotalPrice();
        }
        private void RearrangePanelsAfterRemoval(Panel removedPanel)
        {
            // Xóa panel được chỉ định
            panelChuaCacSanPham.Controls.Remove(removedPanel);
            removedPanel.Dispose();

            // Sắp xếp lại các panel còn lại
            var remainingPanels = panelChuaCacSanPham.Controls.OfType<Panel>()
                .OrderBy(p => p.Top)
                .ToList();

            int yOffset = 10;
            int totalHeight = 0;

            foreach (Panel panel in remainingPanels)
            {
                panel.Location = new Point(10, yOffset);
                yOffset += panel.Height + 10;
                totalHeight = panel.Bottom + 10;
            }

            // Cập nhật kích thước của panel cha
            panelChuaCacSanPham.Height = Math.Min(Math.Max(totalHeight, 300), 300);
            panelChuaCacSanPham.AutoScrollMinSize = new Size(0, totalHeight);

            // Reset scroll position
            panelChuaCacSanPham.VerticalScroll.Value = 0;

            // Refresh UI
            panelChuaCacSanPham.PerformLayout();
            panelChuaCacSanPham.Refresh();

            // Cập nhật tổng số mặt hàng và tổng tiền
            UpdateTotalItems();
            UpdateTotalPrice();
            LoadGioHang();

        }

        public delegate void OnBackButtonClickedHandler();
        public event OnBackButtonClickedHandler OnBackButtonClicked;

        private void btnQuayLai_Click(object sender, EventArgs e)
        {

            OnBackButtonClicked?.Invoke();
        }
    }


}