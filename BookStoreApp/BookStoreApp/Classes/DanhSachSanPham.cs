using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCounterFinalProject.Classes
{
    internal class DanhSachSanPham
    {
        List<SanPham> items;

        public DanhSachSanPham(List<SanPham> items)
        {
            this.items = items;
        }
        public DanhSachSanPham()
        {
            this.items = new List<SanPham>();
        }
        //CRUD
        public void ThemSanPham(SanPham otherItem)
        {
            this.items.Add(otherItem);
        }
        public void XoaSanPham(string maSp)
        {
            items.RemoveAll(sp => sp.maSp == maSp);
            // THEM LENH DE XOA SP TRONG CSDL
        }

        public List<SanPham> LayDanhSachSanPham()
        {
            return items;
        }

        public int TongSoLuong()
        {
            int tong = 0;
            foreach (var item in items)
            {
                tong += item.soLuong;
            }
            return tong;
        }

        public decimal TongGiaTri()
        {
            decimal tongGia = 0;
            foreach (var item in items)
            {
                tongGia += item.giaSp * item.soLuong;
            }
            return tongGia;
        }
        public int TongSoSP()
        {
            return items.Count;
        }
        public SanPham GetSanPham(int index)
        {
            Console.WriteLine(index);
            return items[index];
        }
    }
}
