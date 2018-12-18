using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            BinhLuanSp = new HashSet<BinhLuanSp>();
            HoaDon = new HashSet<HoaDon>();
            HoiDap = new HashSet<HoiDap>();
            YeuThich = new HashSet<YeuThich>();
        }

        public int MaKh { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string Email { get; set; }
        public string Hinh { get; set; }
        public bool TrangThaiHd { get; set; }
        public bool? LoaiKH { get; set; }

        public ICollection<BinhLuanSp> BinhLuanSp { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
        public ICollection<HoiDap> HoiDap { get; set; }
        public ICollection<YeuThich> YeuThich { get; set; }
    }
}
