using System;
using System.Collections.Generic;
using System.Text;

namespace repaso.clase
{
    class pizza
    {
        public pizza()
        {
        }
        private string tipo;
        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        private string tamanio;
        public string Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }
        private float precio;
        public float Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
    }
}
