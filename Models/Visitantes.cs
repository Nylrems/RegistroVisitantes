using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RegistroDeVisitantes.Models
{
    public class Visitantes
    {
        [Key]
        public int VisitanteID { get; set; }
        [Required]
        public string Nombres { get; set; }
        [Required]
        public string Apellidos { get; set; }
        [Required]
        public DateTime fechaVisita { get; set; }
    }

    public class EFEntities : DbContext
    {
        public DbSet<Visitantes> visitantes { get; set; }
        public DbSet<HistorialVisitas> HistorialVisitas { get; set; }

        public System.Data.Entity.DbSet<RegistroDeVisitantes.Models.Eventos> Eventos { get; set; }
    }
}