namespace Practica6
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bnEncender = new System.Windows.Forms.Button();
            this.bnApagar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bnEncender
            // 
            this.bnEncender.Location = new System.Drawing.Point(302, 102);
            this.bnEncender.Name = "bnEncender";
            this.bnEncender.Size = new System.Drawing.Size(179, 108);
            this.bnEncender.TabIndex = 0;
            this.bnEncender.Text = "Encender";
            this.bnEncender.UseVisualStyleBackColor = true;
            this.bnEncender.Click += new System.EventHandler(this.bnEncender_Click);
            // 
            // bnApagar
            // 
            this.bnApagar.Location = new System.Drawing.Point(302, 263);
            this.bnApagar.Name = "bnApagar";
            this.bnApagar.Size = new System.Drawing.Size(179, 64);
            this.bnApagar.TabIndex = 1;
            this.bnApagar.Text = "Apagar";
            this.bnApagar.UseVisualStyleBackColor = true;
            this.bnApagar.Click += new System.EventHandler(this.bnApagar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bnApagar);
            this.Controls.Add(this.bnEncender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.CerrandoForm1_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bnEncender;
        private System.Windows.Forms.Button bnApagar;
    }
}

