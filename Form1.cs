using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimuladorSuperMercado2;

namespace SimuladorSuperMercado
{
    
    public partial class formSuper : Form
    {
        int ContadorClientes = 1;

        public formSuper()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(MaxCantidadDelay: 10, MaxCantidadProductos: 5, ID: ContadorClientes);
            ListViewItem Cliente = new ListViewItem(cliente.ID.ToString());
            Cliente.SubItems.Add(cliente.CantidadProductos.ToString());
            Cliente.SubItems.Add(cliente.Delay.ToString());
            ListViewClientes.Items.Add(Cliente);

            ContadorClientes += 1;
        }
    }
}
