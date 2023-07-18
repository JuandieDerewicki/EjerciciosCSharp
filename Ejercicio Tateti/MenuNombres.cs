using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TatetiProbar
{
    public partial class MenuNombres : Form
    {
        public MenuNombres()
        {
            InitializeComponent();
        }

        private void AbrirFormularioPrincipal()
        {
            string jugador1 = textBox1.Text;
            string jugador2 = textBox2.Text;
            Form1 formulario = new Form1(jugador1, jugador2);
            formulario.Show();
            this.Hide();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            AbrirFormularioPrincipal();
        }
    }
}
