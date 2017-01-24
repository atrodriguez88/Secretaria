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
    public partial class nuevoPlanNombre : DevExpress.XtraEditors.XtraForm
    {
        public string Nombre { get; set; }
        DataTable aux;
        string modalidad;

        public nuevoPlanNombre(DataTable plan, string mod)
        {
            InitializeComponent();
            aux = plan;
            modalidad = mod;
        }

        private void nuevoPlanNombre_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = modalidad;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Nombre = textBox1.Text;
            modalidad = comboBox1.Text;


            for (int i = 0; i < ((DataTable)aux).Rows.Count; i++)
            {
                string carrera=(((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(5)).ToString();
                string año = (((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(6)).ToString();
                string semestre = (((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(7)).ToString();
                string asignatura = (((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(1)).ToString();
                int horas = int.Parse((((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(2)).ToString());
                string descripcion = (((Array)((DataTable)aux).Rows[i].ItemArray).GetValue(3)).ToString();

                DataTable var3 = Asignatura.Segun_Nombre_Descripcion_Horas(asignatura, descripcion, horas);
                int idAsignatura = int.Parse(var3.Rows[0].ItemArray[0].ToString());

               
                 PlnDE plan = new PlnDE(Nombre, carrera, año, semestre, modalidad);
                 plan.Add(Nombre, carrera, año, semestre, idAsignatura, modalidad);

                
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        

       
    }
}