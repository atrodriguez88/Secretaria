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
    class PlnDE
    {
        private int idPlan;
        private string Nombre;
        private string Carrera;
        private string Año;
        private string Semestre;
        private int Asig;
        private string Modalidad;

        public PlnDE(string Nombre, string Carrera, string Año, string Semestre, string Modalidad)
        {
            this.idPlan = 0;
            this.Nombre = Nombre;
            this.Asig = 0;
            this.Carrera = Carrera;
            this.Año = Año;
            this.Semestre = Semestre;
            this.Modalidad = Modalidad;
           
        }

        public bool Add(string Nombre, string Carrera, string Año, string Semestre, int Asig, string Modalidad)
        {
            string query = "INSERT INTO PlnDE (Nombre,Carrera,Año,Semestre,Asig,Modalidad) VALUES ('" + Nombre + "','" + Carrera + "','" + Año + "','" + Semestre + "'," + Asig + ",'" + Modalidad + "')";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
        public static DataTable Nombrexx(string n, string m, string mod)
        {
            string query = "SELECT Asignatura.IdAsignatura, Asignatura.nombre, Asignatura.horas, Asignatura.descripcion, PlnDE.Nombre, PlnDE.Carrera, PlnDE.Año, PlnDE.Semestre, PlnDE.Modalidad FROM Asignatura INNER JOIN PlnDE ON Asignatura.IdAsignatura = PlnDE.Asig WHERE (((PlnDE.Nombre)='"+n+"') AND ((PlnDE.Carrera)='"+m+"') AND ((PlnDE.Modalidad)='"+mod+"')) ORDER BY PlnDE.Año, PlnDE.Semestre";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }
        public static DataTable Nombre_Modalidad(string n, string mod)
        {
            string query = "SELECT PlnDE.Nombre, PlnDE.Modalidad, PlnDE.Carrera FROM Asignatura INNER JOIN PlnDE ON Asignatura.IdAsignatura = PlnDE.Asig GROUP BY PlnDE.Nombre, PlnDE.Modalidad, PlnDE.Carrera HAVING (((PlnDE.Nombre)='"+n+"') AND ((PlnDE.Modalidad)='"+mod+"'))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Carrera_Modalidad(string m, string mod)
        {
            string query = "SELECT PlnDE.Carrera, PlnDE.Modalidad, PlnDE.Nombre FROM PlnDE GROUP BY PlnDE.Carrera, PlnDE.Modalidad, PlnDE.Nombre HAVING (((PlnDE.Carrera)='"+m+"') AND ((PlnDE.Modalidad)='"+mod+"'))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Nombre_Carrera(string n, string m)
        {
            string query = "SELECT PlnDE.Nombre, PlnDE.Carrera, PlnDE.Modalidad FROM PlnDE GROUP BY PlnDE.Nombre, PlnDE.Carrera, PlnDE.Modalidad HAVING (((PlnDE.Nombre)='"+n+"') AND ((PlnDE.Carrera)='"+m+"'))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Modalida(string mod)
        {
            string query = "SELECT PlnDE.Modalidad, PlnDE.Nombre, PlnDE.Carrera FROM PlnDE GROUP BY PlnDE.Modalidad, PlnDE.Nombre, PlnDE.Carrera HAVING (((PlnDE.Modalidad)='"+mod+"'))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Nombress()
        {
            string query = "SELECT PlnDE.Nombre FROM PlnDE";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Dado_Plan_Carrera(string nombrePlan)
        {
            string query = "SELECT PlnDE.Nombre, PlnDE.Carrera FROM Asignatura INNER JOIN PlnDE ON Asignatura.IdAsignatura = PlnDE.Asig GROUP BY PlnDE.Nombre, PlnDE.Carrera HAVING (((PlnDE.Nombre)='"+nombrePlan+"'))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Dado_Carrera_Plan(string nombreCarrera)
        {
            string query = "SELECT PlnDE.Carrera, PlnDE.Nombre FROM Asignatura INNER JOIN PlnDE ON Asignatura.IdAsignatura = PlnDE.Asig GROUP BY PlnDE.Carrera, PlnDE.Nombre HAVING (((PlnDE.Carrera)='"+nombreCarrera+"'))";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable SegunPlan(string n)
        {
            string query = "SELECT PlnDE.Nombre, PlnDE.Carrera FROM PlnDE WHERE (((PlnDE.Nombre)='"+n+"'))";

            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static bool ActualizarPlan(int idPlan, int idAsignatura,string semestre, string ano, string nombreAsignatura)
        {
            string query = "UPDATE Asignatura INNER JOIN PlnDE ON Asignatura.IdAsignatura = PlnDE.Asig SET PlnDE.Año = '"+ ano +"', PlnDE.Semestre = '"+ semestre +"', Asignatura.nombre = '"+nombreAsignatura+"' WHERE (((PlnDE.idPlan)="+ idPlan +") AND ((PlnDE.Asig)="+idAsignatura+"))";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }


        public static DataTable Asi(string n, string m, string mod)
        {
            string query = "SELECT PlnDE.Nombre, PlnDE.Carrera, PlnDE.Año, PlnDE.Semestre, Asignatura.nombre, Asignatura.horas, PlnDE.Modalidad, PlnDE.idPlan, PlnDE.Asig FROM Asignatura INNER JOIN PlnDE ON Asignatura.IdAsignatura = PlnDE.Asig WHERE (((PlnDE.Nombre)='"+n+"') AND ((PlnDE.Carrera)='"+m+"') AND ((PlnDE.Modalidad)='"+mod+"')) ORDER BY PlnDE.Año, PlnDE.Semestre";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

    }
}
