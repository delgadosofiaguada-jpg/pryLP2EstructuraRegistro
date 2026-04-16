using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLP2EstructuraRegistro
{
    public partial class frmListarOrdenado : Form
    {
        public frmListarOrdenado()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            switch (cbCampo.SelectedIndex)
            { 
             case 0:
                    if (cbMando.SelectedIndex == 0)
                    {
                        Vector.OrdenarCodigoAsc();
                    }
                    else
                    {
                        Vector.OrdenarCodigoDesc();
                    }
                    break;
            case 1:
                    if (cbMando.SelectedIndex == 0)
                    {
                        Vector.OrdenarNombreAsc();
                    }
                    else
                    {
                       Vector.OrdenarNombreDesc();
                    }
                    break;
            case 2:
                    if (cbMando.SelectedIndex == 0)
                    {
                       Vector.OrdenarLimiteAsc();
                    }
                    else
                    {
                       Vector.OrdenarLimiteDesc();
                    }
                    break;

            case 3:
                    if (cbMando.SelectedIndex == 0)
                    {
                        Vector.OrdenarDeudaAsc();
                    }
                    else
                    {
                       Vector.OrdenarDeudaDesc();
                    }
                    break;
            }
            dgvDatos.Rows.Clear();
            for (Int32 i = 0; i < Vector.IND; i++)
            {
                dgvDatos.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);

            }
            
        }

        private void frmListarOrdenado_Load(object sender, EventArgs e)
        {
            Vector.precarga();
        }
    }
}
