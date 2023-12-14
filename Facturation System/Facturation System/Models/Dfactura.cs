using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturation_System.Models
{
    public partial class Dfactura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Secuencia { get; set; }

        [ForeignKey("Hfactura")]
        public string? Factura { get; set; }
        public string? Cliente { get; set; }
        public string? Fecha { get; set; }

        [ForeignKey("Producto")]
        public string? Articulo { get; set; }
        public double? Cantidad { get; set; }
        public double? Preciodeventa { get; set; }
        public double? Impuesto { get; set; }
        public double? Montoporlinea { get; set; }
        public virtual Producto Productos { get; set; }
    }
}
