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
    public partial class editCarrera : DevExpress.XtraEditors.XtraForm
    {
        int a;
        string b;
        int c;
        public editCarrera(int idCArrera ,string nombre, int idFacultad)
        {
            InitializeComponent();
            a = idCArrera;
            b = nombre;
            c = idFacultad;
        }

       

        private void editCarrera_Load(object sender, EventArgs e)
        {
            DataTable var = Facultad.Todo();
            for (int i = 0; i < ((DataTable)var).Rows.Count; i++)
            {
                comboBoxFacultad.Items.Add(((Array)((DataTable)var).Rows[i].ItemArray).GetValue(1));
            }



            DataTable varAux = Facultad.Nombre_segun_ID(c);
            string d = varAux.Rows[0].ItemArray[1].ToString();
        
            textBoxNuevoN.Text = b;
            comboBoxFacultad.SelectedItem = d;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxNuevoN.Text==""||comboBoxFacultad.Text=="")
            {
                MessageBox.Show("Introduzca todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string aux2 = comboBoxFacultad.Text;
                DataTable varAux2 = Facultad.Segun_Nombre(aux2);
                int d2 = int.Parse(varAux2.Rows[0].ItemArray[0].ToString());


                Carrera.Actualizar(a, textBoxNuevoN.Text, d2);
                MessageBox.Show("Los cambios se han guardado con Éxito");
                Close();
                
        
            }
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxNuevoN_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        private void textBoxNuevoN_Leave(object sender, EventArgs e)
        {
            string a = textBoxNuevoN.Text;
            DataTable va = Carrera.Todo_Nombre(a);

            if (va.Rows.Count == 0)
            {
 
            }
            else
            {
                MessageBox.Show("Ya existe una carrera con ese nombre. Cámbie el nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNuevoN.Text = "";
                textBoxNuevoN.Focus();
            }
        }

           


    }
}