using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bai_Tap_Thuc_Tap.Data.Models
{
    [Table("tbl_DM_San_Pham")]
    public class SanPham
    {
        [Key]
        [Column("Auto_ID")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Mã sản phẩm không được để trống.")]
        [StringLength(50)]
        [Column("Ma_San_Pham")]
        public string MaSanPham { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm không được để trống.")]
        [StringLength(255)]
        [Column("Ten_San_Pham")]
        public string TenSanPham { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn loại sản phẩm.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn loại sản phẩm.")]
        [Column("Loai_San_Pham_ID")]
        public int LoaiSanPhamId { get; set; }

        [Required(ErrorMessage = "Vui lòng chọn đơn vị tính.")]
        [Range(1, int.MaxValue, ErrorMessage = "Vui lòng chọn đơn vị tính.")]
        [Column("Don_Vi_Tinh_ID")]
        public int DonViTinhId { get; set; }

        [StringLength(500)]
        [Column("Ghi_Chu")]
        public string? GhiChu { get; set; }


        [ForeignKey("LoaiSanPhamId")]
        public virtual LoaiSanPham? LoaiSanPham { get; set; }

        [ForeignKey("DonViTinhId")]
        public virtual DonViTinh? DonViTinh { get; set; }
    }
}
