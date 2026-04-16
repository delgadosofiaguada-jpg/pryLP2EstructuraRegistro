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
            this.clCódigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clLimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDeuda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbMando = new System.Windows.Forms.ComboBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
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
            this.gbConsulta.Size = new System.Drawing.Size(484, 398);
            this.gbConsulta.TabIndex = 0;
            this.gbConsulta.TabStop = false;
            this.gbConsulta.Text = "Consulta de datos";
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(374, 366);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(86, 26);
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
            this.dgvDatos.Location = new System.Drawing.Point(18, 84);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(442, 232);
            this.dgvDatos.TabIndex = 4;
            // 
            // clCódigo
            // 
            this.clCódigo.HeaderText = "Codigo";
            this.clCódigo.Name = "clCódigo";
            // 
            // clNombre
            // 
            this.clNombre.HeaderText = "Nombre";
            this.clNombre.Name = "clNombre";
            // 
            // clLimite
            // 
            this.clLimite.HeaderText = "Límite";
            this.clLimite.Name = "clLimite";
            // 
            // clDeuda
            // 
            this.clDeuda.HeaderText = "Deuda";
            this.clDeuda.Name = "clDeuda";
            // 
            // cbMando
            // 
            this.cbMando.FormattingEnabled = true;
            this.cbMando.Items.AddRange(new object[] {
            "Ascendente",
            "Descendente"});
            this.cbMando.Location = new System.Drawing.Point(295, 27);
            this.cbMando.Name = "cbMando";
            this.cbMando.Size = new System.Drawing.Size(121, 24);
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
            this.cbCampo.Location = new System.Drawing.Point(73, 29);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(121, 24);
            this.cbCampo.TabIndex = 2;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(247, 32);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(42, 16);
            this.lblModo.TabIndex = 1;
            this.lblModo.Text = "Modo";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(15, 35);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(51, 16);
            this.lblCampo.TabIndex = 0;
            this.lblCampo.Text = "Campo";
            this.lblCampo.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmListarOrdenado
            // 
            this.ClientSize = new System.Drawing.Size(528, 422);
            this.Controls.Add(this.gbConsulta);
            this.Name = "frmListarOrdenado";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clCódigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clLimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDeuda;
        private System.Windows.Forms.Button cmdListar;
    }
}