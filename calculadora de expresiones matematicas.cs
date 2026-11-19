namespace proyecto4_calculadora
{
    public class pila
    {
        private nodo tope;


        private class nodo
        {
            public char dato;
            public nodo siguiente;

            public nodo(char dato)
            {
                dato = dato;
            }
        }

        public bool vacia()
        {
            return tope == null;
        }

        public void apilar(char dato)
        {
            nodo nuevo = new nodo(dato);
            nuevo.siguiente = tope;
            tope = nuevo;
        }

        public char desapilar()
        {
            if (vacia())
                return '\0';

            char dato = tope.dato;
            tope = tope.siguiente;

            return dato;
        }

        public char tope()
        {
            if (vacia())
                return '\0';

            return tope.dato;
        }
    }
}

using System;

namespace proyecto4_calculadora
{
    internal class Program
    {
        static int prioridad(char operador)
        {
            if (operador == '+' || operador == '-')
                return 1;

            if (operador == '*' || operador == '/')
                return 2;

            if (operador == '^')
                return 3;

            return 0;
        }
        static string infijaAposFija(string expresion)
        {
            pila pila = new pila();
            string salida = "";

            foreach (char carter in expresion)
            {
                if (char.isdigit(caracter))
                {
                    salida + = caracter;
                }
                else if (caracter ==´(´)
                {
                    pila.apilar(caracter);
                }
                else if (caracter ==´)´)
                {
                    while (!pila.vacia() &&
                        pila.tope()! =´(´)
                    {
                        salida + = pila.desapilar();
                    }

                    pila.desapilar();
                }
                else if ("+-*/^".contains(caracter))
                {
                    while (!pila.vacia()) salida + = pila.desapilar();

                    return salida;
                }

                static void Main()
                {
                    Console.WriteLine("===CALCULADORA===");

                    Console.Write("expresion:");
                    string expresion = Console.ReadLine();

                    string posfija = infijaAposFija(expresion);

                    console.WriteLine($"Posfija:{posfija}");

                    console.readkey();
                }
            }
        }












