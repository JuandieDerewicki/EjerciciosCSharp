// Metodos Anonimos
// Declaracion delegado 
//public delegate void MiDelegado(string msj); 

//class Program
//{
//    static void Main(string[] args)
//    {
//        MiDelegado delegado;
//        DateTime dt = DateTime.Now;

//        // Declaracion metodo anonimo
//        delegado = delegate (string s) // Podemos utilizar MiDelegado porque tienen la misma firma
//        {
//            Console.WriteLine($"Metodo anonimo; {s} {dt}"); // Tambien imprime esta variable que estaba afuera
//        };
//        // Invocacion 
//        delegado("Soy el delegado"); // Muestra esto tambien porque lo estoy pasando por parametro 
//    }
//}

// Metods anonimos y expresiones lambda
// Declaracion delegado
//public delegate bool EsFinDeSemana(DateTime dt);
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Instanciacion del delegado con un metodo anonimo
//        EsFinDeSemana esFinDeSemana = delegate (DateTime dt)
//        {
//            return dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;
//        };

//        // Expresion lambda equivalente
//        esFinDeSemana = dt => dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;

//        bool res = esFinDeSemana(DateTime.Now);
//    }
//}

// Delegados genericos - Func 
//class Program
//{
//    static void Main(string[] args)
//    {
//        // Instanciacion del delegado con un metodo anonimo
//        Func<DateTime,bool> esFinDeSemana = delegate (DateTime dt)
//        {
//            return dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;
//        };

//        // Expresion lambda equivalente
//        esFinDeSemana = dt => dt.DayOfWeek == DayOfWeek.Saturday || dt.DayOfWeek == DayOfWeek.Sunday;

//        bool res = esFinDeSemana(DateTime.Now);
//    }
//}


// Delegados genericos - Predicate
//class Program
//{
//    static void Main(string[] args)
//    {
//        List<int> lista = new List<int>() { 6, 13, 4, 9, 3 };

//        // Se crea una nueva lista con los numeros pares de la lista original
//        // public int FindIndex(Predicate<T> match)
//        List<int> filtro = lista.FindAll(n => n % 2 == 0);

//        // Se crea una nueva lsita con los cuadrados de la lista original 
//        // Public List<TOutput> ConvertAll<TOutput> (Converter<T, TOutput> converter)
//        // Converter es un delegado ad-hoc}
//        List<int> foo = lista.ConvertAll(d => d * d);
//    }
//}


// LINQ

//class Program
//{
//    static void Main(string[] args)
//    {
//        Empleado[] empleados =
//        {
//            new Empleado() { DNI = 1, Nombre = "Jose", FechaNac = DateTime.Parse("1979/2/13") }, 
//            new Empleado() { DNI = 2, Nombre = "Raul", FechaNac = DateTime.Parse("1950/2/13") },
//            new Empleado() { DNI = 3, Nombre = "Lionel", FechaNac = DateTime.Parse("2000/2/13") },
//            new Empleado() { DNI = 4, Nombre = "Marta", FechaNac = DateTime.Parse("1970/2/13") },
//            new Empleado() { DNI = 5, Nombre = "Diego", FechaNac = DateTime.Parse("1975/2/13") },
//            new Empleado() { DNI = 6, Nombre = "Angel", FechaNac = DateTime.Parse("1971/2/13") },
//        };

//        // Version QUERY
//        var result = from e in empleados where e.Edad > 40 select e;

//        // Version FLUENT
//        var result2 = empleados.Where(e => e.Edad > 40);

//        foreach ( var e in result2 )
//        {
//            Console.WriteLine(e);
//        }
//    }
//}

//class Empleado
//{
//    private DateTime fechaNac;

//    public int DNI { get; set; }
//    public string Nombre { get; set; }
//    public DateTime FechaNac { get; set; }
//    public int Edad { get; set; }

//    public override string ToString()
//    {
//        return $"Dni: {DNI} - Nombre {Nombre} - Edad{Edad}";
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        Empleado[] empleados =
        {
            new Empleado() { DNI = 1, Nombre = "Jose", FechaNac = DateTime.Parse("1979/2/13") },
            new Empleado() { DNI = 2, Nombre = "Raul", FechaNac = DateTime.Parse("1950/2/13") },
            new Empleado() { DNI = 3, Nombre = "Lionel", FechaNac = DateTime.Parse("2000/2/13") },
            new Empleado() { DNI = 4, Nombre = "Marta", FechaNac = DateTime.Parse("1970/2/13") },
            new Empleado() { DNI = 5, Nombre = "Diego", FechaNac = DateTime.Parse("1975/2/13") },
            new Empleado() { DNI = 6, Nombre = "Angel", FechaNac = DateTime.Parse("1971/2/13") },
        };

        // Calcular la edad de cada empleado
        foreach (var empleado in empleados)
        {
            empleado.Edad = CalcularEdad(empleado.FechaNac);
        }

        // Version QUERY
        var result = from e in empleados where e.Edad > 40 select e;

        // Version FLUENT
        var result2 = empleados.Where(e => e.Edad > 40);

        foreach (var e in result2)
        {
            Console.WriteLine(e);
        }
    }

    // Método para calcular la edad a partir de la fecha de nacimiento
    static int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;
        if (fechaNacimiento > fechaActual.AddYears(-edad))
        {
            edad--;
        }
        return edad;
    }
}

class Empleado
{
    public int DNI { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaNac { get; set; }
    public int Edad { get; set; }

    public override string ToString()
    {
        return $"Dni: {DNI} - Nombre: {Nombre} - Edad: {Edad}";
    }
}