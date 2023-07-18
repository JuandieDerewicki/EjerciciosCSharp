namespace EjercicioJuegoSimon2
{
    public partial class Form1 : Form
    {
        // Declaracion de la lista y el index de ella
        private List<Color> secuencia;
        private int secuenciaIndex;
        public Form1()
        {
            // Inicializacion cuando se compila de la lista y el index
            InitializeComponent();
            secuencia = new List<Color>();
            secuenciaIndex = 1;
        }

        // MainForm_Load: Este m�todo se ejecuta cuando se carga el
        // formulario principal. Aqu� se configuran los colores iniciales de los botones.
        private void Form1_Load(object sender, EventArgs e)
        {
            //Configurar botones con colores iniciales
            botonRojo.BackColor = Color.Red;
            botonAzul.BackColor = Color.Blue;
            botonVerde.BackColor = Color.Green;
            botonMarron.BackColor = Color.Brown;
        }

        // btnStart_Click: Este m�todo se ejecuta cuando se hace clic en el bot�n "Start".
        // Inicia el juego reiniciando la secuencia y mostrando la primera secuencia generada.
        private void botonComenzar_Click(object sender, EventArgs e)
        {
            // Iniciar juego
            secuencia.Clear();
            secuenciaIndex = 1;
            AgregarColorSecuencia();
            MostrarSecuencia();
        }


        // AddColorToSequence: Este m�todo genera un n�mero aleatorio entre 1 y 4 para seleccionar
        // un color al azar (rojo, verde, azul o amarillo) y lo agrega a la secuencia.
        private void AgregarColorSecuencia()
        {
            Random random = new Random();
            int colorIndex = random.Next(1, 5);

            switch (colorIndex)
            {
                case 1:
                    secuencia.Add(Color.Red);
                    break;
                case 2:
                    secuencia.Add(Color.Blue);
                    break;
                case 3:
                    secuencia.Add(Color.Green);
                    break;
                case 4:
                    secuencia.Add(Color.Brown);
                    break;
            }
        }

        // ShowSequence: Este m�todo muestra visualmente
        // la secuencia generada al resaltar cada color uno por uno. Utiliza un bucle foreach para
        // iterar sobre la lista de colores en la secuencia y llama al m�todo HighlightColor para
        // resaltar cada color.
        private void MostrarSecuencia()
        {
            foreach (Color color in secuencia)
            {
                ResaltarColor(color);
                System.Threading.Thread.Sleep(1000); // Tiempo de espera entre colores
                //ResetearColor();
                System.Threading.Thread.Sleep(500); // Tiempo de espera entre colores
            }
        }

        //  HighlightColor: Este m�todo resalta visualmente un color en la secuencia. Recibe un color
        //  como par�metro y busca el bot�n correspondiente llamando al m�todo GetButtonByColor.
        //  Temporalmente cambia el color de fondo del bot�n a blanco para resaltarlo y luego espera
        //  un tiempo antes de restaurar el color original del bot�n.

        private void ResaltarColor(Color color)
        {
            Button boton = ObtenerBotonPorColor(color);
            if (boton != null)
            {
                boton.BackColor = Color.White;
                Refresh();
                System.Threading.Thread.Sleep(500); // Medio segundo que se resalta el color
                boton.BackColor = color;
                Refresh();
            }
        }

        // GetButtonByColor: Este m�todo recibe un color como par�metro y devuelve el bot�n
        // correspondiente. Se utiliza para obtener el bot�n correcto seg�n el color en el m�todo
        // HighlightColor y ResetColor.

        private Button ObtenerBotonPorColor(Color color)
        {
            if (color == Color.Red)
            {
                return botonRojo;
            }
            else if (color == Color.Blue)
            {
                return botonAzul;
            }
            else if (color == Color.Green)
            {
                return botonVerde;
            }
            else if (color == Color.Brown)
            {
                return botonMarron;
            }
            return null;
        }

        // ResetColor: Este m�todo restablece los colores de fondo de los botones a sus valores
        // originales (rojo, verde, azul y amarillo) llamando al m�todo GetButtonByColor.
        private void ResetearColor()
        {
            // Restablecer los colores de los botones 
            botonRojo.BackColor = Color.Red;
            botonAzul.BackColor = Color.Blue;
            botonVerde.BackColor = Color.Green;
            botonMarron.BackColor = Color.Brown;
            Refresh();
        }


        // btnColor_Click: Este m�todo se ejecuta cuando se hace clic en uno de los botones de
        // colores. Compara el color seleccionado por el jugador con el color esperado en la secuencia
        // en la posici�n actual (sequenceIndex). Si los colores coinciden, se avanza a la siguiente
        // posici�n en la secuencia. Si se llega al final de la secuencia, se muestra un mensaje de
        // felicitaci�n y se genera una nueva secuencia. Si los colores no coinciden, se muestra un
        // mensaje de error y se reinicia la secuencia. 
        private void btnColor_Click(object sender, EventArgs e)
        {
            // El jugador hizo clic en un color
            Button button = (Button)sender;
            Color selectedColor = button.BackColor;
            Color expectedColor = secuencia[secuenciaIndex];

            if (selectedColor == expectedColor)
            {
                secuenciaIndex++;

                if (secuenciaIndex >= secuencia.Count)
                {
                    // El jugador replic� correctamente la secuencia
                    MessageBox.Show($"�Felicidades! Has replicado la secuencia correctamente y has completado el nivel {secuenciaIndex}.");
                    secuenciaIndex = 0;
                    AgregarColorSecuencia();
                    MostrarSecuencia();
                }
            }
            else
            {
                // El jugador cometi� un error
                MessageBox.Show($"Lo siento, has cometido un error. Has llegado hasta el nivel {secuenciaIndex} �Int�ntalo de nuevo!");
                secuencia.Clear();
                secuenciaIndex = 0;
            }
        }
    }
}