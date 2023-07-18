namespace EjercicioPracticaRecuperatorioAdinvinarNro
{
    partial class Nivel3
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
            lblBienvenida3 = new Label();
            lblNivel3 = new Label();
            listBox3 = new ListBox();
            btnEnviarNumero3 = new Button();
            txtBoxNumero3 = new TextBox();
            pictureBox3 = new PictureBox();
            lblIntentos3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida3
            // 
            lblBienvenida3.AutoSize = true;
            lblBienvenida3.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblBienvenida3.Location = new Point(326, 9);
            lblBienvenida3.Name = "lblBienvenida3";
            lblBienvenida3.Size = new Size(115, 32);
            lblBienvenida3.TabIndex = 2;
            lblBienvenida3.Text = "label1";
            // 
            // lblNivel3
            // 
            lblNivel3.AutoSize = true;
            lblNivel3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblNivel3.Location = new Point(537, 82);
            lblNivel3.Name = "lblNivel3";
            lblNivel3.Size = new Size(106, 29);
            lblNivel3.TabIndex = 3;
            lblNivel3.Text = "Nivel 3";
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(736, 82);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(259, 394);
            listBox3.TabIndex = 7;
            // 
            // btnEnviarNumero3
            // 
            btnEnviarNumero3.Location = new Point(615, 233);
            btnEnviarNumero3.Name = "btnEnviarNumero3";
            btnEnviarNumero3.Size = new Size(75, 23);
            btnEnviarNumero3.TabIndex = 8;
            btnEnviarNumero3.Text = "Aceptar";
            btnEnviarNumero3.UseVisualStyleBackColor = true;
            btnEnviarNumero3.Click += btnEnviarNumero3_Click;
            // 
            // txtBoxNumero3
            // 
            txtBoxNumero3.Location = new Point(486, 234);
            txtBoxNumero3.Name = "txtBoxNumero3";
            txtBoxNumero3.Size = new Size(100, 23);
            txtBoxNumero3.TabIndex = 9;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(12, 73);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(429, 421);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // lblIntentos3
            // 
            lblIntentos3.AutoSize = true;
            lblIntentos3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblIntentos3.Location = new Point(568, 323);
            lblIntentos3.Name = "lblIntentos3";
            lblIntentos3.Size = new Size(51, 21);
            lblIntentos3.TabIndex = 11;
            lblIntentos3.Text = "label1";
            // 
            // Nivel3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 497);
            Controls.Add(lblIntentos3);
            Controls.Add(pictureBox3);
            Controls.Add(txtBoxNumero3);
            Controls.Add(btnEnviarNumero3);
            Controls.Add(listBox3);
            Controls.Add(lblNivel3);
            Controls.Add(lblBienvenida3);
            Name = "Nivel3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nivel3";
            Load += Nivel3_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida3;
        private Label lblNivel3;
        private ListBox listBox3;
        private Button btnEnviarNumero3;
        private TextBox txtBoxNumero3;
        private PictureBox pictureBox3;
        private Label lblIntentos3;
    }
}