using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroDeVisitantes.Models
{
    public class HistorialVisitas
    {
        [Key]
        public int HistorialId { get; set; }
        [Required]
        public DateTime HoraDeEntrada { get; set; }
        [Required]

        public DateTime HoraDeSalida { get; set; }
        [Required]
        public int VisitanteId { get; set; }
        public HistorialVisitas historialVisitas { get; set; }
    }

    
}