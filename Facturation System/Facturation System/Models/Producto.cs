using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturation_System.Models
{
    public partial class Producto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? Item { get; set; }
        public string? Descripcion { get; set; }
        public int? CantidadEnExistencia { get; set; }
        public double? Costo { get; set; }
        public double? PrecioDeVenta { get; set; }
        public double? Impuesto { get; set; }
        public int? EstatusProducto { get; set; }
        public string? BarCode { get; set; }
        public byte[]? Imagen { get; set; }
        public string? Ruta { get; set; }
        public virtual ICollection<Dfactura> Dfacturas { get; set; }
    }
}
