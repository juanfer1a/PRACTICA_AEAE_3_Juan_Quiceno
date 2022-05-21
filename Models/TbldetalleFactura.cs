﻿using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class TbldetalleFactura
    {
        public int IdDetalle { get; set; }
        public int IdFactura { get; set; }
        public int? NumCantidad { get; set; }
        public int IdProducto { get; set; }
        public double? NumPrecio { get; set; }

        public virtual Tblfactura IdFacturaNavigation { get; set; } = null!;
        public virtual Tblproducto IdProductoNavigation { get; set; } = null!;
    }
}
