using System;
using System.Collections.Generic;
using System.Text;

namespace repaso.clase
{
    class ingredientes
    {
        public ingredientes(string nombre)
        {
            this.Nombre = nombre;
        }
        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
    }
}
