﻿namespace Guia1._1Ejercicio3
{
    partial class FormCargaPeaje
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
            nupDia = new NumericUpDown();
            tbVehiculos = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nupDia).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 54);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 0;
            label1.Text = "Dias :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 156);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 1;
            label2.Text = "Cantidad Autos :";
            // 
            // nupDia
            // 
            nupDia.Location = new Point(146, 52);
            nupDia.Name = "nupDia";
            nupDia.Size = new Size(120, 23);
            nupDia.TabIndex = 2;
            // 
            // tbVehiculos
            // 
            tbVehiculos.Location = new Point(184, 153);
            tbVehiculos.Name = "tbVehiculos";
            tbVehiculos.Size = new Size(100, 23);
            tbVehiculos.TabIndex = 3;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(277, 243);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.OK;
            button2.Location = new Point(86, 243);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "Aceptar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormCargaPeaje
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbVehiculos);
            Controls.Add(nupDia);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormCargaPeaje";
            Text = "FormCargaPeaje";
            ((System.ComponentModel.ISupportInitialize)nupDia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDown1;
        public Button button1;
        public Button button2;
        public NumericUpDown nupDia;
        public TextBox tbVehiculos;
    }
}