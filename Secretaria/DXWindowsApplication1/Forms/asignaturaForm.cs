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
    public partial class asignaturaForm : DevExpress.XtraEditors.XtraForm
    {
        public asignaturaForm()
        {
            InitializeComponent();
        }

        private void asignaturaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet7.Asignatura' Puede moverla o quitarla según sea necesario.
            this.asignaturaTableAdapter.Fill(this.tesisDataSet7.Asignatura);
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet8.Asignatura' Puede moverla o quitarla según sea necesario.
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || richTextBoxDescripcion.Text=="" || textBoxHoras.Text=="")
            {
                MessageBox.Show("Escriba todos los Datos");
            }
            else
            {

                string a = textBoxNombre.Text;
                string b = richTextBoxDescripcion.Text;
                int c = int.Parse(textBoxHoras.Text);
                Asignatura asig = new Asignatura(a,b);
                DataTable var = Asignatura.Dame_Nombre(a);

                if (var.Rows.Count != 0)
                {
                    MessageBox.Show("Ya existe una Asignatura con ese nombre");
                }
                else
                {
                    asig.Add(a,b,c);
                    this.asignaturaTableAdapter.Fill(this.tesisDataSet7.Asignatura);
                    MessageBox.Show("La Asignatura fue insertada correctamente");
                    textBoxNombre.Clear();
                    richTextBoxDescripcion.Text = "";
                    textBoxHoras.Clear();
                }
            }
        }
    }
}