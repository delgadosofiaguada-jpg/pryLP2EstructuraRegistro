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
    public partial class frmClientesDeudores : Form
    {
        public frmClientesDeudores()
        {
            InitializeComponent();
        }
    
        private void cmdListarDeudores_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            decimal TotalDeudas = 0;
            dgvConsulta.Rows.Clear();
            int CantidadClientes = 0;
            for (int i = 0; i < Vector.IND; i++)
            {
                if (Vector.Clientes[i].Deuda > 0)
                {
                    dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                    TotalDeudas=TotalDeudas+ Vector.Clientes[i].Deuda;
                    CantidadClientes++;
                }
               

            }
            lblTotalDeuda1.Text = TotalDeudas.ToString("C");
            lblCantClientes1.Text= CantidadClientes.ToString();
            lblPromDeuda1.Text = (TotalDeudas / CantidadClientes).ToString("C");

        }
    }
}
