using System;
using System.Collections.Generic;

namespace ASPCore_Final.Models
{
    public partial class Loai
    {
        public Loai()
        {
            HangHoa = new HashSet<HangHoa>();
        }

        public string MaLoai { get; set; }
        public bool GioiTinh { get; set; }
        public string TenLoai { get; set; }

        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
