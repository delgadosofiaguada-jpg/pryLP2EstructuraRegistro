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
            if (Vector.IND < Vector.Clientes.Length)
            {
                Int32 i = 0;
                Int32 codigoBuscado = Convert.ToInt32(txtCodigo.Text);
                while ((i < Vector.IND && Vector.Clientes[i].Codigo != codigoBuscado))//dentro del rango, busca el codigo que ingreso
                {
                    i++;
                }

                if (i == Vector.IND)
                {
                   Vector. Clientes[IND].Codigo = Convert.ToInt32(txtCodigo.Text);
                   Vector.Clientes[IND].Usuario = txtUsuario.Text;
                   Vector.Clientes[IND].Deuda = Convert.ToDecimal(txtDeuda.Text);
                   Vector.Clientes[IND].Limite = Convert.ToDecimal(txtLimCredito.Text);
                    Vector.IND++;
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
            
            
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            cmdCargar.Enabled = false;
            Vector.precarga();
           
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

        private void cmdDeudores_Click(object sender, EventArgs e)
        {
            Decimal TotalDeuda = 0;
            //dgvConsulta.Rows.Clear();
            for (int i = 0; i < Vector.IND; i++)
            {
               if (Vector.Clientes[i].Deuda>0)
               {
                   //dgvConsulta.Rows.Add(Vector.Clientes[i].Codigo, Vector.Clientes[i].Usuario, Vector.Clientes[i].Limite, Vector.Clientes[i].Deuda);
                   TotalDeuda = TotalDeuda + Vector.Clientes[i].Deuda;
               }
            }
            lblTotal.Text = TotalDeuda.ToString();
        }

        private void dgvConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gbConsulta_Enter(object sender, EventArgs e)
        {

        }
    }
}
