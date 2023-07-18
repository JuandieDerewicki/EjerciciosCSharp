using System.Windows.Forms;

namespace EjercicioPracticaRecuperatorioAdinvinarNro
{
    public partial class Form1 : Form
    {
        private string nombreJ;
        private int intentos = 3;
        Random nroRandom = new Random();
        int numeroAdivinar;
        Random imgRandom;
        List<Image> listaImagenes;
        public Form1(string jugador)
        {
            nombreJ = jugador;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text = "¡Bienvenido " + nombreJ + "!";
            lblIntentos.Text = "Intentos: " + intentos;
            listBox1.Items.Add("Numeros ingresados:");
            generarNroRandom();
            generarImagenRandom();
        }

        private void generarNroRandom()
        {
            numeroAdivinar = nroRandom.Next(1, 11);
        }

        private void generarImagenRandom()
        {
            imgRandom = new Random();
            listaImagenes = new List<Image>()
            {
                Image.FromFile("imagenesEjercicio/fotoArg1.jpg"),
                Image.FromFile("imagenesEjercicio/fotoArg2.jpg"),
                Image.FromFile("imagenesEjercicio/fotoArg3.jpg"),
                Image.FromFile("imagenesEjercicio/fotoArg4.jpg")
            };
        }

        private void btnEnviarNumero_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxNumero.Text, out int numeroIngresado))
            {
                if (numeroAdivinar > numeroIngresado)
                {
                    listBox1.Items.Add("-" + numeroIngresado + ". El numero debe ser mayor");
                }
                else if (numeroAdivinar < numeroIngresado)
                {
                    listBox1.Items.Add("-" + numeroIngresado + ". El numero debe ser menor");
                }
                else if (numeroAdivinar == numeroIngresado)
                {
                    int num = imgRandom.Next(1, 5);
                    Image imagenSeleccionada = listaImagenes[num - 1];
                    pictureBox1.Image = imagenSeleccionada;
                    if (MessageBox.Show("¡Ha ganado! Presione aceptar para pasar a jugar el nivel 2", "GANADOR", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Nivel2 nivel2 = new Nivel2(nombreJ);
                        nivel2.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                intentos--;
                lblIntentos.Text = "Intentos: " + intentos;
            }

            if (intentos == 0)
            {
                MessageBox.Show("No quedan más intentos. ¡Usted ha perdido!");
                this.Close();
            }
        }
    }
}
