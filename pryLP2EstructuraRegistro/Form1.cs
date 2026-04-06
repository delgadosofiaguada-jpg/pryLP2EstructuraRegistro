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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Declaracion de registro
        private struct  RegCliente
        {
            public Int32 Codigo;
            public String Usuario;
            public Decimal Deuda;
            public Decimal Limite;
        }

        //Declaracion del vector
        private RegCliente[] Clientes = new RegCliente[10];   

        //Declaracion del indice
        private Int32 IND = 0;

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            if (IND < Clientes.Length)
            {
                Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                Clientes[IND].Usuario = txtUsuario.Text;
                Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                Clientes[IND].Limite = Convert.ToDecimal(txtLimCredito.Text);
                IND++;
                Listar();
                MessageBox.Show("Cliente cargado correctamente");
                txtCodigo.Text="";
                txtUsuario.Text="";
                txtDeuda.Text="";
                txtLimCredito.Text="";
            }
           else
           {
                MessageBox.Show("No se pueden cargar mas clientes");
           }
            
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            Decimal TotalDeuda = 0;
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < IND; i++)
            {
                dgvConsulta.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Limite, Clientes[i].Deuda);
                TotalDeuda = TotalDeuda + Clientes[i].Deuda;
            }
            lblTotal.Text = TotalDeuda.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdCargar.Enabled = false;

        }

        private void Comprobar()
        {
            if (txtCodigo.Text != "" && txtUsuario.Text != "" && txtDeuda.Text != "" && txtLimCredito.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }

        private void txtLimCredito_TextChanged(object sender, EventArgs e)
        {
            Comprobar();
        }
    }
}
