using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCore_Final.Models
{
    public class HangHoaNhap
    {
        public int MaHh { get; set; }
        public string TenHh { get; set; }
        public string Hinh { get; set; }
        public string KichCo { get; set; }
        public double DonGiaNhap { get; set; }
        public int SoLuongNhap { get; set; }
        public double ThanhTien => DonGiaNhap * SoLuongNhap;
    }
}
