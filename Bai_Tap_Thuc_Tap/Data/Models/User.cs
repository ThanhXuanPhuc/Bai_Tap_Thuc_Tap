using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_User")]
    public class User
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Column("Ma_Dang_Nhap")]
        public string MaDangNhap { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Ho_Ten")]
        public string HoTen { get; set; }
    }
}
