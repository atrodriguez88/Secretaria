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
    public partial class buscarFacultad : DevExpress.XtraEditors.XtraForm
    {
        public buscarFacultad()
        {
            InitializeComponent();
        }

        private void buscarFacultad_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet5.Facultad' Puede moverla o quitarla según sea necesario.
            this.facultadTableAdapter.Fill(this.tesisDataSet5.Facultad);
          
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Inserte el Nombre de la Facultad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string nombre = textBoxNombre.Text;
                DataTable var = Facultad.Segun_Nombre(nombre);
                if (var.Rows.Count != 0)
                {
                    dataGridViewFacultades.DataSource = var;
                   
                }
                else
                {
                    MessageBox.Show("No hay ninguna facultad con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                    
                     

            }
           
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewFacultades.Rows[e.RowIndex].Cells[0].Value.ToString());
            string nombre = dataGridViewFacultades.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (e.ColumnIndex.Equals(2))
            {
                editFacultad edit = new editFacultad(id,nombre);
                edit.ShowDialog();
                

            }
            else
            {
                if (e.ColumnIndex.Equals(3))
                {
                    Facultad.Eliminar(id);
                    this.facultadTableAdapter.Fill(this.tesisDataSet5.Facultad);
                    MessageBox.Show("La Facultad se ha Eliminado con Éxito");
                   
                }
                else
                {
                    MessageBox.Show("no ha seleccionado");
                }
            }
        }

        

        

        
       
    }
}