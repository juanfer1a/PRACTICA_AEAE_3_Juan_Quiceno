using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

       
        [Display(Name = "Nombre")]
        public string StrNombre { get; set; } = null!;
       
        [Display(Name = "Numero de documento")]
        public long NumDocumento { get; set; }

        
        [Display(Name = "Direccion")]
        public string? StrDireccion { get; set; }

       
        [Display(Name = "Telefono")]
        public string? StrTelefono { get; set; }

     
        [Display(Name = "Email")]
        public string? StrEmail { get; set; }

      
        [Display(Name = "Rol")]
        public int? IdRolEmpleado { get; set; }

       
        [Display(Name = "Fecha de ingreso")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        public DateTime? DtmIngreso { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de retiro")]
        public DateTime? DtmRetiro { get; set; }

    
        [Display(Name = "Datos adicionales")]
        public string? StrDatosAdicionales { get; set; }

        public DateTime? DtmFechaModifica { get; set; }

       
        public string? StrUsuarioModifico { get; set; }

        public virtual Tblrole? IdRolEmpleadoNavigation { get; set; }        
        public virtual ICollection<Tblfactura> Tblfacturas { get; set; }
        public virtual ICollection<Tblseguridad> Tblseguridads { get; set; }
    }
}
