using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class Tblrole
    {
        public Tblrole()
        {
            Tblempleados = new HashSet<Tblempleado>();
        }

        public int IdRolEmpleado { get; set; }
        public string? StrDescripcion { get; set; }

        public virtual ICollection<Tblempleado> Tblempleados { get; set; }
    }
}
