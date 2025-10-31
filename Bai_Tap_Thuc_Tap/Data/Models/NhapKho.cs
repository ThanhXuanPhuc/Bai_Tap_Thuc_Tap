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
    [Table("tbl_DM_Nhap_Kho")]
    public class NhapKho
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Số phiếu nhập không được để trống.")]
        [StringLength(50)]
        [Column("So_Phieu_Nhap_Kho")]
        public string SoPhieuNhapKho { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn kho.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn kho.")]
        [Column("Kho_ID")]
        public int KhoId { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn nhà cung cấp.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn nhà cung cấp.")]
        [Column("NCC_ID")]
        public int NccId { get; set; }

        [Required(ErrorMessage = "Ngày nhập kho không được để trống.")]
        [Column("Ngay_Nhap_Kho")]
        public DateTime NgayNhapKho { get; set; } = DateTime.Today;

        [StringLength(500)]
        [Column("Ghi_Chu")]
        public string? GhiChu { get; set; }

        // Navigation Properties
        [ForeignKey("KhoId")]
        public virtual Kho? Kho { get; set; }

        [ForeignKey("NccId")]
        public virtual NhaCungCap? NhaCungCap { get; set; }

        // Danh sách các dòng chi tiết
        public virtual ICollection<NhapKhoRawData> ChiTietPhieuNhap { get; set; } = new List<NhapKhoRawData>();
    }
}
