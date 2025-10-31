using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_Loai_San_Pham")]
    public class LoaiSanPham
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã loại sản phẩm không được để trống.")]
        [StringLength(50)]
        [Column("Ma_LSP")]
        public string MaLSP { get; set; }

        [Required(ErrorMessage = "Tên loại sản phẩm không được để trống.")]
        [StringLength(255)]
        [Column("Ten_LSP")]
        public string TenLSP { get; set; }

        [StringLength(500)]
        [Column("Ghi_Chu")]
        public string? GhiChu { get; set; }
    }
}
