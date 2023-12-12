using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturation_System.Models
{
    public partial class Hfactura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Factura { get; set; }

        [ForeignKey("Cliente")]
        public int? Cliente { get; set; }
        public string? Fecha { get; set; }
        public double? Subtotal { get; set; }
        public double? Impuesto { get; set; }
        public double? Montofacturado { get; set; }
        public virtual Cliente Clientes { get; set; }

        public virtual ICollection<Dfactura> Dfacturas { get; set; }
        public virtual Cliente CLIENTE_OBJ { get; set; }

    }
}
