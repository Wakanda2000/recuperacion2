using System;
using System.Collections.Generic;
using System.Text;

namespace repaso.clase
{
    class pedido
    {
        public pedido()
        {
        }
        private string fecha;
        public string Fecha
        {
            get { return this.fecha; }
            set { this.fecha = value; }
        }
        private string numentrega;
        public string Numentrega
        {
            get { return this.numentrega; }
            set { this.numentrega = value; }
        }
        private cliente cliente;
        public cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        private List<pedidoPorPizza> pizzasPorPedido;
        public List<pedidoPorPizza> PizzasPorPedido
        {
            get { return this.pizzasPorPedido; }
            set { this.pizzasPorPedido = value; }
        }
    }
}
