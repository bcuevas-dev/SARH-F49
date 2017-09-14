namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tanda_laboral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tanda_laboral()
        {
            empleado = new HashSet<empleado>();
        }

        [Key]
        public int tanda_id { get; set; }

        [Required]
        [StringLength(100)]
        public string descripcion { get; set; }

        public TimeSpan? hora_entrada { get; set; }

        public TimeSpan? hora_salida { get; set; }

        public int estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<empleado> empleado { get; set; }
    }
}
