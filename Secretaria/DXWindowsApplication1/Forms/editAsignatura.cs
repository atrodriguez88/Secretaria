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
    public partial class editAsignatura : DevExpress.XtraEditors.XtraForm
    {
        int aux;
        string aux2;
        string aux3;
        int aux4;

        public editAsignatura(int id, string nombre,string descripcion,int hor)
        {
            InitializeComponent();
            aux = id;
            lbNombre.Text = nombre;
            aux2 = nombre;
            aux3 = descripcion;
            aux4 = hor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bandera = false;
            buscarAsignatura bus = new buscarAsignatura();
             if (textBoxNuevo.Text == "") 
            {
                MessageBox.Show("Escriba el nuevo nombre");
            }
            else
            {
                //DataTable var = Asignatura.Dame_Nombre(textBoxNuevo.Text);
                //if (var.Rows.Count != 0) 
                //{
                //    MessageBox.Show("Ya existe una Asignatura con ese nombre. Intentelo de nuevo");
                //    textBoxNuevo.Text="";
                //}
                //else
                //{
                    string nuevo = textBoxNuevo.Text;
                    string nuevo2 = richTextBoxNuevaDescripcion.Text;
                    int nuevo3 = int.Parse(textBoxHoras.Text);

                    Asignatura.Actualizar(aux,nuevo,nuevo2,nuevo3);
                    MessageBox.Show("Los Cambios se realizaron con Exito");
                    Close();
                //}
                
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void editAsignatura_Load(object sender, EventArgs e)
        {
            textBoxNuevo.Text = aux2;
            richTextBoxNuevaDescripcion.Text = aux3;
            textBoxHoras.Text = aux4.ToString();
        }
        
    }
}