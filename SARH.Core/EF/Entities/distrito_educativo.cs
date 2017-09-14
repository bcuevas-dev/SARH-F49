namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class distrito_educativo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public distrito_educativo()
        {
            centro_educativo = new HashSet<centro_educativo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int distrito_educativo_id { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public int regional_educativa_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<centro_educativo> centro_educativo { get; set; }

        public virtual regional_educativa regional_educativa { get; set; }
    }
}
