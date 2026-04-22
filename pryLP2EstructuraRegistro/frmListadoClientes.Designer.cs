namespace pryLP2EstructuraRegistro
{
    partial class frmListadoClientes
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
            this.lblTotalDeuda1 = new System.Windows.Forms.Label();
            this.lblTotalDeuda = new System.Windows.Forms.Label();
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.lblCantClientes = new System.Windows.Forms.Label();
            this.lblCantClientes1 = new System.Windows.Forms.Label();
            this.lblPromDeuda = new System.Windows.Forms.Label();
            this.lblPromDeuda1 = new System.Windows.Forms.Label();
            this.clCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimCredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotalDeuda1
            // 
            this.lblTotalDeuda1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalDeuda1.Location = new System.Drawing.Point(495, 358);
            this.lblTotalDeuda1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda1.Name = "lblTotalDeuda1";
            this.lblTotalDeuda1.Size = new System.Drawing.Size(191, 32);
            this.lblTotalDeuda1.TabIndex = 15;
            // 
            // lblTotalDeuda
            // 
            this.lblTotalDeuda.AutoSize = true;
            this.lblTotalDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeuda.Location = new System.Drawing.Point(293, 368);
            this.lblTotalDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalDeuda.Name = "lblTotalDeuda";
            this.lblTotalDeuda.Size = new System.Drawing.Size(115, 24);
            this.lblTotalDeuda.TabIndex = 13;
            this.lblTotalDeuda.Text = "Total deuda:";
            this.lblTotalDeuda.Click += new System.EventHandler(this.lblTotalDeuda_Click);
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.dgvConsulta);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(28, 32);
            this.gbConsulta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbConsulta.Size = new System.Drawing.Size(709, 492);
            this.gbConsulta.TabIndex = 14;
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
            this.dgvConsulta.Size = new System.Drawing.Size(685, 254);
            this.dgvConsulta.TabIndex = 9;
            this.dgvConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConsulta_CellContentClick);
            // 
            // lblCantClientes
            // 
            this.lblCantClientes.AutoSize = true;
            this.lblCantClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantClientes.Location = new System.Drawing.Point(293, 422);
            this.lblCantClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClientes.Name = "lblCantClientes";
            this.lblCantClientes.Size = new System.Drawing.Size(185, 24);
            this.lblCantClientes.TabIndex = 16;
            this.lblCantClientes.Text = "Cantidad de clientes:";
            // 
            // lblCantClientes1
            // 
            this.lblCantClientes1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCantClientes1.Location = new System.Drawing.Point(495, 412);
            this.lblCantClientes1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantClientes1.Name = "lblCantClientes1";
            this.lblCantClientes1.Size = new System.Drawing.Size(191, 32);
            this.lblCantClientes1.TabIndex = 17;
            // 
            // lblPromDeuda
            // 
            this.lblPromDeuda.AutoSize = true;
            this.lblPromDeuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPromDeuda.Location = new System.Drawing.Point(293, 473);
            this.lblPromDeuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuda.Name = "lblPromDeuda";
            this.lblPromDeuda.Size = new System.Drawing.Size(183, 24);
            this.lblPromDeuda.TabIndex = 18;
            this.lblPromDeuda.Text = "Promedio de deuda:";
            // 
            // lblPromDeuda1
            // 
            this.lblPromDeuda1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPromDeuda1.Location = new System.Drawing.Point(495, 463);
            this.lblPromDeuda1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPromDeuda1.Name = "lblPromDeuda1";
            this.lblPromDeuda1.Size = new System.Drawing.Size(191, 32);
            this.lblPromDeuda1.TabIndex = 19;
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
            this.clDeuda.Width = 160;
            // 
            // frmListadoClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 545);
            this.Controls.Add(this.lblPromDeuda1);
            this.Controls.Add(this.lblPromDeuda);
            this.Controls.Add(this.lblCantClientes1);
            this.Controls.Add(this.lblCantClientes);
            this.Controls.Add(this.lblTotalDeuda1);
            this.Controls.Add(this.lblTotalDeuda);
            this.Controls.Add(this.gbConsulta);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListadoClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de todos los clientes";
            this.Load += new System.EventHandler(this.frmListadoClientes_Load);
            this.gbConsulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTotalDeuda1;
        private System.Windows.Forms.Label lblTotalDeuda;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.Label lblCantClientes;
        private System.Windows.Forms.Label lblCantClientes1;
        private System.Windows.Forms.Label lblPromDeuda;
        private System.Windows.Forms.Label lblPromDeuda1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimCredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
    }
}