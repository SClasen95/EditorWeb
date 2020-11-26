using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EditorWeb.DAO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EditorWeb.Controllers
{

    public class UsuarioController : Controller
    {
        [HttpPost]
        public IActionResult registrarUsuario(String nombre, String contraseña, String clave)
        {
            var camposObligatorios = nombre != null && contraseña != null && clave != null;
            Usuario u = new Usuario(nombre, contraseña, clave);
            if (!UsuariosDAO.existeUsuario(u) && UsuariosDAO.keyValida(clave)) {
                UsuariosDAO.agregarUsuario(u);
                ViewBag.msg = "El usuario fue creado con exito.";
            } else { 
                ViewBag.msg = "El usuario ya existe o la clave es invalida.";
            }
            return View("../Home/Registro"); 
        }

        public IActionResult loguearUsuario(String nombre, String contraseña) {
            Usuario u = new Usuario(nombre, contraseña);
            if (UsuariosDAO.validarUsuario(u)) {
                HttpContext.Session.SetString("usuario", JsonConvert.SerializeObject(u));
                ViewBag.usuario = u;
                return View("../Home/Index");
            }else {
                ViewBag.msg = "El usuario no existe.";
                return View("../Home/Login");
            }            
        }
        public IActionResult Logout() {
            HttpContext.Session.Clear();
            ViewBag.usuario = null;
            return Redirect("/Home/Index");
        }












        /*  public string Get()
          {
              //PersonasDAO
              var usuarios = UsuariosDAO.verUsuarios();
              return JsonConvert.SerializeObject(usuarios);

          }*/

        /* public string Get(int id)
         {
             var usuarios = UsuariosDAO.verUsuario(id);

             return JsonConvert.SerializeObject(usuarios);
         }*/


    }
}
