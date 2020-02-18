using System;
using System.Collections.Generic;
using System.Text;

namespace repaso.clase
{
    class pedidoPorPizza
    {
        public pedidoPorPizza()
        {   }
        private pizza pizza;
        public pizza Pizza
        {
            get { return this.pizza; }
            set { this.pizza = value; }
        }
        private pedido pedido;
        public pedido Pedido
        {
            get { return this.pedido; }
            set { this.pedido = value; }
        }
        private List<ingredientes> ingredientes;
        public List<ingredientes> Ingredientes
        {
            get { return this.ingredientes; }
            set { this.ingredientes = value; }
        }
    }
}
