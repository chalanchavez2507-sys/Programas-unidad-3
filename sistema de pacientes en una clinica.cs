using proyecto1_clinica;
using proyecto1_Clinica;
using System.ComponentModel.DataAnnotations.Schema;

paciente.cs
namespace proyecto1_clinica
{
    public class paciente
    {
        public int expediente { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public int prioridad { get; set; }

        public paciente(int expediente, string nombre, int edad, int prioridad)
        {
            expediente = expediente;
            nombre = nombre;
            edad = edad;
            prioridad = prioridad;
        }

        public override string ToString()
        {
            return $"Expediente: {expediente}|" +
                $"Nombre:{nombre}|" +
                $"Edad:{edad}|" +
                $"Prioridad:{prioridad}";
        }
    }
}

namespace proyecto1_Clinica
}
    public class nodo
{
    public paciente datos;
    public nodo siguiente;

    public nodo(paciente paciente)
    {
        datos = paciente;
        siguiente = null;
    }
  }
}

using system;

namespace proyecto1_clinica
{
    internal class Program
    {
        static Cola pacientes = new Cola();

        static void Main(string[] args)
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("=====CLINICA=====");
                Console.WriteLine("1. registrar paciente");
                Console.WriteLine("2. atender pacientes");
                Console.WriteLine("3.Mostrar pacientes");
                Console.WriteLine("0. Salir");
                Console.Write("opcion:");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        registrarPaciente();
                        break;
                    case 2:
                        atenderPaciente();
                        break;
                    case 3:
                        pacientes.mostrar();
                        console.readkey();
                        break;
                }

            } while (opcion != 0);
        }

        static void registrar()
        {
            console.write("expediente:");
            int expediente = int.parse(console.readline());

            console.write("nombre:");
            string nombre = console.readline();

            console.write("edad:");
            int edad = int.parse(console.readline());

            console.write("prioridad:");
            int prioridad = int.parse(console.readline());

            paciente paciente = new paciente(expediente, nombre, edad, prioridad);

            pacientes.encolar(paciente);

            console.writeLine("paciente registrado.");
            console.readkey();
        }

        static void atender()
        {
            paciente paciente = pacientes.desencolar();

            if (paciente != null)
                console.writeLine("no hay pacientes.");
            else
                console.writeLine("atendiendo.");

            if (paciente != null)
                console.writeLine(paciente);
            console.readkey();
        }
    }
}

using System;
namespace proyecto1_clinica
{
    public class Cola
    {
        private nodo frente;
        private nodo final;
        public Cola()
        {
            frente = null;
            final = null;
        }
        public void encolar(paciente paciente)
        {
            nodo nuevoNodo = new nodo(paciente);
            if (frente == null)
            {
                frente = nuevoNodo;
                final = nuevoNodo;
            }
            else
            {
                final.siguiente = nuevoNodo;
                final = nuevoNodo;
            }
        }
        public paciente desencolar()
        {
            if (frente == null)
                return null;
            paciente paciente = frente.datos;
            frente = frente.siguiente;
            if (frente == null)
                final = null;
            return paciente;
        }
        public void mostrar()
        {
            if (frente == null)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }
            nodo aux = frente;
            while (aux != null)
            {
                Console.WriteLine(aux.datos);
                aux = aux.siguiente;
            }
        }
    }
}



















                    




