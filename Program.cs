using System;
using System.Collections.Generic;

using repaso.clase;

namespace repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //definimos un cliente
            cliente clientito = new cliente("Juan P");
                   
            //Definimos ingredientes
            ingredientes salami = new ingredientes("Salami");
            ingredientes tomate = new ingredientes("Tomate");
            ingredientes pimiento = new ingredientes("Pimiento");

            //creamos 2 pizzas
            pizza hawaiana = new pizza()
            {
                Tipo = "Hawaiana",
                Precio = 20,
                Tamanio = "Grande"
            };
            /* hawaiana.Tipo = "Hawaiana";   hawaiana.Precio = 20;   hawaiana.Tamanio = "Grande"; */

            pizza queso = new pizza();
            queso.Tipo = "Queso"; queso.Precio = 18; queso.Tamanio = "Mediana";

            /*{
                Tipo = "Pizza de Queso",
                Precio = 18,
                Tamanio = "Mediana"
            };*/
           

            //Al cliente le agregamos una lista de pedidos

            clientito.Pedidos = new List<pedido>();

            //Crear un Pedido sin pizzas
            pedido pedidos = new pedido()
            {
                Cliente = clientito,
                Fecha = "2019-01-01",
                Numentrega = "123",
                PizzasPorPedido = new List<pedidoPorPizza>()
            };

            //agregar un pedido de la pizza de queso con salami como ingrediente
            pedidoPorPizza pedidoPizza1 = new pedidoPorPizza()
            {
                Pedido = pedidos,
                Pizza = queso,
                Ingredientes = new List<ingredientes>()
            };  pedidoPizza1.Ingredientes.Add(salami);

            //agregar un pedido de la pizza hawaiana con tomate y pimiento
            pedidoPorPizza pedidoPizza2 = new pedidoPorPizza()
            {
                Pedido = pedidos,
                Pizza = hawaiana,
                Ingredientes = new List<ingredientes>()
            };  pedidoPizza2.Ingredientes.Add(tomate);  //pedidoPizza2.Ingredientes.Add(pimiento);


            // en ese pedido agregar las pizzas que desea
            pedidos.PizzasPorPedido.Add(pedidoPizza1);
            pedidos.PizzasPorPedido.Add(pedidoPizza2);

            //por último asociar ese pedido al cliente
            clientito.Pedidos.Add(pedidos);
            //recorrer los pedidos
            foreach (pedido item in clientito.Pedidos)
            {
                //mostrar nombre del cliente
                Console.WriteLine(item.Cliente.Nombre);
                foreach (pedidoPorPizza item2 in item.PizzasPorPedido)
                {
                    //Mostrar Nombre de las pizzas pedidas
                    Console.WriteLine(item2.Pizza.Tipo);
                    //Mostrar nombre de los ingredientes
                    foreach (ingredientes item3 in item2.Ingredientes)
                    {
                        Console.WriteLine(item3.Nombre);
                    }
                }
            }
        }
    }
}
