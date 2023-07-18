namespace EjercicioPracticaRecuperatorioAdinvinarNro
{
    partial class MenuPrincipalcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalcs));
            btnIniciarJuego = new Button();
            lblInfoJuego = new Label();
            textBoxNombreJugador = new TextBox();
            lblInfoNombre = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnIniciarJuego
            // 
            btnIniciarJuego.Location = new Point(343, 222);
            btnIniciarJuego.Name = "btnIniciarJuego";
            btnIniciarJuego.Size = new Size(101, 39);
            btnIniciarJuego.TabIndex = 0;
            btnIniciarJuego.Text = "Iniciar juego";
            btnIniciarJuego.UseVisualStyleBackColor = true;
            btnIniciarJuego.Click += btnIniciarJuego_Click;
            // 
            // lblInfoJuego
            // 
            lblInfoJuego.AutoSize = true;
            lblInfoJuego.Font = new Font("Showcard Gothic", 24F, FontStyle.Italic, GraphicsUnit.Point);
            lblInfoJuego.Location = new Point(39, 30);
            lblInfoJuego.Name = "lblInfoJuego";
            lblInfoJuego.Size = new Size(732, 40);
            lblInfoJuego.TabIndex = 1;
            lblInfoJuego.Text = "Bienvenidos al juego de adivinar numeros";
            // 
            // textBoxNombreJugador
            // 
            textBoxNombreJugador.Location = new Point(369, 156);
            textBoxNombreJugador.Name = "textBoxNombreJugador";
            textBoxNombreJugador.Size = new Size(209, 23);
            textBoxNombreJugador.TabIndex = 2;
            // 
            // lblInfoNombre
            // 
            lblInfoNombre.AutoSize = true;
            lblInfoNombre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfoNombre.Location = new Point(143, 158);
            lblInfoNombre.Name = "lblInfoNombre";
            lblInfoNombre.Size = new Size(220, 21);
            lblInfoNombre.TabIndex = 3;
            lblInfoNombre.Text = "Ingrese nombre del jugador:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 307);
            label1.Name = "label1";
            label1.Size = new Size(553, 85);
            label1.TabIndex = 4;
            label1.Text = resources.GetString("label1.Text");
            // 
            // MenuPrincipalcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblInfoNombre);
            Controls.Add(textBoxNombreJugador);
            Controls.Add(lblInfoJuego);
            Controls.Add(btnIniciarJuego);
            Name = "MenuPrincipalcs";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipalcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarJuego;
        private Label lblInfoJuego;
        private TextBox textBoxNombreJugador;
        private Label lblInfoNombre;
        private Label label1;
    }
}