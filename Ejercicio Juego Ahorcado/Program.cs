using JuegoAhorcado;

int contIntentos = 0;   
Console.WriteLine("----Bienvenido al juego ahorcado----");
Console.WriteLine("***Tendrá 5 intentos para intentar adivinar la palabra\n");
Ahorcado a1 = new Ahorcado();
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Intento {i}, ingrese una letra:");
    char letraUsuario = char.Parse(Console.ReadLine());
    a1.agregarLetra(letraUsuario);
    contIntentos++;
    if (a1.comprobarGanador() == true)
    {
        Console.WriteLine($"\nFelicitaciones, usted ha ganado. La palabra era {a1.Palabra} y la ha adivinado en {contIntentos} intentos!");
        break;
    }
}
if (a1.comprobarGanador() == false)
{
    Console.WriteLine($"\nUsted ha perdido, la palabra era {a1.Palabra}");
}  
