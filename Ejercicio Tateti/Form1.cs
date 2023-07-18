namespace TatetiProbar
{
    public partial class Form1 : Form
    {

        List<Button> listaBotones = new List<Button>();
        int turno = 0;
        bool ganador = false;
        int conteo = 0;
        bool reiniciar = false;
        string jugador1;
        string jugador2;
        public Form1(string nombreJugador1, string nombreJugador2)
        {
            InitializeComponent();
            jugador1 = nombreJugador1;
            jugador2 = nombreJugador2;  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizarLabelTurno();
            crearBotones();
            startAndStop();
        }

        void crearBotones()
        {
            listaBotones.Add(btn1);
            listaBotones.Add(btn2);
            listaBotones.Add(btn3);
            listaBotones.Add(btn4);
            listaBotones.Add(btn5);
            listaBotones.Add(btn6);
            listaBotones.Add(btn7);
            listaBotones.Add(btn8);
            listaBotones.Add(btn9);
        }

        void onClickBoton(object sender, EventArgs eventArgs)
        {

            Button boton = (Button)sender;
            if (string.IsNullOrEmpty(boton.Text) && !ganador)
            {
                if (turno == 0)
                {
                    boton.Text = "X";
                }
                else
                {
                    boton.Text = "O";
                }
                chequearGanador();
                if (turno == 0)
                {
                    turno = 1;
                }
                else
                {
                    turno = 0;
                }
                actualizarLabelTurno();
            }
        }

        void actualizarLabelTurno()
        {
            if (turno == 0)
            {
                turnos.Text = "Turno: Jugador " + jugador1;
            }
            else if(turno == 1)
            {
                turnos.Text = "Turno: Jugador " + jugador2;
            }
            //turnos.Text = "Turno: Jugador " + (turno + 1);
        }


        void chequearGanador()
        {
            if ((!string.IsNullOrEmpty(btn1.Text) && btn1.Text == btn2.Text && btn2.Text == btn3.Text) ||
                (!string.IsNullOrEmpty(btn4.Text) && btn4.Text == btn5.Text && btn5.Text == btn6.Text) ||
                (!string.IsNullOrEmpty(btn7.Text) && btn7.Text == btn8.Text && btn8.Text == btn9.Text) ||
                (!string.IsNullOrEmpty(btn1.Text) && btn1.Text == btn4.Text && btn4.Text == btn7.Text) ||
                (!string.IsNullOrEmpty(btn2.Text) && btn2.Text == btn5.Text && btn5.Text == btn8.Text) ||
                (!string.IsNullOrEmpty(btn3.Text) && btn3.Text == btn6.Text && btn6.Text == btn9.Text) ||
                (!string.IsNullOrEmpty(btn1.Text) && btn1.Text == btn5.Text && btn5.Text == btn9.Text) ||
                (!string.IsNullOrEmpty(btn3.Text) && btn3.Text == btn5.Text && btn5.Text == btn7.Text))
            {
                ganador = true;
                if (MessageBox.Show($"Ganó el jugador {jugadores()}. Duración de partida: {conteo} ¿Desea jugar de nuevo?", "Ganador", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    reiniciarJuego();
                }
                else
                {
                    this.Close();
                }
            }
        }

        string jugadores()
        {
            if (turno == 0)
            {
                return jugador1;
            }
            else
            {
                return jugador2;
            }
            //if (turno == 0)
            //{
            //    return txtJugador1.Text;
            //}
            //else
            //{
            //    return txtJugador2.Text;
            //}
        }

        private void reiniciarJuego()
        {
            ganador = false;
            turno = 1;

            for (int i = 0; i < listaBotones.Count; i++)
            {
                listaBotones[i].Text = "";
            }
            actualizarLabelTurno();

        }

        private void reiniciarPartidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reiniciar = true;
            ganador = false;
            turno = 0;

            for (int i = 0; i < listaBotones.Count; i++)
            {
                listaBotones[i].Text = "";
            }
            actualizarLabelTurno();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            conteo++;
            lblTiempoYGanador.Text = conteo.ToString();
            if (ganador == true)
            {
                conteo = 0;
                lblTiempoYGanador.Text = "0";
            }
            if (reiniciar == true)
            {
                conteo = 0;
                lblTiempoYGanador.Text = "0";
            }
        }

        void startAndStop()
        {
            if (ganador == false || reiniciar == false)
            {
                duracionJuego.Start();
            }
        }
    }
}
