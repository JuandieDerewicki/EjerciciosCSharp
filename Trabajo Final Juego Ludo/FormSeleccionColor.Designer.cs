namespace TrabajoFinalPruebas
{
    partial class FormSeleccionColor
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
            playLudo = new Button();
            panel1 = new Panel();
            verdeText1 = new TextBox();
            verdeRadio3 = new RadioButton();
            verdeRadio2 = new RadioButton();
            verdeRadio1 = new RadioButton();
            label1 = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            rojoText1 = new TextBox();
            rojoRadio3 = new RadioButton();
            label2 = new Label();
            rojoRadio2 = new RadioButton();
            rojoRadio1 = new RadioButton();
            panel3 = new Panel();
            azulText1 = new TextBox();
            azulRadio3 = new RadioButton();
            panel7 = new Panel();
            label3 = new Label();
            azulRadio1 = new RadioButton();
            azulRadio2 = new RadioButton();
            panel4 = new Panel();
            amarilloText1 = new TextBox();
            amarilloRadio3 = new RadioButton();
            amarilloRadio2 = new RadioButton();
            label4 = new Label();
            amarilloRadio1 = new RadioButton();
            panel6 = new Panel();
            panel8 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // playLudo
            // 
            playLudo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playLudo.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            playLudo.Location = new Point(314, 196);
            playLudo.Name = "playLudo";
            playLudo.Size = new Size(186, 38);
            playLudo.TabIndex = 0;
            playLudo.Text = "Empezar Partida";
            playLudo.UseVisualStyleBackColor = true;
            playLudo.Click += playLudo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(verdeText1);
            panel1.Controls.Add(verdeRadio3);
            panel1.Controls.Add(verdeRadio2);
            panel1.Controls.Add(verdeRadio1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel5);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(267, 144);
            panel1.TabIndex = 1;
            // 
            // verdeText1
            // 
            verdeText1.Location = new Point(68, 46);
            verdeText1.Name = "verdeText1";
            verdeText1.Size = new Size(169, 23);
            verdeText1.TabIndex = 5;
            // 
            // verdeRadio3
            // 
            verdeRadio3.AutoSize = true;
            verdeRadio3.Location = new Point(168, 106);
            verdeRadio3.Name = "verdeRadio3";
            verdeRadio3.Size = new Size(72, 19);
            verdeRadio3.TabIndex = 4;
            verdeRadio3.Tag = "verde";
            verdeRadio3.Text = "Máquina";
            verdeRadio3.UseVisualStyleBackColor = true;
            // 
            // verdeRadio2
            // 
            verdeRadio2.AutoSize = true;
            verdeRadio2.Location = new Point(90, 106);
            verdeRadio2.Name = "verdeRadio2";
            verdeRadio2.Size = new Size(72, 19);
            verdeRadio2.TabIndex = 3;
            verdeRadio2.Tag = "verde";
            verdeRadio2.Text = "Humano";
            verdeRadio2.UseVisualStyleBackColor = true;
            // 
            // verdeRadio1
            // 
            verdeRadio1.AutoSize = true;
            verdeRadio1.Checked = true;
            verdeRadio1.Location = new Point(11, 106);
            verdeRadio1.Name = "verdeRadio1";
            verdeRadio1.Size = new Size(73, 19);
            verdeRadio1.TabIndex = 2;
            verdeRadio1.TabStop = true;
            verdeRadio1.Tag = "verde";
            verdeRadio1.Text = "No juega";
            verdeRadio1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 49);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Lime;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(266, 35);
            panel5.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(rojoText1);
            panel2.Controls.Add(rojoRadio3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(rojoRadio2);
            panel2.Controls.Add(rojoRadio1);
            panel2.Location = new Point(521, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(267, 144);
            panel2.TabIndex = 2;
            // 
            // rojoText1
            // 
            rojoText1.Location = new Point(72, 49);
            rojoText1.Name = "rojoText1";
            rojoText1.Size = new Size(169, 23);
            rojoText1.TabIndex = 10;
            // 
            // rojoRadio3
            // 
            rojoRadio3.AutoSize = true;
            rojoRadio3.Location = new Point(172, 109);
            rojoRadio3.Name = "rojoRadio3";
            rojoRadio3.Size = new Size(72, 19);
            rojoRadio3.TabIndex = 9;
            rojoRadio3.Tag = "rojo";
            rojoRadio3.Text = "Máquina";
            rojoRadio3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre:";
            // 
            // rojoRadio2
            // 
            rojoRadio2.AutoSize = true;
            rojoRadio2.Location = new Point(94, 109);
            rojoRadio2.Name = "rojoRadio2";
            rojoRadio2.Size = new Size(72, 19);
            rojoRadio2.TabIndex = 8;
            rojoRadio2.Tag = "rojo";
            rojoRadio2.Text = "Humano";
            rojoRadio2.UseVisualStyleBackColor = true;
            // 
            // rojoRadio1
            // 
            rojoRadio1.AutoSize = true;
            rojoRadio1.Checked = true;
            rojoRadio1.Location = new Point(15, 109);
            rojoRadio1.Name = "rojoRadio1";
            rojoRadio1.Size = new Size(73, 19);
            rojoRadio1.TabIndex = 7;
            rojoRadio1.TabStop = true;
            rojoRadio1.Tag = "rojo";
            rojoRadio1.Text = "No juega";
            rojoRadio1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(azulText1);
            panel3.Controls.Add(azulRadio3);
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(azulRadio1);
            panel3.Controls.Add(azulRadio2);
            panel3.Location = new Point(521, 293);
            panel3.Name = "panel3";
            panel3.Size = new Size(267, 145);
            panel3.TabIndex = 3;
            // 
            // azulText1
            // 
            azulText1.Location = new Point(75, 52);
            azulText1.Name = "azulText1";
            azulText1.Size = new Size(169, 23);
            azulText1.TabIndex = 15;
            // 
            // azulRadio3
            // 
            azulRadio3.AutoSize = true;
            azulRadio3.Location = new Point(175, 112);
            azulRadio3.Name = "azulRadio3";
            azulRadio3.Size = new Size(72, 19);
            azulRadio3.TabIndex = 14;
            azulRadio3.Tag = "azul";
            azulRadio3.Text = "Máquina";
            azulRadio3.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Blue;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(266, 35);
            panel7.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 55);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 11;
            label3.Text = "Nombre:";
            // 
            // azulRadio1
            // 
            azulRadio1.AutoSize = true;
            azulRadio1.Checked = true;
            azulRadio1.Location = new Point(18, 112);
            azulRadio1.Name = "azulRadio1";
            azulRadio1.Size = new Size(73, 19);
            azulRadio1.TabIndex = 12;
            azulRadio1.TabStop = true;
            azulRadio1.Tag = "azul";
            azulRadio1.Text = "No juega";
            azulRadio1.UseVisualStyleBackColor = true;
            // 
            // azulRadio2
            // 
            azulRadio2.AutoSize = true;
            azulRadio2.Location = new Point(97, 112);
            azulRadio2.Name = "azulRadio2";
            azulRadio2.Size = new Size(72, 19);
            azulRadio2.TabIndex = 13;
            azulRadio2.Tag = "azul";
            azulRadio2.Text = "Humano";
            azulRadio2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.BackColor = SystemColors.ButtonHighlight;
            panel4.Controls.Add(amarilloText1);
            panel4.Controls.Add(amarilloRadio3);
            panel4.Controls.Add(amarilloRadio2);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(amarilloRadio1);
            panel4.Location = new Point(12, 293);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 145);
            panel4.TabIndex = 4;
            // 
            // amarilloText1
            // 
            amarilloText1.Location = new Point(71, 52);
            amarilloText1.Name = "amarilloText1";
            amarilloText1.Size = new Size(169, 23);
            amarilloText1.TabIndex = 20;
            // 
            // amarilloRadio3
            // 
            amarilloRadio3.AutoSize = true;
            amarilloRadio3.Location = new Point(171, 112);
            amarilloRadio3.Name = "amarilloRadio3";
            amarilloRadio3.Size = new Size(72, 19);
            amarilloRadio3.TabIndex = 19;
            amarilloRadio3.Tag = "amarillo";
            amarilloRadio3.Text = "Máquina";
            amarilloRadio3.UseVisualStyleBackColor = true;
            // 
            // amarilloRadio2
            // 
            amarilloRadio2.AutoSize = true;
            amarilloRadio2.Location = new Point(93, 112);
            amarilloRadio2.Name = "amarilloRadio2";
            amarilloRadio2.Size = new Size(72, 19);
            amarilloRadio2.TabIndex = 18;
            amarilloRadio2.Tag = "amarillo";
            amarilloRadio2.Text = "Humano";
            amarilloRadio2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 55);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 16;
            label4.Text = "Nombre:";
            // 
            // amarilloRadio1
            // 
            amarilloRadio1.AutoSize = true;
            amarilloRadio1.Checked = true;
            amarilloRadio1.Location = new Point(14, 112);
            amarilloRadio1.Name = "amarilloRadio1";
            amarilloRadio1.Size = new Size(73, 19);
            amarilloRadio1.TabIndex = 17;
            amarilloRadio1.TabStop = true;
            amarilloRadio1.Tag = "amarillo";
            amarilloRadio1.Text = "No juega";
            amarilloRadio1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel6.BackColor = Color.Red;
            panel6.Location = new Point(521, 12);
            panel6.Name = "panel6";
            panel6.Size = new Size(266, 35);
            panel6.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.Yellow;
            panel8.Location = new Point(12, 293);
            panel8.Name = "panel8";
            panel8.Size = new Size(267, 35);
            panel8.TabIndex = 3;
            // 
            // FormSeleccionColor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(playLudo);
            MaximizeBox = false;
            Name = "FormSeleccionColor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormSeleccionColor";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button playLudo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private TextBox verdeText1;
        private RadioButton verdeRadio3;
        private RadioButton verdeRadio2;
        private RadioButton verdeRadio1;
        private Label label1;
        private TextBox rojoText1;
        private RadioButton rojoRadio3;
        private Label label2;
        private RadioButton rojoRadio2;
        private RadioButton rojoRadio1;
        private TextBox azulText1;
        private RadioButton azulRadio3;
        private Label label3;
        private RadioButton azulRadio1;
        private RadioButton azulRadio2;
        private TextBox amarilloText1;
        private RadioButton amarilloRadio3;
        private RadioButton amarilloRadio2;
        private Label label4;
        private RadioButton amarilloRadio1;
    }
}