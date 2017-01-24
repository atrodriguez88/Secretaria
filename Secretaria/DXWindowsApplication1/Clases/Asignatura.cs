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
    class Asignatura
    {
        private int IdAsignatura;
        private string nombre;
        private string descripcion;
        private int horas;


        public Asignatura(string n, string m)
        {
            this.IdAsignatura = 0;
            this.nombre = n;
            this.descripcion = m;
            this.horas = 0;
        }

        public bool Add(string nombre, string descripcion,int horas)
        {
            string query = "INSERT INTO Asignatura (nombre,descripcion,horas) VALUES ('" + nombre + "','" + descripcion + "'," + horas + ")";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static DataTable Dame_Nombre(string n)
        {
            string query = "Select nombre from Asignatura WHERE  nombre ='" + n + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Segun_Nombre(string n)
        {
            string query = "Select * from Asignatura WHERE  nombre ='" + n + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }
        public static DataTable Segun_Nombre_Descripcion_Horas(string nombre, string descrip, int horas)
        {
            string query = "SELECT Asignatura.IdAsignatura, Asignatura.nombre, Asignatura.descripcion, Asignatura.horas FROM Asignatura WHERE (((Asignatura.nombre)='"+nombre+"') AND ((Asignatura.descripcion)='"+descrip+"') AND ((Asignatura.horas)="+horas+"))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        //public static DataTable Segun_Nombre_Horas(string nombre, int horas)
        //{
        //    string query = "SELECT Asignatura.IdAsignatura, Asignatura.nombre, Asignatura.descripcion, Asignatura.horas FROM Asignatura WHERE (((Asignatura.nombre)='" + nombre + "') AND ((Asignatura.descripcion)='" + descrip + "') AND ((Asignatura.horas)=" + horas + "))";
        //    Conexion con = new Conexion();
        //    DataTable tabla = con.Selecionar(query);
        //    return tabla;
        //}

        public static bool Eliminar(int id)
        {
            string query = "DELETE FROM Asignatura WHERE  IdAsignatura =" + id + " ";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
        public static bool Actualizar(int id, string nuevo, string descripcion, int horas)
        {
            string query = "UPDATE Asignatura SET nombre = '" + nuevo + "', descripcion= '" + descripcion + "', horas= " + horas + " WHERE  IdAsignatura =" + id + "";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
        public static DataTable Todo()
        {
            string query = "Select * from Asignatura";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }
    }
}
