using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCore_Final.Models
{
    public partial class HangHoa
    {
        public HangHoa()
        {
            BinhLuanSp = new HashSet<BinhLuanSp>();
            ChiTietHd = new HashSet<ChiTietHd>();
            SanPhamKhoNavigation = new HashSet<SanPhamKho>();
            YeuThich = new HashSet<YeuThich>();
        }
        [Display(Name = "Mã hàng hóa")]
        public int MaHh { get; set; }
        [Display(Name = "Tên hàng hóa")]
        public string TenHh { get; set; }
        [Display(Name = "Mã loại")]
        public string MaLoai { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Hinh { get; set; }
        [Display(Name = "Đơn giá")]
        public double DonGia { get; set; }
        [Display(Name = "Giảm giá")]
        public double GiamGia { get; set; }
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }
        [Display(Name = "Mã NCC")]
        public string MaNcc { get; set; }
        [Display(Name = "Số lượng tồn")]
        public int? SanPhamKho { get; set; }
        [Display(Name = "Mã loại")]
        public Loai MaLoaiNavigation { get; set; }
        [Display(Name = "Mã nhà CC")]
        public NhaCungCap MaNccNavigation { get; set; }
        public ICollection<BinhLuanSp> BinhLuanSp { get; set; }
        public ICollection<ChiTietHd> ChiTietHd { get; set; }
        public ICollection<SanPhamKho> SanPhamKhoNavigation { get; set; }
        public ICollection<YeuThich> YeuThich { get; set; }
    }
}
