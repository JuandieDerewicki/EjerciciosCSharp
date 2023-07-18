using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TrabajoFinalPruebas.Clases;
using Timer = System.Threading.Timer;
using System.Windows.Forms;


namespace TrabajoFinalPruebas
{
    public partial class FormLudo : Form
    {
        private Random dadoAleatorio;
        private List<Image> imagenesDado;
        private bool estaGirando = false;
        private bool movimientoInicio = false;
        private bool repetirTurno = false;
        private int posicionIndex;
        private int puesto = 1;

        private Jugador jugadorVerde;
        private Jugador jugadorRojo;
        private Jugador jugadorAmarillo;
        private Jugador jugadorAzul;
        private Jugador jugador;

        private int jugadorActual;
        private List<Jugador> listaJugadores = new List<Jugador> { };

        private List<Point> coordenadasCasillerosVerdes = new List<Point>
        {
            new Point(125, 217),
            new Point(199, 217),
            new Point(270, 217),
            new Point(342, 217),
            new Point(414, 217),
            new Point(483, 185),
            new Point(483, 151),
            new Point(483, 119),
            new Point(483, 88),
            new Point(483, 54),
            new Point(483, 22),
            new Point(557, 22),
            new Point(624, 22),
            new Point(625, 55),
            new Point(625, 87),
            new Point(625, 120),
            new Point(625, 153),
            new Point(625, 184),
            new Point(699, 219),
            new Point(770, 219),
            new Point(839, 219),
            new Point(912, 219),
            new Point(982, 219),
            new Point(1056, 219),
            new Point(1056, 254),
            new Point(1056, 282),
            new Point(983, 283),
            new Point(912, 283),
            new Point(840, 283),
            new Point(769, 283),
            new Point(700, 283),
            new Point(624, 315),
            new Point(624, 349),
            new Point(624, 381),
            new Point(624, 413),
            new Point(624, 446),
            new Point(627, 479),
            new Point(552, 478),
            new Point(485, 478),
            new Point(485, 446),
            new Point(485, 414),
            new Point(485, 382),
            new Point(485, 348),
            new Point(485, 315),
            new Point(411, 283),
            new Point(341, 283),
            new Point(268, 283),
            new Point(197, 283),
            new Point(128, 283),
            new Point(54, 283),
            new Point(55, 252),
            new Point(126, 252),
            new Point(199, 252),
            new Point(270, 252),
            new Point(342, 252),
            new Point(412, 252),
            new Point(469, 252), // Coordenada final donde debe llegar el boton 
        };
        private List<Point> coordenadasCasillerosRojos = new List<Point>
        {
            new Point(626, 54),
            new Point(626, 87),
            new Point(626, 120),
            new Point(626, 152),
            new Point(626, 184),
            new Point(698, 218),
            new Point(769, 217),
            new Point(842, 218),
            new Point(912, 218),
            new Point(984, 218),
            new Point(1055, 218),
            new Point(1055, 251),
            new Point(1055, 284),
            new Point(983, 284), //casillero azul
            new Point(912, 284),
            new Point(841, 284),
            new Point(769, 283),
            new Point(698, 284),
            new Point(627, 316),
            new Point(627, 349),
            new Point(628, 382),
            new Point(627, 414),
            new Point(626, 446),
            new Point(626, 479),
            new Point(556, 480),
            new Point(484, 479),
            new Point(481, 447), // casillero amarillo
            new Point(482, 414),
            new Point(482, 382),
            new Point(482, 349),
            new Point(482, 316),
            new Point(412, 283),
            new Point(341, 283),
            new Point(269, 283),
            new Point(197, 283),
            new Point(125, 283),
            new Point(53, 283),
            new Point(53, 251),
            new Point(53, 217),
            new Point(126, 217),  // casillero verde
            new Point(197, 217),
            new Point(269, 217),
            new Point(340, 217),
            new Point(410, 217),
            new Point(482, 185),
            new Point(482, 153),
            new Point(482, 120),
            new Point(482, 87),
            new Point(482, 54),
            new Point(482, 22),
            new Point(553, 21),
            new Point(553, 54), // casillero recta final
            new Point(553, 87),
            new Point(553, 119),
            new Point(553, 152),
            new Point(553, 185),
            new Point(553, 217), // casillero donde suma puntaje
        };
        private List<Point> coordenadasCasillerosAmarillos = new List<Point>
        {
            new Point(481, 447), // casillero amarillo
            new Point(482, 414),
            new Point(482, 382),
            new Point(482, 349),
            new Point(482, 316),
            new Point(412, 283),
            new Point(341, 283),
            new Point(269, 283),
            new Point(197, 283),
            new Point(125, 283),
            new Point(53, 283),
            new Point(53, 251),
            new Point(53, 217),
            new Point(126, 217),  // casillero verde
            new Point(197, 217),
            new Point(269, 217),
            new Point(340, 217),
            new Point(410, 217),
            new Point(482, 185),
            new Point(482, 153),
            new Point(482, 120),
            new Point(482, 87),
            new Point(482, 54),
            new Point(482, 22),
            new Point(553, 21),
            new Point(626, 21),
            new Point(626, 54),
            new Point(626, 87),
            new Point(626, 120),
            new Point(626, 152),
            new Point(626, 184),
            new Point(698, 218),
            new Point(769, 217),
            new Point(842, 218),
            new Point(912, 218),
            new Point(984, 218),
            new Point(1055, 218),
            new Point(1055, 251),
            new Point(1055, 284),
            new Point(983, 284), //casillero azul
            new Point(912, 284),
            new Point(841, 284),
            new Point(769, 283),
            new Point(698, 284),
            new Point(627, 316),
            new Point(627, 349),
            new Point(628, 382),
            new Point(627, 414),
            new Point(626, 446),
            new Point(626, 479),
            new Point(556, 480),
            new Point(556, 446), // recta final
            new Point(556, 414),
            new Point(556, 381),
            new Point(556, 349),
            new Point(556, 316),
            new Point(556, 285),
        };
        private List<Point> coordenadasCasillerosAzules = new List<Point>
        {
            new Point(983, 284), //casillero azul
            new Point(912, 284),
            new Point(841, 284),
            new Point(769, 283),
            new Point(698, 284),
            new Point(627, 316),
            new Point(627, 349),
            new Point(628, 382),
            new Point(627, 414),
            new Point(626, 446),
            new Point(626, 479),
            new Point(556, 480),
            new Point(484, 479),
            new Point(481, 447), // casillero amarillo
            new Point(482, 414),
            new Point(482, 382),
            new Point(482, 349),
            new Point(482, 316),
            new Point(412, 283),
            new Point(341, 283),
            new Point(269, 283),
            new Point(197, 283),
            new Point(125, 283),
            new Point(53, 283),
            new Point(53, 251),
            new Point(53, 217),
            new Point(126, 217),  // casillero verde
            new Point(197, 217),
            new Point(269, 217),
            new Point(340, 217),
            new Point(410, 217),
            new Point(482, 185),
            new Point(482, 153),
            new Point(482, 120),
            new Point(482, 87),
            new Point(482, 54),
            new Point(482, 22),
            new Point(553, 21),
            new Point(625, 21),
            new Point(626, 54),
            new Point(626, 87),
            new Point(626, 120),
            new Point(626, 152),
            new Point(626, 184),
            new Point(698, 218),
            new Point(769, 217),
            new Point(842, 218),
            new Point(912, 218),
            new Point(984, 218),
            new Point(1055, 218),
            new Point(1055, 250),
            new Point(983 , 250), // casilleros finales
            new Point(913 , 250),
            new Point(840 , 250),
            new Point(770 , 250),
            new Point(700 , 250),
            new Point(634 , 250), // casillero para sumar puntos
        };

