namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class formacion_academica
    {
        [Key]
        public int formacion_id { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public DateTime? fecha_inicio { get; set; }

        public DateTime? fecha_termino { get; set; }

        [StringLength(50)]
        public string titulo_obtenido { get; set; }
    }
}
