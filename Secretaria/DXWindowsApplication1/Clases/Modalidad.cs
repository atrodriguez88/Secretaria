using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Drawing;

namespace DXWindowsApplication1
{
    class Modalidad
    {
        private int idMod;
        private string Nombre;

        public Modalidad(int idMod, string Nombre)
        {
            this.idMod = idMod;
            this.Nombre = Nombre;
        }

        public Modalidad()
        {
            this.idMod = 0;
            this.Nombre = "";
        }

    }
}
