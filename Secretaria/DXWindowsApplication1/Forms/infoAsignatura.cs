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
    public partial class infoAsignatura : DevExpress.XtraEditors.XtraForm
    {
        string a;
        string b;
        int c;

        public infoAsignatura(string nombre, string descripcion, int horas)
        {
            InitializeComponent();
            a = nombre;
            b = descripcion;
            c = horas;
        }

        private void infoAsignatura_Load(object sender, EventArgs e)
        {
            lbNomb.Text = a;
            lbDescrip.Text = b;
            lbHor.Text = c.ToString();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}