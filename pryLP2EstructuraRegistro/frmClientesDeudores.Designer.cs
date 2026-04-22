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
            this.cmdListarDeudores = new System.Windows.Forms.Button();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPromDeuda1
            // 
            this.lblPromDeuda1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeuda1.Location = new System.Drawing.Point(518, 423);
            this.lblPromDeuda1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuda1.Name = "lblPromDeuda1";
            this.lblPromDeuda1.Size = new System.Drawing.Size(191, 32);
            this.lblPromDeuda1.TabIndex = 26;
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(265, 431);
            this.lblPromDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(183, 24);
            this.lblPromDeuda.TabIndex = 25;
            this.lblPromDeuda.Text = "Promedio de deuda:";
            // 
            // lblCantClientes1
            // 
            this.lblCantClientes1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClientes1.Location = new System.Drawing.Point(518, 367);
            this.lblCantClientes1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClientes1.Name = "lblCantClientes1";
            this.lblCantClientes1.Size = new System.Drawing.Size(191, 32);
            this.lblCantClientes1.TabIndex = 24;
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.Location = new System.Drawing.Point(265, 375);
            this.lblCantClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(185, 24);
            this.lblCantClientes.TabIndex = 23;
            this.lblCantClientes.Text = "Cantidad de clientes:";
            // 
            // lblTotalDeuda1
            // 
            this.lblTotalDeuda1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda1.Location = new System.Drawing.Point(518, 305);
            this.lblTotalDeuda1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda1.Name = "lblTotalDeuda1";
            this.lblTotalDeuda1.Size = new System.Drawing.Size(191, 32);
            this.lblTotalDeuda1.TabIndex = 22;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(265, 313);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(115, 24);
            this.lblTotalDeuda.TabIndex = 20;
            this.lblTotalDeuda.Text = "Total deuda:";
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.lblPromDeuda1);
            this.gbConsulta.Controls.Add(this.cmdListarDeudores);
            this.gbConsulta.Controls.Add(this.lblPromDeuda);
            this.gbConsulta.Controls.Add(this.dgvConsulta);
            this.gbConsulta.Controls.Add(this.lblCantClientes1);
            this.gbConsulta.Controls.Add(this.lblTotalDeuda1);
            this.gbConsulta.Controls.Add(this.lblCantClientes);
            this.gbConsulta.Controls.Add(this.lblTotalDeuda);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(16, 15);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsulta.Size = new System.Drawing.Size(734, 571);
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
            this.dgvConsulta.Location = new System.Drawing.Point(16, 26);
            this.dgvConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.RowHeadersWidth = 51;
            this.dgvConsulta.Size = new System.Drawing.Size(693, 254);
            this.dgvConsulta.TabIndex = 9;
            // 
            // cmdListarDeudores
            // 
            this.cmdListarDeudores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListarDeudores.Location = new System.Drawing.Point(518, 510);
            this.cmdListarDeudores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdListarDeudores.Name = "cmdListarDeudores";
            this.cmdListarDeudores.Size = new System.Drawing.Size(191, 41);
            this.cmdListarDeudores.TabIndex = 27;
            this.cmdListarDeudores.Text = "Listar deudores";
            this.cmdListarDeudores.UseVisualStyleBackColor = true;
            this.cmdListarDeudores.Click += new System.EventHandler(this.cmdListarDeudores_Click);
            // 
            // clCodigo
            // 
            this.clCodigo.HeaderText = "Código";
            this.clCodigo.MinimumWidth = 6;
            this.clCodigo.Name = "clCodigo";
            this.clCodigo.Width = 120;
            // 
            // clUsuario
            // 
            this.clUsuario.HeaderText = "Usuario";
            this.clUsuario.MinimumWidth = 6;
            this.clUsuario.Name = "clUsuario";
            this.clUsuario.Width = 190;
            // 
            // clLimCredito
            // 
            this.clLimCredito.HeaderText = "Límite de crédito";
            this.clLimCredito.MinimumWidth = 6;
            this.clLimCredito.Name = "clLimCredito";
            this.clLimCredito.Width = 160;
            // 
            // clDeuda
            // 
            this.clDeuda.HeaderText = "Deuda";
            this.clDeuda.MinimumWidth = 6;
            this.clDeuda.Name = "clDeuda";
            this.clDeuda.Width = 170;
            // 
            // frmClientesDeudores
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(763, 604);
            this.Controls.Add(this.gbConsulta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmClientesDeudores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Deudores";
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button cmdListarDeudores;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
    }
}