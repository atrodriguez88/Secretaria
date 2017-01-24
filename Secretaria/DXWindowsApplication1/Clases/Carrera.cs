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
    class Carrera
    {
        private int IdCArrera;
        private string nombre;
        private int idFacultad;

       
        public Carrera(int a)
        {
            IdCArrera = 0;
            nombre = "";
            idFacultad = a;
        }

        public int GetIdCarr() 
        {
            return IdCArrera;
        }

        public bool Add(string nombre, int idFacultad)
        {
            string query = "INSERT INTO Carrera (nombre, idFacultad) VALUES ('" + nombre + "', " + idFacultad + ")";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static DataTable Todo()
        {
            string query = "Select * from Carrera";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Todo_Nombre(string n)
        {
            string query = "Select * from Carrera WHERE  nombre ='" + n + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable TodoCarrera_id(int facultad)
        {
            string query = "Select * from Carrera WHERE  idFacultad =" + facultad + "";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable ID(string nombre)
        {
            string query = "Select IdCArrera from Carrera WHERE  nombre ='" + nombre + "'";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Nombre_Dado_ID(int id)
        {
            string query = "Select * from Carrera WHERE  IdCArrera =" + id + "";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static bool Actualizar(int id, string nuevo, int idFacultad)
        {
            string query = "UPDATE Carrera SET nombre = '" + nuevo + "', idFacultad = '" + idFacultad + "'  WHERE  IdCArrera =" + id + " ";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static bool Eliminar(int id)
        {
            string query = "DELETE FROM Carrera WHERE  IdCArrera =" + id + " ";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
    }
}
