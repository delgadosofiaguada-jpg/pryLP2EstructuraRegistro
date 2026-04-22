namespace pryLP2EstructuraRegistro
{
    partial class frmListarOrdenado
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
            this.gbConsulta = new System.Windows.Forms.GroupBox();
            this.cmdListar = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cbMando = new System.Windows.Forms.ComboBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.clCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConsulta
            // 
            this.gbConsulta.Controls.Add(this.cmdListar);
            this.gbConsulta.Controls.Add(this.dgvDatos);
            this.gbConsulta.Controls.Add(this.cbMando);
            this.gbConsulta.Controls.Add(this.cbCampo);
            this.gbConsulta.Controls.Add(this.lblModo);
            this.gbConsulta.Controls.Add(this.lblCampo);
            this.gbConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbConsulta.Location = new System.Drawing.Point(12, 12);
            this.gbConsulta.Name = "gbConsulta";
            this.gbConsulta.Size = new System.Drawing.Size(720, 398);
            this.gbConsulta.TabIndex = 0;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de datos";
            // 
            // cmdListar
            // 
            this.cmdListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdListar.Location = new System.Drawing.Point(616, 348);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(86, 35);
            this.cmdListar.TabIndex = 5;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCódigo,
            this.clNombre,
            this.clLimite,
            this.clDeuda});
            this.dgvDatos.Location = new System.Drawing.Point(18, 90);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(684, 232);
            this.dgvDatos.TabIndex = 4;
            // 
            // cbMando
            // 
            this.cbMando.FormattingEnabled = true;
            this.cbMando.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbMando.Location = new System.Drawing.Point(371, 37);
            this.cbMando.Name = "cbMando";
            this.cbMando.Size = new System.Drawing.Size(121, 28);
            this.cbMando.TabIndex = 3;
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "Código",
            "Nombre",
            "Límite",
            "Deuda"});
            this.cbCampo.Location = new System.Drawing.Point(127, 37);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 28);
            this.cbCampo.TabIndex = 2;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(304, 45);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(50, 20);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Modo";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(33, 45);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(62, 20);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            this.lblCampo.Click += new System.EventHandler(this.label2_Click);
            // 
            // clCódigo
            // 
            this.clCódigo.HeaderText = "Codigo";
            this.clCódigo.MinimumWidth = 6;
            this.clCódigo.Name = "clCódigo";
            this.clCódigo.Width = 120;
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.MinimumWidth = 6;
            this.clNombre.Name = "clNombre";
            this.clNombre.Width = 190;
            // 
            // clLimite
            // 
            this.clLimite.HeaderText = "Límite";
            this.clLimite.MinimumWidth = 6;
            this.clLimite.Name = "clLimite";
            this.clLimite.Width = 160;
            // 
            // clDeuda
            // 
            this.clDeuda.HeaderText = "Deuda";
            this.clDeuda.MinimumWidth = 6;
            this.clDeuda.Name = "clDeuda";
            this.clDeuda.Width = 160;
            // 
            // frmListarOrdenado
            // 
            this.ClientSize = new System.Drawing.Size(749, 422);
            this.Controls.Add(this.gbConsulta);
            this.Name = "frmListarOrdenado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Ordenado";
            this.Load += new System.EventHandler(this.frmListarOrdenado_Load);
            this.gbConsulta.ResumeLayout(false);
            this.gbConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConsultaDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbConsulta;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.ComboBox cbMando;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
    }
}