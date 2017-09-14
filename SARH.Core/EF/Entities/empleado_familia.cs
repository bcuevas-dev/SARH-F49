namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class empleado_familia
    {
        [Key]
        public int familiar_id { get; set; }

        [StringLength(100)]
        public string nombres { get; set; }

        [StringLength(50)]
        public string apellido1 { get; set; }

        [StringLength(50)]
        public string apellido2 { get; set; }

        [StringLength(13)]
        public string telefono { get; set; }

        [StringLength(100)]
        public string direccion { get; set; }

        public int parentezco_id { get; set; }

        public virtual parentezco_familiar parentezco_familiar { get; set; }
    }
}
