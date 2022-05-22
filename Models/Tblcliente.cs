using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class Tblcliente
    {
        public Tblcliente()
        {
            Tblfacturas = new HashSet<Tblfactura>();
        }

        public int IdCliente { get; set; }
        public string? StrNombre { get; set; }
        public long? NumDocumento { get; set; }
        public string? StrDireccion { get; set; }
        public string? StrTelefono { get; set; }
        public string? StrEmail { get; set; }
        public DateTime? DtmFechaModifica { get; set; }
        public string? StrUsuarioModifica { get; set; }

        public virtual ICollection<Tblfactura> Tblfacturas { get; set; }
    }
}
