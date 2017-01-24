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
    public partial class cambiarContrasena : DevExpress.XtraEditors.XtraForm
    {
        public cambiarContrasena()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string a = comboBoxUsuarios.Text;
            string b = textBoxNueva.Text;
            string c = textBoxRepetir.Text;
            registrar r = new registrar();


            if (comboBoxUsuarios.Text == "" || textBoxNueva.Text == "" || textBoxRepetir.Text == "")
            {
                MessageBox.Show("Inserte todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                if (b == c)
                {
                    r.Actualizar(a, b);
                    MessageBox.Show("Su Contraseña se ha cambiado con Exito");
                    textBoxNueva.Clear();
                    textBoxRepetir.Clear();
                }
                else
                {
                    MessageBox.Show("Los campos'Nueva Contraseña' y 'Repita nueva Contraseña' no coinciden. Intentelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxNueva.Clear();
                    textBoxRepetir.Clear();
                }

            }
        }

       
    }
}