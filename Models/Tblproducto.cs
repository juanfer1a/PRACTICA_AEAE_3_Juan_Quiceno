using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class Tblproducto
    {
        public Tblproducto()
        {
            TbldetalleFacturas = new HashSet<TbldetalleFactura>();
        }

        public int IdProducto { get; set; }
        [Display(Name = "Nombre")]
        public string StrNombre { get; set; } = null!;
        [Display(Name = "Codigo")]
        public string StrCodigo { get; set; } = null!;

        [Display(Name = "Precio de compra")]
        public double NumPrecioCompra { get; set; }

        [Display(Name = "Precio de venta")]
        public double NumPrecioVenta { get; set; }

        [Display(Name = "Categoria")]
        public int IdCategoria { get; set; }

        [Display(Name = "Detalle")]
        public string? StrDetalle { get; set; }
        public string? StrFoto { get; set; }

        [Display(Name = "Stock")]
        public int? NumStock { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string? StrUsuarioModifica { get; set; } 

        public virtual TblcategoriaProd? IdCategoriaNavigation { get; set; } 
        public virtual ICollection<TbldetalleFactura> TbldetalleFacturas { get; set; }
    }
}
