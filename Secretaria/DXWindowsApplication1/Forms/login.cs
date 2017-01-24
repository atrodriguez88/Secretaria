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
    public partial class login : DevExpress.XtraEditors.XtraForm
    {
        int lala;
        public login()
        {
            InitializeComponent();
            lala = 3;
        }

        public int get()
        {
            return lala;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Introduzca todos los Datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                registrar regis = new registrar();
                DataTable var = regis.Mostrar_usuario();
                // Administrador date
                string c = var.Rows[1].ItemArray[0].ToString();
                string d = var.Rows[1].ItemArray[1].ToString();
                // Usuario Date
                string q = var.Rows[0].ItemArray[0].ToString();
                string a = var.Rows[0].ItemArray[1].ToString();

                string b = comboBox1.Text;


                if (c == b && d == textBox2.Text)
                {
                    lala = 1;
                    this.Close();

                }
                else
                {
                    if (q == b && a == textBox2.Text)
                    {
                        lala = 2;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usted no se ha autentificado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }


            }
            }
            
            


    }
}