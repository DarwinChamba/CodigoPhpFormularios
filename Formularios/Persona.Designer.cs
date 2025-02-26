namespace Formularios
{
    partial class Persona
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cualquiernombre1 = new System.Windows.Forms.TextBox();
            this.cualquiernombredelavariable2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese su nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese su edad";
            // 
            // cualquiernombre1
            // 
            this.cualquiernombre1.Location = new System.Drawing.Point(115, 55);
            this.cualquiernombre1.Name = "cualquiernombre1";
            this.cualquiernombre1.Size = new System.Drawing.Size(100, 20);
            this.cualquiernombre1.TabIndex = 2;
            // 
            // cualquiernombredelavariable2
            // 
            this.cualquiernombredelavariable2.Location = new System.Drawing.Point(115, 123);
            this.cualquiernombredelavariable2.Name = "cualquiernombredelavariable2";
            this.cualquiernombredelavariable2.Size = new System.Drawing.Size(100, 20);
            this.cualquiernombredelavariable2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(115, 216);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(100, 23);
            this.btnMostrarLista.TabIndex = 5;
            this.btnMostrarLista.Text = "mostrar lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // Persona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 424);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cualquiernombredelavariable2);
            this.Controls.Add(this.cualquiernombre1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Persona";
            this.Text = "Persona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cualquiernombre1;
        private System.Windows.Forms.TextBox cualquiernombredelavariable2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnMostrarLista;
    }
}