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
    public partial class planForm : DevExpress.XtraEditors.XtraForm
    {
        string nombreAsignatura ;
        int horasAsignatura;
        string descripcionAsignatura ;

        string nombrePlan;
        string año ;
        string semestre ;
        string carrera ;
        string modalidad ;

        public planForm()
        {
            InitializeComponent();
        }

        private void planForm_Load(object sender, EventArgs e)
        {
            
                      
            DataTable var2 = Carrera.Todo();
            for (int i = 0; i < ((DataTable)var2).Rows.Count; i++)
            {
                comboBox1.Items.Add(((Array)((DataTable)var2).Rows[i].ItemArray).GetValue(1));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox4.Text == "" || textBox3.Text == "" || richTextBox1.Text == "" || comboBox1.Text == "" || comboBox3.Text == "" || comboBox4.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Introduzca todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
	        {
                 nombreAsignatura = textBox4.Text;
                 horasAsignatura = int.Parse(textBox3.Text);
                 descripcionAsignatura = richTextBox1.Text;

                 nombrePlan = textBox1.Text;
                 año = comboBox3.Text;
                 semestre = comboBox4.Text;
                 carrera = comboBox1.Text;
                 modalidad = comboBox2.Text;

                 Asignatura asig = new Asignatura(nombreAsignatura, descripcionAsignatura);
                 asig.Add(nombreAsignatura, descripcionAsignatura, horasAsignatura);
                textBox4.Text = "";
                textBox3.Text = "";
                richTextBox1.Text = "";

                PlnDE plan = new PlnDE(nombrePlan, carrera, año, semestre, modalidad);
                DataTable var3 = Asignatura.Segun_Nombre_Descripcion_Horas(nombreAsignatura, descripcionAsignatura, horasAsignatura);
                int idAsignatura = int.Parse(var3.Rows[0].ItemArray[0].ToString());

                plan.Add(nombrePlan, carrera, año, semestre, idAsignatura, modalidad);
                DataTable var4 = PlnDE.Nombrexx(nombrePlan, carrera, modalidad);

                dataGridView1.DataSource = var4;

                textBox4.Focus();
                
            
	        }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
        private void textBox2_Leave_1(object sender, EventArgs e)
        {
            
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            DataTable var14 = PlnDE.Nombrexx(nombrePlan, carrera, modalidad);
            for (int i = 0; i < ((DataTable)var14).Rows.Count; i++)
            {
                string Asignatu = (((Array)((DataTable)var14).Rows[i].ItemArray).GetValue(1)).ToString();

                if (textBox4.Text == Asignatu)
                {
                    MessageBox.Show("Ya este Plan contiene una Asignatura con el mismo nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Text = "";
                    textBox4.Focus();
                    break;

                }

            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }

       
    


        }
    }
