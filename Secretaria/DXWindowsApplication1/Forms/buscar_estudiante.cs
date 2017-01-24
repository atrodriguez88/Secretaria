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
    public partial class buscar_estudiante : Form
    {
        public buscar_estudiante()
        {
            InitializeComponent();
        }

        private void buscar_estudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet4.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.tesisDataSet4.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCarne.Text == "" && textBoxNombre.Text == "" && textBoxApellido.Text == "" && textBox1.Text == "")
            {
                MessageBox.Show("Escriba en un criterio de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (textBoxNombre.Text != "" && textBoxCarne.Text == "" && textBoxApellido.Text == "" && textBox1.Text == "")
                {
                    string nombre = textBoxNombre.Text;
                    DataTable var = Estudiante.Nombre(nombre);
                    if (var.Rows.Count != 0)
                    {
                        textBoxNombre.Text = "";
                        dataGridViewEstudiantes.DataSource = var;

                    }
                    else
                    {
                        textBoxNombre.Text = "";
                        MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                     
                    }   
                }
                if (textBoxNombre.Text == "" && textBoxCarne.Text != "" && textBoxApellido.Text == "" && textBox1.Text == "")
                {
                    string ci = textBoxCarne.Text;
                    DataTable var = Estudiante.CI(ci);
                    if (var.Rows.Count != 0)
                    {
                        textBoxCarne.Text = "";
                        dataGridViewEstudiantes.DataSource = var;

                    }
                    else
                    {
                        textBoxCarne.Text = "";
                        MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (textBoxNombre.Text == "" && textBoxCarne.Text == "" && textBoxApellido.Text != "" && textBox1.Text == "")
                {
                    string primerApellido = textBoxApellido.Text;
                    DataTable var = Estudiante.Apellido(primerApellido);
                    if (var.Rows.Count != 0)
                    {
                        textBoxApellido.Text = "";
                        dataGridViewEstudiantes.DataSource = var;

                    }
                    else
                    {
                        textBoxApellido.Text = "";
                        MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (textBoxNombre.Text == "" && textBoxCarne.Text != "" && textBoxApellido.Text != "" && textBox1.Text == "")
                {
                    string ci = textBoxCarne.Text;
                    string primerApellido = textBoxApellido.Text;
                    DataTable var = Estudiante.Ci_primerApellido(ci,primerApellido);
                    if (var.Rows.Count != 0)
                    {
                        textBoxApellido.Text = "";
                        textBoxCarne.Text = "";
                        dataGridViewEstudiantes.DataSource = var;

                    }
                    else
                    {
                        textBoxApellido.Text = "";
                        textBoxCarne.Text = "";
                        MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (textBoxNombre.Text != "" && textBoxCarne.Text != "" && textBoxApellido.Text == "" && textBox1.Text == "")
                {
                    string ci = textBoxCarne.Text;
                    string nombre = textBoxNombre.Text;
                    DataTable var = Estudiante.Ci_Nombre(ci, nombre);
                    if (var.Rows.Count != 0)
                    {
                        textBoxNombre.Text = "";
                        textBoxCarne.Text = "";
                        dataGridViewEstudiantes.DataSource = var;

                    }
                    else
                    {
                        textBoxNombre.Text = "";
                        textBoxCarne.Text = "";
                        MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (textBoxNombre.Text != "" && textBoxCarne.Text == "" && textBoxApellido.Text != "" && textBox1.Text == "")
                {
                    string nombre = textBoxNombre.Text;
                    string primerApellido = textBoxApellido.Text;
                    DataTable var = Estudiante.Nombre_Apellido(nombre,primerApellido);
                    if (var.Rows.Count != 0)
                    {
                        textBoxApellido.Text = "";
                        textBoxNombre.Text = "";
                        dataGridViewEstudiantes.DataSource = var;

                    }
                    else
                    {
                        textBoxApellido.Text = "";
                        textBoxNombre.Text = "";
                        MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                if (textBoxNombre.Text != "" && textBoxCarne.Text != "" && textBoxApellido.Text != "" && textBox1.Text == "")
                {
                    string ci = textBoxCarne.Text;
                    string nombre = textBoxNombre.Text;
                    string primerApellido = textBoxApellido.Text;
                    DataTable var = Estudiante.Ci_Nombre_Apellido(ci,nombre, primerApellido);
                    if (var.Rows.Count != 0)
                    {
                        textBoxApellido.Text = "";
                        textBoxNombre.Text = "";
                        textBoxCarne.Text = "";
                        dataGridViewEstudiantes.DataSource = var;

                    }
                    else
                    {
                        textBoxApellido.Text = "";
                        textBoxNombre.Text = "";
                        textBoxCarne.Text = "";
                        MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (textBoxNombre.Text == "" && textBoxCarne.Text == "" && textBoxApellido.Text == "" && textBox1.Text != "")
                    { 
                        DataTable var = Estudiante.Expediente(int.Parse(textBox1.Text));
                        if (var.Rows.Count != 0)
                        {
                            textBox1.Text = "";
                            dataGridViewEstudiantes.DataSource = var;

                        }
                        else
                        {
                            textBox1.Text = "";
                            MessageBox.Show("No hay ningun Estudiante con esos Datos en el sistema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

       

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewEstudiantes.Rows[e.RowIndex].Cells[0].Value.ToString());
            string ci = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[1].Value.ToString();
            string nombre = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[2].Value.ToString();
            string primerApellido = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[3].Value.ToString();
            string segundoApellido = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[4].Value.ToString();
            string sexo = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[5].Value.ToString();
            string telef = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[6].Value.ToString();
            string pais = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[7].Value.ToString();
            string direccion = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[8].Value.ToString();
            string piel = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[9].Value.ToString();
            string provincia = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[10].Value.ToString();
            string modalidad = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[11].Value.ToString();
            string trabajo = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[12].Value.ToString();
            string ocupacion = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[13].Value.ToString();
            string organismo = dataGridViewEstudiantes.Rows[e.RowIndex].Cells[14].Value.ToString();
            int idExpediente = int.Parse(dataGridViewEstudiantes.Rows[e.RowIndex].Cells[15].Value.ToString());
            int idCarrera =int.Parse(dataGridViewEstudiantes.Rows[e.RowIndex].Cells[16].Value.ToString());
            
            if (e.ColumnIndex.Equals(17))
            {
                editEstudiante estud = new editEstudiante(id,ci,  nombre,  primerApellido,  segundoApellido,  sexo,  telef,  pais,  direccion,  piel,  provincia, modalidad,  trabajo,  ocupacion,  organismo,  idExpediente,  idCarrera);
                               estud.ShowDialog();
            }
            else
            {
                if (e.ColumnIndex.Equals(18))
                {
                    certificacionForm cer = new certificacionForm(id);
                    cer.ShowDialog();
                }
                else
                {
                    if (e.ColumnIndex.Equals(19))
                    {
                        Estudiante.Eliminar(id);
                        this.estudianteTableAdapter.Fill(this.tesisDataSet4.Estudiante);
                        MessageBox.Show("El Estudiante ha sido Eliminado con Éxito");
                    }
                    else
                    {
                        if (e.ColumnIndex.Equals(1))
                        {
                            DataTable var3 = Expediente.Todo(idExpediente);
                            int c = int.Parse(var3.Rows[0].ItemArray[0].ToString());
                            int d =int.Parse( var3.Rows[0].ItemArray[1].ToString());

                            buscarExpediente exped = new buscarExpediente(d,c,nombre,primerApellido,segundoApellido);
                            exped.ShowDialog();
                        }
                        else
                        {
                            if (e.ColumnIndex.Equals(2))
                            {
                                infoEstudiante infoEst = new infoEstudiante(ci, nombre, primerApellido, segundoApellido, sexo, telef, pais, direccion, piel, provincia, modalidad, trabajo, ocupacion, organismo,idCarrera);
                                infoEst.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Para consultar información sobre el estudiante seleccione 'Carné de Identidad' ó 'Nombre'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                           
                        }
                       
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

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > (char)47) && (e.KeyChar < (char)58) || (e.KeyChar == '\b')))
            {

                MessageBox.Show("Solo puede entrar números. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
                if (e.KeyChar == (char)46)
                {
                    MessageBox.Show("Solo puede entrar números. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;

                }


        }

        private void textBoxCarne_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > (char)47) && (e.KeyChar < (char)58) || (e.KeyChar == '\b')))
            {

                MessageBox.Show("Solo puede entrar números. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            else
                if (e.KeyChar == (char)46)
                {
                    MessageBox.Show("Solo puede entrar números. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    e.Handled = true;

                }


        }

    }
}
