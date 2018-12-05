using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPCore_Final.Models
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            HangHoa = new HashSet<HangHoa>();
        }
        [Display(Name = "Mã NCC")]
        public string MaNcc { get; set; }
        [Display(Name = "Tên công ty")]
        public string TenCongTy { get; set; }
        public string Email { get; set; }
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }
        [Display(Name = "Mô tả")]
        public string MoTa { get; set; }

        public ICollection<HangHoa> HangHoa { get; set; }
    }
}
