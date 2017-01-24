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
    public partial class certificacionForm : DevExpress.XtraEditors.XtraForm
    {
        int aux;
        public certificacionForm(int id)
        {
            InitializeComponent();
            aux = id;
        }

        private void certificacionForm_Load(object sender, EventArgs e)
        {
            DataTable var = Est_Asig.Informacion(aux);
            dataGridView1.DataSource = var;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}