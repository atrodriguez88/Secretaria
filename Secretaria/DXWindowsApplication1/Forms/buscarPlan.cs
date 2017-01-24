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
    public partial class buscarPlan : DevExpress.XtraEditors.XtraForm
    {
        public buscarPlan()
        {
            InitializeComponent();
        }

        private void buscarPlan_Load(object sender, EventArgs e)
        {
            DataTable var = Carrera.Todo(); 
            for (int i = 0; i < ((DataTable)var).Rows.Count; i++)
            {
                comboBox2.Items.Add(((Array)((DataTable)var).Rows[i].ItemArray).GetValue(1));
            }

            DataTable varAux = PlnDE.Nombress();
            for (int i = 0; i < ((DataTable)varAux).Rows.Count; i++)
            {
                if (!comboBox1.Items.Contains(((Array)((DataTable)varAux).Rows[i].ItemArray).GetValue(0)))

                    comboBox1.Items.Add(((Array)((DataTable)varAux).Rows[i].ItemArray).GetValue(0));
            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string nombrePlan;
            string carrera;
            string modalidad;

            if (comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text == "")
            {
                dataGridView1.DataSource = null;
                MessageBox.Show("Escoja un criterio de Búsqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (comboBox1.Text != "" && comboBox2.Text == "" && comboBox3.Text == "")
                {
                    nombrePlan = comboBox1.Text;

                    DataTable var3 = PlnDE.Dado_Plan_Carrera(nombrePlan);

                    if (var3.Rows.Count != 0)
                    {
                        comboBox1.SelectedItem = null;
                        escojaPlan1 escoj1 = new escojaPlan1(var3);
                        escoj1.ShowDialog();

                    }
                    else
                    {
                        comboBox1.SelectedItem = null;
                        MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    if (comboBox1.Text == "" && comboBox2.Text != "" && comboBox3.Text == "")
                    {
                        carrera = comboBox2.Text;
                        DataTable var4 = PlnDE.Dado_Carrera_Plan(carrera);

                        if (var4.Rows.Count != 0)
                        {
                            comboBox2.SelectedItem = null;
                            escojaPlan2 escoj2 = new escojaPlan2(var4);
                            escoj2.ShowDialog();

                        }
                        else
                        {
                            comboBox2.SelectedItem = null;
                            dataGridView1.DataSource = var4;
                            MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (comboBox1.Text == "" && comboBox2.Text == "" && comboBox3.Text != "")
                        {
                            modalidad = comboBox3.Text;
                            DataTable var4 = PlnDE.Modalida(modalidad);

                            if (var4.Rows.Count != 0)
                            {
                                comboBox3.SelectedItem = null;
                                escojaPlan3 escoj3 = new escojaPlan3(var4);
                                escoj3.ShowDialog();

                            }
                            else
                            {
                                comboBox3.SelectedItem = null;
                                dataGridView1.DataSource = var4;
                                MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    if (comboBox1.Text != "" && comboBox2.Text == "" && comboBox3.Text != "")
                    {
                        nombrePlan = comboBox1.Text;
                        modalidad = comboBox3.Text;
                        DataTable var4 = PlnDE.Nombre_Modalidad(nombrePlan, modalidad);

                        if (var4.Rows.Count != 0)
                        {
                            comboBox1.SelectedItem = null;
                            comboBox3.SelectedItem = null;
                            escojaPlan4 escoj4 = new escojaPlan4(var4);
                            escoj4.ShowDialog();

                        }
                        else
                        {
                            comboBox1.SelectedItem = null;
                            comboBox3.SelectedItem = null;
                            dataGridView1.DataSource = var4;
                            MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    else
                    {
                        if (comboBox1.Text == "" && comboBox2.Text != "" && comboBox3.Text != "")
                        {
                            carrera = comboBox2.Text;
                            modalidad = comboBox3.Text;
                            DataTable var4 = PlnDE.Carrera_Modalidad(carrera, modalidad);

                            if (var4.Rows.Count != 0)
                            {
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                escojaPlan5 escoj5 = new escojaPlan5(var4);
                                escoj5.ShowDialog();

                            }
                            else
                            {
                                comboBox2.SelectedItem = null;
                                comboBox3.SelectedItem = null;
                                dataGridView1.DataSource = var4;
                                MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                         }

                   
                        if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text == "")
                        {
                            nombrePlan = comboBox1.Text;
                            carrera = comboBox2.Text;
                           
                            DataTable var4 = PlnDE.Nombre_Carrera(nombrePlan,carrera);

                            if (var4.Rows.Count != 0)
                            {
                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                escojaPlan6 escoj6 = new escojaPlan6(var4);
                                escoj6.ShowDialog();

                            }
                            else
                            {
                                comboBox1.SelectedItem = null;
                                comboBox2.SelectedItem = null;
                                dataGridView1.DataSource = var4;
                                MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        
                        }

                        

                        else
                        {
                            if (comboBox1.Text != "" && comboBox2.Text != "" && comboBox3.Text != "")
                            {
                                nombrePlan = comboBox1.Text;
                                carrera = comboBox2.Text;
                                modalidad = comboBox3.Text;

                                DataTable var2 = PlnDE.Asi(nombrePlan, carrera, modalidad);

                                if (var2.Rows.Count != 0)
                                {
                                    comboBox1.SelectedItem = null;
                                    comboBox2.SelectedItem = null;
                                    comboBox3.SelectedItem = null;
                                    dataGridView1.DataSource = var2;

                                }
                                else
                                {
                                    comboBox1.SelectedItem = null;
                                    comboBox2.SelectedItem = null;
                                    comboBox3.SelectedItem = null;
                                    dataGridView1.DataSource = var2;
                                    MessageBox.Show("No hay ningun Plan de Estudio con esos Criterios de Busqueda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }


            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idPlan = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString());
            string asignatura = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string ano = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string semestre = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            int idAsignatura = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString());



            if (e.ColumnIndex.Equals(11))
            {
                editPlan edit = new editPlan(idPlan, idAsignatura, ano, semestre, asignatura);
                  edit.ShowDialog();
            }
        }

        
    }
}