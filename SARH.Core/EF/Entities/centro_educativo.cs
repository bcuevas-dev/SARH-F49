namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class centro_educativo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int centro_educativo_id { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

        public int distrito_educativo_id { get; set; }

        public virtual distrito_educativo distrito_educativo { get; set; }
    }
}
