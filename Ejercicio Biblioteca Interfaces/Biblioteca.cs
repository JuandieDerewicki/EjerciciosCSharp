using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBibliotecaInterfaces
{
    internal class Biblioteca : ICollection
    {

        private ArrayList libros = new ArrayList();  //  contiene una instancia de ArrayList llamada "libros" que almacena los elementos de la biblioteca.

        // Implementacion de ICollection que te da los miembros necesarios para crear una coleccion personalizada 
        public int Count { get { return libros.Count; } }

        public bool IsSynchronized { get { return libros.IsSynchronized; } }    

        public object SyncRoot { get { return libros.SyncRoot; } } 

        public void CopyTo(Array array, int index)
        {
            libros.CopyTo(array, index);
        }
        public IEnumerator GetEnumerator()
        {
            return libros.GetEnumerator();  
        }

        // Metodos personalizados

        public void agregarLibro(Libro libro)
        {
            libros.Add(libro);
        }

        public void eliminarLibro(Libro libro)
        {
            libros.Remove(libro);
        }

        public bool ContieneLibro(Libro libro)
        {
            return libros.Contains(libro);
        }

        public ArrayList GetLibros()
        {
            return libros;
        }
    }
}
