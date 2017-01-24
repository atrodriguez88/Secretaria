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
    public partial class editPlan : DevExpress.XtraEditors.XtraForm
    {
        string ano1;
        string semestre1;
        string asignatura1;
        int idPlan1;
        int idAsig1;

        public editPlan(int idPlan, int idAsig, string ano, string semestre, string asignatura)
        {
            InitializeComponent();
            ano1 = ano;
            semestre1 = semestre;
            asignatura1 = asignatura;
            idPlan1 = idPlan;
            idAsig1 = idAsig;
        }

        private void button2_Click(object sender, EventArgs e)
        {
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

        private void editPlan_Load(object sender, EventArgs e)
        {
            textBox1.Text = asignatura1;
            comboBox1.SelectedItem = ano1;
            comboBox2.SelectedItem = semestre1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Introduzca el nombre de la Asignatura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
            }
            else
            {
                string an = comboBox1.Text;
                string seme = comboBox2.Text;
                string asi = textBox1.Text;

                PlnDE.ActualizarPlan(idPlan1, idAsig1, seme, an, asi);
                MessageBox.Show("Cambios Guardados con éxito");
                Close();
            }
            
        }
    }
}