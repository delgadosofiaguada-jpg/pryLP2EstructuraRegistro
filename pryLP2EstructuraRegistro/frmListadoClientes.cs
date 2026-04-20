using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLP2EstructuraRegistro
{
    public partial class frmListadoClientes : Form
    {
        public frmListadoClientes()
        {
            InitializeComponent();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmListadoClientes_Load(object sender, EventArgs e)
        {
            Vector.precarga();
            Listar();
        }
        private void Listar()
        {
            int CantidadClientes = 0; 
            Decimal TotalDeuda = 0;
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < Vector.IND; i++)
            {
                dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
                CantidadClientes++;
            }
            lblTotalDeuda1.Text = TotalDeuda.ToString();
            lblCantClientes1.Text = CantidadClientes.ToString();
            lblPromDeuda1.Text = (TotalDeuda / CantidadClientes).ToString();
        }
    }
}
