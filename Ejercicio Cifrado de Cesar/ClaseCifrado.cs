using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCifradoCesar2
{
    internal class ClaseCifrado
    {

        //private string palabra; Son innecesarios pq ya se asignan valores e inicializan desde el constructor. Ademas estos campos privados ni siquiera son utilizados durante la clase, por lo que es innecesario declararlos de esta manera
        //private int clave;

        public ClaseCifrado(string palabra, int clave)
        {
            this.Palabra = palabra;
            this.Clave = clave; 
        }

        string Palabra { get; set; }
        int Clave { get; set; }
        public string recorrer(int password, char texto, bool opcion) // Va a recibir la clave de cuantos lugares moverse, la palabra y un booleano que nos va a decir si es + o -.
        {
            string caracteresCifrados = "aábcdeéfghiíjklmnñoópqrstuúüvwxyz";
            int cont = 0;
            int indice = caracteresCifrados.IndexOf(texto); // Lo que buscamos es el primer indice del string texto que se encuentra en "caracteres cifrados". Ej; si la palabra es barco el primer indice es 2
            int ultimo = caracteresCifrados.Length - 1; // Para saber el numero de letras de caracteres cifrados y lo hacemos - 1 porque arranca en 0.
            
            while(cont < password) // Mientras cont sea menor a la clave, seguimos iterando y devolviendo letra por letra.
            {
                if (opcion) // Si opcion es true, significa que el numero es positivo y se debe mover por el numero de clave
                {
                    indice++;
                }
                else // Si opcion es false, significa que el numero es negativo y se debe mover por el numero de clave
                {
                    indice--;
                }
                if (indice > ultimo) // Si nos pasamos de la cantidad de caracteres que tenemos en caracteres cifrados que es 28, volvemos a empezar en 0
                {
                    indice = 0;
                }
                if (indice < 0) // Si nos pasamos de la cantidad de caracteres que tenemos en caracteres cifrados, vamos al ultimo. Esto pasa cuando nos movemos hacia la izquierda.
                {
                    indice = ultimo;
                }
                cont++; // Aumenta cont y volvemos a repetir el proceso.
            }
            return caracteresCifrados[indice].ToString(); // El método devuelve una letra en cada llamada, por lo que si quieres cifrar una palabra, debes llamar a este método por cada letra de la palabra y concatenar las letras resultantes para formar la palabra cifrada
            /* Forma 2
             
            */ 
        }

        public string Encriptar()
        {
            string textoEncriptado = "";
            foreach (char letra in Palabra)
            {
                if(letra == ' ')
                {
                    textoEncriptado += " ";
                }
                else
                {
                    string letraEncriptada = recorrer(this.Clave, letra, true);
                    textoEncriptado += letraEncriptada.ToString();
                }
            }
            return textoEncriptado;
        }
        /* Forma 2
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
        EXPLICACION:
        Este método recibe un texto (almacenado en la variable entrada) y lo recorre caracter por caracter, aplicando la función recorrer para encriptar cada letra.
        Si la letra es un espacio, se agrega directamente a la variable aux que se utiliza para almacenar el texto encriptado. Si no es un espacio, se llama a la función recorrer pasando la clave y la letra actual, con un tercer parámetro de true que indica que se debe mover hacia la derecha en el alfabeto. El resultado de recorrer se agrega a aux.
        Finalmente, el método devuelve la variable aux que contiene el texto encriptado.
        */
        public string Desencriptar()
        {
            string textoEncriptado = "";
            foreach (char letra in Palabra)
                if (letra == ' ')
                {
                    textoEncriptado += " ";
                }
                else
                {
                    string letraEncriptada = recorrer(this.Clave, letra, false);
                    textoEncriptado += letraEncriptada.ToString();
                }
            return textoEncriptado;
        }
        /* Forma 2
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
        */
    }
}
