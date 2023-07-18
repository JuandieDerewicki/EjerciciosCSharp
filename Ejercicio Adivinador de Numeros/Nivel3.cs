using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPracticaRecuperatorioAdinvinarNro
{
    public partial class Nivel3 : Form
    {
        private string nombreJ;
        private int intentos = 10;
        Random nroRandom = new Random();
        int numeroAdivinar;
        Random imgRandom;
        List<Image> listaImagenes;

        public Nivel3(string jugador)
        {
            InitializeComponent();
            nombreJ = jugador;
        }

        private void Nivel3_Load_1(object sender, EventArgs e)
        {
            lblBienvenida3.Text = "¡Bienvenido al nivel 3 " + nombreJ + "!";
            lblIntentos3.Text = "Intentos: " + intentos;
            listBox3.Items.Add("Numeros ingresados:");
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

        private void btnEnviarNumero3_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxNumero3.Text, out int numeroIngresado))
            {
                if (numeroAdivinar > numeroIngresado)
                {
                    listBox3.Items.Add("-" + numeroIngresado + ". El numero debe ser mayor");
                }
                else if (numeroAdivinar < numeroIngresado)
                {
                    listBox3.Items.Add("-" + numeroIngresado + ". El numero debe ser menor");
                }
                else if (numeroAdivinar == numeroIngresado)
                {
                    int num = imgRandom.Next(1, 5);
                    Image imagenSeleccionada = listaImagenes[num - 1];
                    pictureBox3.Image = imagenSeleccionada;
                    if (MessageBox.Show("¡Felicitaciones es el ganador del juego! Ha completado con exitos los tres niveles.", "GANADOR", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
                intentos--;
                lblIntentos3.Text = "Intentos: " + intentos;

                if (intentos == 0)
                {
                    MessageBox.Show("No quedan más intentos. ¡Usted ha perdido!");
                    this.Close();
                }
            }
        }
    }
}
