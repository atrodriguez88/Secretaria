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
    public partial class planaPartirdeOtro : DevExpress.XtraEditors.XtraForm
    {
        public planaPartirdeOtro()
        {
            InitializeComponent();
        }

        string nombrePlan;
        string carrera;
        string modalidad;
        DataTable var2;

        private void planaPartirdeOtro_Load(object sender, EventArgs e)
        {
            DataTable var = Carrera.Todo();
            for (int i = 0; i < ((DataTable)var).Rows.Count; i++)
            {
                comboBox2.Items.Add(((Array)((DataTable)var).Rows[i].ItemArray).GetValue(1));
            }

            DataTable varAux = PlnDE.Nombress();
            for (int i = 0; i < ((DataTable)varAux).Rows.Count; i++)
            {
                if (!comboBox1.Items.Contains(((Array)((DataTable)varAux).Rows[i].ItemArray).GetValue(0)))

                    comboBox1.Items.Add(((Array)((DataTable)varAux).Rows[i].ItemArray).GetValue(0));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                comboBox1.SelectedItem = null;
                comboBox2.SelectedItem = null;
                comboBox3.SelectedItem = null;
                MessageBox.Show("Inserte todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nombrePlan = comboBox1.Text;
                carrera = comboBox2.Text;
                modalidad = comboBox3.Text;

                 var2 = PlnDE.Nombrexx(nombrePlan, carrera, modalidad);

                if (var2.Rows.Count != 0)
                {
                    comboBox1.SelectedItem = null;
                    comboBox2.SelectedItem = null;
                    comboBox3.SelectedItem = null;
                    dataGridView1.DataSource = var2;

                }
                else
                {
                    comboBox1.SelectedItem = null;
                    comboBox2.SelectedItem = null;
                    comboBox3.SelectedItem = null;
                    dataGridView1.DataSource = var2;
                    MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nuevoPlanNombre prue = new nuevoPlanNombre(var2, modalidad);
            prue.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex.Equals(9))
            {
                int a = e.RowIndex;
                //Int32 seleccionado = this.dataGridView1.(DataGridViewElementStates.Selected);
                var2.Rows.RemoveAt(a);

                dataGridView1.DataSource = var2;
                MessageBox.Show("Asignatura Eliminada del Plan");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }
}