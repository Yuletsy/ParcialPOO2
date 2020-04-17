namespace Funciones.Parcial
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
            this.buttonDivr = new System.Windows.Forms.Button();
            this.buttonMultp = new System.Windows.Forms.Button();
            this.buttonFact = new System.Windows.Forms.Button();
            this.buttonFibon = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.textBoxEntrada = new System.Windows.Forms.TextBox();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonSerie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDivr
            // 
            this.buttonDivr.Location = new System.Drawing.Point(76, 118);
            this.buttonDivr.Name = "buttonDivr";
            this.buttonDivr.Size = new System.Drawing.Size(167, 45);
            this.buttonDivr.TabIndex = 0;
            this.buttonDivr.Text = "Divisores";
            this.buttonDivr.UseVisualStyleBackColor = true;
            this.buttonDivr.Click += new System.EventHandler(this.buttonDivr_Click);
            // 
            // buttonMultp
            // 
            this.buttonMultp.Location = new System.Drawing.Point(249, 118);
            this.buttonMultp.Name = "buttonMultp";
            this.buttonMultp.Size = new System.Drawing.Size(167, 45);
            this.buttonMultp.TabIndex = 1;
            this.buttonMultp.Text = "Multiplos";
            this.buttonMultp.UseVisualStyleBackColor = true;
            this.buttonMultp.Click += new System.EventHandler(this.buttonMultp_Click);
            // 
            // buttonFact
            // 
            this.buttonFact.Location = new System.Drawing.Point(76, 169);
            this.buttonFact.Name = "buttonFact";
            this.buttonFact.Size = new System.Drawing.Size(167, 45);
            this.buttonFact.TabIndex = 2;
            this.buttonFact.Text = "Factorial";
            this.buttonFact.UseVisualStyleBackColor = true;
            this.buttonFact.Click += new System.EventHandler(this.buttonFact_Click);
            // 
            // buttonFibon
            // 
            this.buttonFibon.Location = new System.Drawing.Point(249, 169);
            this.buttonFibon.Name = "buttonFibon";
            this.buttonFibon.Size = new System.Drawing.Size(167, 45);
            this.buttonFibon.TabIndex = 3;
            this.buttonFibon.Text = "Fibonacci";
            this.buttonFibon.UseVisualStyleBackColor = true;
            this.buttonFibon.Click += new System.EventHandler(this.buttonFibon_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.Location = new System.Drawing.Point(249, 220);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(167, 45);
            this.buttonBorrar.TabIndex = 4;
            this.buttonBorrar.Text = "AC";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(422, 118);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(52, 147);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "Out";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // textBoxEntrada
            // 
            this.textBoxEntrada.Location = new System.Drawing.Point(76, 83);
            this.textBoxEntrada.Name = "textBoxEntrada";
            this.textBoxEntrada.Size = new System.Drawing.Size(103, 22);
            this.textBoxEntrada.TabIndex = 6;
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(185, 83);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(289, 22);
            this.textBoxResult.TabIndex = 7;
            // 
            // buttonSerie
            // 
            this.buttonSerie.Location = new System.Drawing.Point(76, 220);
            this.buttonSerie.Name = "buttonSerie";
            this.buttonSerie.Size = new System.Drawing.Size(167, 45);
            this.buttonSerie.TabIndex = 8;
            this.buttonSerie.Text = "Y = X^2";
            this.buttonSerie.UseVisualStyleBackColor = true;
            this.buttonSerie.Click += new System.EventHandler(this.buttonSerie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSerie);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxEntrada);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonFibon);
            this.Controls.Add(this.buttonFact);
            this.Controls.Add(this.buttonMultp);
            this.Controls.Add(this.buttonDivr);
            this.Name = "Form1";
            this.Text = "Funciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDivr;
        private System.Windows.Forms.Button buttonMultp;
        private System.Windows.Forms.Button buttonFact;
        private System.Windows.Forms.Button buttonFibon;
        private System.Windows.Forms.Button buttonBorrar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.TextBox textBoxEntrada;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonSerie;
    }
}

