using Microsoft.AspNetCore.Mvc;
using Reserva.Models;

namespace Reserva.Controllers
{
    public class ReservaController : Controller
    {
        public IActionResult Index()
        {
            List<ReservaModel> reservas = new List<ReservaModel>();

            ReservaModel reserva = new ReservaModel();
            reserva.Nome = "Guilherme";

            ReservaModel novaReserva = new ReservaModel();
            novaReserva.Nome = "Paulo";


            reservas.Add(reserva);
            reservas.Add(novaReserva);

            return View(reservas);
        }
    }
}
