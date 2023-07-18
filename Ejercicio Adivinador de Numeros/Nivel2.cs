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
    public partial class Nivel2 : Form
    {
        public Nivel2()
        {
            InitializeComponent();
        }

        private string nombreJ;
        private int intentos = 5;
        Random nroRandom = new Random();
        int numeroAdivinar;
        Random imgRandom;
        List<Image> listaImagenes;
        public Nivel2(string jugador)
        {
            nombreJ = jugador;
            InitializeComponent();
        }

        private void Nivel2_Load(object sender, EventArgs e)
        {
            lblBienvenida2.Text = "¡Bienvenido al nivel 2 " + nombreJ + "!";
            lblIntentos2.Text = "Intentos: " + intentos;
            listBox2.Items.Add("Numeros ingresados:");
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

        private void btnEnviarNumero2_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxNumero2.Text, out int numeroIngresado))
            {
                if (numeroAdivinar > numeroIngresado)
                {
                    listBox2.Items.Add("-" + numeroIngresado + ". El numero debe ser mayor");
                }
                else if (numeroAdivinar < numeroIngresado)
                {
                    listBox2.Items.Add("-" + numeroIngresado + ". El numero debe ser menor");
                }
                else if (numeroAdivinar == numeroIngresado)
                {
                    int num = imgRandom.Next(1, 5);
                    Image imagenSeleccionada = listaImagenes[num - 1];
                    pictureBox2.Image = imagenSeleccionada;
                    if (MessageBox.Show("¡Ha ganado! Presione aceptar para pasar a jugar el ultimo nivel. ", "GANADOR", MessageBoxButtons.OK) == DialogResult.OK)
                    {
                        Nivel3 nivel3 = new Nivel3(nombreJ);
                        nivel3.Show();
                        this.Hide();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                intentos--;
                lblIntentos2.Text = "Intentos: " + intentos;

                if (intentos == 0)
                {
                    MessageBox.Show("No quedan más intentos. ¡Usted ha perdido!");
                    this.Close();
                }
            }
        }

    }
}
