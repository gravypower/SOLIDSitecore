using System.Web.Mvc;
using DependencyInversion.Adapters;
using DependencyInversion.Models;

namespace DependencyInversion.Controllers
{
    public class HelloController : Controller
    {
        private readonly ILoggedOnUser _loggedOnUser;

        public HelloController(ILoggedOnUser loggedOnUser)
        {
            _loggedOnUser = loggedOnUser;
        }

        public ActionResult Index()
        {
            return View(new User {Name = _loggedOnUser.Name});
        }
    }
}