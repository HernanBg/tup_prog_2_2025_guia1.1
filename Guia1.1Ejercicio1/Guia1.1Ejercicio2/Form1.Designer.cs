namespace Guia1._1Ejercicio2
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
            btnIniciar = new Button();
            btnIngresadaParada = new Button();
            label1 = new Label();
            label2 = new Label();
            tbMLLegada = new TextBox();
            tbHLLegada = new TextBox();
            label3 = new Label();
            btnFinalizar = new Button();
            SuspendLayout();
            // 
            // btnIniciar
            // 
            btnIniciar.DialogResult = DialogResult.OK;
            btnIniciar.Location = new Point(112, 52);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(193, 36);
            btnIniciar.TabIndex = 0;
            btnIniciar.Text = "Iniciar Viaje";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnIngresadaParada
            // 
            btnIngresadaParada.Location = new Point(112, 125);
            btnIngresadaParada.Name = "btnIngresadaParada";
            btnIngresadaParada.Size = new Size(193, 35);
            btnIngresadaParada.TabIndex = 1;
            btnIngresadaParada.Text = "Ingresa Parada";
            btnIngresadaParada.UseVisualStyleBackColor = true;
            btnIngresadaParada.Click += btnIngresadaParada_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(112, 225);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 2;
            label1.Text = "Finalizar Parada";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 269);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 3;
            label2.Text = "Hora de Finalizacion (MM:HH)";
            // 
            // tbMLLegada
            // 
            tbMLLegada.Location = new Point(428, 266);
            tbMLLegada.Name = "tbMLLegada";
            tbMLLegada.Size = new Size(80, 23);
            tbMLLegada.TabIndex = 4;
            // 
            // tbHLLegada
            // 
            tbHLLegada.Location = new Point(326, 266);
            tbHLLegada.Name = "tbHLLegada";
            tbHLLegada.Size = new Size(80, 23);
            tbHLLegada.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(412, 269);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 6;
            label3.Text = ":";
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(342, 322);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(155, 23);
            btnFinalizar.TabIndex = 7;
            btnFinalizar.Text = "Finalizar Viaje";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFinalizar);
            Controls.Add(label3);
            Controls.Add(tbHLLegada);
            Controls.Add(tbMLLegada);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnIngresadaParada);
            Controls.Add(btnIniciar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btnIniciar;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Button button3;
        public Button btnIngresadaParada;
        public Button btnFinalizar;
        public TextBox tbHLLegada;
        public TextBox tbMLLegada;
    }
}
