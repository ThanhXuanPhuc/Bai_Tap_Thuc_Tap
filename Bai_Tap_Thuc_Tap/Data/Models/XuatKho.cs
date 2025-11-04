using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_Xuat_Kho")]
    public class XuatKho
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Số phiếu xuất không được để trống.")]
        [StringLength(50)]
        [Column("So_Phieu_Xuat_Kho")]
        public string SoPhieuXuatKho { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn kho.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn kho.")]
        [Column("Kho_ID")]
        public int KhoId { get; set; }

        [Required(ErrorMessage = "Ngày xuất kho không được để trống.")]
        [Column("Ngay_Xuat_Kho")]
        public DateTime NgayXuatKho { get; set; } = DateTime.Today;

        [StringLength(500)]
        [Column("Ghi_Chu")]
        public string? GhiChu { get; set; }

        [ForeignKey("KhoId")]
        public virtual Kho? Kho { get; set; }

        public virtual ICollection<XuatKhoRawData> ChiTietPhieuXuat { get; set; } = new List<XuatKhoRawData>();
    }
}
