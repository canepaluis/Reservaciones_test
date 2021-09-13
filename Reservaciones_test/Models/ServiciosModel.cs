using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class Servicios
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Contenido { get; set; }

        public List<Descripciones> Descripcion { get; set; }

    }


}
