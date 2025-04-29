using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCounterFinalProject.Classes
{
    public class SanPham
    {
        public string maSp { get; set; }
        public string tenSp { get; set; }
        public string phanLoai { get; set; }
        public string hangSX { get; set; }
        public int soLuong { get; set; }

        public decimal giaSp { get; set; }
        public string anhSp { get; set; }
        public string moTa { get; set; }
        public SanPham() { }

        public SanPham(string maSp, string tenSp, string phanLoai, string hangSX, int sl, decimal giaSp, string anhSp, string moTa)
        {
            this.maSp = maSp;
            this.tenSp = tenSp;
            this.phanLoai = phanLoai;
            this.hangSX = hangSX;
            this.soLuong = sl;
            this.giaSp = giaSp;
            this.anhSp = anhSp;
            this.moTa = moTa;
        }
    }
}
