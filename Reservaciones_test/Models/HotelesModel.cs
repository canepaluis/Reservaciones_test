using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class Hoteles
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Nombre { get; set; }


        [Required]
        public int DestinoId { get; set; }

        [ForeignKey("DestinoId")]
        public Destinos Destino { get; set; }

        public List<Reservaciones> Reservacion { get; set; }
    }
}
