using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioApuestasCompleto
{
    internal class ModosApuestas
    {
        public enum EleccionApuesta
        {
            Conservador = 1,
            Arriesgado = 2,
            Desesperado = 3
        }

        public void ApuestaJugador(EleccionApuesta ea, Jugadores j, double dineroJugado, bool ganar)
        {
            if (ea == EleccionApuesta.Conservador)
            {
                if (ganar == true)
                {
                    j.DineroJugador += dineroJugado * 2;
                }
                else
                {
                    j.DineroJugador -= dineroJugado;
                }
            }
            if (ea == EleccionApuesta.Arriesgado)
            {
                if (ganar == true)
                {
                    j.DineroJugador += dineroJugado * 5;
                }
                else
                {
                    j.DineroJugador -= dineroJugado * 2;
                }
            }
            if (ea == EleccionApuesta.Desesperado)
            {
                if (ganar == true)
                {
                    j.DineroJugador += dineroJugado * 15;
                }
                else
                {
                    j.DineroJugador -= dineroJugado * 4;
                }
            }
        }
    }
}
