using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_Kho")]
    public class Kho
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên kho không được để trống.")]
        [StringLength(255)]
        [Column("Ten_Kho")]
        public string TenKho { get; set; }

        [StringLength(500)]
        [Column("Ghi_Chu")]
        public string? GhiChu { get; set; }
    }
}
