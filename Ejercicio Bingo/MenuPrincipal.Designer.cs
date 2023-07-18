namespace EjercicioPracticoRecuperatorioBingo
{
    partial class MenuPrincipal
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
            lblInfoBingo = new Label();
            btnIniciar = new Button();
            SuspendLayout();
            // 
            // lblInfoBingo
            // 
            lblInfoBingo.AutoSize = true;
            lblInfoBingo.Font = new Font("Britannic Bold", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoBingo.Location = new Point(262, 74);
            lblInfoBingo.Name = "lblInfoBingo";
            lblInfoBingo.Size = new Size(280, 32);
            lblInfoBingo.TabIndex = 0;
            lblInfoBingo.Text = "Bienvenidos al bingo";
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnIniciar.Location = new Point(313, 206);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(172, 44);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIniciar);
            Controls.Add(lblInfoBingo);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInfoBingo;
        private Button btnIniciar;
    }
}