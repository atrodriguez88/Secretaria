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
    public partial class escojaPlan2 : DevExpress.XtraEditors.XtraForm
    {
        DataTable aux;
        public escojaPlan2(DataTable plan)
        {
            InitializeComponent();
            aux = plan;
        }

        private void escojaPlan2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = aux;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex.Equals(1))
            {
                string a = aux.Rows[e.RowIndex].ItemArray[1].ToString();
                string b = aux.Rows[e.RowIndex].ItemArray[0].ToString();
                MessageBox.Show(a);
                MessageBox.Show(b);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}