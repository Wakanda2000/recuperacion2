using System;
using System.Collections.Generic;
using System.Text;

namespace repaso.clase
{
    class cliente
    {
        public cliente(string nombre)
        {
            Nombre = nombre;
        }

        private string nombre;
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        private List<pedido> pedidos;
        public List<pedido> Pedidos
        {
            get { return this.pedidos; }
            set { this.pedidos = value; }
        }
    }
}
