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
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lblTotDeuda = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmdDeudores = new System.Windows.Forms.Button();
            this.gbCargaDatos.SuspendLayout();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
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
            this.gbCargaDatos.Location = new System.Drawing.Point(23, 12);
            this.gbCargaDatos.Name = "gbCargaDatos";
            this.gbCargaDatos.Size = new System.Drawing.Size(532, 175);
            this.gbCargaDatos.TabIndex = 0;
            this.gbCargaDatos.TabStop = false;
            this.gbCargaDatos.Text = "Carga de datos";
            this.gbCargaDatos.Enter += new System.EventHandler(this.gbCargaDatos_Enter);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCargar.Location = new System.Drawing.Point(390, 139);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(116, 30);
            this.cmdCargar.TabIndex = 8;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // txtLimCredito
            // 
            this.txtLimCredito.Location = new System.Drawing.Point(373, 91);
            this.txtLimCredito.Name = "txtLimCredito";
            this.txtLimCredito.Size = new System.Drawing.Size(133, 22);
            this.txtLimCredito.TabIndex = 7;
            this.txtLimCredito.TextChanged += new System.EventHandler(this.txtLimCredito_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(373, 29);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(133, 22);
            this.txtUsuario.TabIndex = 6;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(73, 91);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(133, 22);
            this.txtDeuda.TabIndex = 5;
            this.txtDeuda.TextChanged += new System.EventHandler(this.txtDeuda_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(77, 27);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(133, 22);
            this.txtCodigo.TabIndex = 4;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // lblLimCredito
            // 
            this.lblLimCredito.AutoSize = true;
            this.lblLimCredito.Location = new System.Drawing.Point(259, 97);
            this.lblLimCredito.Name = "lblLimCredito";
            this.lblLimCredito.Size = new System.Drawing.Size(108, 16);
            this.lblLimCredito.TabIndex = 3;
            this.lblLimCredito.Text = "Límite de crédito:";
            // 
            // lblDeuda
            // 
            this.lblDeuda.AutoSize = true;
            this.lblDeuda.Location = new System.Drawing.Point(16, 97);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(51, 16);
            this.lblDeuda.TabIndex = 2;
            this.lblDeuda.Text = "Deuda:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(299, 32);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 32);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(54, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.dgvConsulta);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(23, 209);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(532, 246);
            this.gbConsulta.TabIndex = 9;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de Datos";
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigo,
            this.clUsuario,
            this.clLimCredito,
            this.clDeuda});
            this.dgvConsulta.Location = new System.Drawing.Point(6, 25);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(520, 206);
            this.dgvConsulta.TabIndex = 9;
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 120;
            // 
            // clUsuario
            // 
            this.clUsuario.HeaderText = "Usuario";
            this.clUsuario.Name = "clUsuario";
            this.clUsuario.Width = 120;
            // 
            // clLimCredito
            // 
            this.clLimCredito.HeaderText = "Límite de crédito";
            this.clLimCredito.Name = "clLimCredito";
            this.clLimCredito.Width = 120;
            // 
            // clDeuda
            // 
            this.clDeuda.HeaderText = "Deuda";
            this.clDeuda.Name = "clDeuda";
            this.clDeuda.Width = 120;
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(433, 525);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(116, 30);
            this.cmdListar.TabIndex = 8;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lblTotDeuda
            // 
            this.lblTotDeuda.AutoSize = true;
            this.lblTotDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotDeuda.Location = new System.Drawing.Point(222, 482);
            this.lblTotDeuda.Name = "lblTotDeuda";
            this.lblTotDeuda.Size = new System.Drawing.Size(89, 18);
            this.lblTotDeuda.TabIndex = 9;
            this.lblTotDeuda.Text = "Total deuda:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(326, 486);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // cmdDeudores
            // 
            this.cmdDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeudores.Location = new System.Drawing.Point(285, 525);
            this.cmdDeudores.Name = "cmdDeudores";
            this.cmdDeudores.Size = new System.Drawing.Size(116, 30);
            this.cmdDeudores.TabIndex = 11;
            this.cmdDeudores.Text = "Deudores";
            this.cmdDeudores.UseVisualStyleBackColor = true;
            this.cmdDeudores.Click += new System.EventHandler(this.cmdDeudores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 567);
            this.Controls.Add(this.cmdDeudores);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotDeuda);
            this.Controls.Add(this.gbConsulta);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.gbCargaDatos);
            this.Name = "Form1";
            this.Text = "Gestion de Clientes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCargaDatos.ResumeLayout(false);
            this.gbCargaDatos.PerformLayout();
            this.gbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
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
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
        private System.Windows.Forms.Label lblTotDeuda;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button cmdDeudores;
    }
}

