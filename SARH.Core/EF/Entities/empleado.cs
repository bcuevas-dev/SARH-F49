namespace SARH.Core.EF.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("empleado")]
    public partial class empleado
    {
        [Key]
        public int empleado_id { get; set; }

        [Required]
        [StringLength(100)]
        public string nombres { get; set; }

        [Required]
        [StringLength(100)]
        public string apellido1 { get; set; }

        [Required]
        [StringLength(100)]
        public string apellido2 { get; set; }

        public int tipo_documento_id { get; set; }

        [Required]
        [StringLength(13)]
        public string documento { get; set; }

        [StringLength(13)]
        public string telefono1 { get; set; }

        [StringLength(13)]
        public string telefono2 { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(200)]
        public string direccion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fecha_nacimiento { get; set; }

        public int estado_civil_id { get; set; }

        public int tipo_sangre_id { get; set; }

        public int nacionalidad_id { get; set; }

        public int sexo { get; set; }

        public int profesion_id { get; set; }

        public int ocupacion_id { get; set; }

        public int rango_id { get; set; }

        public int tipo_ingreso_id { get; set; }

        public int funcion_id { get; set; }

        public int tanda_id { get; set; }

        [StringLength(100)]
        public string fotografia { get; set; }

        public int provincia_id { get; set; }

        public int municipio_id { get; set; }

        public int distrito_municipal_id { get; set; }

        public int departamento_id { get; set; }

        public int estatus { get; set; }

        public int instancia_militar_id { get; set; }

        public DateTime? fecha_ingreso { get; set; }

        public int? usuario_creo { get; set; }

        public int? usuario_modifico { get; set; }

        public DateTime? fecha_creacion { get; set; }

        public DateTime? fecha_modificacion { get; set; }

        public DateTime? fecha_ultimo_ascenso { get; set; }

        public virtual departamento departamento { get; set; }

        public virtual distrito_municipal distrito_municipal { get; set; }

        public virtual funcion funcion { get; set; }

        public virtual instancia_militar instancia_militar { get; set; }

        public virtual municipio municipio { get; set; }

        public virtual nacionalidad nacionalidad { get; set; }

        public virtual profesion profesion { get; set; }

        public virtual provincia provincia { get; set; }

        public virtual rango rango { get; set; }

        public virtual tanda_laboral tanda_laboral { get; set; }

        public virtual tipo_ingreso tipo_ingreso { get; set; }
    }
}
