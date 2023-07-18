using System.Xml.Serialization;

namespace EjercicioPracticoRecuperatorioBingo
{
    public partial class Form1 : Form
    {
        private List<Button> listaBotones = new List<Button>();
        Random nroRandom = new Random();
        int numeroBoton;
        int numero;
        string nombre;
        public Form1(string nombreJugador)
        {
            InitializeComponent();
            nombre = nombreJugador;
            lblBienvenidaJugador.Text = "Jugador: " + nombre;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            agregarBotones();
            generarCarton();
            listBox1.Items.Add("Numeros salidos:");
        }
        private void agregarBotones()
        {
            listaBotones.Add(button1);
            listaBotones.Add(button2);
            listaBotones.Add(button3);
            listaBotones.Add(button4);
            listaBotones.Add(button5);
            listaBotones.Add(button6);
            listaBotones.Add(button7);
            listaBotones.Add(button8);
            listaBotones.Add(button9);
            listaBotones.Add(button10);
            listaBotones.Add(button11);
            listaBotones.Add(button12);
            listaBotones.Add(button13);
            listaBotones.Add(button14);
            listaBotones.Add(button15);
            listaBotones.Add(button16);
        }

        private void generarCarton() // Hacer que no acepte numeros repetidos y se ordenen de forma creciente
        {
            //for (int i = 0; i < listaBotones.Count; i++)
            //{
            //    numeroBoton = nroRandom.Next(1, 75);
            //    listaBotones[i].Text = numeroBoton.ToString();
            //}
            List<int> numerosAleatorios = new List<int>();

            // Generar números aleatorios en el rango 1-75 sin repeticiones
            while (numerosAleatorios.Count < listaBotones.Count)
            {
                int numero = nroRandom.Next(1, 76);
                if (!numerosAleatorios.Contains(numero))
                {
                    numerosAleatorios.Add(numero);
                }
            }

            // Ordenar los números de forma creciente
            numerosAleatorios.Sort();

            // Asignar los números a los botones
            for (int i = 0; i < listaBotones.Count; i++)
            {
                listaBotones[i].Text = numerosAleatorios[i].ToString();
            }
        }

        //private void btnNumeroAleatorio_Click(object sender, EventArgs e)
        //{
        //    numero = nroRandom.Next(1, 76);
        //    listBox1.Items.Add(numero);
        //}
        List<int> numerosGenerados = new List<int>(); // Declararla afuera
        private void btnNumeroAleatorio_Click(object sender, EventArgs e)
        {
            int numero = nroRandom.Next(1, 76); // Generar un número aleatorio

            while (numerosGenerados.Contains(numero)) // Verificar si el número ya fue generado
            {
                numero = nroRandom.Next(1, 76); // Generar otro número aleatorio
            }


            numerosGenerados.Add(numero); // Agregar el número a la lista de números generados
            listBox1.Items.Add(numero); // Agregar el número al ListBox
        }


        private void colorearBotones(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Red;
            chequearGanador();
        }

        private void chequearGanador()
        {
            if (button1.BackColor == Color.Red && button2.BackColor == Color.Red && button3.BackColor == Color.Red && button4.BackColor == Color.Red || // 4 primeras horizontales
                button5.BackColor == Color.Red && button6.BackColor == Color.Red && button7.BackColor == Color.Red && button8.BackColor == Color.Red ||
                button9.BackColor == Color.Red && button10.BackColor == Color.Red && button11.BackColor == Color.Red && button12.BackColor == Color.Red ||
                button13.BackColor == Color.Red && button14.BackColor == Color.Red && button15.BackColor == Color.Red && button16.BackColor == Color.Red ||
                button1.BackColor == Color.Red && button5.BackColor == Color.Red && button9.BackColor == Color.Red && button13.BackColor == Color.Red || // 4 segundas verticales
                button2.BackColor == Color.Red && button6.BackColor == Color.Red && button10.BackColor == Color.Red && button14.BackColor == Color.Red ||
                button3.BackColor == Color.Red && button7.BackColor == Color.Red && button11.BackColor == Color.Red && button15.BackColor == Color.Red ||
                button4.BackColor == Color.Red && button8.BackColor == Color.Red && button12.BackColor == Color.Red && button16.BackColor == Color.Red ||
                button1.BackColor == Color.Red && button6.BackColor == Color.Red && button11.BackColor == Color.Red && button16.BackColor == Color.Red || // 2 restantes diagonales
                button4.BackColor == Color.Red && button7.BackColor == Color.Red && button10.BackColor == Color.Red && button13.BackColor == Color.Red)
            {
                if (MessageBox.Show($"Ganó el jugador {nombre}. ¿Desea jugar de nuevo?", "Ganador", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    reiniciarJuego();
                }
                else
                {
                    this.Close();
                }
            }
        }

        private void reiniciarJuego()
        {
            listBox1.Items.Clear();
            generarCarton();
            foreach (Button boton in listaBotones)
            {
                boton.BackColor = Color.White;
            }
        }
    }
}