        public FormLudo(Jugador _jugadorVerde, Jugador _jugadorRojo, Jugador _jugadorAmarillo, Jugador _jugadorAzul)
        {
            InitializeComponent();

            jugadorVerde = _jugadorVerde;
            if (jugadorVerde != null && jugadorVerde.Juega)
            {
                listaJugadores.Add(jugadorVerde);
                verdeNombre.Text = jugadorVerde.Nombre;

                jugadorVerde.Ficha1 = new Ficha(btnVerde1, posicionIndex, coordenadasCasillerosVerdes.Count);
                jugadorVerde.Ficha2 = new Ficha(btnVerde2, posicionIndex, coordenadasCasillerosVerdes.Count);
                jugadorVerde.Ficha3 = new Ficha(btnVerde3, posicionIndex, coordenadasCasillerosVerdes.Count);
                jugadorVerde.Ficha4 = new Ficha(btnVerde4, posicionIndex, coordenadasCasillerosVerdes.Count);

                jugadorVerde.fichaSeleccionada = jugadorVerde.Ficha1;
            }

            jugadorRojo = _jugadorRojo;
            if (jugadorRojo != null && jugadorRojo.Juega)
            {
                listaJugadores.Add(jugadorRojo);
                rojoNombre.Text = jugadorRojo.Nombre;

                jugadorRojo.Ficha1 = new Ficha(btnRojo1, posicionIndex, coordenadasCasillerosRojos.Count);
                jugadorRojo.Ficha2 = new Ficha(btnRojo2, posicionIndex, coordenadasCasillerosRojos.Count);
                jugadorRojo.Ficha3 = new Ficha(btnRojo3, posicionIndex, coordenadasCasillerosRojos.Count);
                jugadorRojo.Ficha4 = new Ficha(btnRojo4, posicionIndex, coordenadasCasillerosRojos.Count);

                jugadorRojo.fichaSeleccionada = jugadorRojo.Ficha1;
            }

            jugadorAmarillo = _jugadorAmarillo;
            if (jugadorAmarillo != null && jugadorAmarillo.Juega)
            {
                listaJugadores.Add(jugadorAmarillo);
                amarilloNombre.Text = jugadorAmarillo.Nombre;

                jugadorAmarillo.Ficha1 = new Ficha(btnAmarillo1, posicionIndex, coordenadasCasillerosAmarillos.Count);
                jugadorAmarillo.Ficha2 = new Ficha(btnAmarillo2, posicionIndex, coordenadasCasillerosAmarillos.Count);
                jugadorAmarillo.Ficha3 = new Ficha(btnAmarillo3, posicionIndex, coordenadasCasillerosAmarillos.Count);
                jugadorAmarillo.Ficha4 = new Ficha(btnAmarillo4, posicionIndex, coordenadasCasillerosAmarillos.Count);

                jugadorAmarillo.fichaSeleccionada = jugadorAmarillo.Ficha1;

            }

            jugadorAzul = _jugadorAzul;
            if (jugadorAzul != null && jugadorAzul.Juega)
            {
                listaJugadores.Add(jugadorAzul);
                azulNombre.Text = jugadorAzul.Nombre;

                jugadorAzul.Ficha1 = new Ficha(btnAzul1, posicionIndex, coordenadasCasillerosAzules.Count);
                jugadorAzul.Ficha2 = new Ficha(btnAzul2, posicionIndex, coordenadasCasillerosAzules.Count);
                jugadorAzul.Ficha3 = new Ficha(btnAzul3, posicionIndex, coordenadasCasillerosAzules.Count);
                jugadorAzul.Ficha4 = new Ficha(btnAzul4, posicionIndex, coordenadasCasillerosAzules.Count);

                jugadorAzul.fichaSeleccionada = jugadorAzul.Ficha1;
            }

            IniciarDado();
        }

