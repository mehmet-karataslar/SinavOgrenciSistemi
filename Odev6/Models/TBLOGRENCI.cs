using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinavOgrenciSistemi.Models
{
    [Table("TBLOGRENCI")]
    public partial class TBLOGRENCI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLOGRENCI()
        {
            TBLNOTLAR = new HashSet<TBLNOTLAR>();
        }

        [Key]
        public int OgrenciID { get; set; }

        [Required]
        [StringLength(50)]
        public string OgrenciAd { get; set; }

        [Required]
        [StringLength(50)]
        public string OgrenciSoyad { get; set; }

        [StringLength(250)]
        public string OgrenciFoto { get; set; }

        public int? KulupID { get; set; }

        public virtual TBLKULUPLER TBLKULUPLER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLNOTLAR> TBLNOTLAR { get; set; }
    }
}

