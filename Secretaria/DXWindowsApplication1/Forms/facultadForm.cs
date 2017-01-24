using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DXWindowsApplication1
{
    public partial class facultadForm : Form
    {
        public facultadForm()
        {
            InitializeComponent();
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            Close();

        }
        
        private void facultadForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet1.Facultad' Puede moverla o quitarla según sea necesario.
            this.facultadTableAdapter.Fill(this.tesisDataSet1.Facultad);

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("Escriba el nombre de la Facultad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string a = textBoxNombre.Text;
                Facultad fac = new Facultad(a);
                DataTable var = Facultad.Todo_Nombre(a);

                if (var.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe una Facultad con ese nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    fac.Add(a);
                    this.facultadTableAdapter.Fill(this.tesisDataSet1.Facultad);
                    MessageBox.Show("La Facultad fue insertada correctamente");
                    textBoxNombre.Clear();
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
