namespace EjercicioJuegoSimon2
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
            Button botonRojo;
            botonAzul = new Button();
            botonVerde = new Button();
            botonMarron = new Button();
            botonComenzar = new Button();
            botonRojo = new Button();
            SuspendLayout();
            // 
            // botonRojo
            // 
            botonRojo.Location = new Point(283, 121);
            botonRojo.Name = "botonRojo";
            botonRojo.Size = new Size(77, 46);
            botonRojo.TabIndex = 0;
            botonRojo.UseVisualStyleBackColor = true;
            botonRojo.Click += btnColor_Click;
            // 
            // botonAzul
            // 
            botonAzul.Location = new Point(444, 121);
            botonAzul.Name = "botonAzul";
            botonAzul.Size = new Size(77, 46);
            botonAzul.TabIndex = 1;
            botonAzul.UseVisualStyleBackColor = true;
            botonAzul.Click += btnColor_Click;
            // 
            // botonVerde
            // 
            botonVerde.Location = new Point(283, 224);
            botonVerde.Name = "botonVerde";
            botonVerde.Size = new Size(77, 46);
            botonVerde.TabIndex = 2;
            botonVerde.UseVisualStyleBackColor = true;
            botonVerde.Click += btnColor_Click;
            // 
            // botonMarron
            // 
            botonMarron.Location = new Point(444, 224);
            botonMarron.Name = "botonMarron";
            botonMarron.Size = new Size(77, 46);
            botonMarron.TabIndex = 3;
            botonMarron.UseVisualStyleBackColor = true;
            botonMarron.Click += btnColor_Click;
            // 
            // botonComenzar
            // 
            botonComenzar.Location = new Point(40, 178);
            botonComenzar.Name = "botonComenzar";
            botonComenzar.Size = new Size(75, 38);
            botonComenzar.TabIndex = 4;
            botonComenzar.Text = "Comenzar";
            botonComenzar.UseVisualStyleBackColor = true;
            botonComenzar.Click += botonComenzar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(botonComenzar);
            Controls.Add(botonMarron);
            Controls.Add(botonVerde);
            Controls.Add(botonAzul);
            Controls.Add(botonRojo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button botonRojo;
        private Button botonAzul;
        private Button botonVerde;
        private Button botonMarron;
        private Button botonComenzar;
    }
}