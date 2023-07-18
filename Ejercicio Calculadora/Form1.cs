namespace EjercicioCalculadora2
{
    public partial class Form1 : Form
    {

        double numero1 = 0;
        double numero2 = 0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender); // Estamos casteando a la variable boton para que tenga las propiedades de boton y no de VAR

            if (txtResultados.Text == "0")
                txtResultados.Text = "";

            txtResultados.Text += boton.Text;
        }

        private void ClickOperador(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            numero1 = Convert.ToDouble(txtResultados.Text);
            operador = Convert.ToChar(boton.Text);

            txtResultados.Text = "0";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtResultados.Text);

            if (operador == '+')
            {
                txtResultados.Text = (numero1 + numero2).ToString();
                listHistorial.Items.Add($"{numero1} + {numero2} = " + txtResultados.Text);
            }
            if (operador == '_')
            {
                txtResultados.Text = (numero1 - numero2).ToString();
                listHistorial.Items.Add($"{numero1} - {numero2} = " + txtResultados.Text);
            }
            if (operador == '/')
            {
                txtResultados.Text = (numero1 / numero2).ToString();
                listHistorial.Items.Add($"{numero1} / {numero2} = " + txtResultados.Text);
            }
            if (operador == 'X')
            {
                txtResultados.Text = (numero1 * numero2).ToString();
                listHistorial.Items.Add($"{numero1} x {numero2} = " + txtResultados.Text);
            }


        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txtResultados.Text.Length > 1)
            {
                txtResultados.Text = txtResultados.Text.Substring(0, txtResultados.Text.Length - 1);
            }
            else
            {
                txtResultados.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operador = '\0';
            txtResultados.Text = "0";
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            if (!txtResultados.Text.Contains(","))
            {
                txtResultados.Text += ",";
            }
        }

        private void btnPosNeg_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txtResultados.Text);
            numero1 *= -1;
            txtResultados.Text = numero1.ToString();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            DateTime fechaInicio = dtpFechaInicio.Value;
            DateTime fechaFin = dtpFechaFinal.Value;

            TimeSpan diferencia = fechaFin.Subtract(fechaInicio);

            // Ejemplo: Obtener la diferencia en días
            int diferenciaEnDias = diferencia.Days;

            //lblResultadoFechas.Text = diferenciaEnDias.ToString();
            MessageBox.Show("La diferencia en días es: " + diferenciaEnDias);
        }
    }


    /*

     private double valor1;
        private double valor2;

        private double resultado;
        private int operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button_0_Click(object sender, EventArgs e)
        {
            // numero 0
            textBox_Resultado.Text = textBox_Resultado.Text + "0";
        }


        private void button_1_Click(object sender, EventArgs e)
        {
            // numero 1
            textBox_Resultado.Text = textBox_Resultado.Text + "1";

        }


        private void button_2_Click(object sender, EventArgs e)
        {
            // numero 2
            textBox_Resultado.Text = textBox_Resultado.Text + "2";
        }


        private void button_3_Click(object sender, EventArgs e)
        {
            // numero 3
            textBox_Resultado.Text = textBox_Resultado.Text + "3";

        }


        private void button_4_Click(object sender, EventArgs e)
        {
            // numero 4
            textBox_Resultado.Text = textBox_Resultado.Text + "4";

        }


        private void button11_Click(object sender, EventArgs e)
        {
            // numero 5
            textBox_Resultado.Text = textBox_Resultado.Text + "5";

        }


        private void button_6_Click(object sender, EventArgs e)
        {
            // numero 6
            textBox_Resultado.Text = textBox_Resultado.Text + "6";

        }

        private void button_7_Click(object sender, EventArgs e)
        {
            // numero 7
            textBox_Resultado.Text = textBox_Resultado.Text + "7";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // numero 8
            textBox_Resultado.Text = textBox_Resultado.Text + "8";

        }

        private void button_9_Click(object sender, EventArgs e)
        {
            // numero 9
            textBox_Resultado.Text = textBox_Resultado.Text + "9";

        }

        // ----------- OPERACIONES -------------
        private void button_suma_Click(object sender, EventArgs e)
        {
            // boton suma
            operacion = 1;

            valor1 = double.Parse(textBox_Resultado.Text);
            textBox_Resultado.Text = "";

        }

        private void button_resta_Click(object sender, EventArgs e)
        {
            operacion = 2;
            // boton resta
            valor1 = double.Parse(textBox_Resultado.Text);
            textBox_Resultado.Text = "";

        }


        private void button9_Click(object sender, EventArgs e)
        {
            operacion = 3;
            // boton multiplicacion 

            valor1 = double.Parse(textBox_Resultado.Text);
            textBox_Resultado.Text = "";

        }


        private void button_division_Click(object sender, EventArgs e)
        {
            operacion = 4;
            // boton division
            valor1 = double.Parse(textBox_Resultado.Text);
            textBox_Resultado.Text = "";

        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            // boton igual

            valor2 = double.Parse(textBox_Resultado.Text);



            switch (operacion)
            {
                case 1:
                    resultado = valor1 + valor2;
                    break;
                case 2:
                    resultado = valor1 - valor2;
                    break;
                case 3:
                    resultado = valor1 * valor2;
                    break;
                case 4:
                    resultado = valor1 / valor2;
                    break;
            }




            textBox_Resultado.Text = resultado.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // boton borrar
            textBox_Resultado.Text = "";

        }

        private void button_punto_Click(object sender, EventArgs e)
        {
            textBox_Resultado.Text = textBox_Resultado.Text + ".";
        }

    */
}
