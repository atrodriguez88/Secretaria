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
    class Facultad
    {
        private int IdFacultad;
        private string nombre;

       
        public Facultad(string n)
        {
            this.IdFacultad = 0;
            this.nombre = n;
        }

        public string get_Nombre_Fac()
        {
            return nombre;
        }

        public int get_IdFacultad() 
        {
            return IdFacultad;
        }

        public bool Add(string nombre)
        {
            string query = "INSERT INTO Facultad (nombre) VALUES ('" + nombre + "')";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static DataTable Todo()
        {
            string query = "Select * from Facultad";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Nombre(string nomb)
        {
            string query = "Select nombre from Facultad WHERE  nombre ='" + nomb + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Todo_Nombre(string n)
        {
            string query = "Select nombre from Facultad WHERE  nombre ='" + n + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public  static DataTable Todo_ID(string nombre)
        {
            string query = "Select IdFacultad from Facultad WHERE  nombre ='" + nombre + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }
        public static bool Actualizar(int id,string nuevo)
        {
            string query = "UPDATE Facultad SET nombre = '" + nuevo + "' WHERE  IdFacultad =" + id + " ";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static DataTable Segun_Nombre(string n)
        {
            string query = "Select * from Facultad WHERE  nombre ='" + n + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Nombre_segun_ID(int id)
        {
            string query = "Select * from Facultad WHERE  IdFacultad =" + id + "";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static bool Eliminar(int id)
        {
            string query = "DELETE FROM Facultad WHERE  IdFacultad =" + id + " ";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
    }
}
