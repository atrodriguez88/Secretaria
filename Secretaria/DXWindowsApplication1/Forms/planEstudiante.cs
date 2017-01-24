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
    public partial class planEstudiante : DevExpress.XtraEditors.XtraForm
    {
        DataTable aux;
        int auxEstudiante;
        string auxModalidad;

        public planEstudiante(DataTable plan, int idEstudiante, string modalidad)
        {
            InitializeComponent();
            aux = plan;
            auxEstudiante = idEstudiante;
            auxModalidad = modalidad;
        }

        private void planEstudiante_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = aux;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estudiante movido a 'Pendientes de Plan de Estudio'");
            Estudiante.PendienteDePlan(auxEstudiante);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduzca el Año del '1° Año'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                for (int i = 0; i < ((DataTable)aux).Rows.Count; i++)
                {
                    int idAsignatura = int.Parse((((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(0)).ToString());
                    string nombreAsignatura = (((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(1)).ToString();
                    string ano = (((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(6)).ToString();
                    string nota = dataGridView1.Rows[i].Cells[9].Value.ToString();

                    int var = int.Parse(textBox1.Text);
                    int a = var + 1;
                    int b = a + 1;
                    int c = b + 1;
                    int d = c + 1;
                    int f = d + 1;
                    int g = f + 1;

                    string uno = (var.ToString() + "-" + a.ToString());
                    string dos = (a.ToString() + "-" + b.ToString());
                    string tres = (b.ToString() + "-" + c.ToString());
                    string cuatro = (c.ToString() + "-" + d.ToString());
                    string cinco = (d.ToString() + "-" + f.ToString());
                    string seis = (f.ToString() + "-" + g.ToString());

                    if (ano == "1° Año")
                    {
                        Est_Asig est = new Est_Asig(nota, uno, nombreAsignatura);
                        est.Add(nota, idAsignatura, auxEstudiante, uno, nombreAsignatura);
                    }
                    if (ano == "2° Año")
                    {
                        Est_Asig est = new Est_Asig(nota, dos, nombreAsignatura);
                        est.Add(nota, idAsignatura, auxEstudiante, dos, nombreAsignatura);
                    }
                    if (ano == "3° Año")
                    {
                        Est_Asig est = new Est_Asig(nota, tres, nombreAsignatura);
                        est.Add(nota, idAsignatura, auxEstudiante, tres, nombreAsignatura);
                    }
                    if (ano == "4° Año")
                    {
                        Est_Asig est = new Est_Asig(nota, cuatro, nombreAsignatura);
                        est.Add(nota, idAsignatura, auxEstudiante, cuatro, nombreAsignatura);
                    }
                    if (ano == "5° Año")
                    {
                        Est_Asig est = new Est_Asig(nota, cinco, nombreAsignatura);
                        est.Add(nota, idAsignatura, auxEstudiante, cinco, nombreAsignatura);

                    }
                    if (ano == "6° Año")
                    {
                        Est_Asig est = new Est_Asig(nota, seis, nombreAsignatura);
                        est.Add(nota, idAsignatura, auxEstudiante, seis, nombreAsignatura);
                    }
                }

                DataTable variable = Estudiante.DecirSiEstaPendienteDePlan(auxEstudiante);
                string an = variable.Rows[0].ItemArray[0].ToString();
                if (an == "Si")
                {
                    Estudiante.QuitadoPendienteDePlan(auxEstudiante);
                    MessageBox.Show("Notas Guardadas Con éxito y Estudiante quitado de 'Pendientes de Plan de Estudio'");
                    Close();
                }
                else
                {
                    MessageBox.Show("Notas Guardadas Con éxito");
                    Close();
                }

            }
        }
    }
}