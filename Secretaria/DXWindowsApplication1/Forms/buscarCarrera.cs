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
    public partial class buscarCarrera : DevExpress.XtraEditors.XtraForm
    {
        public buscarCarrera()
        {
            InitializeComponent();
        }

        private void buscarCarrera_Load(object sender, EventArgs e)
        {
           
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet2.Carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter.Fill(this.tesisDataSet2.Carrera);
            DataTable var = Facultad.Todo();
            for (int i = 0; i < ((DataTable)var).Rows.Count; i++)
            {
                comboBoxFacultad.Items.Add(((Array)((DataTable)var).Rows[i].ItemArray).GetValue(1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" && comboBoxFacultad.Text=="")
            {
                MessageBox.Show("Escoja un criterio de Búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxNombre.Text!="" && comboBoxFacultad.Text=="")
                {
                string nombre = textBoxNombre.Text;
                DataTable var = Carrera.Todo_Nombre(nombre);
                if (var.Rows.Count != 0)
                {
                    dataGridViewCarreras.DataSource = var;
                    textBoxNombre.Clear();

                }
                else
                {
                    MessageBox.Show("No hay ninguna facultad con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNombre.Clear();
                }

                }
                else
                {
                    if (textBoxNombre.Text == "" && comboBoxFacultad.Text != "")
                        {
                            string facultad = comboBoxFacultad.Text;
                            DataTable var = Facultad.Segun_Nombre(facultad);
                            int a = int.Parse(var.Rows[0].ItemArray[0].ToString());
                            DataTable var2 = Carrera.TodoCarrera_id(a);
                            if (var.Rows.Count != 0)
                            {
                                dataGridViewCarreras.DataSource = var2;
                                
                            }
                            else
                            {
                                MessageBox.Show("No hay ninguna facultad con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                comboBoxFacultad.SelectedItem="";
                            }
                        }
                }
                

            }
           
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCarrera = int.Parse(dataGridViewCarreras.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nombre = dataGridViewCarreras.Rows[e.RowIndex].Cells[1].Value.ToString();
            int idFacultad = int.Parse(dataGridViewCarreras.Rows[e.RowIndex].Cells[2].Value.ToString());


            if (e.ColumnIndex.Equals(3))
            {
                editCarrera edcarrera = new editCarrera(idCarrera,nombre,idFacultad);
                edcarrera.ShowDialog();
            }
            else
            {
                if (e.ColumnIndex.Equals(4))
                {
                    Carrera.Eliminar(idCarrera);
                    // TODO: esta línea de código carga datos en la tabla 'tesisDataSet2.Carrera' Puede moverla o quitarla según sea necesario.
                    this.carreraTableAdapter.Fill(this.tesisDataSet2.Carrera);
                    MessageBox.Show("La Carrera ha sido Eliminada con Éxito");
                }
                else
                {
                    if (e.ColumnIndex.Equals(1))
                    {
                        infoCarrera info = new infoCarrera(nombre,idFacultad);
                        info.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("No ha seleccionado ninguna opción", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
            }

            
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }
    }
}