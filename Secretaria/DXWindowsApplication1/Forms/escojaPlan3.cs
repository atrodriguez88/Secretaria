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
    public partial class escojaPlan3 : DevExpress.XtraEditors.XtraForm
    {
        DataTable aux;
        public escojaPlan3(DataTable plan)
        {
            InitializeComponent();
            aux = plan;
        }

        private void escojaPlan3_Load(object sender, EventArgs e)
        {
           dataGridView1.DataSource = aux;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(2))
            {
                string a = aux.Rows[e.RowIndex].ItemArray[1].ToString();
                string b = aux.Rows[e.RowIndex].ItemArray[0].ToString();
                string c = aux.Rows[e.RowIndex].ItemArray[2].ToString();
                MessageBox.Show(a);
                MessageBox.Show(b);
                MessageBox.Show(c);
            }
        }
    }
}