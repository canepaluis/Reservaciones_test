using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class T_Habitaciones
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Tipo { get; set; }

        public List<Descripciones> Descripcion { get; set; }

    }
}
