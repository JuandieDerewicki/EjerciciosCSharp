using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBibliotecaInterfaces
{
    internal class Libro : IColeccionable, IComparable<Libro>, IComparable
    {
        private string autor;
        private string titulo;

        public Libro(string autor, string titulo)
        {
            this.Autor = autor;
            this.Titulo = titulo;
        }
        public string Autor { get => autor; set => autor = value; }
        public string Titulo { get => titulo; set => titulo = value; }

        public void Describir()
        {
            Console.WriteLine($"El nombre del libro es {Titulo} y el autor es {Autor}");
        }

        //int IComparable<Libro>.CompareTo(Libro? other)
        //{
        //    // Comparar los títulos de los libros
        //    int resultado = string.Compare(this.Titulo, other.Titulo);

        //    // Devolver el resultado de la comparación
        //    return resultado;
        //}
        public int CompareTo(Libro other)
        {
            // Comparar los títulos de los libros
            int resultado = string.Compare(this.Titulo, other.Titulo);

            // Devolver el resultado de la comparación
            return resultado;
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
        //Se puede hacer de cualquiera de las dos maneras, una te la genera la IDE y la otra la implementas vos

    }
}
