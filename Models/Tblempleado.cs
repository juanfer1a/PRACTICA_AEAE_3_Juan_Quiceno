﻿using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class Tblempleado
    {
        public Tblempleado()
        {
            Tblfacturas = new HashSet<Tblfactura>();
            Tblseguridads = new HashSet<Tblseguridad>();
        }

        public int IdEmpleado { get; set; }
        public string StrNombre { get; set; } = null!;
        public long NumDocumento { get; set; }
        public string? StrDireccion { get; set; }
        public string? StrTelefono { get; set; }
        public string? StrEmail { get; set; }
        public int? IdRolEmpleado { get; set; }
        public DateTime? DtmIngreso { get; set; }
        public DateTime? DtmRetiro { get; set; }
        public string? StrDatosAdicionales { get; set; }
        public DateTime? DtmFechaModifica { get; set; }
        public string? StrUsuarioModifico { get; set; }

        public virtual Tblrole? IdRolEmpleadoNavigation { get; set; }
        public virtual ICollection<Tblfactura> Tblfacturas { get; set; }
        public virtual ICollection<Tblseguridad> Tblseguridads { get; set; }
    }
}
