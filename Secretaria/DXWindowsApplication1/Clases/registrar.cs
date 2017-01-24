using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DXWindowsApplication1
{
    class registrar
    {
        private string usuario;
        private string pass;

        public registrar(string usuario, string pass)
        {
            this.usuario = usuario;
            this.pass = pass;
        }

        public registrar()
        {
            this.usuario = "";
            this.pass = "";
        }

        public DataTable Mostrar_usuario()
        {
            string query = "SELECT usuario,pass FROM Login;";
            Conexion con = new Conexion();
            DataTable dt = con.Selecionar(query);
            return dt;
        }


        public bool Actualizar(string user, string pass)
        {
            string query = "UPDATE Login SET pass = '" + pass + "' WHERE usuario='" + user + "'";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
    }
}
