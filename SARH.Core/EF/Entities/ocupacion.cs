namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ocupacion")]
    public partial class ocupacion
    {
        [Key]
        public int ocupacion_id { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }
    }
}
