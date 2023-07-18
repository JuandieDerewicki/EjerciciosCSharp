// See https://aka.ms/new-console-template for more information

using EjercicioModa2;

Moda m1 = new Moda();

Console.Write("Ingrese números enteros separados por espacios: ");
string input = Console.ReadLine(); // Cadena de datos que pone el usuario
string[] inputNum = input.Trim().Split(' '); // Los espacios en blanco que se pongan al principio o al final se eliminan para evitar errores. Ademas el split hace que por cada espacio en blanco se salte a otro linea

// Convertir las cadenas de entrada a enteros
int[] numeros = new int[inputNum.Length];
for (int i = 0; i < inputNum.Length; i++)
{
    if (int.TryParse(inputNum[i], out int num)) // Trato de pasar lo que tengo en inputNum que es una cadena de strings a un entero con int y si lo logra, almacena ese valor en el nuevo arreglo, y si no lo logra arroja un error
    {
        numeros[i] = num;
    }
    else
    {
        Console.WriteLine($"Invalid input: {inputNum[i]}");
        return;
    }
}

Console.WriteLine("\n" + m1.FuncionValorMinMax(numeros));
Console.WriteLine("\n" + m1.FuncionModa(numeros));

/* Forma 1
Console.WriteLine("Ingrese la cantidad de datos con las que cuenta: ");
int cantidadDatos = int.Parse(Console.ReadLine());  

int[] matrizDatosUsuario = new int[cantidadDatos];

Console.WriteLine("\nAhora ingrese sus respectivos datos númericos:");

for (int i = 0; i < matrizDatosUsuario.Length; i++)
{
    Console.WriteLine("-");
    int datosUsuario = int.Parse(Console.ReadLine());
    matrizDatosUsuario[i] = datosUsuario;
}

Console.WriteLine("\n" + m1.FuncionValorMinMax(matrizDatosUsuario));
Console.WriteLine("\n" + m1.FuncionModa(matrizDatosUsuario));
*/




