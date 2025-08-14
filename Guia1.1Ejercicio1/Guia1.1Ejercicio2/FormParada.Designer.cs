namespace Guia1._1Ejercicio2
{
    partial class FormParada
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbHLLegadaParada = new TextBox();
            tbHSalidaParada = new TextBox();
            tbMLLegadaParada = new TextBox();
            tbMSalidaParada = new TextBox();
            tbAscienden = new TextBox();
            tbDescienden = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 26);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Parada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 92);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 1;
            label2.Text = "Llegada(HH:MM)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 141);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 2;
            label3.Text = "Salida(HH:MM)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 185);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 3;
            label4.Text = "Ascienden";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 226);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 4;
            label5.Text = "Descienden";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 95);
            label6.Name = "label6";
            label6.Size = new Size(10, 15);
            label6.TabIndex = 5;
            label6.Text = ":";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(213, 144);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 6;
            label7.Text = ":";
            // 
            // tbHLLegadaParada
            // 
            tbHLLegadaParada.Location = new Point(149, 89);
            tbHLLegadaParada.Name = "tbHLLegadaParada";
            tbHLLegadaParada.Size = new Size(58, 23);
            tbHLLegadaParada.TabIndex = 7;
            tbHLLegadaParada.TextChanged += thHLLegadaParada_TextChanged;
            // 
            // tbHSalidaParada
            // 
            tbHSalidaParada.Location = new Point(149, 141);
            tbHSalidaParada.Name = "tbHSalidaParada";
            tbHSalidaParada.Size = new Size(58, 23);
            tbHSalidaParada.TabIndex = 8;
            // 
            // tbMLLegadaParada
            // 
            tbMLLegadaParada.Location = new Point(229, 92);
            tbMLLegadaParada.Name = "tbMLLegadaParada";
            tbMLLegadaParada.Size = new Size(58, 23);
            tbMLLegadaParada.TabIndex = 9;
            // 
            // tbMSalidaParada
            // 
            tbMSalidaParada.Location = new Point(229, 141);
            tbMSalidaParada.Name = "tbMSalidaParada";
            tbMSalidaParada.Size = new Size(58, 23);
            tbMSalidaParada.TabIndex = 10;
            // 
            // tbAscienden
            // 
            tbAscienden.Location = new Point(149, 185);
            tbAscienden.Name = "tbAscienden";
            tbAscienden.Size = new Size(138, 23);
            tbAscienden.TabIndex = 11;
            // 
            // tbDescienden
            // 
            tbDescienden.Location = new Point(149, 226);
            tbDescienden.Name = "tbDescienden";
            tbDescienden.Size = new Size(138, 23);
            tbDescienden.TabIndex = 12;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(132, 287);
            button1.Name = "button1";
            button1.Size = new Size(75, 50);
            button1.TabIndex = 13;
            button1.Text = "Ingresada Parada";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(229, 287);
            button2.Name = "button2";
            button2.Size = new Size(75, 50);
            button2.TabIndex = 14;
            button2.Text = "Ingresada Parada";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormParada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbDescienden);
            Controls.Add(tbAscienden);
            Controls.Add(tbMSalidaParada);
            Controls.Add(tbMLLegadaParada);
            Controls.Add(tbHSalidaParada);
            Controls.Add(tbHLLegadaParada);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormParada";
            Text = "DatosParada";
            Load += FormParada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox tbMInicio;
        private TextBox textBox4;
        public TextBox tbHLLegadaParada;
        public TextBox tbMLLegadaParada;
        public TextBox tbHSalidaParada;
        public TextBox tbMSalidaParada;
        public TextBox tbAscienden;
        public TextBox tbDescienden;
        public Button button1;
        public Button button2;
    }
}