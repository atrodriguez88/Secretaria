using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;

namespace DXWindowsApplication1
{
    class Conexion
    {
        private string conection;
        private OleDbConnection con;

        public Conexion(string conection)
        {
            this.conection = conection;
            con = new OleDbConnection(this.conection);

        }
        public Conexion()
        {
            this.conection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=\"Tesis.mdb\"";
            con = new OleDbConnection(this.conection);
        }
        public bool Actualizar(string consulta)
        {
            try
            {
                con.Open();
                OleDbCommand co = new OleDbCommand(consulta, con);
                co.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
        }

        public DataTable Selecionar(string consulta)
        {
            OleDbDataAdapter da = new OleDbDataAdapter(consulta, con);

            DataSet ds = new DataSet();

            da.Fill(ds);
            DataTable dt = ds.Tables[0];
            return dt;
        }

        public string Conection
        {
            get { return this.conection; }
            set { this.conection = value; }
        }
    
    }
}
