using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_Kho_User")]
    public class KhoUser
    {
        [Column("Ma_Dang_Nhap")]
        public string MaDangNhap { get; set; }

        [Column("Kho_ID")]
        public int KhoId { get; set; }

        public virtual User User { get; set; }
        public virtual Kho Kho { get; set; }
    }
}
