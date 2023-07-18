namespace EjercicioPracticaRecuperatorioAdinvinarNro
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
            lblBienvenida = new Label();
            lblNivel = new Label();
            listBox1 = new ListBox();
            txtBoxNumero = new TextBox();
            btnEnviarNumero = new Button();
            pictureBox1 = new PictureBox();
            lblIntentos = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida.Location = new Point(300, 28);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(115, 32);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "label1";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNivel.Location = new Point(481, 123);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(106, 29);
            lblNivel.TabIndex = 1;
            lblNivel.Text = "Nivel 1";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(723, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(259, 394);
            listBox1.TabIndex = 2;
            // 
            // txtBoxNumero
            // 
            txtBoxNumero.Location = new Point(462, 228);
            txtBoxNumero.Name = "txtBoxNumero";
            txtBoxNumero.Size = new Size(100, 23);
            txtBoxNumero.TabIndex = 3;
            // 
            // btnEnviarNumero
            // 
            btnEnviarNumero.Location = new Point(597, 228);
            btnEnviarNumero.Name = "btnEnviarNumero";
            btnEnviarNumero.Size = new Size(75, 23);
            btnEnviarNumero.TabIndex = 4;
            btnEnviarNumero.Text = "Aceptar";
            btnEnviarNumero.UseVisualStyleBackColor = true;
            btnEnviarNumero.Click += btnEnviarNumero_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(429, 421);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // lblIntentos
            // 
            lblIntentos.AutoSize = true;
            lblIntentos.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntentos.Location = new Point(527, 332);
            lblIntentos.Name = "lblIntentos";
            lblIntentos.Size = new Size(51, 21);
            lblIntentos.TabIndex = 5;
            lblIntentos.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 515);
            Controls.Add(pictureBox1);
            Controls.Add(lblIntentos);
            Controls.Add(btnEnviarNumero);
            Controls.Add(txtBoxNumero);
            Controls.Add(listBox1);
            Controls.Add(lblNivel);
            Controls.Add(lblBienvenida);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblNivel;
        private ListBox listBox1;
        private TextBox txtBoxNumero;
        private Button btnEnviarNumero;
        private PictureBox pictureBox1;
        private Label lblIntentos;
    }
}