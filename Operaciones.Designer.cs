namespace Pablo_Caneva_parcial
{
    partial class Operaciones
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnSaldo = new System.Windows.Forms.Button();
            this.btnExtraer = new System.Windows.Forms.Button();
            this.btnDepositar = new System.Windows.Forms.Button();
            this.comboCuenta = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textMonto = new System.Windows.Forms.TextBox();
            this.textDias = new System.Windows.Forms.TextBox();
            this.btnSimularPF = new System.Windows.Forms.Button();
            this.btnPlazoFijo = new System.Windows.Forms.Button();
            this.textDiasPF = new System.Windows.Forms.TextBox();
            this.textMontoPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(13, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDepositar);
            this.tabPage1.Controls.Add(this.btnExtraer);
            this.tabPage1.Controls.Add(this.btnSaldo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(767, 367);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuenta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSimularPF);
            this.tabPage2.Controls.Add(this.textDias);
            this.tabPage2.Controls.Add(this.textMonto);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(767, 367);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simulador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnPlazoFijo);
            this.tabPage3.Controls.Add(this.textDiasPF);
            this.tabPage3.Controls.Add(this.textMontoPF);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(767, 367);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Inversiones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnSaldo
            // 
            this.btnSaldo.Location = new System.Drawing.Point(295, 6);
            this.btnSaldo.Name = "btnSaldo";
            this.btnSaldo.Size = new System.Drawing.Size(166, 60);
            this.btnSaldo.TabIndex = 0;
            this.btnSaldo.Text = "Consultar Saldo";
            this.btnSaldo.UseVisualStyleBackColor = true;
            this.btnSaldo.Click += new System.EventHandler(this.btnSaldo_Click);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(295, 301);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.Size = new System.Drawing.Size(166, 60);
            this.btnExtraer.TabIndex = 1;
            this.btnExtraer.Text = "Extraer";
            this.btnExtraer.UseVisualStyleBackColor = true;
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // btnDepositar
            // 
            this.btnDepositar.Location = new System.Drawing.Point(295, 153);
            this.btnDepositar.Name = "btnDepositar";
            this.btnDepositar.Size = new System.Drawing.Size(166, 60);
            this.btnDepositar.TabIndex = 2;
            this.btnDepositar.Text = "Depositar";
            this.btnDepositar.UseVisualStyleBackColor = true;
            this.btnDepositar.Click += new System.EventHandler(this.btnDepositar_Click);
            // 
            // comboCuenta
            // 
            this.comboCuenta.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboCuenta.FormattingEnabled = true;
            this.comboCuenta.Location = new System.Drawing.Point(108, 10);
            this.comboCuenta.Name = "comboCuenta";
            this.comboCuenta.Size = new System.Drawing.Size(676, 24);
            this.comboCuenta.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cuenta Nro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monto a depositar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(123, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dias de duracion";
            // 
            // textMonto
            // 
            this.textMonto.Location = new System.Drawing.Point(126, 86);
            this.textMonto.Name = "textMonto";
            this.textMonto.Size = new System.Drawing.Size(155, 22);
            this.textMonto.TabIndex = 2;
            // 
            // textDias
            // 
            this.textDias.Location = new System.Drawing.Point(126, 186);
            this.textDias.MaxLength = 3;
            this.textDias.Name = "textDias";
            this.textDias.Size = new System.Drawing.Size(155, 22);
            this.textDias.TabIndex = 3;
            // 
            // btnSimularPF
            // 
            this.btnSimularPF.Location = new System.Drawing.Point(620, 306);
            this.btnSimularPF.Name = "btnSimularPF";
            this.btnSimularPF.Size = new System.Drawing.Size(141, 55);
            this.btnSimularPF.TabIndex = 4;
            this.btnSimularPF.Text = "Simular Plazo Fijo";
            this.btnSimularPF.UseVisualStyleBackColor = true;
            this.btnSimularPF.Click += new System.EventHandler(this.btnSimularPF_Click);
            // 
            // btnPlazoFijo
            // 
            this.btnPlazoFijo.Location = new System.Drawing.Point(623, 309);
            this.btnPlazoFijo.Name = "btnPlazoFijo";
            this.btnPlazoFijo.Size = new System.Drawing.Size(141, 55);
            this.btnPlazoFijo.TabIndex = 9;
            this.btnPlazoFijo.Text = "Realizar Plazo Fijo";
            this.btnPlazoFijo.UseVisualStyleBackColor = true;
            this.btnPlazoFijo.Click += new System.EventHandler(this.btnPlazoFijo_Click);
            // 
            // textDiasPF
            // 
            this.textDiasPF.Location = new System.Drawing.Point(129, 189);
            this.textDiasPF.MaxLength = 3;
            this.textDiasPF.Name = "textDiasPF";
            this.textDiasPF.Size = new System.Drawing.Size(155, 22);
            this.textDiasPF.TabIndex = 8;
            // 
            // textMontoPF
            // 
            this.textMontoPF.Location = new System.Drawing.Point(129, 89);
            this.textMontoPF.Name = "textMontoPF";
            this.textMontoPF.Size = new System.Drawing.Size(155, 22);
            this.textMontoPF.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Dias de duracion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Monto a depositar";
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCuenta);
            this.Controls.Add(this.tabControl1);
            this.Name = "Operaciones";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnDepositar;
        private System.Windows.Forms.Button btnExtraer;
        private System.Windows.Forms.Button btnSaldo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox comboCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimularPF;
        private System.Windows.Forms.TextBox textDias;
        private System.Windows.Forms.TextBox textMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPlazoFijo;
        private System.Windows.Forms.TextBox textDiasPF;
        private System.Windows.Forms.TextBox textMontoPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}