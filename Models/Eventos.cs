using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RegistroDeVisitantes.Models
{
    public class Eventos
    {
        [Key]
        public int EventosId { get; set; }
        [Required]
        public string NombreDelEvento { get; set; }
        [Required]
        public string Detalles { get; set; }
        [Required]
        public DateTime fechaEvento { get; set; }
        
    }
}