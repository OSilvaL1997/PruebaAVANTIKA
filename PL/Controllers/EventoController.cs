using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class EventoController : Controller
    {
        // GET: Evento
        //[HttpGet]
        public ActionResult GetAll()
        {
            ML.Evento evento = new ML.Evento();
            evento.Eventos = new List<object>();
            ML.Result result = BL.Evento.GetAllEvento();
            if (result.Correct)
            {
                evento.Eventos = result.Objects.ToList();
            }
            return View(evento);
        }
    }
}