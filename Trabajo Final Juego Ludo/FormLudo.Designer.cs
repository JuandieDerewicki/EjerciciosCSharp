namespace TrabajoFinalPruebas
{
    partial class FormLudo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLudo));
            Dado = new PictureBox();
            TableroLudo = new PictureBox();
            btnVerde1 = new Button();
            btnVerde4 = new Button();
            btnVerde2 = new Button();
            btnVerde3 = new Button();
            btnRojo1 = new Button();
            btnRojo2 = new Button();
            btnRojo3 = new Button();
            btnRojo4 = new Button();
            btnAmarillo4 = new Button();
            btnAmarillo3 = new Button();
            btnAmarillo1 = new Button();
            btnAmarillo2 = new Button();
            btnAzul1 = new Button();
            btnAzul2 = new Button();
            btnAzul4 = new Button();
            btnAzul3 = new Button();
            verdeNombre = new Label();
            rojoNombre = new Label();
            amarilloNombre = new Label();
            azulNombre = new Label();
            lblTurnos = new Label();
            ((System.ComponentModel.ISupportInitialize)Dado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TableroLudo).BeginInit();
            SuspendLayout();
            // 
            // Dado
            // 
            Dado.Anchor = AnchorStyles.None;
            Dado.Image = (Image)resources.GetObject("Dado.Image");
            Dado.Location = new Point(545, 245);
            Dado.Name = "Dado";
            Dado.Size = new Size(50, 39);
            Dado.SizeMode = PictureBoxSizeMode.StretchImage;
            Dado.TabIndex = 1;
            Dado.TabStop = false;
            Dado.Click += Dado_Click;
            // 
            // TableroLudo
            // 
            TableroLudo.BackColor = Color.Black;
            TableroLudo.Dock = DockStyle.Fill;
            TableroLudo.Image = Properties.Resources.TableroLudo3;
            TableroLudo.Location = new Point(0, 0);
            TableroLudo.Name = "TableroLudo";
            TableroLudo.Size = new Size(1142, 522);
            TableroLudo.SizeMode = PictureBoxSizeMode.StretchImage;
            TableroLudo.TabIndex = 0;
            TableroLudo.TabStop = false;
            // 
            // btnVerde1
            // 
            btnVerde1.BackColor = Color.FromArgb(0, 192, 0);
            btnVerde1.Location = new Point(162, 103);
            btnVerde1.Name = "btnVerde1";
            btnVerde1.Size = new Size(34, 22);
            btnVerde1.TabIndex = 2;
            btnVerde1.UseVisualStyleBackColor = false;
            btnVerde1.Click += btnVerde1_Click;
            // 
            // btnVerde4
            // 
            btnVerde4.BackColor = Color.FromArgb(0, 192, 0);
            btnVerde4.Location = new Point(234, 67);
            btnVerde4.Name = "btnVerde4";
            btnVerde4.Size = new Size(34, 22);
            btnVerde4.TabIndex = 3;
            btnVerde4.UseVisualStyleBackColor = false;
            btnVerde4.Click += btnVerde4_Click;
            // 
            // btnVerde2
            // 
            btnVerde2.BackColor = Color.FromArgb(0, 192, 0);
            btnVerde2.Location = new Point(234, 137);
            btnVerde2.Name = "btnVerde2";
            btnVerde2.Size = new Size(34, 22);
            btnVerde2.TabIndex = 4;
            btnVerde2.UseVisualStyleBackColor = false;
            btnVerde2.Click += btnVerde2_Click;
            // 
            // btnVerde3
            // 
            btnVerde3.BackColor = Color.FromArgb(0, 192, 0);
            btnVerde3.Location = new Point(305, 103);
            btnVerde3.Name = "btnVerde3";
            btnVerde3.Size = new Size(34, 22);
            btnVerde3.TabIndex = 5;
            btnVerde3.UseVisualStyleBackColor = false;
            btnVerde3.Click += btnVerde3_Click;
            // 
            // btnRojo1
            // 
            btnRojo1.BackColor = Color.Red;
            btnRojo1.Location = new Point(806, 103);
            btnRojo1.Name = "btnRojo1";
            btnRojo1.Size = new Size(34, 22);
            btnRojo1.TabIndex = 6;
            btnRojo1.UseVisualStyleBackColor = false;
            btnRojo1.Click += btnRojo1_Click;
            // 
            // btnRojo2
            // 
            btnRojo2.BackColor = Color.Red;
            btnRojo2.Location = new Point(875, 137);
            btnRojo2.Name = "btnRojo2";
            btnRojo2.Size = new Size(34, 22);
            btnRojo2.TabIndex = 7;
            btnRojo2.UseVisualStyleBackColor = false;
            btnRojo2.Click += btnRojo2_Click;
            // 
            // btnRojo3
            // 
            btnRojo3.BackColor = Color.Red;
            btnRojo3.Location = new Point(950, 103);
            btnRojo3.Name = "btnRojo3";
            btnRojo3.Size = new Size(34, 22);
            btnRojo3.TabIndex = 8;
            btnRojo3.UseVisualStyleBackColor = false;
            btnRojo3.Click += btnRojo3_Click;
            // 
            // btnRojo4
            // 
            btnRojo4.BackColor = Color.Red;
            btnRojo4.Location = new Point(875, 67);
            btnRojo4.Name = "btnRojo4";
            btnRojo4.Size = new Size(34, 22);
            btnRojo4.TabIndex = 9;
            btnRojo4.UseVisualStyleBackColor = false;
            btnRojo4.Click += btnRojo4_Click;
            // 
            // btnAmarillo4
            // 
            btnAmarillo4.BackColor = Color.Gold;
            btnAmarillo4.Location = new Point(619, 378);
            btnAmarillo4.Name = "btnAmarillo4";
            btnAmarillo4.Size = new Size(34, 22);
            btnAmarillo4.TabIndex = 10;
            btnAmarillo4.UseVisualStyleBackColor = false;
            btnAmarillo4.Click += btnAmarillo4_Click;
            // 
            // btnAmarillo3
            // 
            btnAmarillo3.BackColor = Color.Gold;
            btnAmarillo3.Location = new Point(304, 397);
            btnAmarillo3.Name = "btnAmarillo3";
            btnAmarillo3.Size = new Size(34, 22);
            btnAmarillo3.TabIndex = 11;
            btnAmarillo3.UseVisualStyleBackColor = false;
            btnAmarillo3.Click += btnAmarillo3_Click;
            // 
            // btnAmarillo1
            // 
            btnAmarillo1.BackColor = Color.Gold;
            btnAmarillo1.Location = new Point(162, 394);
            btnAmarillo1.Name = "btnAmarillo1";
            btnAmarillo1.Size = new Size(34, 22);
            btnAmarillo1.TabIndex = 12;
            btnAmarillo1.UseVisualStyleBackColor = false;
            btnAmarillo1.Click += btnAmarillo1_Click;
            // 
            // btnAmarillo2
            // 
            btnAmarillo2.BackColor = Color.Gold;
            btnAmarillo2.Location = new Point(234, 431);
            btnAmarillo2.Name = "btnAmarillo2";
            btnAmarillo2.Size = new Size(34, 22);
            btnAmarillo2.TabIndex = 13;
            btnAmarillo2.UseVisualStyleBackColor = false;
            btnAmarillo2.Click += btnAmarillo2_Click;
            // 
            // btnAzul1
            // 
            btnAzul1.BackColor = Color.Blue;
            btnAzul1.Location = new Point(806, 394);
            btnAzul1.Name = "btnAzul1";
            btnAzul1.Size = new Size(34, 22);
            btnAzul1.TabIndex = 14;
            btnAzul1.UseVisualStyleBackColor = false;
            btnAzul1.Click += btnAzul1_Click;
            // 
            // btnAzul2
            // 
            btnAzul2.BackColor = Color.Blue;
            btnAzul2.Location = new Point(875, 431);
            btnAzul2.Name = "btnAzul2";
            btnAzul2.Size = new Size(34, 22);
            btnAzul2.TabIndex = 15;
            btnAzul2.UseVisualStyleBackColor = false;
            btnAzul2.Click += btnAzul2_Click;
            // 
            // btnAzul4
            // 
            btnAzul4.BackColor = Color.Blue;
            btnAzul4.Location = new Point(875, 362);
            btnAzul4.Name = "btnAzul4";
            btnAzul4.Size = new Size(34, 22);
            btnAzul4.TabIndex = 16;
            btnAzul4.UseVisualStyleBackColor = false;
            btnAzul4.Click += btnAzul4_Click;
            // 
            // btnAzul3
            // 
            btnAzul3.BackColor = Color.Blue;
            btnAzul3.Location = new Point(950, 394);
            btnAzul3.Name = "btnAzul3";
            btnAzul3.Size = new Size(34, 22);
            btnAzul3.TabIndex = 17;
            btnAzul3.UseVisualStyleBackColor = false;
            btnAzul3.Click += btnAzul3_Click;
            // 
            // verdeNombre
            // 
            verdeNombre.AutoSize = true;
            verdeNombre.Location = new Point(335, 31);
            verdeNombre.Name = "verdeNombre";
            verdeNombre.Size = new Size(14, 15);
            verdeNombre.TabIndex = 18;
            verdeNombre.Text = "X";
            // 
            // rojoNombre
            // 
            rojoNombre.AutoSize = true;
            rojoNombre.Location = new Point(985, 31);
            rojoNombre.Name = "rojoNombre";
            rojoNombre.Size = new Size(14, 15);
            rojoNombre.TabIndex = 19;
            rojoNombre.Text = "X";
            // 
            // amarilloNombre
            // 
            amarilloNombre.AutoSize = true;
            amarilloNombre.Location = new Point(335, 321);
            amarilloNombre.Name = "amarilloNombre";
            amarilloNombre.Size = new Size(14, 15);
            amarilloNombre.TabIndex = 20;
            amarilloNombre.Text = "X";
            // 
            // azulNombre
            // 
            azulNombre.AutoSize = true;
            azulNombre.Location = new Point(985, 321);
            azulNombre.Name = "azulNombre";
            azulNombre.Size = new Size(14, 15);
            azulNombre.TabIndex = 21;
            azulNombre.Text = "X";
            // 
            // lblTurnos
            // 
            lblTurnos.AutoSize = true;
            lblTurnos.Location = new Point(487, 0);
            lblTurnos.Name = "lblTurnos";
            lblTurnos.Size = new Size(43, 15);
            lblTurnos.TabIndex = 22;
            lblTurnos.Text = "Turnos";
            // 
            // FormLudo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 522);
            Controls.Add(lblTurnos);
            Controls.Add(azulNombre);
            Controls.Add(amarilloNombre);
            Controls.Add(rojoNombre);
            Controls.Add(verdeNombre);
            Controls.Add(btnAzul3);
            Controls.Add(btnAzul4);
            Controls.Add(btnAzul2);
            Controls.Add(btnAzul1);
            Controls.Add(btnAmarillo2);
            Controls.Add(btnAmarillo1);
            Controls.Add(btnAmarillo3);
            Controls.Add(btnAmarillo4);
            Controls.Add(btnRojo4);
            Controls.Add(btnRojo3);
            Controls.Add(btnRojo2);
            Controls.Add(btnRojo1);
            Controls.Add(btnVerde3);
            Controls.Add(btnVerde2);
            Controls.Add(btnVerde4);
            Controls.Add(btnVerde1);
            Controls.Add(Dado);
            Controls.Add(TableroLudo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLudo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ludo";
            Load += FormLudo_Load;
            ((System.ComponentModel.ISupportInitialize)Dado).EndInit();
            ((System.ComponentModel.ISupportInitialize)TableroLudo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox Dado;
        private PictureBox TableroLudo;
        private Button btnVerde1;
        private Button btnVerde4;
        private Button btnVerde2;
        private Button btnVerde3;
        private Button btnRojo1;
        private Button btnRojo2;
        private Button btnRojo3;
        private Button btnRojo4;
        private Button btnAmarillo4;
        private Button btnAmarillo3;
        private Button btnAmarillo1;
        private Button btnAmarillo2;
        private Button btnAzul1;
        private Button btnAzul2;
        private Button btnAzul4;
        private Button btnAzul3;
        private Label verdeNombre;
        private Label rojoNombre;
        private Label amarilloNombre;
        private Label azulNombre;
        private Label lblTurnos;
    }
}