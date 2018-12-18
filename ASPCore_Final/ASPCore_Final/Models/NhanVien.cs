using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoiDap = new HashSet<HoiDap>();
        }

        public int MaNv { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string MatKhau { get; set; }
        public int MaPq { get; set; }
        public bool? TrangThaiHd { get; set; }

        public PhanQuyen MaPqNavigation { get; set; }
        public ICollection<HoiDap> HoiDap { get; set; }
    }
}
