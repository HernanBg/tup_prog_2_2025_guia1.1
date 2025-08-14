namespace Guia1._1Ejercicio2
{
    partial class FormInforme
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
            ltbResultados = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 71);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Informe";
            // 
            // ltbResultados
            // 
            ltbResultados.FormattingEnabled = true;
            ltbResultados.ItemHeight = 15;
            ltbResultados.Location = new Point(63, 98);
            ltbResultados.Name = "ltbResultados";
            ltbResultados.Size = new Size(423, 244);
            ltbResultados.TabIndex = 1;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.Cancel;
            button1.Location = new Point(214, 371);
            button1.Name = "button1";
            button1.Size = new Size(123, 44);
            button1.TabIndex = 2;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormInforme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ltbResultados);
            Controls.Add(label1);
            Name = "FormInforme";
            Text = "Informe";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public ListBox ltbResultados;
        public Label label1;
        public Button button1;
    }
}