using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class YeuThich
    {
        public int MaYt { get; set; }
        public int? MaHh { get; set; }
        public int? MaKh { get; set; }
        public DateTime? NgayChon { get; set; }
        public double DiemDanhGia { get; set; }
        public int? MaBl { get; set; }

        public HangHoa MaHhNavigation { get; set; }
        public KhachHang MaKhNavigation { get; set; }
    }
}
