using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.Models
{
    public class MultipleTablesJoinClass
    {
        public Descripciones descripcioneslist { get; set; }
        public Destinos destinoslist { get; set; }
        public T_Habitaciones t_Habitacioneslist { get; set; }
        public Servicios servicioslist { get; set; }
    }
}
