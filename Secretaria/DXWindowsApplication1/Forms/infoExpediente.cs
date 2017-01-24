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
    public partial class buscarExpediente : DevExpress.XtraEditors.XtraForm
    {
        int noConcecutivo;
        int noExpediente;
        string nomb;
        string pApell;
        string sApell;

        public buscarExpediente(int a, int b, string c, string d, string e)
        {
            InitializeComponent();
            noConcecutivo = a;
            noExpediente = b;
            nomb = c;
            pApell = d;
            sApell = e;
        }

        private void buscarExpediente_Load(object sender, EventArgs e)
        {
            lbConsecutivo.Text= noConcecutivo.ToString();
            lbExpediente.Text= noExpediente.ToString();
            lbNombre.Text = nomb+" "+pApell+" "+sApell;

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}