        private void FormLudo_Load(object sender, EventArgs e)
        {
            // Establecer el tamaño del formulario
            this.Size = new Size(1158, 561);
            IniciarTurno();

            // Establecemos que los botones arranquen en los casilleros
            btnVerde1.Location = new Point(162, 103);
            btnVerde2.Location = new Point(234, 137);
            btnVerde3.Location = new Point(305, 103);
            btnVerde4.Location = new Point(234, 67);

            btnAmarillo1.Location = new Point(162, 394);
            btnAmarillo2.Location = new Point(234, 431);
            btnAmarillo3.Location = new Point(305, 394);
            btnAmarillo4.Location = new Point(234, 362);

            btnAzul1.Location = new Point(806, 394);
            btnAzul2.Location = new Point(875, 431);
            btnAzul3.Location = new Point(950, 394);
            btnAzul4.Location = new Point(875, 362);

            btnRojo1.Location = new Point(806, 103);
            btnRojo2.Location = new Point(875, 137);
            btnRojo3.Location = new Point(950, 103);
            btnRojo4.Location = new Point(875, 67);
        }
        private void FormLudo_Closing(object sender, FormClosedEventArgs e)
        {
            // Cerrar la aplicación cuando se cierre el formulario FormLudo
            Application.Exit();
        }
        private void MoverFicha(Ficha ficha, int cantidadPosiciones, List<Point> coordenadas)
        {
            if (movimientoInicio)
            {
                // Mover el botón verde al primer casillero después de obtener un 6
                ficha.Button.Location = coordenadas[0];
                ficha.Posicion = 0;
                movimientoInicio = false;
            }
            else
            {
                int nuevoIndice = (ficha.Posicion + cantidadPosiciones) % coordenadas.Count;
                Point nuevaPosicion = coordenadas[nuevoIndice];

                // ---- CONTROLA QUE NO DE ERROR SI SALE NUMERO MAYOR A LA CANTIDAD DE CASILLEROS RESTANTES ----
                if (ficha.Posicion >= coordenadas.Count - 1)
                {
                    // Si ya está en la recta final, no se permite mover más allá de la última posición
                    return;
                }
                if (ficha.Restantes <= cantidadPosiciones)
                {
                    if (ficha.Posicion + ficha.Restantes == coordenadas.Count - 1)
                    {
                        // Si el número obtenido en el dado es exactamente el necesario para llegar a la última posición en la recta final
                        ficha.Button.Location = coordenadas[coordenadas.Count - 1];
                        ficha.Button.Enabled = false; // Desactivar el botón verde, ya no puede moverse
                        ficha.Restantes = 0; // Establecer la cantidad de casilleros restantes en cero

                        ComprobarGanador(ficha, coordenadas);
                        return;
                    }
                    else
                    {
                        // Si el número obtenido en el dado se pasa de la última posición en la recta final, no se realiza el movimiento
                        return;
                    }
                }
                // ---- HASTA ACA CONTROLA QUE NO DE ERROR SI SE PASA DE LOS CASILLEROS RESTANTES ------

                if (ficha.Restantes <= cantidadPosiciones)
                {
                    // El jugador se queda en el final
                    ficha.Button.Location = coordenadas[coordenadas.Count]; // - 1
                    ficha.Button.Enabled = false; // Desactivar el botón verde, ya no puede moverse
                    ficha.Restantes = 0; // Establecer la cantidad de casilleros restantes en cero
                    ComprobarGanador(ficha, coordenadas);
                    return;
                }

                ficha.Button.Location = nuevaPosicion;
                ficha.Posicion = nuevoIndice;

                ficha.Restantes -= cantidadPosiciones; // Actualizar la cantidad de casilleros restantes

                ComprobarGanador(ficha, coordenadas);
            }
        }

