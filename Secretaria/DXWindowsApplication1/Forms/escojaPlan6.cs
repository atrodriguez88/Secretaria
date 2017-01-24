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
    public partial class escojaPlan6 : DevExpress.XtraEditors.XtraForm
    {
        DataTable aux;
        public escojaPlan6(DataTable plan)
        {
            InitializeComponent();
            aux = plan;
        }

        private void escojaPlan6_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aux;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}