﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Facturation_System.Models
{
    public partial class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Idcliente { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Sector { get; set; }
        public string? Ciudad { get; set; }
        public string? Pais { get; set; }
        public string? Telefono01 { get; set; }
        public string? Telefono02 { get; set; }
        public string? Ididentificacion { get; set; }
        public int? Estatus { get; set; }
        public double? Monto { get; set; }
        public string? Correo { get; set; }
        public byte[]? Imagen { get; set; }
        public string? RutaImagen { get; set; }
        public int? PagaImpuesto { get; set; }
        public virtual ICollection<Hfactura> Hfacturas { get; set; }
    }
}
