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
    class Est_Asig
    {
        private string nota;
        private int IdAsignatura;
        private int IdEstudiante;
        private string cursos;
        private string asignatura;

        public Est_Asig(string nota, string cursos, string asignatura)
        {
            this.nota = nota;
            this.IdAsignatura = 0;
            this.IdEstudiante = 0;
            this.cursos = cursos;
            this.asignatura = asignatura;
        }

        public bool Add(string nota, int IdAsignatura, int IdEstudiante, string cursos, string asignatura)
        {
            string query = "INSERT INTO Est_Asig (nota,IdAsignatura,IdEstudiante,cursos,asignatura) VALUES ('" + nota + "','" + IdAsignatura + "','" + IdEstudiante + "','" + cursos + "','" + asignatura + "')";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }

        public static DataTable segun_ID(int id)
        {
            string query = "Select * from Est_Asig WHERE  IdEstudiante =" + id + "";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

        public static DataTable Informacion(int id)
        {
            string query = "SELECT Est_Asig.cursos, Est_Asig.asignatura, Est_Asig.nota, Est_Asig.IdEstudiante FROM Est_Asig WHERE (((Est_Asig.IdEstudiante)="+id+")) ORDER BY Est_Asig.cursos";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }

    }
}
