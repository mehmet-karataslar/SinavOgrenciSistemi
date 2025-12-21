using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinavOgrenciSistemi.Models
{
    [Table("TBLNOTLAR")]
    public partial class TBLNOTLAR
    {
        [Key]
        public int NOTID { get; set; }

        public int DERS { get; set; }

        public int OGRENCI { get; set; }

        public int? SINAV1 { get; set; }

        public int? SINAV2 { get; set; }

        public int? SINAV3 { get; set; }

        [Column(TypeName = "decimal")]
        public decimal? ORTALAMA { get; set; }

        public bool? DURUM { get; set; }

        public virtual TBLDERSLER TBLDERSLER { get; set; }

        public virtual TBLOGRENCI TBLOGRENCI { get; set; }
    }
}

