using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EditorWeb.DAO {
    public static class UsuariosDAO {

        public static void agregarUsuario(Usuario usuario) {

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("INSERT INTO usuario (nombre,contraseña,clave) VALUES (@nombre,@contraseña,@clave)");
            queryBuilder.addParam("@nombre", usuario.nombre);
            queryBuilder.addParam("@contraseña", usuario.contraseña);
            queryBuilder.addParam("@clave", usuario.clave);
            DBConnection.getInstance().abm(queryBuilder);
            queryBuilder.setQuery("UPDATE claves SET estado=@estado WHERE clave=@clave");
            queryBuilder.addParam("@clave", usuario.clave);
            queryBuilder.addParam("@estado", "No Disponible");
            DBConnection.getInstance().abm(queryBuilder);

        }

        public static Boolean existeUsuario(Usuario usuario) {
            Boolean ret = false;
            String nombre = usuario.nombre;

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            queryBuilder.setQuery("SELECT * FROM usuario WHERE nombre=@nombre");
            queryBuilder.addParam("@nombre", nombre);
            var dataReader = DBConnection.getInstance().select(queryBuilder);
            while (dataReader.Read() && !ret) {
                ret = dataReader.GetString(1).Equals(nombre);
            }
            return ret;
        }

        public static Boolean validarUsuario(Usuario usuario) {
            Boolean ret = false;
            String nombre = usuario.nombre;
            String contraseña = usuario.contraseña;

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            queryBuilder.setQuery("SELECT * FROM usuario WHERE nombre=@nombre");
            queryBuilder.addParam("@nombre", nombre);
            var dataReader = DBConnection.getInstance().select(queryBuilder);
            while (dataReader.Read() && !ret) {
                ret = dataReader.GetString(1).Equals(nombre) && dataReader.GetString(2).Equals(contraseña);
            }
            return ret;
        }
    
        public static Boolean keyValida(String key) {
            Boolean ret = false;
            Boolean flag = false;
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            queryBuilder.setQuery("SELECT * FROM claves WHERE clave=@clave");
            queryBuilder.addParam("@clave", key);
            var dataReader = DBConnection.getInstance().select(queryBuilder);
            while (dataReader.Read()&&!flag) {
                flag = dataReader.GetString(1).Equals(key);
                ret = flag && dataReader.GetString(2).Equals("Disponible");
            }
            return ret;
        }

        /*public static List<Usuario> verUsuarios() {
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            queryBuilder.setQuery("SELECT * FROM usuario");
            var dataReader = DBConnection.getInstance().select(queryBuilder);
            var lista = new List<Usuario>();
            while (dataReader.Read()) {
                var usuario = new Usuario(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
                lista.Add(usuario);
            }
            return lista;
        }*/

        /*public static Usuario verUsuario(int id) {

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("SELECT * FROM usuario WHERE id=@id");
            queryBuilder.addParam("@id", id);

            var dataReader = DBConnection.getInstance().select(queryBuilder);
            Usuario usuario = null;
            while (dataReader.Read()) {
                usuario = new Usuario(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
            }
            return usuario;
        }*/

        /*public static void eliminarUsuario(Usuario usuario) {
            var queryBuilder = DBConnection.getInstance().getQueryBuilder();
            queryBuilder.setQuery("DELETE FROM usuario WHERE id=@id");
            queryBuilder.addParam("@id", usuario.id);
            DBConnection.getInstance().abm(queryBuilder);
        }*/

        // SOBRECARGA
        /*public static void eliminarUsuario(int id) {

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("DELETE FROM usuario WHERE id=@id");
            queryBuilder.addParam("@id", id);

            DBConnection.getInstance().abm(queryBuilder);

        }*/

        /*public static void actualizarUsuario(Usuario usuario) {

            var queryBuilder = DBConnection.getInstance().getQueryBuilder();

            queryBuilder.setQuery("UPDATE usuario SET nombre=@nombre,contraseña=@contraseña WHERE id=@id");
            queryBuilder.addParam("@nombre", usuario.nombre);
            queryBuilder.addParam("@contraseña", usuario.contraseña);

            DBConnection.getInstance().abm(queryBuilder);


        }*/

    }
}
