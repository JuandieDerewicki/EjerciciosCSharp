using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioApuestasCompleto
{
    internal class Jugadores
    {
        private string nombre;
        private double dineroJugador;
        public Jugadores(string nombre)
        {
            this.nombre = nombre;
            dineroJugador = 100;
        }

        public string Nombre
        {
            get 
            {
                return nombre;
            }
            set 
            { 
                nombre = value; 
            }
        }

        public double DineroJugador
        {
            get 
            {
                return dineroJugador; 
            }
            set 
            { 
                dineroJugador = value;
            }
        }

        public override string ToString()
        {
            return "Nombre: " +  nombre + " - Dinero: $" + dineroJugador;
        }
    }
}
