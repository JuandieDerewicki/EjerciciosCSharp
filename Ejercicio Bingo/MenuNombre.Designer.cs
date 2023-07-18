namespace EjercicioPracticoRecuperatorioBingo
{
    partial class MenuNombre
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
            btnEnviarNombre = new Button();
            lblInfoNombre = new Label();
            txtBoxNombre = new TextBox();
            SuspendLayout();
            // 
            // btnEnviarNombre
            // 
            btnEnviarNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEnviarNombre.Location = new Point(318, 205);
            btnEnviarNombre.Name = "btnEnviarNombre";
            btnEnviarNombre.Size = new Size(129, 32);
            btnEnviarNombre.TabIndex = 0;
            btnEnviarNombre.Text = "Aceptar";
            btnEnviarNombre.UseVisualStyleBackColor = true;
            btnEnviarNombre.Click += btnEnviarNombre_Click;
            // 
            // lblInfoNombre
            // 
            lblInfoNombre.AutoSize = true;
            lblInfoNombre.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblInfoNombre.Location = new Point(203, 142);
            lblInfoNombre.Name = "lblInfoNombre";
            lblInfoNombre.Size = new Size(155, 25);
            lblInfoNombre.TabIndex = 1;
            lblInfoNombre.Text = "Agregar nombre:";
            // 
            // txtBoxNombre
            // 
            txtBoxNombre.Location = new Point(364, 147);
            txtBoxNombre.Name = "txtBoxNombre";
            txtBoxNombre.Size = new Size(203, 23);
            txtBoxNombre.TabIndex = 2;
            // 
            // MenuNombre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBoxNombre);
            Controls.Add(lblInfoNombre);
            Controls.Add(btnEnviarNombre);
            Name = "MenuNombre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuNombre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEnviarNombre;
        private Label lblInfoNombre;
        private TextBox txtBoxNombre;
    }
}