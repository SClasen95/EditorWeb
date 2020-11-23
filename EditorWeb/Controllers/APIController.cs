using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using EditorWeb.Models;
using Newtonsoft.Json;
using EditorWeb.DAO;
using Microsoft.AspNetCore.Http;

namespace EditorWeb.Controllers {
    public class APIController : Controller {

        public Boolean Login(String nombre, String contraseña) {
            Usuario u = new Usuario(nombre, contraseña);
            return UsuariosDAO.validarUsuario(u);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
