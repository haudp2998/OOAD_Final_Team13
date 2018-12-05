using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class BinhLuanSp
    {
        public int MaBl { get; set; }
        public string NoiDung { get; set; }
        public DateTime? NgayBl { get; set; }
        public int? MaKh { get; set; }
        public int? MaHh { get; set; }

        public HangHoa MaHhNavigation { get; set; }
        public KhachHang MaKhNavigation { get; set; }
    }
}
