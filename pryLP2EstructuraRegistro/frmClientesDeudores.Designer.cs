namespace pryLP2EstructuraRegistro
{
    partial class frmClientesDeudores
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
            this.lblPromDeuda1 = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblCantClientes1 = new System.Windows.Forms.Label();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblTotalDeuda1 = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListarDeudores = new System.Windows.Forms.Button();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromDeuda1
            // 
            this.lblPromDeuda1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeuda1.Location = new System.Drawing.Point(362, 362);
            this.lblPromDeuda1.Name = "lblPromDeuda1";
            this.lblPromDeuda1.Size = new System.Drawing.Size(143, 26);
            this.lblPromDeuda1.TabIndex = 26;
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(211, 370);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(141, 18);
            this.lblPromDeuda.TabIndex = 25;
            this.lblPromDeuda.Text = "Promedio de deuda:";
            // 
            // lblCantClientes1
            // 
            this.lblCantClientes1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClientes1.Location = new System.Drawing.Point(362, 321);
            this.lblCantClientes1.Name = "lblCantClientes1";
            this.lblCantClientes1.Size = new System.Drawing.Size(143, 26);
            this.lblCantClientes1.TabIndex = 24;
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.Location = new System.Drawing.Point(211, 329);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(144, 18);
            this.lblCantClientes.TabIndex = 23;
            this.lblCantClientes.Text = "Cantidad de clientes:";
            // 
            // lblTotalDeuda1
            // 
            this.lblTotalDeuda1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda1.Location = new System.Drawing.Point(362, 277);
            this.lblTotalDeuda1.Name = "lblTotalDeuda1";
            this.lblTotalDeuda1.Size = new System.Drawing.Size(143, 26);
            this.lblTotalDeuda1.TabIndex = 22;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(211, 285);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(89, 18);
            this.lblTotalDeuda.TabIndex = 20;
            this.lblTotalDeuda.Text = "Total deuda:";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.dgvConsulta);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(12, 12);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(532, 246);
            this.gbConsulta.TabIndex = 21;
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
            this.dgvConsulta.Location = new System.Drawing.Point(12, 21);
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
            // cmdListarDeudores
            // 
            this.cmdListarDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarDeudores.Location = new System.Drawing.Point(362, 468);
            this.cmdListarDeudores.Name = "cmdListarDeudores";
            this.cmdListarDeudores.Size = new System.Drawing.Size(143, 23);
            this.cmdListarDeudores.TabIndex = 27;
            this.cmdListarDeudores.Text = "Listar deudores";
            this.cmdListarDeudores.UseVisualStyleBackColor = true;
            this.cmdListarDeudores.Click += new System.EventHandler(this.cmdListarDeudores_Click);
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 510);
            this.Controls.Add(this.cmdListarDeudores);
            this.Controls.Add(this.lblPromDeuda1);
            this.Controls.Add(this.lblPromDeuda);
            this.Controls.Add(this.lblCantClientes1);
            this.Controls.Add(this.lblCantClientes);
            this.Controls.Add(this.lblTotalDeuda1);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.gbConsulta);
            this.Name = "frmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmClientesDeudores";
            this.gbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPromDeuda1;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.Label lblCantClientes1;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblTotalDeuda1;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
        private System.Windows.Forms.Button cmdListarDeudores;
    }
}