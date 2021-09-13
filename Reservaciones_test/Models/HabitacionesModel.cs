using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class Habitaciones
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DescripcionId { get; set; }

        [ForeignKey("DescripcionId")]
        public Descripciones Descripcion { get; set; }

        [Required]
        public int Precio { get; set; }

        public List<Reservaciones> Reservacion { get; set; }

    }
}
