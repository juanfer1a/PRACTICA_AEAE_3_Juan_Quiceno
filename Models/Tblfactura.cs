﻿using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class Tblfactura
    {
        public Tblfactura()
        {
            TbldetalleFacturas = new HashSet<TbldetalleFactura>();
        }

        public int IdFactura { get; set; }
        public DateTime? DtmFecha { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public double? NumDescuento { get; set; }
        public double? NumImpuesto { get; set; }
        public double? NumValorTotal { get; set; }
        public int? IdEstado { get; set; }
        public DateTime? DtmFechaModifica { get; set; }
        public string? StrUsuarioModifica { get; set; }

        public virtual Tblcliente IdClienteNavigation { get; set; } = null!;
        public virtual Tblempleado IdEmpleadoNavigation { get; set; } = null!;
        public virtual TblestadoFactura? IdEstadoNavigation { get; set; }
        public virtual ICollection<TbldetalleFactura> TbldetalleFacturas { get; set; }
    }
}
