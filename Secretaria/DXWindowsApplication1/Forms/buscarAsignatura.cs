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
    public partial class buscarAsignatura : DevExpress.XtraEditors.XtraForm
    {
        bool ActualizarAsignatura;
        public buscarAsignatura()
        {
            ActualizarAsignatura = false;
            InitializeComponent();
        }

        private void buscarAsignatura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet7.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.tesisDataSet7.Asignatura);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Inserte el Nombre de la Asignatura");
            }
            else
            {
                string nombre = textBoxNombre.Text;
                DataTable var = Asignatura.Segun_Nombre(nombre);
                if (var.Rows.Count != 0)
                {
                    dataGridViewAsignatura.DataSource = var;

                }
                else
                {
                    MessageBox.Show("No hay ninguna facultad con ese nombre");
                }


            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridViewAsignatura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int id = int.Parse(dataGridViewAsignatura.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nombre = dataGridViewAsignatura.Rows[e.RowIndex].Cells[1].Value.ToString();
            string descrip = dataGridViewAsignatura.Rows[e.RowIndex].Cells[2].Value.ToString();
            int horas = int.Parse(dataGridViewAsignatura.Rows[e.RowIndex].Cells[3].Value.ToString());

            if (e.ColumnIndex.Equals(4))
            {
                editAsignatura edit = new editAsignatura(id, nombre, descrip, horas);                
                edit.ShowDialog();
                this.asignaturaTableAdapter.Fill(this.tesisDataSet7.Asignatura);

            }
            else
            {
                if (e.ColumnIndex.Equals(5))
                {
                    Asignatura.Eliminar(id);
                    this.asignaturaTableAdapter.Fill(this.tesisDataSet7.Asignatura);
                    MessageBox.Show("La Asignatura se ha Eliminado con Éxito");

                }

                else
                {
                    if (e.ColumnIndex.Equals(1))
                    {
                        infoAsignatura infoAsig = new infoAsignatura(nombre,descrip,horas);
                        infoAsig.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("no ha seleccionado");

                    }
                   
                }
            }
        }
    }
}