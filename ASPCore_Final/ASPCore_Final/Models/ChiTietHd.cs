using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCore_Final.Models
{
    public partial class ChiTietHd
    {

        [Display(Name = "Mã chi tiết")]
        public int MaCt { get; set; }
        [Display(Name = "Mã hóa đơn")]
        public int MaHd { get; set; }
        [Display(Name = "Mã hàng hóa")]
        public int MaHh { get; set; }
        [Display(Name = "Đơn giá")]
        public double DonGia { get; set; }
        [Display(Name = "Giảm giá")]
        public double? GiamGia { get; set; }
        [Display(Name = "Số lượng")]
        public int SoLuong { get; set; }
        [Display(Name = "Kích cỡ")]
        public string KichCo { get; set; }

        public HoaDon MaHdNavigation { get; set; }
        public HangHoa MaHhNavigation { get; set; }
    }
}
