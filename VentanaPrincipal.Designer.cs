namespace Pablo_Caneva_parcial
{
    partial class VentanaPrincipal
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
            this.btnClienteNuevo = new System.Windows.Forms.Button();
            this.btnOperaciones = new System.Windows.Forms.Button();
            this.btnSaldoTesoreria = new System.Windows.Forms.Button();
            this.btnCerrarPrograma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClienteNuevo
            // 
            this.btnClienteNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnClienteNuevo.Name = "btnClienteNuevo";
            this.btnClienteNuevo.Size = new System.Drawing.Size(401, 211);
            this.btnClienteNuevo.TabIndex = 0;
            this.btnClienteNuevo.Text = "Cliente Nuevo";
            this.btnClienteNuevo.UseVisualStyleBackColor = true;
            this.btnClienteNuevo.Click += new System.EventHandler(this.btnClienteNuevo_Click);
            // 
            // btnOperaciones
            // 
            this.btnOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperaciones.Location = new System.Drawing.Point(419, 12);
            this.btnOperaciones.Name = "btnOperaciones";
            this.btnOperaciones.Size = new System.Drawing.Size(369, 211);
            this.btnOperaciones.TabIndex = 1;
            this.btnOperaciones.Text = "Operaciones";
            this.btnOperaciones.UseVisualStyleBackColor = true;
            this.btnOperaciones.Click += new System.EventHandler(this.btnOperaciones_Click);
            // 
            // btnSaldoTesoreria
            // 
            this.btnSaldoTesoreria.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaldoTesoreria.Location = new System.Drawing.Point(13, 229);
            this.btnSaldoTesoreria.Name = "btnSaldoTesoreria";
            this.btnSaldoTesoreria.Size = new System.Drawing.Size(400, 209);
            this.btnSaldoTesoreria.TabIndex = 2;
            this.btnSaldoTesoreria.Text = "Saldo Tesoreria";
            this.btnSaldoTesoreria.UseVisualStyleBackColor = true;
            this.btnSaldoTesoreria.Click += new System.EventHandler(this.btnSaldoTesoreria_Click);
            // 
            // btnCerrarPrograma
            // 
            this.btnCerrarPrograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarPrograma.Location = new System.Drawing.Point(419, 229);
            this.btnCerrarPrograma.Name = "btnCerrarPrograma";
            this.btnCerrarPrograma.Size = new System.Drawing.Size(368, 208);
            this.btnCerrarPrograma.TabIndex = 3;
            this.btnCerrarPrograma.Text = "Cerrar Programa";
            this.btnCerrarPrograma.UseVisualStyleBackColor = true;
            this.btnCerrarPrograma.Click += new System.EventHandler(this.btnCerrarPrograma_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarPrograma);
            this.Controls.Add(this.btnSaldoTesoreria);
            this.Controls.Add(this.btnOperaciones);
            this.Controls.Add(this.btnClienteNuevo);
            this.Name = "VentanaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClienteNuevo;
        private System.Windows.Forms.Button btnOperaciones;
        private System.Windows.Forms.Button btnSaldoTesoreria;
        private System.Windows.Forms.Button btnCerrarPrograma;
    }
}

