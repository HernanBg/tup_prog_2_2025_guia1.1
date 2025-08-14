namespace Guia1._1Ejercicio3
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
            lbVer = new ListBox();
            btnRegistrarPeaje = new Button();
            btnVer = new Button();
            SuspendLayout();
            // 
            // lbVer
            // 
            lbVer.FormattingEnabled = true;
            lbVer.ItemHeight = 15;
            lbVer.Location = new Point(53, 57);
            lbVer.MultiColumn = true;
            lbVer.Name = "lbVer";
            lbVer.Size = new Size(325, 259);
            lbVer.TabIndex = 0;
            // 
            // btnRegistrarPeaje
            // 
            btnRegistrarPeaje.Location = new Point(434, 69);
            btnRegistrarPeaje.Name = "btnRegistrarPeaje";
            btnRegistrarPeaje.Size = new Size(75, 52);
            btnRegistrarPeaje.TabIndex = 1;
            btnRegistrarPeaje.Text = "Registrar Peaje";
            btnRegistrarPeaje.UseVisualStyleBackColor = true;
            btnRegistrarPeaje.Click += button1_Click;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(434, 185);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(75, 53);
            btnVer.TabIndex = 2;
            btnVer.Text = "Ver Resumen";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVer);
            Controls.Add(btnRegistrarPeaje);
            Controls.Add(lbVer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        public ListBox lbVer;
        private Button btnRegistrarPeaje;
        public Button btnVer;
    }
}
