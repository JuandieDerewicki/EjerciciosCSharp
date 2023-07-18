using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPracticoRecuperatorioBingo
{
    public partial class MenuNombre : Form
    {
        public MenuNombre()
        {
            InitializeComponent();
        }
        
        private void AbrirFormularioPrincipal()
        {
            string nombreJugador = txtBoxNombre.Text;
            Form1 formularioPrincipal = new Form1(nombreJugador);
            formularioPrincipal.Show();
            this.Hide();
        }

        private void btnEnviarNombre_Click(object sender, EventArgs e)
        {
            AbrirFormularioPrincipal();
        }
    }
}
