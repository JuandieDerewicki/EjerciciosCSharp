// Declaracion del tipo 
public delegate void MiDelegado(string msj);

//class Program
//{
//    static void Main(string[] args)
//    {
//        //Instanciacion - "method group conversion syntax"
//        MiDelegado delegado = ClaseA.MetodoA;
//        //Invocacion
//        delegado("Soy el delegado");
//    }
//}

//class ClaseA
//{
//    public static void MetodoA(string mensaje)
//    {
//        Console.WriteLine("Llamado ClaseA.MetodoA() con parámetro: " + mensaje);
//    }
//}

class Program
{
    static void Main(string[] args)
    {
        //Instanciacion - "method group conversion syntax"
        MiDelegado delegado = ClaseA.MetodoA;
        //Invocacion
        //delegado("Invocado con este parámetro");

        //delegado = ClaseB.MetodoB;  // Sobreescribiría al metodo A
        delegado += ClaseB.MetodoB; // Se concatenaria con el metodo A e imprimiría los dos
        InvocarDelegado(delegado);
    }
    static void InvocarDelegado(MiDelegado del)
    {
        del("Soy el delegado"); // Delegado
    }
}

class ClaseA
{
    public static void MetodoA(string mensaje)
    {
        Console.WriteLine("Llamado ClaseA.MetodoA() con parámetro: " + mensaje);
    }
}

class ClaseB
{
    public static void MetodoB(string mensaje)
    {
        Console.WriteLine("Llamado ClaseA.MetodoB() con parámetro: " + mensaje);
    }
}

