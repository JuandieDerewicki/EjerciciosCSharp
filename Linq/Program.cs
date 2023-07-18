using System.Linq;

var frutas = new String[] { "Sandia", "Banana", "Pera", "Manzana", "Ciruela", "Naranja", "Banana ecuatorianas" };

var BananaLista = frutas.Where(p => p.StartsWith("Banana")).ToList();

// var mangoList = frutas.Where(f => f.ToLower().Contains("mango")).ToList(); Otra manera de filtrar

BananaLista.ForEach(p => Console.WriteLine(p));

// ToList utilizamos por rendimiento y performance, asi puedo seguir utilizando LINQ.
// Porque las expresiones LINQ devuelven in INumerable que no tiene Linq entonces, poniendo esto
// puedo seguir utilizando LINQ.

// Where: Necesita una condición que de como resultado true or false para filtrar una colección,
// cada vez que esta condición se cumpla agrega este elemento a una colección nueva la cual regresa
// como resultado después de filtrar toda la colección.