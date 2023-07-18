namespace AdivinadorAnimalesIA
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
            btnNo = new Button();
            lblPregunta = new Label();
            textBoxPregunta = new TextBox();
            btnSi = new Button();
            btnEnviar = new Button();
            textBoxNombreAnimal = new TextBox();
            lblInfoAnimal = new Label();
            lblPreguntaAnimal = new Label();
            lblInformacion = new Label();
            lblInformacionJuego = new Label();
            SuspendLayout();
            // 
            // btnNo
            // 
            btnNo.Location = new Point(494, 160);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(85, 26);
            btnNo.TabIndex = 0;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Location = new Point(76, 166);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(38, 15);
            lblPregunta.TabIndex = 2;
            lblPregunta.Text = "label1";
            // 
            // textBoxPregunta
            // 
            textBoxPregunta.Location = new Point(442, 351);
            textBoxPregunta.Name = "textBoxPregunta";
            textBoxPregunta.Size = new Size(307, 23);
            textBoxPregunta.TabIndex = 3;
            // 
            // btnSi
            // 
            btnSi.Location = new Point(370, 160);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(85, 26);
            btnSi.TabIndex = 4;
            btnSi.Text = "Si";
            btnSi.UseVisualStyleBackColor = true;
            btnSi.Click += btnSi_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(370, 402);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(85, 26);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click_1;
            // 
            // textBoxNombreAnimal
            // 
            textBoxNombreAnimal.Location = new Point(76, 351);
            textBoxNombreAnimal.Name = "textBoxNombreAnimal";
            textBoxNombreAnimal.Size = new Size(307, 23);
            textBoxNombreAnimal.TabIndex = 6;
            // 
            // lblInfoAnimal
            // 
            lblInfoAnimal.AutoSize = true;
            lblInfoAnimal.Location = new Point(190, 321);
            lblInfoAnimal.Name = "lblInfoAnimal";
            lblInfoAnimal.Size = new Size(97, 15);
            lblInfoAnimal.TabIndex = 7;
            lblInfoAnimal.Text = "¿Qué animal era?";
            // 
            // lblPreguntaAnimal
            // 
            lblPreguntaAnimal.AutoSize = true;
            lblPreguntaAnimal.Location = new Point(455, 321);
            lblPreguntaAnimal.Name = "lblPreguntaAnimal";
            lblPreguntaAnimal.Size = new Size(294, 15);
            lblPreguntaAnimal.TabIndex = 8;
            lblPreguntaAnimal.Text = "Agregue una pregunta identificatoria para este animal:";
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblInformacion.Location = new Point(116, 277);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(607, 21);
            lblInformacion.TabIndex = 9;
            lblInformacion.Text = "Si la respuesta es incorrecta, agregue estas peticiones y envíelas para mejorar el juego:";
            // 
            // lblInformacionJuego
            // 
            lblInformacionJuego.AutoSize = true;
            lblInformacionJuego.Font = new Font("Snap ITC", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInformacionJuego.Location = new Point(235, 22);
            lblInformacionJuego.Name = "lblInformacionJuego";
            lblInformacionJuego.Size = new Size(350, 31);
            lblInformacionJuego.TabIndex = 10;
            lblInformacionJuego.Text = "Adivinador de animales";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInformacionJuego);
            Controls.Add(lblInformacion);
            Controls.Add(lblPreguntaAnimal);
            Controls.Add(lblInfoAnimal);
            Controls.Add(textBoxNombreAnimal);
            Controls.Add(btnEnviar);
            Controls.Add(btnSi);
            Controls.Add(textBoxPregunta);
            Controls.Add(btnNo);
            Controls.Add(lblPregunta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnNo;
        private Label lblPregunta;
        private TextBox textBoxPregunta;
        private Button btnSi;
        private Button btnEnviar;
        private TextBox textBoxNombreAnimal;
        private Label lblInfoAnimal;
        private Label lblPreguntaAnimal;
        private Label lblInformacion;
        private Label lblInformacionJuego;
    }
}