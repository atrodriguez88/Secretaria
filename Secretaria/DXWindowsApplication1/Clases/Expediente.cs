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
    class Expediente
    {
        private int IdExpediente;
        private int noExpediente;
        private int noConsecutivo;


        public Expediente( int IdExpediente, int noExpediente, int noConsecutivo)
            {
                this.IdExpediente = IdExpediente;
                this.noExpediente = noExpediente;
                this.noConsecutivo = noConsecutivo;
            }
        public Expediente()
        {
            this.IdExpediente = 0;
            this.noExpediente = 0;
            this.noConsecutivo = 0;
        }

        public bool Add(int noExpediente, int noConsecutivo)
        {
            string query = "INSERT INTO Expediente (noExpediente, noConsecutivo) VALUES ('" + noExpediente + "', '" + noConsecutivo + "')";
            Conexion con = new Conexion();
            return con.Actualizar(query);
        }
        public static DataTable Todo(int noExpediente)
        {
            string query = "Select * from Expediente WHERE noExpediente=" + noExpediente + " ";
            Conexion con = new Conexion();
            DataTable tabla = con.Selecionar(query);
            return tabla;
        }
       
        public int GetId()
        {
            return IdExpediente;
        }
    }
}
