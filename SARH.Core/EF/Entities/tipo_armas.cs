namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tipo_armas
    {
        [Key]
        public int tipo_arma_id { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }
    }
}
