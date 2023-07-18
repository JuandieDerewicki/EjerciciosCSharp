namespace TatetiProbar
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
            btnInicio = new Button();
            lblInfoTateti = new Label();
            SuspendLayout();
            // 
            // btnInicio
            // 
            btnInicio.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.Location = new Point(329, 191);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(148, 40);
            btnInicio.TabIndex = 0;
            btnInicio.Text = "Iniciar";
            btnInicio.UseVisualStyleBackColor = true;
            btnInicio.Click += btnInicio_Click;
            // 
            // lblInfoTateti
            // 
            lblInfoTateti.AutoSize = true;
            lblInfoTateti.Font = new Font("Segoe UI Black", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lblInfoTateti.Location = new Point(200, 68);
            lblInfoTateti.Name = "lblInfoTateti";
            lblInfoTateti.Size = new Size(415, 40);
            lblInfoTateti.TabIndex = 1;
            lblInfoTateti.Text = "Bienvenidos al juego TaTeTi";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInfoTateti);
            Controls.Add(btnInicio);
            Name = "MenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInicio;
        private Label lblInfoTateti;
    }
}