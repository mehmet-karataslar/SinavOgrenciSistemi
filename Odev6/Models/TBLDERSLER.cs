using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinavOgrenciSistemi.Models
{
    [Table("TBLDERSLER")]
    public partial class TBLDERSLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLDERSLER()
        {
            TBLNOTLAR = new HashSet<TBLNOTLAR>();
        }

        [Key]
        public int DERSID { get; set; }

        [Required]
        [StringLength(50)]
        public string DERSAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLNOTLAR> TBLNOTLAR { get; set; }
    }
}

