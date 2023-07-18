using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabajoFinalPruebas.Clases;

namespace TrabajoFinalPruebas
{
    public partial class FormSeleccionColor : Form
    {
        Jugador jugadorVerde = new Jugador("Verde");
        Jugador jugadorRojo = new Jugador("Rojo");
        Jugador jugadorAmarillo = new Jugador("Amarillo");
        Jugador jugadorAzul = new Jugador("Azul");

        public FormSeleccionColor()
        {
            InitializeComponent();
        }

        private void playLudo_Click(object sender, EventArgs e)
        {
            // JUGADOR VERDE
            jugadorVerde.Juega = !verdeRadio1.Checked;
            jugadorVerde.EsHumano = verdeRadio2.Checked;
            jugadorVerde.Nombre = verdeText1.Text;

            // JUGADOR ROJO
            jugadorRojo.Juega = !rojoRadio1.Checked;
            jugadorRojo.EsHumano = rojoRadio2.Checked;
            jugadorRojo.Nombre = rojoText1.Text;

            // JUGADOR AMARILLO
            jugadorAmarillo.Juega = !amarilloRadio1.Checked;
            jugadorAmarillo.EsHumano = amarilloRadio2.Checked;
            jugadorAmarillo.Nombre = amarilloText1.Text;

            // JUGADOR AZUL
            jugadorAzul.Juega = !azulRadio1.Checked;
            jugadorAzul.EsHumano = azulRadio2.Checked;
            jugadorAzul.Nombre = azulText1.Text;

            AbrirFormLudo();
        }

        private void AbrirFormLudo()
        {
            FormLudo FormLudo = new FormLudo(jugadorVerde, jugadorRojo, jugadorAmarillo, jugadorAzul);
            FormLudo.Show();
            this.Hide();
        }
    }
}
