namespace Guia1._1Ejercicio2
{
    partial class FormInicio
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
            components = new System.ComponentModel.Container();
            tbContinuar = new Button();
            btnCerrar = new Button();
            label1 = new Label();
            label4 = new Label();
            tbHInicio = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tbMInicio = new TextBox();
            label2 = new Label();
            tbAsientos = new TextBox();
            SuspendLayout();
            // 
            // tbContinuar
            // 
            tbContinuar.DialogResult = DialogResult.OK;
            tbContinuar.Location = new Point(146, 213);
            tbContinuar.Name = "tbContinuar";
            tbContinuar.Size = new Size(75, 23);
            tbContinuar.TabIndex = 0;
            tbContinuar.Text = "Continuar";
            tbContinuar.UseVisualStyleBackColor = true;
            tbContinuar.Click += tbContinuar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(297, 213);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(87, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(-1, 111);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 2;
            label1.Text = "Hora de Inicio (HH : MM)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(209, 111);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 5;
            label4.Text = ":";
            // 
            // tbHInicio
            // 
            tbHInicio.Location = new Point(146, 108);
            tbHInicio.Name = "tbHInicio";
            tbHInicio.Size = new Size(57, 23);
            tbHInicio.TabIndex = 6;
            tbHInicio.TextChanged += textBox1_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tbMInicio
            // 
            tbMInicio.Location = new Point(221, 108);
            tbMInicio.Name = "tbMInicio";
            tbMInicio.Size = new Size(58, 23);
            tbMInicio.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 167);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 9;
            label2.Text = "Asientos :";
            label2.Click += label2_Click;
            // 
            // tbAsientos
            // 
            tbAsientos.Location = new Point(146, 159);
            tbAsientos.Name = "tbAsientos";
            tbAsientos.Size = new Size(133, 23);
            tbAsientos.TabIndex = 10;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbAsientos);
            Controls.Add(label2);
            Controls.Add(tbMInicio);
            Controls.Add(tbHInicio);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnCerrar);
            Controls.Add(tbContinuar);
            Name = "FormInicio";
            Text = "FormInicio";
            Load += FormInicio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Continuar;
        private Label label1;
        private Label label4;
        private ContextMenuStrip contextMenuStrip1;
        public TextBox tbHInicio;
        public TextBox tbMInicio;
        private Label label2;
        public TextBox tbAsientos;
        public Button tbContinuar;
        public Button btnCerrar;
        private TextBox textBox2;
    }
}