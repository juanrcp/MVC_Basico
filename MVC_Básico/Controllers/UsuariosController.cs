using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC_Básico.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Con este metodo, establecemos la logica de la lista en el controlador 
        public ActionResult listaUsuarios()
        {
            List<string> listaUsuarios = new List<string>();
            listaUsuarios.Add("Juan Ramon");
            listaUsuarios.Add("Carlos");
            listaUsuarios.Add("Pedro");
            listaUsuarios.Add("Raquel");
            listaUsuarios.Add("Michael");
            listaUsuarios.Add("Alexandra");


            //Formas de guardar la lista segun si se quiere pasar a la vista o a un controlador
            ViewBag.Prueba = "ViewBag";
            TempData["Prueba2"] = "TempData";
            HttpContext.Session.SetString("prueba3", "Session");
            ViewData["Prueba4"] = "ViewData";

            return View(listaUsuarios);
        }


        //Con este metodo, establecemos la logica para recuperar el valor

        [HttpPost] //Con esta etiqueta declaramos el evento post
        public ActionResult listaUsuarios(string selUsuario)
        {
            //ViewBag.Nombre = selUsuario;

            //List<string> listaUsuarios = ViewBag.ListaUsuarios;
            //List<string> listaUsuarios = (List<string>)TempData["ListaUsuarios"];
            //List<string> listaUsuarios = HttpContext.Session.SetString("ListaUsuarios", listaUsuarios);
            //List<string> listaUsuarios = (List<string>)ViewData["ListaUsuarios"];


            return View();
        }
    }
}
