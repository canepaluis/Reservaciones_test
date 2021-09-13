using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class Destinos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        [Display(Name ="Título")]
        public string Nombre { get; set; }

        public List<Hoteles> Hotel { get; set; }

        public List<Descripciones> Descripcion { get; set; }

        public List<Reservaciones> Reservacion { get; set; }


    }
}
