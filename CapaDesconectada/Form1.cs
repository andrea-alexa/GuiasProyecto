using AccesoDatos;
using CapaDesconectada.NorthwindTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDesconectada
{
    public partial class Form1 : Form
    {
        private void RellenarForm(Customer cliente)
        {
            if (cliente != null)
            {
                txtCustomerID.Text = cliente.CustomerID;
                txtCompanyName.Text = cliente.CompanyName;
                txtContactName.Text = cliente.ContactName;
                txtContactTitle.Text = cliente.ContactTitle;
                txtAddress.Text = cliente.Address;
            }
            if (cliente == null)
            {
                MessageBox.Show("objeto null");
            }
        }

        #region No Tipado
        private CustomerRepository customerRepository = new CustomerRepository();

        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            GridNoTipado.DataSource = customerRepository.ObtenerTodos();
        }

        private void btnBuscarNT_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorID(txtBuscarNT.Text);

            RellenarForm(cliente);
            if (cliente == null)
            {
                MessageBox.Show("El objeto es null");
            }
            if (cliente != null)
            {
                var listaClientes = new List<Customer> {cliente};
                GridNoTipado.DataSource = listaClientes;
            }
        }

        private void btnInsertarCliente_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = customerRepository.InsertarCliente(cliente);
            MessageBox.Show($"{insertados} registrados");
        }

        private Customer CrearCliente()
        {
            var cliente = new Customer
            {
                CustomerID = txtCustomerID.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                ContactTitle = txtContactTitle.Text,
                Address = txtAddress.Text
            };
            return cliente;
        }

        private void btnActualizarNT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            var actualizadas = customerRepository.ActualizarCliente(cliente);
            MessageBox.Show($"{actualizadas} filas actualizadas");
        }
        #endregion
        //-------------------------------------------------------------------------
        #region Tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnObtenerTipado_Click(object sender, EventArgs e)
        {
            var customers = adaptador.GetData();
            GridTipado.DataSource = customers;
        }

        private void btnBuscarT_Click(object sender, EventArgs e)
        {
            var customer = adaptador.GetDataByCustomerID(txtBuscarT.Text);
            if (customer != null)
            {
                var objeto1 = customerRepository.ExtraerInformacionCliente(customer);
                Console.WriteLine(customer);
            }
        }

        private void btnInsertarT_Click(object sender, EventArgs e)
        {
            var cliente = CrearCliente();
            int insertados = adaptador.Insert(cliente.CustomerID, cliente.CompanyName, cliente.ContactName, cliente.ContactTitle, cliente.Address, cliente.City, cliente.Region, cliente.PostalCode, cliente.Country, cliente.Phone, cliente.Fax);
            MessageBox.Show($"{insertados} resgistros insertados");
        }
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
    }
}
