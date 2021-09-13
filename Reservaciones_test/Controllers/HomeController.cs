using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Reservaciones_test.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Dynamic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Reservaciones_test.Data;
using Microsoft.EntityFrameworkCore;
using Reservaciones_test.ViewModels;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Data;

namespace Reservaciones_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _cc;

        public HomeController(ApplicationDbContext cc)
        {
            _cc = cc;
        }

        public ActionResult Index()
        {
            using (var dbcon = _cc)
            {
                var model = new ReservacionViewModel
                {
                    ListaDestinos = dbcon.Destinos.ToList(),
                    ListaHoteles = dbcon.Hoteles.ToList(),
                    ListaHabitaciones = dbcon.Habitaciones.ToList()
                };
                return View(model);
            }
        }

        public ActionResult RailService(int id)
        {
            
            var dbcon = _cc;
            List<Descripciones> descripcioneslist = dbcon.Descripciones.ToList();
            List<Destinos> destinoslist = dbcon.Destinos.ToList();
            List<T_Habitaciones> t_habitacioneslist = dbcon.T_Habitaciones.ToList();
            List<Servicios> servicioslist = dbcon.Servicios.ToList();

            ViewData["jointables"] = from desc in descripcioneslist
                                     join dest in destinoslist
                                     on desc.DestinoId equals dest.Id into table1
                                     from dest in table1.DefaultIfEmpty()
                                     join t_hab in t_habitacioneslist on desc.T_HabitacionId equals t_hab.Id into table2 from t_hab in table2.DefaultIfEmpty()
                                     join serv in servicioslist on desc.ServicioId equals serv.Id into table3 from serv in table3.DefaultIfEmpty()
                                     where desc.DestinoId==id
                                     select new MultipleTablesJoinClass
                                     { descripcioneslist = desc, destinoslist = dest, t_Habitacioneslist = t_hab, servicioslist = serv };

            return View(ViewData["jointables"]);
 
        }

        [HttpPost]
        public IActionResult Details(string fecha)
        {
            
            ViewBag.destino = Request.Form["destino"];
            ViewBag.hotel = Request.Form["hotel"];
            ViewBag.fecha = fecha;
            ViewBag.habitacion = Request.Form["habitacion"];
            ViewBag.adultos = Request.Form["adultos"];
            ViewBag.menores = Request.Form["menores"];
            int habitacion = int.Parse(ViewBag.habitacion);
            int adultos = int.Parse(ViewBag.adultos);
            int menores = int.Parse(ViewBag.menores);
            int subtotal = (adultos + menores)*habitacion;
            ViewBag.total = subtotal;
            JsonSerialize(ViewBag, "json/reservacion_data.save");
            return View();
        }

        public IActionResult JsonDos()
        {
            ViewBag.habitacion = Request.Form["modelo"];
            ViewBag.adultos = Request.Form["adultos"];
            ViewBag.menores = Request.Form["menores"];
            JsonSerialize(ViewBag, "json/aparado_data.save");
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void JsonSerialize(object data, string filePath)
        {
            JsonSerializer jsonserialize = new JsonSerializer();
            StreamWriter sw = new StreamWriter(filePath);
            JsonWriter jsonWriter = new JsonTextWriter(sw);

            jsonserialize.Serialize(jsonWriter, data);
            jsonWriter.Close();
            sw.Close();

        }

        public ActionResult Json()
        {
            
            return View();
        }


    }
}
