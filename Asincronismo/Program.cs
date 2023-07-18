using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        Console.WriteLine("Inicio del programa");
        await EjecutarTareaAsincrona();
        Console.WriteLine("Fin del programa");
    }

    public static async Task EjecutarTareaAsincrona()
    {
        Console.WriteLine("Iniciando tarea asincrónica");
        await Task.Delay(2000); // Simulación de una operación asincrónica que tarda 2 segundos
        Console.WriteLine("Tarea asincrónica completada");
    }
}
//public class Program
//{
//    public static async Task Main()
//    {
//        Console.WriteLine("Inicio del programa");

//        string resultado = await ObtenerDatosDeApi();
//        Console.WriteLine(resultado);

//        Console.WriteLine("Fin del programa");
//    }

//    public static async Task<string> ObtenerDatosDeApi()
//    {
//        using (HttpClient cliente = new HttpClient())
//        {
//            Console.WriteLine("Iniciando solicitud a la API");
//            HttpResponseMessage respuesta = await cliente.GetAsync("https://api.example.com/data");
//            respuesta.EnsureSuccessStatusCode();
//            string contenido = await respuesta.Content.ReadAsStringAsync();
//            Console.WriteLine("Solicitud a la API completada");
//            return contenido;
//        }
//    }
//}