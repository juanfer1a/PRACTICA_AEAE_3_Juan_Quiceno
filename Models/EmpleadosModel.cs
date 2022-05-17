using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRACTICA_AEAE_3_Juan_Quiceno.Models
{
    public class EmpleadosModel
    {
        //Estructura de la tabla
        public int IdEmpleado { get; set; }
        [Required]
        public string? Nombre { get; set; }
        [Required]
        public int? NumDocumento { get; set; }
        [Required]
        public string? Direccion { get; set; }
        [Required]
        public string? Telefono { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? DatosAdicionales { get; set; }


    }
}
