namespace CalculadoraDerivadas
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
            this.lblFuncion = new System.Windows.Forms.Label();
            this.txtFuncion = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnDerivar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFuncion
            // 
            this.lblFuncion.AutoSize = true;
            this.lblFuncion.Location = new System.Drawing.Point(55, 65);
            this.lblFuncion.Name = "lblFuncion";
            this.lblFuncion.Size = new System.Drawing.Size(48, 13);
            this.lblFuncion.TabIndex = 0;
            this.lblFuncion.Text = "Funcion:";
            // 
            // txtFuncion
            // 
            this.txtFuncion.Location = new System.Drawing.Point(109, 62);
            this.txtFuncion.Name = "txtFuncion";
            this.txtFuncion.Size = new System.Drawing.Size(520, 20);
            this.txtFuncion.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(327, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 13);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Calculadora de Derivadas";
            // 
            // btnDerivar
            // 
            this.btnDerivar.Location = new System.Drawing.Point(635, 60);
            this.btnDerivar.Name = "btnDerivar";
            this.btnDerivar.Size = new System.Drawing.Size(75, 23);
            this.btnDerivar.TabIndex = 3;
            this.btnDerivar.Text = "Derivar";
            this.btnDerivar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDerivar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtFuncion);
            this.Controls.Add(this.lblFuncion);
            this.Name = "Form1";
            this.Text = "jhno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFuncion;
        private System.Windows.Forms.TextBox txtFuncion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnDerivar;
    }
}

