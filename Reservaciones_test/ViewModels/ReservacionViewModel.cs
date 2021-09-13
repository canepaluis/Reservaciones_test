using Reservaciones_test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reservaciones_test.ViewModels
{
    public class ReservacionViewModel
    {
        public IEnumerable<Destinos> ListaDestinos { get; set; }
        public IEnumerable<Hoteles> ListaHoteles { get; set; }
        public IEnumerable<Habitaciones> ListaHabitaciones { get; set; }


    }
}
