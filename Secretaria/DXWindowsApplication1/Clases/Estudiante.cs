using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Drawing;

namespace DXWindowsApplication1
{
    class Estudiante
    {
        private int IdEstudiante;
        private string ci;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private string sexo;
        private string telef;
        private string pais;
        private string direccionParticular;
        private string piel;
        private string provincia;
        private string modalidad;
        private string trabajo;
        private string ocupacion;
        private string organismo;
        private int idExpediente;
        private int idCarrera;
        private string pendienteDePlan;


        public Estudiante(int a, int c)
        {
            this.IdEstudiante = 0;
            this.ci = "";
            this.nombre = "";
            this.primerApellido = "";
            this.segundoApellido = "";
            this.sexo = "";
            this.telef = "";
            this.pais = "";
            this.direccionParticular = "";
            this.piel = "";
            this.provincia = "";
            this.modalidad = "";
            this.trabajo = "";
            this.ocupacion = "";
            this.organismo = "";
            this.idExpediente = a; 
            this.idCarrera = c;
            this.pendienteDePlan = "";
        }


        public bool Add(string ci, string nombre, string primerApellido, string segundoApellido, string sexo, string telef, string pais, string direccionParticular, string piel, string provincia, string modalidad, string trabajo, string ocupacion, string organismo, int idExpediente, int idCarrera, string pendienteDePlan)
        {
            string query = "INSERT INTO Estudiante (CI, Nombre,primerApellido,segundoApellido,sexo,telefono,pais,direccionParticular,piel,provincia,modalidad,centro_trabajo,ocupacion,organismo,idExpediente,idCarrera, pendienteDePlan) VALUES " +
                "('" + ci + "', '" + nombre + "','" + primerApellido + "','" + segundoApellido + "','" + sexo + "','" + telef + "','" + pais + "','" + direccionParticular + "','" + piel + "','" + provincia + "','" + modalidad + "','" + trabajo + "','" + ocupacion + "','" + organismo + "'," + idExpediente + "," + idCarrera + ",'" + pendienteDePlan + "')";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
        public static DataTable Todo()
        {
            string query = "Select * from Estudiante";
            Conexion con = new Conexion();
            DataTable tabla= con.Selecionar(query);
            return tabla;
        }
        public static DataTable Nombre(string n)
        {
            string query = "Select * from Estudiante WHERE  Nombre ='" + n + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable CI(string ci)
        {
            string query = "Select * from Estudiante WHERE  CI ='" + ci + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Expediente(int noEexpediente)
        {
            string query = "SELECT Expediente.noExpediente, Estudiante.* FROM Expediente INNER JOIN Estudiante ON Expediente.noExpediente = Estudiante.idExpediente WHERE (((Expediente.noExpediente)="+noEexpediente+"));";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Apellido(string primerApellido)
        {
            string query = "Select * from Estudiante WHERE  primerApellido ='" + primerApellido + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Ci_primerApellido(string ci,string primerApellido)
        {
            string query = "Select * from Estudiante WHERE  CI ='" + ci + "'  AND primerApellido ='" + primerApellido + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Ci_Nombre(string ci, string nombre)
        {
            string query = "Select * from Estudiante WHERE  CI ='" + ci + "' AND Nombre ='" + nombre + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Nombre_Apellido(string nombre, string primerApellido)
        {
            string query = "Select * from Estudiante WHERE  Nombre ='" + nombre + "' AND primerApellido ='" + primerApellido + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Ci_Nombre_Apellido(string ci, string nombre, string primerApellido)
        {
            string query = "Select * from Estudiante WHERE  CI ='" + ci + "' AND Nombre ='" + nombre + "' AND primerApellido ='" + primerApellido + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Pendientes ()
        {
            string query = "SELECT Estudiante.* FROM Estudiante WHERE (((Estudiante.pendienteDePlan)='"+"si"+"'))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static bool Actualizar(int id, string ci, string nombre, string primerApellido, string segundoApellido, string sexo, string telef, string pais, string direccion, string piel, string provincia, string modalidad, string trabajo, string ocupacion, string organismo, int idExpediente, int idCarrera)
        {
            string query = "UPDATE Estudiante SET CI = '" + ci + "', Nombre = '" + nombre + "', primerApellido = '" + primerApellido + "', segundoApellido = '" + segundoApellido + "', sexo = '" + sexo + "', telefono = '" + telef + "', pais = '" + pais + "', direccionParticular = '" + direccion + "', piel = '" + piel + "', provincia = '" + provincia + "', modalidad = '" + modalidad + "', centro_trabajo = '" + trabajo + "', ocupacion = '" + ocupacion + "', organismo = '" + organismo + "', idExpediente = " + idExpediente + ", idCarrera = " + idCarrera + " WHERE  IdEstudiante =" + id + " ";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static bool PendienteDePlan(int id)
        {
            string query = "UPDATE Estudiante SET Estudiante.pendienteDePlan = '"+"Si"+"' WHERE (((Estudiante.IdEstudiante)="+id+"))";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static bool QuitadoPendienteDePlan(int id)
        {
            string query = "UPDATE Estudiante SET Estudiante.pendienteDePlan = '" + "No" + "' WHERE (((Estudiante.IdEstudiante)=" + id + "))";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static DataTable DecirSiEstaPendienteDePlan(int id)
        {
            string query = "SELECT Estudiante.pendienteDePlan, Estudiante.IdEstudiante FROM Estudiante WHERE (((Estudiante.IdEstudiante)=" + id + "))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static bool Eliminar(int id)
        {
            string query = "DELETE FROM Estudiante WHERE  IdEstudiante =" + id + " ";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

    }
}
