using Microsoft.AspNetCore.Mvc;

namespace Tickets.Controllers
{
    public class TicketController : Controller
    {
        // GET: TicketController
        public ActionResult Index()
        {

            return View();
        }
    }
}
