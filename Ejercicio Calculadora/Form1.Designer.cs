namespace EjercicioCalculadora2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            btn7 = new Button();
            btnBorrarTodo = new Button();
            btn8 = new Button();
            btnBorrar = new Button();
            btn9 = new Button();
            btnComa = new Button();
            btnDivision = new Button();
            btnMultiplicacion = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnResta = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnSuma = new Button();
            btnPosNeg = new Button();
            btn0 = new Button();
            btnIgual = new Button();
            listHistorial = new ListBox();
            txtResultados = new TextBox();
            dtpFechaInicio = new DateTimePicker();
            lblCalcularFechas = new Label();
            dtpFechaFinal = new DateTimePicker();
            btnCalcular = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btnBorrarTodo, 0, 1);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btnBorrar, 1, 1);
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btnComa, 2, 1);
            tableLayoutPanel1.Controls.Add(btnDivision, 3, 1);
            tableLayoutPanel1.Controls.Add(btnMultiplicacion, 3, 2);
            tableLayoutPanel1.Controls.Add(btn4, 0, 3);
            tableLayoutPanel1.Controls.Add(btn5, 1, 3);
            tableLayoutPanel1.Controls.Add(btn6, 2, 3);
            tableLayoutPanel1.Controls.Add(btnResta, 3, 3);
            tableLayoutPanel1.Controls.Add(btn1, 0, 4);
            tableLayoutPanel1.Controls.Add(btn2, 1, 4);
            tableLayoutPanel1.Controls.Add(btn3, 2, 4);
            tableLayoutPanel1.Controls.Add(btnSuma, 3, 4);
            tableLayoutPanel1.Controls.Add(btnPosNeg, 0, 5);
            tableLayoutPanel1.Controls.Add(btn0, 1, 5);
            tableLayoutPanel1.Controls.Add(btnIgual, 2, 5);
            tableLayoutPanel1.Controls.Add(listHistorial, 4, 0);
            tableLayoutPanel1.Controls.Add(txtResultados, 0, 0);
            tableLayoutPanel1.Controls.Add(dtpFechaInicio, 5, 1);
            tableLayoutPanel1.Controls.Add(lblCalcularFechas, 5, 0);
            tableLayoutPanel1.Controls.Add(dtpFechaFinal, 5, 2);
            tableLayoutPanel1.Controls.Add(btnCalcular, 5, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tableLayoutPanel1.Size = new Size(910, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 151);
            btn7.Name = "btn7";
            btn7.Size = new Size(145, 68);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.AutoSizeChanged += agregarNumero;
            btn7.Click += agregarNumero;
            // 
            // btnBorrarTodo
            // 
            btnBorrarTodo.Dock = DockStyle.Fill;
            btnBorrarTodo.Location = new Point(3, 77);
            btnBorrarTodo.Name = "btnBorrarTodo";
            btnBorrarTodo.Size = new Size(145, 68);
            btnBorrarTodo.TabIndex = 1;
            btnBorrarTodo.Text = "C";
            btnBorrarTodo.UseVisualStyleBackColor = true;
            btnBorrarTodo.Click += btnBorrarTodo_Click;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(154, 151);
            btn8.Name = "btn8";
            btn8.Size = new Size(145, 68);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.AutoSizeChanged += agregarNumero;
            btn8.Click += agregarNumero;
            // 
            // btnBorrar
            // 
            btnBorrar.Dock = DockStyle.Fill;
            btnBorrar.Location = new Point(154, 77);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(145, 68);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(305, 151);
            btn9.Name = "btn9";
            btn9.Size = new Size(145, 68);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.AutoSizeChanged += agregarNumero;
            btn9.Click += agregarNumero;
            // 
            // btnComa
            // 
            btnComa.Dock = DockStyle.Fill;
            btnComa.Location = new Point(305, 77);
            btnComa.Name = "btnComa";
            btnComa.Size = new Size(145, 68);
            btnComa.TabIndex = 3;
            btnComa.Text = ",";
            btnComa.UseVisualStyleBackColor = true;
            btnComa.Click += btnComa_Click;
            // 
            // btnDivision
            // 
            btnDivision.Dock = DockStyle.Fill;
            btnDivision.Location = new Point(456, 77);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(145, 68);
            btnDivision.TabIndex = 4;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += ClickOperador;
            // 
            // btnMultiplicacion
            // 
            btnMultiplicacion.Dock = DockStyle.Fill;
            btnMultiplicacion.Location = new Point(456, 151);
            btnMultiplicacion.Name = "btnMultiplicacion";
            btnMultiplicacion.Size = new Size(145, 68);
            btnMultiplicacion.TabIndex = 8;
            btnMultiplicacion.Text = "X";
            btnMultiplicacion.UseVisualStyleBackColor = true;
            btnMultiplicacion.Click += ClickOperador;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 225);
            btn4.Name = "btn4";
            btn4.Size = new Size(145, 68);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.AutoSizeChanged += agregarNumero;
            btn4.Click += agregarNumero;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(154, 225);
            btn5.Name = "btn5";
            btn5.Size = new Size(145, 68);
            btn5.TabIndex = 10;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.AutoSizeChanged += agregarNumero;
            btn5.Click += agregarNumero;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(305, 225);
            btn6.Name = "btn6";
            btn6.Size = new Size(145, 68);
            btn6.TabIndex = 11;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.AutoSizeChanged += agregarNumero;
            btn6.Click += agregarNumero;
            // 
            // btnResta
            // 
            btnResta.Dock = DockStyle.Fill;
            btnResta.Location = new Point(456, 225);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(145, 68);
            btnResta.TabIndex = 12;
            btnResta.Text = "_";
            btnResta.UseVisualStyleBackColor = true;
            btnResta.Click += ClickOperador;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 299);
            btn1.Name = "btn1";
            btn1.Size = new Size(145, 68);
            btn1.TabIndex = 13;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.AutoSizeChanged += agregarNumero;
            btn1.Click += agregarNumero;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(154, 299);
            btn2.Name = "btn2";
            btn2.Size = new Size(145, 68);
            btn2.TabIndex = 14;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.AutoSizeChanged += agregarNumero;
            btn2.Click += agregarNumero;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(305, 299);
            btn3.Name = "btn3";
            btn3.Size = new Size(145, 68);
            btn3.TabIndex = 15;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.AutoSizeChanged += agregarNumero;
            btn3.Click += agregarNumero;
            // 
            // btnSuma
            // 
            btnSuma.Dock = DockStyle.Fill;
            btnSuma.Location = new Point(456, 299);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(145, 68);
            btnSuma.TabIndex = 16;
            btnSuma.Text = "+";
            btnSuma.UseVisualStyleBackColor = true;
            btnSuma.Click += ClickOperador;
            // 
            // btnPosNeg
            // 
            btnPosNeg.Dock = DockStyle.Fill;
            btnPosNeg.Location = new Point(3, 373);
            btnPosNeg.Name = "btnPosNeg";
            btnPosNeg.Size = new Size(145, 74);
            btnPosNeg.TabIndex = 17;
            btnPosNeg.Text = "+/-";
            btnPosNeg.UseVisualStyleBackColor = true;
            btnPosNeg.Click += btnPosNeg_Click;
            // 
            // btn0
            // 
            btn0.Dock = DockStyle.Fill;
            btn0.Location = new Point(154, 373);
            btn0.Name = "btn0";
            btn0.Size = new Size(145, 74);
            btn0.TabIndex = 18;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += agregarNumero;
            // 
            // btnIgual
            // 
            tableLayoutPanel1.SetColumnSpan(btnIgual, 2);
            btnIgual.Dock = DockStyle.Fill;
            btnIgual.Location = new Point(305, 373);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(296, 74);
            btnIgual.TabIndex = 20;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            btnIgual.Click += btnIgual_Click;
            // 
            // listHistorial
            // 
            listHistorial.Dock = DockStyle.Fill;
            listHistorial.FormattingEnabled = true;
            listHistorial.ItemHeight = 15;
            listHistorial.Location = new Point(607, 3);
            listHistorial.Name = "listHistorial";
            tableLayoutPanel1.SetRowSpan(listHistorial, 6);
            listHistorial.Size = new Size(145, 444);
            listHistorial.TabIndex = 22;
            listHistorial.Click += btnIgual_Click;
            // 
            // txtResultados
            // 
            tableLayoutPanel1.SetColumnSpan(txtResultados, 4);
            txtResultados.Dock = DockStyle.Fill;
            txtResultados.Location = new Point(3, 3);
            txtResultados.MaxLength = 21;
            txtResultados.Name = "txtResultados";
            txtResultados.Size = new Size(598, 23);
            txtResultados.TabIndex = 21;
            txtResultados.Text = "0";
            txtResultados.TextAlign = HorizontalAlignment.Right;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Dock = DockStyle.Fill;
            dtpFechaInicio.Location = new Point(758, 77);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(149, 23);
            dtpFechaInicio.TabIndex = 24;
            // 
            // lblCalcularFechas
            // 
            lblCalcularFechas.AutoSize = true;
            lblCalcularFechas.Dock = DockStyle.Fill;
            lblCalcularFechas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCalcularFechas.Location = new Point(758, 0);
            lblCalcularFechas.Name = "lblCalcularFechas";
            lblCalcularFechas.Size = new Size(149, 74);
            lblCalcularFechas.TabIndex = 26;
            lblCalcularFechas.Text = "Calcular diferencia entre fechas";
            lblCalcularFechas.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Dock = DockStyle.Fill;
            dtpFechaFinal.Location = new Point(758, 151);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(149, 23);
            dtpFechaFinal.TabIndex = 25;
            // 
            // btnCalcular
            // 
            btnCalcular.Dock = DockStyle.Fill;
            btnCalcular.Location = new Point(758, 225);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(149, 68);
            btnCalcular.TabIndex = 28;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            AutoSizeChanged += agregarNumero;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDivision;
        private Button btnComa;
        private Button btnBorrar;
        private Button btnBorrarTodo;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplicacion;
        private Button button8;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnResta;
        private Button button12;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnSuma;
        private Button btnPosNeg;
        private Button btn0;
        private Button button19;
        private Button btnIgual;
        private TextBox txtResultados;
        private ListBox listHistorial;
        private Button button25;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFinal;
        private Label lblCalcularFechas;
        private Button btnCalcular;
    }
}