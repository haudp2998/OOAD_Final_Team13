using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCore_Final.Models
{
    public partial class ChiTietHd
    {
        public int MaCt { get; set; }
        [Display(Name = "Mã HĐ")]
        public int MaHd { get; set; }
        [Display(Name = "Mã HH")]
        public int MaHh { get; set; }
        [Display(Name = "Đơn Giá")]
        public double DonGia { get; set; }
        [Display(Name = "Giảm Giá")]
        public double? GiamGia { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
        [Display(Name = "Size")]
        public string KichCo { get; set; }

        public HoaDon MaHdNavigation { get; set; }
        public HangHoa MaHhNavigation { get; set; }
    }
}