        private void IniciarDado()
        {
            dadoAleatorio = new Random();
            imagenesDado = new List<Image>()
            {
                Image.FromFile("ImagenesDados/Dado1.png"), // Propiedades copiar en directorio de salida: copiar siempre
                Image.FromFile("ImagenesDados/Dado2.png"),
                Image.FromFile("ImagenesDados/Dado3.png"),
                Image.FromFile("ImagenesDados/Dado4.png"),
                Image.FromFile("ImagenesDados/Dado5.png"),
                Image.FromFile("ImagenesDados/Dado6.png")
            };
        }

        private void IniciarTurno()
        {
            // Establecer el jugador actual al primer jugador (índice 0)
            jugadorActual = 0; 
            lblTurnos.Text = ($"Turno de {listaJugadores[jugadorActual].Nombre} - Color: {listaJugadores[jugadorActual].Color}");
        }

        private void CambiarTurno()
        {
            // Avanzar al siguiente jugador
            jugadorActual = (jugadorActual + 1) % listaJugadores.Count;

            jugador = listaJugadores[jugadorActual]; // Asignar el jugador actual

            lblTurnos.Text = ($"Turno de {listaJugadores[jugadorActual].Nombre} - Color: {listaJugadores[jugadorActual].Color}");

            if (!listaJugadores[jugadorActual].EsHumano)
            {
                Random random = new Random();
                int num = random.Next(1, 5);
                switch (num)
                {
                    case 1:
                        listaJugadores[jugadorActual].fichaSeleccionada = listaJugadores[jugadorActual].Ficha1;
                        break;
                    case 2:
                        listaJugadores[jugadorActual].fichaSeleccionada = listaJugadores[jugadorActual].Ficha2;
                        break;
                    case 3:
                        listaJugadores[jugadorActual].fichaSeleccionada = listaJugadores[jugadorActual].Ficha3;
                        break;
                    case 4:
                        listaJugadores[jugadorActual].fichaSeleccionada = listaJugadores[jugadorActual].Ficha4;
                        break;
                    default:
                        break;
                }
                AccionarDado();
            }
        }

