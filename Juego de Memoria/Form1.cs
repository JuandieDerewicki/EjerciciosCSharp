using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JuegoMemoria
{
    public partial class Form1 : Form
    {
        private const int TotalPares = 10;
        private const int TotalMovimientos = 10;

        private List<string> palabras;
        private List<Button> botones;
        private List<string> palabrasApareadas;
        private int movimientosRestantes;

        private Label lblConteoMovimientos;
        private ListBox listBoxPalabrasApareadas;

        private Button primerBotonSeleccionado;
        private Button segundoBotonSeleccionado;

        private Random random;
        private System.Windows.Forms.Timer ocultarTimer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Cargar palabras desde el archivo de texto
            palabras = CargarPalabrasDesdeArchivo(@"C:\Users\bocaj\OneDrive\Documentos\Facultad\PalabrasMemorama.txt");

            // Obtener todos los botones del TableLayoutPanel
            botones = tableLayoutPanelJuego.Controls.OfType<Button>().ToList();

            // Configurar eventos de clic para los botones
            //foreach (Button boton in botones)
            //{
            //    boton.Click += Boton_Click;
            //}

            // Inicializar variables y controles
            random = new Random();
            movimientosRestantes = TotalMovimientos;
            palabrasApareadas = new List<string>();

            ActualizarConteoMovimientos();

            // Generar nombres aleatorios para los botones al inicio del juego
            GenerarNombresAleatorios();
        }

        private List<string> CargarPalabrasDesdeArchivo(string rutaArchivo)
        {
            List<string> palabras = new List<string>();

            try
            {
                using (StreamReader sr = new StreamReader(rutaArchivo))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        palabras.Add(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las palabras desde el archivo: " + ex.Message);
            }

            return palabras;
        }

        private void GenerarNombresAleatorios()
        {
            List<string> nombresAleatorios = ObtenerNombresAleatorios();
            int indice = 0;

            foreach (Button boton in botones)
            {
                boton.Name = "button" + nombresAleatorios[indice];
                indice++;
            }
        }

        private List<string> ObtenerNombresAleatorios()
        {
            List<string> nombresAleatorios = new List<string>();

            for (int i = 1; i <= TotalPares; i++)
            {
                nombresAleatorios.Add(i.ToString());
                nombresAleatorios.Add(i.ToString());
            }

            for (int i = TotalPares * 2; i > 1; i--)
            {
                int j = random.Next(i);
                string temp = nombresAleatorios[j];
                nombresAleatorios[j] = nombresAleatorios[i - 1];
                nombresAleatorios[i - 1] = temp;
            }

            return nombresAleatorios;
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;

            if (boton.Text != "")
            {
                // Si el botón ya ha sido seleccionado, no se hace nada
                return;
            }

            string nombreBoton = boton.Name;
            string palabra = ObtenerPalabraPorNombreBoton(nombreBoton);
            boton.Text = palabra;

            if (primerBotonSeleccionado == null)
            {
                primerBotonSeleccionado = boton;
            }
            else
            {
                segundoBotonSeleccionado = boton;

                // Comparar las palabras de los botones seleccionados
                if (ObtenerPalabraPorNombreBoton(primerBotonSeleccionado.Name) == ObtenerPalabraPorNombreBoton(segundoBotonSeleccionado.Name))
                {
                    palabrasApareadas.Add(ObtenerPalabraPorNombreBoton(primerBotonSeleccionado.Name));
                    primerBotonSeleccionado = null;
                    segundoBotonSeleccionado = null;
                    ActualizarListBoxPalabrasApareadas();

                    if (palabrasApareadas.Count == TotalPares)
                    {
                        MessageBox.Show("¡Has encontrado todos los pares! ¡Has ganado el juego!");
                        ReiniciarJuego();
                    }
                }
                else
                {
                    // Si las palabras no coinciden, ocultar los botones después de un breve retraso
                    ocultarTimer = new System.Windows.Forms.Timer();
                    ocultarTimer.Interval = 1000;
                    ocultarTimer.Tick += Timer_Tick;
                    ocultarTimer.Start();
                }

                movimientosRestantes--;
                ActualizarConteoMovimientos();

                if (movimientosRestantes == 0)
                {
                    MessageBox.Show("Se te han terminado los movimientos. ¡Has perdido el juego!");
                    ReiniciarJuego();
                }
            }
        }

        private string ObtenerPalabraPorNombreBoton(string nombreBoton)
        {
            int indice = Convert.ToInt32(nombreBoton.Replace("button", "")) - 1;
            return palabras[indice];
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ocultarTimer.Stop();

            primerBotonSeleccionado.Text = "";
            segundoBotonSeleccionado.Text = "";

            primerBotonSeleccionado = null;
            segundoBotonSeleccionado = null;
        }

        private void ActualizarListBoxPalabrasApareadas()
        {
            listBoxPalabrasApareadas.Items.Clear();

            for (int i = 0; i < palabrasApareadas.Count; i++)
            {
                listBoxPalabrasApareadas.Items.Add((i + 1) + "- " + palabrasApareadas[i]);
            }
        }

        private void ActualizarConteoMovimientos()
        {
            lblConteoMovimientos.Text = movimientosRestantes.ToString();
        }

        private void ReiniciarJuego()
        {
            foreach (Button boton in botones)
            {
                boton.Text = "";
            }

            palabrasApareadas.Clear();
            movimientosRestantes = TotalMovimientos;

            ActualizarListBoxPalabrasApareadas();
            ActualizarConteoMovimientos();

            // Generar nuevos nombres aleatorios para los botones
            GenerarNombresAleatorios();
        }
    }
}
