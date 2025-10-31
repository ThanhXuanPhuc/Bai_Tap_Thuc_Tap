using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_Don_Vi_Tinh")]
    public class DonViTinh
    {
        [Key] // Đánh dấu đây là Khóa chính
        [Column("Auto_ID")]
        public int Id { get; set; }

        // Ràng buộc "Không được rỗng"
        [Required(ErrorMessage = "Tên đơn vị tính không được để trống.")]
        [StringLength(100)]
        [Column("Ten_Don_Vi_Tinh")]
        public string TenDonViTinh { get; set; }

        [StringLength(255)]
        [Column("Ghi_Chu")]
        public string? GhiChu { get; set; }
    }
}
