namespace pryLP2EstructuraRegistro
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
            this.gbCargaDatos = new System.Windows.Forms.GroupBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtLimCredito = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblLimCredito = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbCargaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCargaDatos
            // 
            this.gbCargaDatos.Controls.Add(this.cmdCargar);
            this.gbCargaDatos.Controls.Add(this.txtLimCredito);
            this.gbCargaDatos.Controls.Add(this.txtUsuario);
            this.gbCargaDatos.Controls.Add(this.txtDeuda);
            this.gbCargaDatos.Controls.Add(this.txtCodigo);
            this.gbCargaDatos.Controls.Add(this.lblLimCredito);
            this.gbCargaDatos.Controls.Add(this.lblDeuda);
            this.gbCargaDatos.Controls.Add(this.lblUsuario);
            this.gbCargaDatos.Controls.Add(this.lblCodigo);
            this.gbCargaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCargaDatos.Location = new System.Drawing.Point(31, 15);
            this.gbCargaDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCargaDatos.Size = new System.Drawing.Size(709, 215);
            this.gbCargaDatos.TabIndex = 0;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de datos";
            this.gbCargaDatos.Enter += new System.EventHandler(this.gbCargaDatos_Enter);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(520, 171);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(155, 37);
            this.cmdCargar.TabIndex = 8;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtLimCredito
            // 
            this.txtLimCredito.Location = new System.Drawing.Point(497, 112);
            this.txtLimCredito.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLimCredito.Name = "txtLimCredito";
            this.txtLimCredito.Size = new System.Drawing.Size(176, 26);
            this.txtLimCredito.TabIndex = 7;
            this.txtLimCredito.TextChanged += new System.EventHandler(this.txtLimCredito_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(497, 36);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(176, 26);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(97, 112);
            this.txtDeuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(176, 26);
            this.txtDeuda.TabIndex = 5;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(176, 26);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblLimCredito
            // 
            this.lblLimCredito.AutoSize = true;
            this.lblLimCredito.Location = new System.Drawing.Point(345, 119);
            this.lblLimCredito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLimCredito.Name = "lblLimCredito";
            this.lblLimCredito.Size = new System.Drawing.Size(139, 20);
            this.lblLimCredito.TabIndex = 3;
            this.lblLimCredito.Text = "Límite de crédito:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(21, 119);
            this.lblDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(63, 20);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(399, 39);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(72, 20);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(21, 39);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(66, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(435, 598);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 16);
            this.lblTotal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 260);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.gbCargaDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCargaDatos;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtLimCredito;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblLimCredito;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Label lblTotal;
    }
}

