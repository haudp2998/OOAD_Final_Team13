using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class HoiDap
    {
        public int MaHd { get; set; }
        public int MaKh { get; set; }
        public int? MaNv { get; set; }
        public string CauHoi { get; set; }
        public string TraLoi { get; set; }
        public DateTime NgayDua { get; set; }
        public bool TrangThaiTl { get; set; }

        public KhachHang MaKhNavigation { get; set; }
        public NhanVien MaNvNavigation { get; set; }
    }
}
