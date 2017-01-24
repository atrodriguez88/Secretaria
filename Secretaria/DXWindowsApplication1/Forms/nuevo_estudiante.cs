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

    public partial class nuevo_estudiante : DevExpress.XtraEditors.XtraForm
    {
        int aux;
        int aux2;
        public nuevo_estudiante()
        {
            InitializeComponent();
            aux = -1;
            aux2 = -1;
        }

        private void nuevo_estudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet41.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter1.Fill(this.tesisDataSet41.Estudiante);
          
            groupBox2.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;

             DataTable var = Facultad.Todo();
            for (int i = 0; i < ((DataTable)var).Rows.Count; i++)
            {
                comboBox4.Items.Add(((Array)((DataTable)var).Rows[i].ItemArray).GetValue(1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox6.SelectedItem = null;
            comboBox7.SelectedItem = null;
            comboBox4.Items.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            checkBox1.Checked = false;
            Close();
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox1.Checked)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }
            
        }

        private void comboBox7_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox7.Text == "Cuba")
            {
                comboBox6.Enabled = true;
                comboBox6.SelectedItem = "Pinar del Rio";
            }
            else
            {
                comboBox6.SelectedItem=null;
                comboBox6.Enabled = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable var = Facultad.Todo_ID(comboBox4.Text);
            aux = int.Parse(var.Rows[0].ItemArray[0].ToString());
            comboBox5.Enabled = true;

            DataTable var2 = Carrera.TodoCarrera_id(aux);

            comboBox5.Items.Clear();
           for (int i = 0; i < var2.Rows.Count; i++)
            {
                
                comboBox5.Items.Add(((Array)var2.Rows[i].ItemArray).GetValue(1));
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
             

            if (textBox15.Text == "" || textBox16.Text == "" || textBox1.Text == "" || textBox4.Text == "" || textBox7.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox8.Text == "" ||  comboBox1.Text == "" || comboBox2.Text == "" || comboBox7.Text == "" || comboBox4.Text == "" || comboBox3.Text == "" || comboBox5.Text == "")
            {
                MessageBox.Show("Inserte todos los Datos del Estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable var3 = Carrera.ID(comboBox5.Text);
                aux2 = int.Parse(var3.Rows[0].ItemArray[0].ToString());

                int a = int.Parse(textBox15.Text);
                int b = int.Parse(textBox16.Text);
                Expediente exp = new Expediente();
                exp.Add(a, b);

                if (checkBox1.Checked)
                {
                    if (comboBox6.Enabled == true)
                    {
                        string ci = textBox1.Text;
                        string nombre = textBox2.Text;
                        string primerapellido = textBox3.Text;
                        string segundoapellido = textBox4.Text;
                        string sexo = comboBox1.Text;
                        string telef = textBox7.Text;
                        string pais = comboBox7.Text;
                        string direccion = textBox8.Text;
                        string piel = comboBox2.Text;
                        string provincia = comboBox6.Text;
                        string modalidad = comboBox3.Text;
                        string trabajo = textBox6.Text;
                        string ocupacion = textBox13.Text;
                        string organismo = textBox14.Text;

                        Estudiante est = new Estudiante(a, aux2);

                        est.Add(ci, nombre, primerapellido, segundoapellido, sexo, telef, pais, direccion, piel, provincia, modalidad, trabajo, ocupacion, organismo, a, aux2, "No");
                        
                        MessageBox.Show("Los Datos Personales han sido insertados correctamente");
                        this.Close();
                        planEstudio plan = new planEstudio(ci);
                        plan.ShowDialog();
                       
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox6.Clear();
                        textBox13.Clear();
                        textBox14.Clear();
                        textBox15.Clear();
                        textBox16.Clear();

                    }
                    else
                    {
                        string ci = textBox1.Text;
                        string nombre = textBox2.Text;
                        string primerapellido = textBox3.Text;
                        string segundoapellido = textBox4.Text;
                        string sexo = comboBox1.Text;
                        string telef = textBox7.Text;
                        string pais = comboBox7.Text;
                        string direccion = textBox8.Text;
                        string piel = comboBox2.Text;
                        string modalidad = comboBox3.Text;
                        string trabajo = textBox6.Text;
                        string ocupacion = textBox13.Text;
                        string organismo = textBox14.Text;
                        Estudiante est = new Estudiante(a, aux2);

                        est.Add(ci, nombre, primerapellido, segundoapellido, sexo, telef, pais, direccion, piel, "", modalidad, trabajo, ocupacion, organismo, a, aux2, "No");
                        MessageBox.Show("Los Datos Personales han sido insertados correctamente");
                        this.Close();
                        planEstudio plan = new planEstudio(ci);
                        plan.ShowDialog();

                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox6.Clear();
                        textBox13.Clear();
                        textBox14.Clear();
                        textBox15.Clear();
                        textBox16.Clear();

                    }
                }
                else
                {
                    if (comboBox6.Enabled == true)
                    {
                        string ci = textBox1.Text;
                        string nombre = textBox2.Text;
                        string primerapellido = textBox3.Text;
                        string segundoapellido = textBox4.Text;
                        string sexo = comboBox1.Text;
                        string telef = textBox7.Text;
                        string pais = comboBox7.Text;
                        string direccion = textBox8.Text;
                        string piel = comboBox2.Text;
                        string provincia = comboBox6.Text;
                        string modalidad = comboBox3.Text;
                        Estudiante est = new Estudiante(a, aux2);

                        DataTable var = Estudiante.CI(ci);
                        if (var.Rows.Count == 0)
                        {
                            est.Add(ci, nombre, primerapellido, segundoapellido, sexo, telef, pais, direccion, piel, provincia, modalidad, "", "", "", a, aux2, "No");

                            MessageBox.Show("Los Datos Personales han sido insertados correctamente");
                            this.Close();
                            planEstudio plan = new planEstudio(ci);
                            plan.ShowDialog();

                            textBox1.Clear();
                            textBox2.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox7.Clear();
                            textBox8.Clear();
                            textBox15.Clear();
                            textBox16.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Ya existe este número de Carné");
                        }
                        
                    }

                    else
                    {
                        string ci = textBox1.Text;
                        string nombre = textBox2.Text;
                        string primerapellido = textBox3.Text;
                        string segundoapellido = textBox4.Text;
                        string sexo = comboBox1.Text;
                        string telef = textBox7.Text;
                        string pais = comboBox7.Text;
                        string direccion = textBox8.Text;
                        string piel = comboBox2.Text;
                        string modalidad = comboBox3.Text;
                        Estudiante est = new Estudiante(a, aux2);

                        est.Add(ci, nombre, primerapellido, segundoapellido, sexo, telef, pais, direccion, piel, "", modalidad, "Ninguno", "", "", a, aux2, "No");
                       
                        MessageBox.Show("Los Datos Personales han sido insertados correctamente");
                        this.Close();
                        planEstudio plan = new planEstudio(ci);
                        plan.ShowDialog();
                       
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
                        textBox7.Clear();
                        textBox8.Clear();
                        textBox15.Clear();
                        textBox16.Clear();
                    }
                }
            }
        }

    

        


        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

       

        private void textBox15_Leave(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            { 

            }
            else
            {
                if (Expediente.Todo(int.Parse(textBox15.Text)).Rows.Count.Equals(1))
                {
                    MessageBox.Show("Ya existe un expediente con ese Número. Cámbielo");
                    textBox15.Focus();

                }
            }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Estudiante.CI(textBox1.Text).Rows.Count.Equals(1))
            {
                MessageBox.Show("Ya existe un Estudiante con ese Carné de Identidad. Cámbielo");
                textBox1.Focus();

            }

        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

       

        

       

       
    }
}