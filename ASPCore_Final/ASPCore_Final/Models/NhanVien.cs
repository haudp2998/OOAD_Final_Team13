using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCore_Final.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoiDap = new HashSet<HoiDap>();
        }
        [Display(Name = "Mã NV")]
        public int MaNv { get; set; }
        [Display(Name = "Họ tên")]
        public string HoTen { get; set; }

        public string Email { get; set; }
        [Display(Name = "Mật khẩu")]
        public string MatKhau { get; set; }
        [Display(Name = "Mã PQ")]
        public int MaPq { get; set; }
        [Display(Name = "Trạng thái")]
        public bool? TrangThaiHd { get; set; }

        [Display(Name = "Phân quyền")]
        public PhanQuyen MaPqNavigation { get; set; }
        public ICollection<HoiDap> HoiDap { get; set; }
    }
}
