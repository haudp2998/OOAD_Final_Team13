using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class ChiTietPhieuNhap
    {
        public int MaPn { get; set; }
        public int MaHh { get; set; }
        public string KichCo { get; set; }
        public int? SoLuongNhap { get; set; }
        public double? DonGiaNhap { get; set; }

        public HangHoa MaHhNavigation { get; set; }
        public PhieuNhapHang MaPnNavigation { get; set; }
    }
}