        private async void Dado_Click(object sender, EventArgs e)
        {
            AccionarDado();
        }

        private async void AccionarDado()
        {
            if (!estaGirando)
            {
                estaGirando = true;

                int num = dadoAleatorio.Next(1, 7);

                await GirarDado();

                Dado.Image = imagenesDado[num - 1];
                estaGirando = false;

                if (listaJugadores[jugadorActual].EsHumano || !listaJugadores[jugadorActual].EsHumano)
                {
                    if (num == 6)
                    {
                        repetirTurno = true;
                    }
                    else
                    {
                        repetirTurno = false;
                    }
                }

                switch (listaJugadores[jugadorActual].Color)
                {
                    case "Verde":
                        if (jugadorVerde.fichaSeleccionada.Button.Location == new Point(162, 103)
                            || jugadorVerde.fichaSeleccionada.Button.Location == new Point(234, 137)
                            || jugadorVerde.fichaSeleccionada.Button.Location == new Point(305, 103)
                            || jugadorVerde.fichaSeleccionada.Button.Location == new Point(234, 67)
 )
                        {
                            if (num == 6)
                            {
                                jugadorVerde.fichaSeleccionada.Button.Location = coordenadasCasillerosVerdes[0];
                            }
                            else;
                        }
                        else
                        {
                            MoverFicha(jugadorVerde.fichaSeleccionada, num, coordenadasCasillerosVerdes);
                        }
                        break;

                    case "Rojo":
                        if (jugadorRojo.fichaSeleccionada.Button.Location == new Point(806, 103) ||
                            jugadorRojo.fichaSeleccionada.Button.Location == new Point(875, 137) ||
                            jugadorRojo.fichaSeleccionada.Button.Location == new Point(950, 103) ||
                            jugadorRojo.fichaSeleccionada.Button.Location == new Point(875, 67))
                        {
                            if (num == 6)
                            {
                                jugadorRojo.fichaSeleccionada.Button.Location = coordenadasCasillerosRojos[0];
                            }
                            else;
                        }
                        else
                        {
                            MoverFicha(jugadorRojo.fichaSeleccionada, num, coordenadasCasillerosRojos);
                        }
                        break;

                    case "Amarillo":
                        if (jugadorAmarillo.fichaSeleccionada.Button.Location == new Point(162, 394)
                            || jugadorAmarillo.fichaSeleccionada.Button.Location == new Point(234, 431)
                            || jugadorAmarillo.fichaSeleccionada.Button.Location == new Point(305, 394)
                            || jugadorAmarillo.fichaSeleccionada.Button.Location == new Point(234, 362))
                        {
                            if (num == 6)
                            {
                                jugadorAmarillo.fichaSeleccionada.Button.Location = coordenadasCasillerosAmarillos[0];
                            }
                            else;
                        }
                        else
                        {
                            MoverFicha(jugadorAmarillo.fichaSeleccionada, num, coordenadasCasillerosAmarillos);
                        }
                        break;

                    case "Azul":
                        if (jugadorAzul.fichaSeleccionada.Button.Location == new Point(806, 394)
                            || jugadorAzul.fichaSeleccionada.Button.Location == new Point(875, 431)
                            || jugadorAzul.fichaSeleccionada.Button.Location == new Point(950, 394)
                            || jugadorAzul.fichaSeleccionada.Button.Location == new Point(875, 362))
                        {
                            if (num == 6)
                            {
                                jugadorAzul.fichaSeleccionada.Button.Location = coordenadasCasillerosAzules[0];
                            }
                            else;
                        }
                        else
                        {
                            MoverFicha(jugadorAzul.fichaSeleccionada, num, coordenadasCasillerosAzules);
                        }
                        break;

                    default:
                        break;
                }

                if (repetirTurno)
                {
                    return;
                }
                else
                {
                    CambiarTurno();
                }
            }
        }

        private void ComprobarGanador(Ficha ficha, List<Point> coordenadas)
        {
            Point ultimaCoordenada = coordenadas[coordenadas.Count - 1];

            if (TodasFichasEnUltimaPosicion(ficha, ultimaCoordenada))
            {
                if (puesto == 1)
                {
                    MessageBox.Show($"¡{jugador.Nombre} ha llegado en primer lugar y es el ganador!");
                }
                else
                {
                    MessageBox.Show($"¡{jugador.Nombre} ha llegado en el puesto {puesto}!");
                }
                puesto++;
            }
        }

