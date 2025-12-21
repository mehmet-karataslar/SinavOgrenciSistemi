using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SinavOgrenciSistemi.Models
{
    [Table("TBLKULUPLER")]
    public partial class TBLKULUPLER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBLKULUPLER()
        {
            TBLOGRENCI = new HashSet<TBLOGRENCI>();
        }

        [Key]
        public int KULUPID { get; set; }

        [Required]
        [StringLength(50)]
        public string KULUPAD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBLOGRENCI> TBLOGRENCI { get; set; }
    }
}

