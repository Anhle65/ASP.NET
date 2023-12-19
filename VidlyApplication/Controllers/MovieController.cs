using Microsoft.AspNetCore.Mvc;
using VidlyApplication.Models;

namespace VidlyApplication.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };

            return View(movie);
            //return Content(movie.Name);
        }
    }
}
