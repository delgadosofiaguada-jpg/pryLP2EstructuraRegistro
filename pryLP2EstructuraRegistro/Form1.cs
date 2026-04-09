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
                Int32 i = 0;
                while (Clientes[i].Codigo != Convert.ToInt32(txtCodigo.Text) && i<IND)//dentro del rango, busca el codigo que ingreso
                {
                    i++;
                }

                if (i==IND)
                {
                    Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                    Clientes[IND].Usuario = txtUsuario.Text;
                    Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                    Clientes[IND].Limite = Convert.ToDecimal(txtLimCredito.Text);
                    IND++;
                    MessageBox.Show("Cliente cargado correctamente");
                    txtCodigo.Text = "";
                    txtUsuario.Text = "";
                    txtDeuda.Text = "";
                    txtLimCredito.Text = "";
                }  
                else
                {
                    MessageBox.Show("El codigo ingresado ya existe, ingrese otro");
                    txtCodigo.Text = "";
                }
            }
           else
           {
                MessageBox.Show("No se pueden cargar mas clientes");
           }
            Listar();
            
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
            precarga();
            Listar();
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

        private void gbCargaDatos_Enter(object sender, EventArgs e)
        {

        }

        private void precarga()
        {
            Clientes[IND].Codigo = 10;
            Clientes[IND].Usuario = "Ana";
            Clientes[IND].Deuda = 1000;
            Clientes[IND].Limite = 10000;
            IND++;
            Clientes[IND].Codigo = 20;
            Clientes[IND].Usuario = "Diego";
            Clientes[IND].Deuda = 0;
            Clientes[IND].Limite = 20000;
            IND++;
            Clientes[IND].Codigo = 30;
            Clientes[IND].Usuario = "Maria";
            Clientes[IND].Deuda = 3000;
            Clientes[IND].Limite = 30000;
            IND++;
            
        }

        private void cmdDeudores_Click(object sender, EventArgs e)
        {
            Decimal TotalDeuda = 0;
            dgvConsulta.Rows.Clear();
            for (int i = 0; i < IND; i++)
            {
               if (Clientes[i].Deuda>0)
               {
                   dgvConsulta.Rows.Add(Clientes[i].Codigo, Clientes[i].Usuario, Clientes[i].Limite, Clientes[i].Deuda);
                   TotalDeuda = TotalDeuda + Clientes[i].Deuda;
               }
            }
            lblTotal.Text = TotalDeuda.ToString();
        }
    }
}
