using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorWeb.DAO {

    public class Usuario {

        public int id { get; set; }
        public String nombre { get; set; }
        public String contraseña { get; set; }

        public String clave { get; set; }

        public Usuario(String nombre, String contraseña, string clave) {
            this.nombre = nombre;
            this.contraseña = contraseña;
            this.clave = clave;
        }

        public Usuario(string nombre, string contraseña) {
            this.nombre = nombre;
            this.contraseña = contraseña;
            clave = null;
        }
    }
}
