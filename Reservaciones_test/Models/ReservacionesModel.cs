using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class Reservaciones
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int DestinoId { get; set; }

        [ForeignKey("DestinoId")]
        public Destinos destino { get; set; }

        
        [Required]
        public int HotelId { get; set; }

        [ForeignKey("HotelId")]
        public Hoteles hotel { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }


        [Required]
        public int HabitacionId { get; set; }

        [ForeignKey("HabitacionId")]
        public Habitaciones habitacion { get; set; }

        [Required]
        public int Cantadultos { get; set; }

        [Required]
        public int Cantmenores { get; set; }

        [Required]
        public int Total { get; set; }
    }
}
