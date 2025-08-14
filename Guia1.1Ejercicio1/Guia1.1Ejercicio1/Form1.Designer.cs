namespace Guia1._1Ejercicio1
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
            tbMarca = new TextBox();
            tbValorFabrica = new TextBox();
            tbDepreciacion = new TextBox();
            tbUtil = new TextBox();
            nupModelo = new NumericUpDown();
            nupAñoCalcular = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCalcularCosto = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nupModelo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nupAñoCalcular).BeginInit();
            SuspendLayout();
            // 
            // tbMarca
            // 
            tbMarca.Location = new Point(141, 48);
            tbMarca.Multiline = true;
            tbMarca.Name = "tbMarca";
            tbMarca.Size = new Size(164, 23);
            tbMarca.TabIndex = 0;
            // 
            // tbValorFabrica
            // 
            tbValorFabrica.Location = new Point(141, 160);
            tbValorFabrica.Multiline = true;
            tbValorFabrica.Name = "tbValorFabrica";
            tbValorFabrica.Size = new Size(164, 23);
            tbValorFabrica.TabIndex = 1;
            // 
            // tbDepreciacion
            // 
            tbDepreciacion.Location = new Point(470, 48);
            tbDepreciacion.Multiline = true;
            tbDepreciacion.Name = "tbDepreciacion";
            tbDepreciacion.Size = new Size(192, 23);
            tbDepreciacion.TabIndex = 2;
            // 
            // tbUtil
            // 
            tbUtil.Location = new Point(470, 160);
            tbUtil.Multiline = true;
            tbUtil.Name = "tbUtil";
            tbUtil.Size = new Size(192, 23);
            tbUtil.TabIndex = 3;
            // 
            // nupModelo
            // 
            nupModelo.Location = new Point(141, 86);
            nupModelo.Name = "nupModelo";
            nupModelo.Size = new Size(164, 23);
            nupModelo.TabIndex = 4;
            // 
            // nupAñoCalcular
            // 
            nupAñoCalcular.Location = new Point(141, 121);
            nupAñoCalcular.Name = "nupAñoCalcular";
            nupAñoCalcular.Size = new Size(164, 23);
            nupAñoCalcular.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 48);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 6;
            label1.Text = "Marca";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 86);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 123);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 10;
            label3.Text = "Año a calcular:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 163);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 12;
            label4.Text = "Valor de fabricacion:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(342, 48);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 14;
            label5.Text = "Tasa de depreciacion :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 163);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 16;
            label6.Text = "Vida Útil:";
            // 
            // btnCalcularCosto
            // 
            btnCalcularCosto.Location = new Point(188, 239);
            btnCalcularCosto.Name = "btnCalcularCosto";
            btnCalcularCosto.Size = new Size(93, 51);
            btnCalcularCosto.TabIndex = 17;
            btnCalcularCosto.Text = "Calcular Costo";
            btnCalcularCosto.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(437, 239);
            button2.Name = "button2";
            button2.Size = new Size(75, 51);
            button2.TabIndex = 18;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btnCalcularCosto);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nupAñoCalcular);
            Controls.Add(nupModelo);
            Controls.Add(tbUtil);
            Controls.Add(tbDepreciacion);
            Controls.Add(tbValorFabrica);
            Controls.Add(tbMarca);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nupModelo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nupAñoCalcular).EndInit();
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
        private Button btnCalcularCosto;
        private Button button2;
        public TextBox tbMarca;
        public TextBox tbValorFabrica;
        public TextBox tbDepreciacion;
        public TextBox tbUtil;
        public NumericUpDown nupModelo;
        public NumericUpDown nupAñoCalcular;
    }
}
