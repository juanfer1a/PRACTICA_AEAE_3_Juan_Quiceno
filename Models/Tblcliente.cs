using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public partial class Tblcliente
    {
        public Tblcliente()
        {
            Tblfacturas = new HashSet<Tblfactura>();
        }

        public int IdCliente { get; set; }
        [Required]
        [Display(Name ="Nombre")]
        public string? StrNombre { get; set; }
        [Required]
        [Display(Name = "Numero de documento")]
        public long? NumDocumento { get; set; }
        [Required]
        [Display(Name = "Direccion")]
        public string? StrDireccion { get; set; }
        [Required]
        [Display(Name = "Telefono")]
        public string? StrTelefono { get; set; }
        [Required]
        [Display(Name = "Correo")]
        public string? StrEmail { get; set; }
       
        public DateTime? DtmFechaModifica { get; set; }
        
        public string? StrUsuarioModifica { get; set; }
       
        public virtual ICollection<Tblfactura> Tblfacturas { get; set; }
    }
}
