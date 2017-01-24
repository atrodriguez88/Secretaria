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
    public partial class carreraForm : Form
    {
        public carreraForm()
        {
            InitializeComponent();
        }

        private void carreraForm_Load(object sender, EventArgs e)
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
           
                   
           
         }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBoxFacultad.SelectedItem = null;
            textBoxNombre.Clear();
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

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (textBoxNombre.Text == "" || comboBoxFacultad.Text == "")
            {
                MessageBox.Show("Inserte todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable bb = Facultad.Todo_ID(comboBoxFacultad.Text);
                int c = int.Parse(bb.Rows[0].ItemArray.GetValue(0).ToString());
                string a = textBoxNombre.Text;
                Carrera ca = new Carrera(c);

                DataTable varAux = Carrera.Todo_Nombre(a);
                if (varAux.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe una Carrera con ese Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ca.Add(a, c);
                    // TODO: esta línea de código carga datos en la tabla 'tesisDataSet2.Carrera' Puede moverla o quitarla según sea necesario.
                    this.carreraTableAdapter.Fill(this.tesisDataSet2.Carrera);
                    MessageBox.Show("La Carrera fue insertada correctamente");

                    comboBoxFacultad.SelectedItem = null;
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
