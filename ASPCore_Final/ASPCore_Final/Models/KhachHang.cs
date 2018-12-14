using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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
        [Display(Name = "Mã KH")]
        public int MaKh { get; set; }
        [Display(Name = "Tài khoản")]
        public string TaiKhoan { get; set; }
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }
        [Display(Name = "Giới tính")]
        public string GioiTinh { get; set; }
        [Display(Name = "Ngày sinh")]
        public DateTime NgaySinh { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }

        public string Email { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Hinh { get; set; }
        [Display(Name = "Trạng thái")]
        public bool TrangThaiHd { get; set; }
        [Display(Name = "Loại KH")]
        public bool LoaiKH { get; set; }

        public ICollection<BinhLuanSp> BinhLuanSp { get; set; }
        public ICollection<HoaDon> HoaDon { get; set; }
        public ICollection<HoiDap> HoiDap { get; set; }
        public ICollection<YeuThich> YeuThich { get; set; }
    }
}
