namespace EjercicioPracticaRecuperatorioAdinvinarNro
{
    partial class Nivel2
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
            lblBienvenida2 = new Label();
            lblNivel2 = new Label();
            txtBoxNumero2 = new TextBox();
            listBox2 = new ListBox();
            lblIntentos2 = new Label();
            pictureBox2 = new PictureBox();
            btnEnviarNumero2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida2
            // 
            lblBienvenida2.AutoSize = true;
            lblBienvenida2.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida2.Location = new Point(280, 9);
            lblBienvenida2.Name = "lblBienvenida2";
            lblBienvenida2.Size = new Size(115, 32);
            lblBienvenida2.TabIndex = 1;
            lblBienvenida2.Text = "label1";
            // 
            // lblNivel2
            // 
            lblNivel2.AutoSize = true;
            lblNivel2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNivel2.Location = new Point(515, 77);
            lblNivel2.Name = "lblNivel2";
            lblNivel2.Size = new Size(106, 29);
            lblNivel2.TabIndex = 2;
            lblNivel2.Text = "Nivel 2";
            // 
            // txtBoxNumero2
            // 
            txtBoxNumero2.Location = new Point(475, 247);
            txtBoxNumero2.Name = "txtBoxNumero2";
            txtBoxNumero2.Size = new Size(100, 23);
            txtBoxNumero2.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(706, 77);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(259, 394);
            listBox2.TabIndex = 6;
            // 
            // lblIntentos2
            // 
            lblIntentos2.AutoSize = true;
            lblIntentos2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntentos2.Location = new Point(553, 325);
            lblIntentos2.Name = "lblIntentos2";
            lblIntentos2.Size = new Size(51, 21);
            lblIntentos2.TabIndex = 7;
            lblIntentos2.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(429, 421);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnEnviarNumero2
            // 
            btnEnviarNumero2.Location = new Point(601, 246);
            btnEnviarNumero2.Name = "btnEnviarNumero2";
            btnEnviarNumero2.Size = new Size(75, 23);
            btnEnviarNumero2.TabIndex = 5;
            btnEnviarNumero2.Text = "Aceptar";
            btnEnviarNumero2.UseVisualStyleBackColor = true;
            btnEnviarNumero2.Click += btnEnviarNumero2_Click_1;
            // 
            // Nivel2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 515);
            Controls.Add(pictureBox2);
            Controls.Add(lblIntentos2);
            Controls.Add(listBox2);
            Controls.Add(btnEnviarNumero2);
            Controls.Add(txtBoxNumero2);
            Controls.Add(lblNivel2);
            Controls.Add(lblBienvenida2);
            Name = "Nivel2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nivel2";
            Load += Nivel2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida2;
        private Label lblNivel2;
        private TextBox txtBoxNumero2;
        private ListBox listBox2;
        private Label lblIntentos2;
        private PictureBox pictureBox2;
        private Button btnEnviarNumero2;
    }
}