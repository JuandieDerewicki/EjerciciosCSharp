using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoFinalPruebas.Clases
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public bool EsHumano { get; set; } // Humano o máquina
        public bool Juega { get; set; }

        public Ficha fichaSeleccionada { get; set; }

        public string Color { get; set; }
        public Ficha Ficha1 { get; set; }
        public Ficha Ficha2 { get; set; }
        public Ficha Ficha3 { get; set; }
        public Ficha Ficha4 { get; set; }

        public Jugador(string nombre, bool esHumano, string Color, Ficha ficha1, Ficha ficha2, Ficha ficha3, Ficha ficha4) { 
            this.Nombre = nombre;
            this.EsHumano = esHumano;
            this.Color = Color;
            this.Ficha1 = ficha1;
            this.Ficha2 = ficha2;
            this.Ficha3 = ficha3;
            this.Ficha4 = ficha4;
        }

        public Jugador() 
        { 
            this.Juega = false;
        }

        public Jugador(string color)
        {
            this.Juega = false;
            this.Color = color;
        }
    }
}
