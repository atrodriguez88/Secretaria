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
    public partial class editEstudiante : DevExpress.XtraEditors.XtraForm
    {
        int aux;
        int aux2;
        int ID;
        string CI;
        string NOMBRE;
        string PRIMER;
        string SEGUNDO;
        string SEXO;
        string TELEF;
        string PAIS;
        string DIRECCION;
        string Piel;
        string PROVINCIA;
        string MODALIDAD;
        string TRABAJO;
        string OCUPACION;
        string ORGANISMO;
        int EXPEDIENTE;
        int CARRERA;

        public editEstudiante(int id, string ci, string nombre, string primerApellido, string segundoApellido, string sexo, string telef, string pais, string direccion, string piel, string provincia, string modalidad, string trabajo, string ocupacion, string organismo, int idExpediente, int idCarrera)
        {
            InitializeComponent();
            aux = -1;
            aux2 = -1;
            ID = id;
            CI = ci;
            NOMBRE = nombre;
            PRIMER = primerApellido;
            SEGUNDO = segundoApellido;
            SEXO = sexo;
            TELEF = telef;
            PAIS = pais;
            DIRECCION = direccion;
            Piel = piel;
            PROVINCIA = provincia;
            MODALIDAD = modalidad;
            TRABAJO = trabajo;
            OCUPACION = ocupacion;
            ORGANISMO = organismo;
            EXPEDIENTE = idExpediente;
            CARRERA = idCarrera;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxCarne.Clear();
            textBoxNombre.Clear();
            textBoxPrimerApell.Clear();
            textBoxSegundoApell.Clear();
           
            textBoxTelef.Clear();
            textBoxDireccion.Clear();
            comboBoxProvincia.SelectedItem = null;
            comboBoxPais.SelectedItem = null;
            comboBoxFacultad.Items.Clear();
            comboBoxSexo.SelectedItem = null;
            comboBoxPiel.SelectedItem = null;
            comboBoxCurso.SelectedItem = null;
            
            Close();
        }

        private void editEstudiante_Load(object sender, EventArgs e)
        {
            textBoxCarne.Text = CI;
            textBoxNombre.Text = NOMBRE;
            textBoxPrimerApell.Text = PRIMER;
            textBoxSegundoApell.Text = SEGUNDO;
            comboBoxSexo.Text = SEXO;
            comboBoxPiel.Text = Piel;
            textBoxTelef.Text = TELEF;
            textBoxDireccion.Text = DIRECCION;
            comboBoxPais.Text = PAIS;
            comboBoxProvincia.Text = PROVINCIA;

            DataTable var2 = Carrera.Nombre_Dado_ID(CARRERA);
            string d = var2.Rows[0].ItemArray[1].ToString();
            int c = int.Parse(var2.Rows[0].ItemArray[2].ToString());
            DataTable var3 = Facultad.Nombre_segun_ID(c);
            string f = var3.Rows[0].ItemArray[1].ToString(); 
            
            comboBoxCarrera.Enabled = false;
            DataTable var = Facultad.Todo();
            for (int i = 0; i < ((DataTable)var).Rows.Count; i++)
            {
                comboBoxFacultad.Items.Add(((Array)((DataTable)var).Rows[i].ItemArray).GetValue(1));
            }

            comboBoxFacultad.SelectedItem = f;
            comboBoxCurso.SelectedItem = MODALIDAD;
            comboBoxCarrera.SelectedItem = d;

        }


        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPais.Text == "Cuba")
            {
                comboBoxProvincia.Enabled = true;
            }
            else
            {
                comboBoxProvincia.SelectedIndex=-1;
                comboBoxProvincia.Enabled = false;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable var = Facultad.Todo_ID(comboBoxFacultad.Text);
            aux = int.Parse(var.Rows[0].ItemArray[0].ToString());
            comboBoxCarrera.Enabled = true;

            DataTable var2 = Carrera.TodoCarrera_id(aux);

            comboBoxCarrera.Items.Clear();
            for (int i = 0; i < var2.Rows.Count; i++)
            {

                comboBoxCarrera.Items.Add(((Array)var2.Rows[i].ItemArray).GetValue(1));

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxCarne.Text == "" || textBoxSegundoApell.Text == "" || textBoxTelef.Text == "" || textBoxNombre.Text == "" || textBoxPrimerApell.Text == "" || textBoxDireccion.Text == "" ||comboBoxSexo.Text == "" || comboBoxPiel.Text == "" || comboBoxPais.Text == "" || comboBoxProvincia.Text == "" || comboBoxFacultad.Text == "" || comboBoxCurso.Text == "" || comboBoxCarrera.Text == "")
            {
                MessageBox.Show("Inserte todos los Datos del Estudiante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable var4 = Carrera.ID(comboBoxCarrera.Text);
                aux2 = int.Parse(var4.Rows[0].ItemArray[0].ToString());


                string carne = textBoxCarne.Text;
                string name = textBoxNombre.Text;
                string first = textBoxPrimerApell.Text;
                string second = textBoxSegundoApell.Text;
                string phone = textBoxTelef.Text;
                string address = textBoxDireccion.Text;
                string sex = comboBoxSexo.Text;
                string skin = comboBoxPiel.Text;
                string countrie = comboBoxPais.Text;
                string provin = comboBoxProvincia.Text;                
                string modality = comboBoxCurso.Text;
                              
                Estudiante.Actualizar(ID,carne,name,first,second,sex,phone,countrie,address,skin,provin,modality,TRABAJO,OCUPACION,ORGANISMO,EXPEDIENTE,aux2);
                MessageBox.Show("Los Cambios del Estudiante han sido guardados con Éxito");
                Close();
               
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

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        private void textBoxPrimerApell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }

        private void textBoxSegundoApell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar != 32 && (int)e.KeyChar != 8)
            {
                MessageBox.Show("Solo puede entrar letras. Inténtelo de nuevo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }

        }
    }
}
