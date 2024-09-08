using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DatosLayer;

namespace capaConexion
{
    public partial class Form1 : Form
    {
        CustomerRepository CustomerRepository = new CustomerRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var customer = CustomerRepository.ObtenerTodos();
            dataGrid.DataSource = customer;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var cliente = CustomerRepository.ObtenerPorID(txtBuscar.Text);
            if (cliente != null)
            {
                txtBuscar.Text = cliente.CompanyName;
                MessageBox.Show(cliente.CompanyName);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int elimindas = CustomerRepository.EliminarCliente(txtCustomerID.Text);
            MessageBox.Show("Filas eliminadas = " + elimindas);
        }
    }
}
