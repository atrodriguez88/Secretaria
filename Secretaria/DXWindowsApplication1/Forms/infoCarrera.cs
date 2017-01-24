using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXWindowsApplication1
{
    public partial class infoCarrera : DevExpress.XtraEditors.XtraForm
    {
        string aux;
        int ID;
        public infoCarrera(string nombre, int id)
        {
            InitializeComponent();
            aux = nombre;
            ID = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void infoFacultad_Load(object sender, EventArgs e)
        {
            lbNom.Text = aux;

            DataTable varAux = Facultad.Nombre_segun_ID(ID);
            string d = varAux.Rows[0].ItemArray[1].ToString();

            lbFac.Text = d;
        }
    }
}