        private bool TodasFichasEnUltimaPosicion(Ficha ficha, Point ultimaCoordenada)
        {
            return ficha.Button.Location == ultimaCoordenada &&
                   jugador.Ficha1.Button.Location == ultimaCoordenada &&
                   jugador.Ficha2.Button.Location == ultimaCoordenada &&
                   jugador.Ficha3.Button.Location == ultimaCoordenada &&
                   jugador.Ficha4.Button.Location == ultimaCoordenada;
        }


        private async Task GirarDado()
        {
            int frames = 15; // Cantidad de frames para la animación
            int intervalo = 30; // Intervalo de tiempo en milisegundos entre cada frame
            float anguloPorFrame = 360f / frames;

            for (int i = 0; i < frames; i++)
            {
                Dado.Image = RotarImagenDado(Dado.Image, anguloPorFrame);
                await Task.Delay(intervalo);
            }
        }

        // Método para rotar una imagen
        private Image RotarImagenDado(Image img, float angle)
        {
            Bitmap rotarImagen = new Bitmap(img.Width, img.Height);
            rotarImagen.SetResolution(img.HorizontalResolution, img.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotarImagen))
            {
                g.TranslateTransform(img.Width / 2, img.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-img.Width / 2, -img.Height / 2);
                g.DrawImage(img, new Point(0, 0));
            }

            return rotarImagen;
        }

        private void btnVerde1_Click(object sender, EventArgs e)
        {
            jugadorVerde.fichaSeleccionada = jugadorVerde.Ficha1;
        }

        private void btnVerde2_Click(object sender, EventArgs e)
        {
            jugadorVerde.fichaSeleccionada = jugadorVerde.Ficha2;
        }

        private void btnVerde3_Click(object sender, EventArgs e)
        {
            jugadorVerde.fichaSeleccionada = jugadorVerde.Ficha3;
        }

        private void btnVerde4_Click(object sender, EventArgs e)
        {
            jugadorVerde.fichaSeleccionada = jugadorVerde.Ficha4;
        }

        private void btnRojo1_Click(object sender, EventArgs e)
        {
            jugadorRojo.fichaSeleccionada = jugadorRojo.Ficha1;
        }

        private void btnRojo2_Click(object sender, EventArgs e)
        {
            jugadorRojo.fichaSeleccionada = jugadorRojo.Ficha2;
        }

        private void btnRojo3_Click(object sender, EventArgs e)
        {
            jugadorRojo.fichaSeleccionada = jugadorRojo.Ficha3;
        }

        private void btnRojo4_Click(object sender, EventArgs e)
        {
            jugadorRojo.fichaSeleccionada = jugadorRojo.Ficha4;
        }

        private void btnAmarillo1_Click(object sender, EventArgs e)
        {
            jugadorAmarillo.fichaSeleccionada = jugadorAmarillo.Ficha1;
        }

        private void btnAmarillo2_Click(object sender, EventArgs e)
        {
            jugadorAmarillo.fichaSeleccionada = jugadorAmarillo.Ficha2;
        }

        private void btnAmarillo3_Click(object sender, EventArgs e)
        {
            jugadorAmarillo.fichaSeleccionada = jugadorAmarillo.Ficha3;
        }

        private void btnAmarillo4_Click(object sender, EventArgs e)
        {
            jugadorAmarillo.fichaSeleccionada = jugadorAmarillo.Ficha4;
        }

        private void btnAzul1_Click(object sender, EventArgs e)
        {
            jugadorAzul.fichaSeleccionada = jugadorAzul.Ficha1;
        }

        private void btnAzul2_Click(object sender, EventArgs e)
        {
            jugadorAzul.fichaSeleccionada = jugadorAzul.Ficha2;
        }

        private void btnAzul3_Click(object sender, EventArgs e)
        {
            jugadorAzul.fichaSeleccionada = jugadorAzul.Ficha3;
        }

        private void btnAzul4_Click(object sender, EventArgs e)
        {
            jugadorAzul.fichaSeleccionada = jugadorAzul.Ficha4;
        }
    }
}