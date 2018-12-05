using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class SanPhamKho
    {
        public int MaSpKho { get; set; }
        public int MaHh { get; set; }
        public string KichCo { get; set; }
        public int? SoLuong { get; set; }

        public HangHoa MaHhNavigation { get; set; }
    }
}
