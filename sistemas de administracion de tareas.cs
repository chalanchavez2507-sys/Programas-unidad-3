using System.Text.Json.Nodes;

namespace proyecto6_tareas
{
    public class tarea
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }

        public tarea(int id, string descripcion)
        {
            id = id;
            descripcion = descripcion;
            estado = "pendiente";
        }

        public override string ToString()
        {
            return $"{id}-{descripcion}-{estado}";
        }
    }
}
 

namespace proyecto6_tareas
{
    public class listadoble
    {
        private nodo inicio;
        private class nodo
        {
            public tarea datos;
            public nodo anterior;
            public nodo siguiente;

            public nodo(tarea datos)
            {
                this.datos = datos;
            }
        }

        public void insertar(tarea tarea)
        {
            nodo nuevo = new nodo(tarea);

            if (inicio == null)
            {
                inicio = nuevo;
                return;
            }

            nodo actual = inicio;

            while (actual.siguiente != null)
                actual = actual.siguiente;

            actual.siguiente = nuevo;
            nuevo.anterior = actual;
        }

        public tarea buscar(int id)
        {
            nodo actual = inicio;
            while (actual != null)
            {
                if (actual.datos.id == id)
                    return actual.datos;
                actual = actual.siguiente;
            }

            return null;
        }

        public void mostrar()
        {
            nodo actual = inicio;
            while (actual != null)
            {
                Console.WriteLine(actual.datos);
                actual = actual.siguiente;
            }
        }
    }
}



 
