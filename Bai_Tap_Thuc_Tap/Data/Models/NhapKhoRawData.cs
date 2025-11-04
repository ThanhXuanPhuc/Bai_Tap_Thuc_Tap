using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_Nhap_Kho_Raw_Data")]
    public class NhapKhoRawData
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Column("Nhap_Kho_ID")]
        public int NhapKhoId { get; set; }

        [Column("San_Pham_ID")]
        public int SanPhamId { get; set; }

        [Column("SL_Nhap")]
        public decimal SoLuongNhap { get; set; }

        [Column("Don_Gia_Nhap")]
        public decimal DonGiaNhap { get; set; }

        [ForeignKey("NhapKhoId")]
        public virtual NhapKho? NhapKho { get; set; }

        [ForeignKey("SanPhamId")]
        public virtual SanPham? SanPham { get; set; }
    }
}
