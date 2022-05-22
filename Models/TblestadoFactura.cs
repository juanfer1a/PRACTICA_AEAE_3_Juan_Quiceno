using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class TblestadoFactura
    {
        public TblestadoFactura()
        {
            Tblfacturas = new HashSet<Tblfactura>();
        }

        public int IdEstadoFactura { get; set; }
        public string? StrDescripcion { get; set; }

        public virtual ICollection<Tblfactura> Tblfacturas { get; set; }
    }
}
