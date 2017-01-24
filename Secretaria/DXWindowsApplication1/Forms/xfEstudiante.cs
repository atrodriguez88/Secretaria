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
    public partial class xfEstudiante : DevExpress.XtraEditors.XtraForm
    {
        
        public xfEstudiante()
        {
            InitializeComponent();
            
        }



        private void xfEstudiante_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tesisDataSet41.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter1.Fill(this.tesisDataSet41.Estudiante);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.estudianteTableAdapter1.FillBy(this.tesisDataSet41.Estudiante);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}