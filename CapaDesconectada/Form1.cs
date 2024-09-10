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
        #region No Tipado
        private CustomerRepository customerRepository = new CustomerRepository();

        private void btnObtenerNoTipado_Click(object sender, EventArgs e)
        {
            GridNoTipado.DataSource = customerRepository.ObtenerTodos();
        }

        private void btnBuscarNT_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorID(txtBuscarNT.Text);
        }
        #endregion
        //-------------------------------------------------------------------------
        #region Tipado
        CustomersTableAdapter adaptador = new CustomersTableAdapter();
        private void btnOptenerTipado_Click(object sender, EventArgs e)
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
        #endregion

        public Form1()
        {
            InitializeComponent();
        }
    }
}
