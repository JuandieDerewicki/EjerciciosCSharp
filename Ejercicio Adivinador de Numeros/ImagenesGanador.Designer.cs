namespace EjercicioPracticaRecuperatorioAdinvinarNro
{
    partial class ImagenesGanador
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
            pictureBox1 = new PictureBox();
            lblFelicidades = new Label();
            btnSiguienteNivel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(26, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(958, 407);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblFelicidades
            // 
            lblFelicidades.AutoSize = true;
            lblFelicidades.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblFelicidades.Location = new Point(385, 24);
            lblFelicidades.Name = "lblFelicidades";
            lblFelicidades.Size = new Size(280, 32);
            lblFelicidades.TabIndex = 1;
            lblFelicidades.Text = "¡Felicidades, has ganado!";
            // 
            // btnSiguienteNivel
            // 
            btnSiguienteNivel.Location = new Point(739, 20);
            btnSiguienteNivel.Name = "btnSiguienteNivel";
            btnSiguienteNivel.Size = new Size(186, 50);
            btnSiguienteNivel.TabIndex = 2;
            btnSiguienteNivel.Text = "Siguiente nivel";
            btnSiguienteNivel.UseVisualStyleBackColor = true;
            // 
            // ImagenesGanador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 502);
            Controls.Add(btnSiguienteNivel);
            Controls.Add(lblFelicidades);
            Controls.Add(pictureBox1);
            Name = "ImagenesGanador";
            Text = "ImagenesGanador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblFelicidades;
        private Button btnSiguienteNivel;
    }
}