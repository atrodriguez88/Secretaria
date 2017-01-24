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
    public partial class infoEstudiante : DevExpress.XtraEditors.XtraForm
    {

        string CI;
        string NOMBRE;
        string PRIMER;
        string SEGUNDO;
        string SEXO;
        string TELEF;
        string PAIS;
        string DIRECCION;
        string Piel;
        string PROVINCIA;
        string MODALIDAD;
        string TRABAJO;
        string OCUPACION;
        string ORGANISMO;
        int CARRERA;

        public infoEstudiante(string ci, string nombre, string primerApellido, string segundoApellido, string sexo, string telef, string pais, string direccion, string piel, string provincia, string modalidad, string trabajo, string ocupacion, string organismo, int idCarrera)
        {
            InitializeComponent();
            CI = ci;
            NOMBRE = nombre;
            PRIMER = primerApellido;
            SEGUNDO = segundoApellido;
            SEXO = sexo;
            TELEF = telef;
            PAIS = pais;
            DIRECCION = direccion;
            Piel = piel;
            PROVINCIA = provincia;
            MODALIDAD = modalidad;
            TRABAJO = trabajo;
            OCUPACION = ocupacion;
            ORGANISMO = organismo;
            CARRERA = idCarrera;

             

        }

        private void infoEstudiante_Load(object sender, EventArgs e)
        {
            DataTable var2 = Carrera.Nombre_Dado_ID(CARRERA);
            string d = var2.Rows[0].ItemArray[1].ToString();
            int c = int.Parse(var2.Rows[0].ItemArray[2].ToString());
            DataTable var3 = Facultad.Nombre_segun_ID(c);
            string fa = var3.Rows[0].ItemArray[1].ToString();

            lbNom.Text = NOMBRE;
            lbPrimerApell.Text = PRIMER;
            lbSegundoApell.Text = SEGUNDO;
            lbCarnet.Text = CI;
            lbSex.Text = SEXO;
            lbColorPiel.Text = Piel;
            lbDireccionParticular.Text = DIRECCION;
            lbPaiss.Text = PAIS;
            lbTelefono.Text = TELEF;
            lbProvinc.Text = PROVINCIA;
            lbFac.Text = fa;
            lbTipo.Text = MODALIDAD;
            lbCarr.Text = d;
            if(TRABAJO=="" && OCUPACION==""&& ORGANISMO=="")
            {
                lbTrabajo.Text = "Ninguno";
                lbOcupacion.Text = "Ninguna";
                lbOrganismo.Text = "Ninguno";
            }
            else
            {
                lbTrabajo.Text = TRABAJO;
                lbOcupacion.Text = OCUPACION;
                lbOrganismo.Text = ORGANISMO;
            }

            


        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}