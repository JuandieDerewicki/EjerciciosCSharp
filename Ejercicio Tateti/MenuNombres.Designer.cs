namespace TatetiProbar
{
    partial class MenuNombres
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
            btnEnviar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            lblNombreJ1 = new Label();
            lblNombreJ2 = new Label();
            SuspendLayout();
            // 
            // btnEnviar
            // 
            btnEnviar.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviar.Location = new Point(557, 201);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(92, 29);
            btnEnviar.TabIndex = 0;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(345, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(345, 244);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 2;
            // 
            // lblNombreJ1
            // 
            lblNombreJ1.AutoSize = true;
            lblNombreJ1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreJ1.Location = new Point(159, 167);
            lblNombreJ1.Name = "lblNombreJ1";
            lblNombreJ1.Size = new Size(167, 21);
            lblNombreJ1.TabIndex = 3;
            lblNombreJ1.Text = "Nombre del jugador 1:";
            // 
            // lblNombreJ2
            // 
            lblNombreJ2.AutoSize = true;
            lblNombreJ2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreJ2.Location = new Point(159, 246);
            lblNombreJ2.Name = "lblNombreJ2";
            lblNombreJ2.Size = new Size(167, 21);
            lblNombreJ2.TabIndex = 4;
            lblNombreJ2.Text = "Nombre del jugador 2:";
            // 
            // MenuNombres
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNombreJ2);
            Controls.Add(lblNombreJ1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnEnviar);
            Name = "MenuNombres";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuNombres";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviar;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label lblNombreJ1;
        private Label lblNombreJ2;
    }
}