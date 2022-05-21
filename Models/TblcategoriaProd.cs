using System;
using System.Collections.Generic;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class TblcategoriaProd
    {
        public TblcategoriaProd()
        {
            Tblproductos = new HashSet<Tblproducto>();
        }

        public int IdCategoria { get; set; }
        public string? StrDescripcion { get; set; }
        public DateTime? DtmFechaModifica { get; set; }
        public string? StrUsuarioModifico { get; set; }

        public virtual ICollection<Tblproducto> Tblproductos { get; set; }
    }
}
