using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class Descripciones
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public int DestinoId { get; set; }

        [ForeignKey("DestinoId")]
        public Destinos Destino { get; set; }


        [Required]
        public int T_HabitacionId { get; set; }

        [ForeignKey("T_HabitacionId")]
        public T_Habitaciones T_habitacion { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion { get; set; }


        [Required]
        public int ServicioId { get; set; }

        [ForeignKey("ServicioId")]
        public Servicios Servicio { get; set;  }

        public List<Habitaciones> Habitacion { get; set; }
    }
}
