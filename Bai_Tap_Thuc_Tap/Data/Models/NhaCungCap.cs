using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_NCC")]
    public class NhaCungCap
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã nhà cung cấp không được để trống.")]
        [StringLength(50)]
        [Column("Ma_NCC")]
        public string MaNCC { get; set; }

        [Required(ErrorMessage = "Tên nhà cung cấp không được để trống.")]
        [StringLength(255)]
        [Column("Ten_NCC")]
        public string TenNCC { get; set; }

        [StringLength(500)]
        [Column("Ghi_Chu")]
        public string? GhiChu { get; set; }
    }
}
