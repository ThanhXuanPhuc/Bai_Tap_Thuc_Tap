using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_Xuat_Kho_Raw_Data")]
    public class XuatKhoRawData
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Column("Xuat_Kho_ID")]
        public int XuatKhoId { get; set; }

        [Column("San_Pham_ID")]
        public int SanPhamId { get; set; }

        [Column("SL_Xuat")]
        public decimal SoLuongXuat { get; set; }

        [Column("Don_Gia_Xuat")]
        public decimal DonGiaXuat { get; set; }

        [ForeignKey("XuatKhoId")]
        public virtual XuatKho? XuatKho { get; set; }

        [ForeignKey("SanPhamId")]
        public virtual SanPham? SanPham { get; set; }
    }
}
