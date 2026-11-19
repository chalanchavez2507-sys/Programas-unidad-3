using System.Text.Json.Nodes;

namespace proyecto2_restaurante
{
    public class cliente
    {
        public string nombre { get; set; }
        public int Personas { get; set; }

        public cliente(string nombre, int cantidadPersonas)
        {
            nombre = nombre;
            Personas = Personas;
        }

        public override string ToString()
        {
            return $"{nombre} - {Personas}personas";
        }
    }
}
namespace proyecto2_restaurante
{
    public class cola
    {
        private Nodo frente;
        private Nodo final;

        public void encolar(cliente cliente)
        {
            Nodo nuevoNodo = new Nodo(cliente);
            if (frente == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.Siguiente = nuevoNodo;
                final = nuevoNodo;
            }
        }

        public cliente desencolar()
        {
            if (frente == null)
            {
                return null;

                cliente cliente = frente.Cliente;
                frente = frente.Siguiente;

                if (frente == null)
                    final = null;

                return cliente;
            }

            public void mostrar()
        {
            Nodo actual = frente;
            while (actual != null)
            {
                system.Console.WriteLine(actual.datos);
                actual = actual.Siguiente;
            }
        }
    }
}

using system;

namespace proyecto2_restaurante
{
    internal class program
    {
        static cola espera = new cola();

        static void main()
        {
            int opcion;

            do
            {
                console.writeline("===RESTAURANTE===");
                console.writeline("1. Agregar cliente");
                console.writeline("2. Asignar mesa");
                console.writeline("3. Mostrar espera");
                console.writeline("0. Salir");
                console.write("opción:");

                opcion = int.parse(console.readline());

                switch (opcion)
                {
                    case 1:
                        agregar();
                        break;

                    case 2:
                        asignar mesa();
                        break;

                    case 3:
                        espera.mostrar();
                        console.readkey();
                        break;
                }

            } while (opcion != 0);
        }

        static void agregar()
        {
            console.write("nombre:");
            string nombre = console.readline();

            console.write("numero de personas:")
            int personas = int.parse(console.readline());

            espera.encolar(new cliente(nombre, personas));

            console.writeline("cliente agregado.");
            console.readkey();
        }

        static void asignarmesa()
        {
            cliente cliente = espera.desencolar();

            if (cliente == null)
                console.writeline("no hay clientes.");
            else
                console.writeline($"mesa asignada a{cliente}");

            console.readkey();
        }
    }
}
             




        
    










