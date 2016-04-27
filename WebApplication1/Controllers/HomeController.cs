using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string getUsers()
        {
            IList<User> userList = new List<User> { new User { ID = 1, Nombre = "Bruno", Apellido = "Tello" },
                new User { ID = 2, Nombre = "Nicolas", Apellido = "Buzzi" } };

            JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
            return javaScriptSerializer.Serialize(userList);
        }

    }
}