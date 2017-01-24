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
    public partial class pendientedePlan : DevExpress.XtraEditors.XtraForm
    {
        public pendientedePlan()
        {
            InitializeComponent();
        }
        string ci;

        private void pendientedePlan_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet18.Consulta16' Puede moverla o quitarla según sea necesario.
            this.consulta16TableAdapter.Fill(this.tesisDataSet18.Consulta16);
            DataTable var = Estudiante.Pendientes();
            dataGridView1.DataSource = var;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduzca el Carné de Identidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
 
            }
            else
            {
                ci = textBox1.Text;
                DataTable var = Estudiante.CI(ci);
                if (var.Rows.Count != 0)
                {
                    textBox1.Text = "";
                    dataGridView1.DataSource = var;

                }
                else
                {
                    textBox1.Text = "";
                    MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string ci = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string nombre = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string sexo = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string telef = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            string pais = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string direccion = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            string piel = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            string provincia = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            string primerApellido = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string segundoApellido = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int idExpediente = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[15].Value.ToString());
            string modalidad = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
            string trabajo = dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            string ocupacion = dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            string organismo = dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();
            int idCarrera = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[16].Value.ToString());


            if (e.ColumnIndex.Equals(18))
            {
                planEstudio2 p2 = new planEstudio2(ci);
                p2.ShowDialog();
            }
            else
            {
                if (e.ColumnIndex.Equals(1)) 
                {
                    DataTable var3 = Expediente.Todo(idExpediente);
                    int c = int.Parse(var3.Rows[0].ItemArray[0].ToString());
                    int d = int.Parse(var3.Rows[0].ItemArray[1].ToString());

                    buscarExpediente exped = new buscarExpediente(d, c, nombre, primerApellido, segundoApellido);
                    exped.ShowDialog();
                }
                else
                {
                    if (e.ColumnIndex.Equals(2))
                    {
                        infoEstudiante infoEst = new infoEstudiante(ci, nombre, primerApellido, segundoApellido, sexo, telef, pais, direccion, piel, provincia, modalidad, trabajo, ocupacion, organismo, idCarrera);
                        infoEst.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Para consultar información sobre el estudiante seleccione 'Carné de Identidad' ó 'Nombre'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                    }
                }
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > (char)47) && (e.KeyChar < (char)58) || (e.KeyChar == '\b')))
            {

                MessageBox.Show("Solo puede entrar números. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
                if (e.KeyChar == (char)46)
                {
                    MessageBox.Show("Solo puede entrar números. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;

                }

        }
    }
}