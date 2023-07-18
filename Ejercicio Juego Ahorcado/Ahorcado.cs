using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoAhorcado
{
    internal class Ahorcado
    {
        int contLetras = 0;
        bool ganador = false;
        private string[] palabrasJuego = new string[10] { "pato", "mesa", "vela", "hoja", "pelo", "gato", "vaca", "vaso", "edad", "veda" };
        string palabra;
        string palabraGuiones = "";
        public Ahorcado()
        {
            palabraAhorcado();
            generarGuiones();
        }
        public string Palabra { get => palabra; set => palabra = value; }
        
        public void palabraAhorcado()
        {
            Random palabraRandom = new Random();
            int indiceAleatorio = palabraRandom.Next(palabrasJuego.Length);
            Palabra = palabrasJuego[indiceAleatorio];
        }

        public void generarGuiones()
        {
            for (int i = 0; i < Palabra.Length; i++)
            {
                if (i == 0)
                {
                    palabraGuiones = "_ ";
                }
                else
                {
                    palabraGuiones += "_ ";
                }
            }
            Console.WriteLine($"La palabra tiene {Palabra.Length} letras y es {Palabra}");
            Console.WriteLine(palabraGuiones);
        }
        public void agregarLetra(Char letraAgregada)
        {
            string nuevaPalabra = "";
            for (int i = 0; i < Palabra.Length; i++)
            {
                if (Palabra[i] == letraAgregada)
                {
                    nuevaPalabra += letraAgregada + " ";
                    contLetras++;
                }
                else
                {
                    nuevaPalabra += palabraGuiones[i * 2] + " ";
                }
            }
            palabraGuiones = nuevaPalabra;
            Console.WriteLine(palabraGuiones);
        }
        public bool comprobarGanador()
        {
            if (contLetras == Palabra.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
