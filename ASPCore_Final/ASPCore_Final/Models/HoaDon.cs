using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCore_Final.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHd = new HashSet<ChiTietHd>();
        }
        [Display(Name = "Mã HĐ")]
        public int MaHd { get; set; }
        [Display(Name = "Mã KH")]
        public int MaKh { get; set; }
        [Display(Name = "Ngày đặt")]
        public DateTime NgayDat { get; set; }
        [Display(Name = "Ngày giao")]
        public DateTime? NgayGiao { get; set; }
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "SĐT")]
        public string SdtNguoinhan { get; set; }
        [Display(Name = "Ghi chú")]
        public string GhiChu { get; set; }
        [Display(Name = "Phí vận chuyển")]
        public double PhiVanChuyen { get; set; }
        [Display(Name = "Trạng thái")]
        public int MaTrangThai { get; set; }
        [Display(Name = "Mã NV")]
        public string MaNv { get; set; }

        public KhachHang MaKhNavigation { get; set; }
        public TrangThai MaTrangThaiNavigation { get; set; }
        public ICollection<ChiTietHd> ChiTietHd { get; set; }
    }
}
