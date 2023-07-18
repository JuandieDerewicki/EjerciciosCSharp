
using EjercicioCifradoCesar2;

string palabra;
int contraseña = 0;
int opcion = 0; 
bool cond = true;
bool cond2 = true;


do
{
    Console.WriteLine("Ingrese una palabra: ");
    palabra = Console.ReadLine();

    if (palabra.Replace(" ", "").All(c => Char.IsLetter(c)))
    {
        break;
    }
    Console.WriteLine("Ingrese una palabra válida\n");
} while (true);


while (cond)
{
    Console.WriteLine("Ingrese una contraseña válida en números:");
    if (int.TryParse(Console.ReadLine(), out contraseña))
    {
        cond = false;
    }
    else
    {
        Console.WriteLine("Error al ingresar contraseña - Ingrese una contraseña válida en números\n");
    }
}

ClaseCifrado c1 = new ClaseCifrado(palabra, contraseña);


while (cond2)
{
    Console.WriteLine("Ingrese 1 si desea encriptar\nIngrese 2 si desea desencriptar");
    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        cond2 = false;
    }
    else
    {
        Console.WriteLine("Error al ingresar contraseña - Ingrese una contraseña válida en números\n");
    }
}

if (opcion == 1)
{
    Console.WriteLine(c1.Encriptar());
}
else if (opcion == 2)
{
    Console.WriteLine(c1.Desencriptar());
}
else
{
    Console.WriteLine("El numero no se encuentra dentro de los parametros");
}

/*
using System;

namespace CifradoCesar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese una palabra: ");
            String palabra = Console.ReadLine();
            Console.WriteLine("Ingrese la contraseña: ");
            int password;
            if (!(int.TryParse(Console.ReadLine(), out password)))
            {
                Console.WriteLine("Error al ingresar password");
            }
            else
            {
                Cesar cesar = new Cesar(palabra, password);
                Console.WriteLine("Para encriptar ingrese 1. Para desencriptar ingrese 2.");
                int opcion;
                if ((int.TryParse(Console.ReadLine(), out opcion)))
                {
                    if (opcion == 1)
                    {
                        Console.WriteLine(cesar.encriptar());
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine(cesar.desencriptar());
                    }
                    else
                    {
                        Console.WriteLine("Opcion no valida");
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numero de las opciones");
                }
            }
        }
    }

    public class Cesar
    {
        String entrada { get; set; }
        int password { get; set; }

        public Cesar(String entrada, int n)
        {
            this.entrada = entrada;
            this.password = n;
        }

        private String recorrer(int repetir, Char indice, bool opcion)
        {
            String caracteres = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
            int cont = 0;
            int i = caracteres.IndexOf(indice);
            int ultimo = caracteres.Length - 1;
            while (cont < repetir)
            {
                if (opcion)
                {
                    i++;
                }
                else
                {
                    i--;
                }
                if (i < 0)
                {
                    i = ultimo;
                }
                if (i > ultimo)
                {
                    i = 0;
                }
                cont++;
            }
            return caracteres[i].ToString();
        }

        public String encriptar()
        {
            String aux = "";
            for (int i = 0; i < this.entrada.Length; i++)
            {
                if (this.entrada[i] == ' ')
                {
                    aux = aux + " ";
                }
                else
                {
                    aux = aux + this.recorrer(this.password, this.entrada[i], true);
                }
            }
            return aux;
        }

        public String desencriptar()
        {
            String aux = "";
            for (int i = 0; i < this.entrada.Length; i++)
            {
                if (this.entrada[i] == ' ')
                {
                    aux = aux + " ";
                }
                else
                {
                    aux = aux + this.recorrer(this.password, this.entrada[i], false);
                }
            }
            return aux;
        }
    }
}
*/





