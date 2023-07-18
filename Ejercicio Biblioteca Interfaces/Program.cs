using EjercicioBibliotecaInterfaces;
using System.Collections; // Para utilizar colecciones
using System.Collections.Generic; // Para utilizar colecciones genéricas
using System.Diagnostics; // Para utilizar stopwatch


//Ejercicio de interfaces normal 

Libro[] biblioteca = new Libro[3];
biblioteca[0] = new Libro("Pablo Neruda", "Marinero");
biblioteca[1] = new Libro("Ricardo Darin", "Nebulosa");
biblioteca[2] = new Libro("Diego Derewicki", "Honorarios III");

Array.Sort((Libro[]) biblioteca); //conversión explícita de tipos de datos para el arreglo biblioteca, y los paréntesis exteriores indican que estás llamando al método Array.Sort con el argumento del arreglo castado.

foreach (Libro libros in biblioteca)
{
    if(libros != null)
    {
        libros.Describir();
    }
}



/*
 Ejercicio de almacenar
los libros en una clase contenedora "biblioteca", en "biblioteca" implementar una coleccion
personalizada de ArrayList, y luego mostrar los libros cargados 

Biblioteca miBiblioteca = new Biblioteca();

Libro libro1 = new Libro("JuanPerez", "Diego Derewicki");
Libro libro2 = new Libro("Marinero", "Ricardo Darin");
Libro libro3 = new Libro("Nebulosa", "Leo Messi");
miBiblioteca.agregarLibro(libro1);
miBiblioteca.agregarLibro(libro2);
miBiblioteca.agregarLibro(libro3);
Console.WriteLine(miBiblioteca.ContieneLibro(libro1)); 
miBiblioteca.eliminarLibro(libro2); 

ArrayList listaLibros = miBiblioteca.GetLibros();

foreach (object libroObjeto in listaLibros)
{
    if (libroObjeto is Libro libro)
    {
        Console.WriteLine($"Título: {libro.Titulo}, Autor: {libro.Autor}");
    }
}

/*
 En este código, se itera sobre cada elemento del ArrayList listaLibros utilizando el tipo object. 
Dentro del bucle, se verifica si el elemento es de tipo Libro utilizando la comprobación 
is Libro libro. Si la comprobación es exitosa, se realiza una conversión de tipo a Libro 
y se puede acceder a las propiedades Titulo y Autor para imprimir la información del libro.
 */


/*
List <Libro> libros = new List<Libro>(); // Declaracion de la lista 

// Funciona lo del tiempo cuando cargamos muchas instancias
libros.Add(new Libro("Pablo Neruda", "Marinero"));
libros.Add(new Libro("Juan Diego Derewicki", "Botellas"));
libros.Add(new Libro("Leo Messi", "Perseverancia"));
libros.Add(new Libro("Gonzalo Higuain", "Muerto"));
libros.Add(new Libro("Julian Alvarez", "La araña"));
libros.Add(new Libro("Miguel Almiron", "La 7ma"));
libros.Add(new Libro("Juan Roman Riquelme", "Amor propio"));

// Medir tiempo de ordenacion de Sort
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

// Ordenar libros por titulos
libros.Sort();

// Parar tiempo de ordenacion
stopwatch.Stop();

// Imprimir libros ordenados 
foreach (Libro biblioteca in libros)
{
    if (libros != null)
    {
        biblioteca.Describir();
    }
}

// Imprimir el tiempo de ejecución
Console.WriteLine($"Tiempo de ordenación: {stopwatch.ElapsedMilliseconds} ms");


*/