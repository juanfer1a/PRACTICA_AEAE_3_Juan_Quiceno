using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class Tblproducto
    {
        public Tblproducto()
        {
            TbldetalleFacturas = new HashSet<TbldetalleFactura>();
        }

        public int IdProducto { get; set; }
        public string StrNombre { get; set; } = null!;
        public string StrCodigo { get; set; } = null!;
        public double NumPrecioCompra { get; set; }
        public double NumPrecioVenta { get; set; }
        public int IdCategoria { get; set; }
        public string? StrDetalle { get; set; }
        public string? StrFoto { get; set; }
        public int? NumStock { get; set; }
        public DateTime DtmFechaModifica { get; set; }
        public string StrUsuarioModifica { get; set; } = null!;

        public virtual TblcategoriaProd IdCategoriaNavigation { get; set; } = null!;
        public virtual ICollection<TbldetalleFactura> TbldetalleFacturas { get; set; }
    }
}
