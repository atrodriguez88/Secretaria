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
    public partial class planEstudio : DevExpress.XtraEditors.XtraForm
    {
        string aux;
        int idEstudiante;
        string modalidad;
        int idCarrera;
        string carrera;
        string nombrePlan;


        public planEstudio(string ci)
        {
            InitializeComponent();
            aux = ci;
        }

        private void planEstudio_Load(object sender, EventArgs e)
        {
            DataTable var = Estudiante.CI(aux);
            idEstudiante = int.Parse(var.Rows[0].ItemArray[0].ToString());
            modalidad = var.Rows[0].ItemArray[11].ToString();
            idCarrera = int.Parse(var.Rows[0].ItemArray[16].ToString());

            DataTable var2 = Carrera.Nombre_Dado_ID(idCarrera);
            carrera = var2.Rows[0].ItemArray[1].ToString();

            DataTable var3 = PlnDE.Carrera_Modalidad(carrera,modalidad);

            for (int i = 0; i < var3.Rows.Count; i++)
            {

                comboBox1.Items.Add(((Array)var3.Rows[i].ItemArray).GetValue(2));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "--- Pendiente de Plan de Estudio ---")
            {
                MessageBox.Show("Estudiante movido a 'Pendientes de Plan de Estudio'");
                Estudiante.PendienteDePlan(idEstudiante);
                Close();
                
            }
            else
            {
                    nombrePlan = comboBox1.Text;
                    DataTable var4 = PlnDE.Nombrexx(nombrePlan, carrera, modalidad);
                    planEstudiante plan = new planEstudiante(var4,idEstudiante,modalidad);
                    plan.ShowDialog();
                    Close();
            }
           
        }
    }
}