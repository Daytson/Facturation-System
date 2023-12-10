using System;
using System.Collections.Generic;

namespace Facturation_System.Models
{
    public partial class Dfactura
    {
        public int Secuencia { get; set; }
        public string? Factura { get; set; }
        public string? Cliente { get; set; }
        public string? Fecha { get; set; }
        public string? Articulo { get; set; }
        public double? Cantidad { get; set; }
        public double? Preciodeventa { get; set; }
        public double? Impuesto { get; set; }
        public double? Montoporlinea { get; set; }
    }
}
