using CRUDTEST.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CRUDTEST.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Conexion conexion;

        public UsuarioController(Conexion con)
        {
            conexion = con;
        }
        // GET: UsuarioController1
        public ActionResult login()
        {
            ClaimsPrincipal principal = HttpContext.User;
            if(principal.Identity != null) 
            { 
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}
