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
    public partial class editFacultad : DevExpress.XtraEditors.XtraForm
    {
        int aux;
        string aux2;
        public editFacultad(int id, string nombre)
        {
            InitializeComponent();
            aux= id;
            lbNombre.Text = nombre;
            aux2 = nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            if (textBoxNuevo.Text == "")
            {
                MessageBox.Show("Escriba el nuevo Nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable var = Facultad.Todo_Nombre(textBoxNuevo.Text);
                if (var.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe una Facultad con ese nombre. Intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNuevo.Text = "";
                }
                else
                {
                    string nuevo = textBoxNuevo.Text;
                    Facultad.Actualizar(aux, nuevo);
                    MessageBox.Show("El nombre se ha cambiado con Exito");
                    Close();
                }

            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }
    }
}