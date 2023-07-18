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
    public partial class MenuPrincipalcs : Form
    {
        public MenuPrincipalcs()
        {
            InitializeComponent();
        }

        private void AbrirNivel1()
        {
            string nombreJugador = textBoxNombreJugador.Text;
            Form1 nivel1 = new Form1(nombreJugador);
            nivel1.Show();
            this.Hide();
        }
        private void btnIniciarJuego_Click(object sender, EventArgs e)
        {
            AbrirNivel1();
        }
    }
}
