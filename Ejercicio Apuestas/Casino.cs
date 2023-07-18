using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioApuestasCompleto
{
    internal class Casino
    {
        // Varaibles de la clase
        private double pozoCasino;
        private Casino c1;
        private Dados juegoDado;
        private Jugadores jugador1;
        private Jugadores jugador2;
        private ModosApuestas apuestasJugadores;

        // Constructor e inicializacion de variables de Dado, pozo del casino y apuestas de jugadores
        public Casino()
        {
            pozoCasino = 10000;
            apuestasJugadores = new ModosApuestas();
            juegoDado = new Dados();
        }

        public double PozoCasino // Propiedades con Mayuscula 
        {
            get
            {
                return pozoCasino;
            }
            set
            {
                pozoCasino = value;
            }
        }

        // Metodo del juego 
        public void JuegoDados()
        {
            // Declaracion de variables usadas en el metodo
            int resultadoUsuario1;
            int resultadoUsuario2;
            int respuestaSeguirJugando;
            int respuestaApuesta1;
            int respuestaApuesta2;
            double respuestaDinero1;
            double respuestaDinero2;
            bool juegoUsuario = false;
            double resultado;
            int contRondas = 0;

            // Bienvenida al juego y registracion
            Console.WriteLine("****Bienvenido al juego de los dados****");

            Console.WriteLine("\nRegistrense 2 jugadores:");
            Console.WriteLine("-Nombre del jugador 1:");
            string usuario1 = Console.ReadLine();
            Console.WriteLine("-Nombre del jugador 2:");
            string usuario2 = Console.ReadLine();

            // Inicializacion de la variable jugadores
            jugador1 = new Jugadores(usuario1);
            jugador2 = new Jugadores(usuario2);

            // Estructura While para las diferentes rondas del juego 
            while (!juegoUsuario && PozoCasino > 0 && jugador1.DineroJugador > 0 && jugador2.DineroJugador > 0)//(juegoUsuario == false)
            {
                contRondas++;
                resultado = juegoDado.AdivinarNroDado();
                Console.WriteLine("el resultado es " + resultado);

                //JUGADOR 1
                Console.WriteLine($"\nRONDA {contRondas}");
                Console.WriteLine($"\nTurno de {usuario1}");

                Console.WriteLine("\nLas opciones de apuesta son: \n1-Conservador (-1/2) \n2-Arriesgado (-2/5) \n3-Desesperado (-4/15)");
                Console.WriteLine("Ingrese la apuesta que va a jugar:");
                respuestaApuesta1 = int.Parse(Console.ReadLine());
                while (respuestaApuesta1 > 3 || respuestaApuesta1 < 1)
                {
                    Console.WriteLine("Ingrese una respuesta válida a las opciones");
                    respuestaApuesta1 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ingrese cuanto dinero va a apostar:");
                respuestaDinero1 = double.Parse(Console.ReadLine());
                while (respuestaDinero1 >= jugador1.DineroJugador)
                {
                    Console.WriteLine("Saldo insuficiente, vuelva a ingresar una cantidad válida");
                    respuestaDinero1 = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("\n+A continuacion, ingrese el resultado de los dados comprendido entre 2 y 12:");
                try
                {
                    resultadoUsuario1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("ERROR. No has introducido lo especificado.A continuacion, ingrese el resultado de los dados comprendido entre 2 y 12:");
                    resultadoUsuario1 = int.Parse(Console.ReadLine());
                }

                // JUGADOR 2
                Console.WriteLine($"\nTurno de {usuario2}");

                Console.WriteLine("\nLas opciones de apuesta son: \n1-Conservador (-1/2) \n2-Arriesgado (-2/5) \n3-Desesperado (-4/15)");
                Console.WriteLine("Ingrese la apuesta que va a jugar:");
                respuestaApuesta2 = int.Parse(Console.ReadLine());
                while (respuestaApuesta2 > 3 || respuestaApuesta2 < 1)
                {
                    Console.WriteLine("Ingrese una respuesta válida a las opciones");
                    respuestaApuesta2 = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Ingrese cuanto dinero va a apostar:");
                respuestaDinero2 = double.Parse(Console.ReadLine());
                while (respuestaDinero2 >= jugador2.DineroJugador)
                {
                    Console.WriteLine("Saldo insuficiente, vuelva a ingresar una cantidad válida");
                    respuestaDinero2 = double.Parse(Console.ReadLine());
                }


                Console.WriteLine("\n+A continuacion, ingrese el resultado de los dados comprendido entre 2 y 12:");
                try
                {
                    resultadoUsuario2 = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("ERROR. No has introducido lo especificado.A continuacion, ingrese el resultado de los dados comprendido entre 2 y 12:");
                    resultadoUsuario2 = int.Parse(Console.ReadLine());
                }
                
                // CONDICION DE JUEGO
                // JUGADOR 1
                if (resultadoUsuario1 > 1 && resultadoUsuario1 < 13)
                {
                    if (resultadoUsuario1 == resultado)
                    {
                        if (respuestaApuesta1 == 1)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Conservador, jugador1, respuestaDinero1, true);
                            PozoCasino -= respuestaDinero1 * 2;
                        }
                        else if (respuestaApuesta1 == 2)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Arriesgado, jugador1, respuestaDinero1, true);
                            PozoCasino -= respuestaDinero1 * 5;
                        }
                        else if (respuestaApuesta1 == 3)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Desesperado, jugador1, respuestaDinero1, true);
                            PozoCasino -= respuestaDinero1 * 15;
                        }
                    }
                    else
                    {
                        if (respuestaApuesta1 == 1)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Conservador, jugador1, respuestaDinero1, false);
                            PozoCasino += respuestaDinero1;
                        }
                        else if (respuestaApuesta1 == 2)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Arriesgado, jugador1, respuestaDinero1, false);
                            PozoCasino += respuestaDinero1 * 2;
                        }
                        else if (respuestaApuesta1 == 3)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Desesperado, jugador1, respuestaDinero1, false);
                            PozoCasino += respuestaDinero1 * 4;
                        }
                    }

                    // Jugador 2
                    if (resultadoUsuario2 == resultado)
                    {
                        if (respuestaApuesta2 == 1)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Conservador, jugador2, respuestaDinero2, true);
                            PozoCasino -= respuestaDinero1 * 2;
                        }
                        else if (respuestaApuesta2 == 2)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Arriesgado, jugador2, respuestaDinero2, true);
                            PozoCasino -= respuestaDinero1 * 5;
                        }
                        else if (respuestaApuesta2 == 3)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Desesperado, jugador2, respuestaDinero2, true);
                            PozoCasino -= respuestaDinero1 * 15;
                        }
                    }
                    else
                    {
                        if (respuestaApuesta2 == 1)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Conservador, jugador2, respuestaDinero2, false);
                            PozoCasino += respuestaDinero1;
                        }
                        else if (respuestaApuesta2 == 2)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Arriesgado, jugador2, respuestaDinero2, false);
                            PozoCasino += respuestaDinero1 * 2;
                        }
                        else if (respuestaApuesta2 == 3)
                        {
                            apuestasJugadores.ApuestaJugador(ModosApuestas.EleccionApuesta.Desesperado, jugador2, respuestaDinero2, false);
                            PozoCasino += respuestaDinero1 * 4;
                        }
                    }

                    // Impresion de resultados
                    if (resultadoUsuario1 == resultado && resultadoUsuario2 == resultado)
                    {
                        Console.WriteLine($"\n¡Felicitaciones {usuario1} y {usuario2}, han ganado!");
                        Console.WriteLine("Informacion:\n" + jugador1.ToString() + "\n" + jugador2.ToString() + "\n" + "Pozo del casino: $" + PozoCasino);
                    }

                    else if (resultadoUsuario1 == resultado && resultadoUsuario2 != resultado)
                    {
                        Console.WriteLine($"\n¡Felicitaciones {usuario1} ha ganado!");
                        Console.WriteLine("Informacion:\n" + jugador1.ToString() + "\n" + jugador2.ToString() + "\n" + "Pozo del casino: $" + PozoCasino);
                    }
                    else if (resultadoUsuario1 == resultado && resultadoUsuario2 != resultado)
                    {
                        Console.WriteLine($"\n¡Felicitaciones {usuario1} ha ganado!");
                        Console.WriteLine("Informacion:\n" + jugador1.ToString() + "\n" + jugador2.ToString() + "\n" + "Pozo del casino: $" + PozoCasino);
                    }
                    else
                    {
                        Console.WriteLine("\n¡Ambos jugadores han perdido!");
                        Console.WriteLine("Informacion:\n" + jugador1.ToString() + "\n" + jugador2.ToString() + "\n" + "Pozo del casino: $" + PozoCasino);
                    }

                    // CONDICION DE SEGUIR EL JUEGO
                    Console.WriteLine("\n-Presione 1 si desean volver a jugar\n-Presione 2 si desean salir");
                    try
                    {
                        respuestaSeguirJugando = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("ERROR. Vuelva a ingresar lo solicitado:");
                        respuestaSeguirJugando = int.Parse(Console.ReadLine());
                    }
                    if (respuestaSeguirJugando == 1)
                    {
                        juegoUsuario = false;
                    }
                    else if (respuestaSeguirJugando == 2)
                    {
                        juegoUsuario = true;
                    }
                    else
                    {
                        Console.WriteLine("ERROR. Vuelva a ingresar lo solicitado:");
                        respuestaSeguirJugando = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("ERROR. El numero introducido por uno de los usuarios no se encuentra dentro de los parametros. Se reiniciará el juego y pasarán a jugar una nueva ronda");
                }

                }

            Console.WriteLine("\nEl juego ha terminado, a continuacion se brindarán los datos de la partida: \n" + jugador1.ToString() + "\n" + jugador2.ToString() + "\nPozo casino: $" + PozoCasino);
        }
    }
}
