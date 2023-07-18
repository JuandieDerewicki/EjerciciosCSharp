namespace TatetiProbar
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            lblTurno = new Label();
            turnos = new Label();
            menuStrip1 = new MenuStrip();
            ingreseJugadoresToolStripMenuItem = new ToolStripMenuItem();
            txtJugador1 = new ToolStripTextBox();
            txtJugador2 = new ToolStripTextBox();
            reiniciarPartidaToolStripMenuItem = new ToolStripMenuItem();
            duracionJuego = new System.Windows.Forms.Timer(components);
            lblTiempoYGanador = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33332F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.Controls.Add(btn9, 2, 2);
            tableLayoutPanel1.Controls.Add(btn8, 1, 2);
            tableLayoutPanel1.Controls.Add(btn7, 0, 2);
            tableLayoutPanel1.Controls.Add(btn6, 2, 1);
            tableLayoutPanel1.Controls.Add(btn5, 1, 1);
            tableLayoutPanel1.Controls.Add(btn4, 0, 1);
            tableLayoutPanel1.Controls.Add(btn3, 2, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 0);
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 24);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel1.Size = new Size(556, 464);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btn9
            // 
            btn9.Dock = DockStyle.Fill;
            btn9.Location = new Point(373, 311);
            btn9.Name = "btn9";
            btn9.Size = new Size(180, 150);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += onClickBoton;
            // 
            // btn8
            // 
            btn8.Dock = DockStyle.Fill;
            btn8.Location = new Point(188, 311);
            btn8.Name = "btn8";
            btn8.Size = new Size(179, 150);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += onClickBoton;
            // 
            // btn7
            // 
            btn7.Dock = DockStyle.Fill;
            btn7.Location = new Point(3, 311);
            btn7.Name = "btn7";
            btn7.Size = new Size(179, 150);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += onClickBoton;
            // 
            // btn6
            // 
            btn6.Dock = DockStyle.Fill;
            btn6.Location = new Point(373, 157);
            btn6.Name = "btn6";
            btn6.Size = new Size(180, 148);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += onClickBoton;
            // 
            // btn5
            // 
            btn5.Dock = DockStyle.Fill;
            btn5.Location = new Point(188, 157);
            btn5.Name = "btn5";
            btn5.Size = new Size(179, 148);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += onClickBoton;
            // 
            // btn4
            // 
            btn4.Dock = DockStyle.Fill;
            btn4.Location = new Point(3, 157);
            btn4.Name = "btn4";
            btn4.Size = new Size(179, 148);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += onClickBoton;
            // 
            // btn3
            // 
            btn3.Dock = DockStyle.Fill;
            btn3.Location = new Point(373, 3);
            btn3.Name = "btn3";
            btn3.Size = new Size(180, 148);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += onClickBoton;
            // 
            // btn1
            // 
            btn1.Dock = DockStyle.Fill;
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.Size = new Size(179, 148);
            btn1.TabIndex = 1;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += onClickBoton;
            // 
            // btn2
            // 
            btn2.Dock = DockStyle.Fill;
            btn2.Location = new Point(188, 3);
            btn2.Name = "btn2";
            btn2.Size = new Size(179, 148);
            btn2.TabIndex = 0;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += onClickBoton;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(457, 0);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(0, 15);
            lblTurno.TabIndex = 1;
            // 
            // turnos
            // 
            turnos.AutoSize = true;
            turnos.Location = new Point(562, 0);
            turnos.Name = "turnos";
            turnos.Size = new Size(95, 15);
            turnos.TabIndex = 2;
            turnos.Text = "Turno: Jugador 1";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { ingreseJugadoresToolStripMenuItem, reiniciarPartidaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(789, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // ingreseJugadoresToolStripMenuItem
            // 
            ingreseJugadoresToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtJugador1, txtJugador2 });
            ingreseJugadoresToolStripMenuItem.Name = "ingreseJugadoresToolStripMenuItem";
            ingreseJugadoresToolStripMenuItem.Size = new Size(112, 20);
            ingreseJugadoresToolStripMenuItem.Text = "Ingrese jugadores";
            // 
            // txtJugador1
            // 
            txtJugador1.Name = "txtJugador1";
            txtJugador1.Size = new Size(100, 23);
            txtJugador1.Text = "Jugador 1";
            // 
            // txtJugador2
            // 
            txtJugador2.Name = "txtJugador2";
            txtJugador2.Size = new Size(100, 23);
            txtJugador2.Text = "Jugador 2";
            // 
            // reiniciarPartidaToolStripMenuItem
            // 
            reiniciarPartidaToolStripMenuItem.Name = "reiniciarPartidaToolStripMenuItem";
            reiniciarPartidaToolStripMenuItem.Size = new Size(104, 20);
            reiniciarPartidaToolStripMenuItem.Text = "Reiniciar partida";
            reiniciarPartidaToolStripMenuItem.Click += reiniciarPartidaToolStripMenuItem_Click;
            // 
            // duracionJuego
            // 
            duracionJuego.Interval = 1000;
            duracionJuego.Tick += timer1_Tick;
            // 
            // lblTiempoYGanador
            // 
            lblTiempoYGanador.AutoSize = true;
            lblTiempoYGanador.Location = new Point(687, 42);
            lblTiempoYGanador.Name = "lblTiempoYGanador";
            lblTiempoYGanador.Size = new Size(0, 15);
            lblTiempoYGanador.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(575, 42);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 5;
            label1.Text = "Tiempo de partida:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 488);
            Controls.Add(label1);
            Controls.Add(lblTiempoYGanador);
            Controls.Add(turnos);
            Controls.Add(lblTurno);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn1;
        private Button btn2;
        private Label lblTurno;
        private Label turnos;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ingreseJugadoresToolStripMenuItem;
        private ToolStripMenuItem reiniciarPartidaToolStripMenuItem;
        private ToolStripTextBox txtJugador1;
        private ToolStripTextBox txtJugador2;
        private System.Windows.Forms.Timer duracionJuego;
        private Label lblTiempoYGanador;
        private Label label1;
    }
}