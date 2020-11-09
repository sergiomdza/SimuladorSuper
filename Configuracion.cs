using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimuladorSuperMercado
{
    public partial class Configuracion : Form
    {
        formSuper formPrincipal;
       
        public Configuracion(formSuper instanciaFormSuper)
        {
            formPrincipal = instanciaFormSuper;
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            formPrincipal.MAX_NUM_OF_CLIENTS = Convert.ToInt32(numMaxClient.Value);
            formPrincipal.MAX_NUM_OF_PRODUCTS = Convert.ToInt32(numMaxProduct.Value);
            formPrincipal.MAX_CLIENT_DELAY = Convert.ToInt32(numMaxDelay.Value);
            formPrincipal.EXPRESS_LANE_MAX_PRODUCTS = Convert.ToInt32(numMaxProductsExpressLane.Value);
            formPrincipal.Cajas[0].MaxProducts= Convert.ToInt32(numMaxProductsExpressLane.Value);

            formPrincipal.Cajas[0].Checkout = Convert.ToInt32(numCheckoutCaja1.Value);
            formPrincipal.Cajas[1].Checkout = Convert.ToInt32(numCheckoutCaja2.Value);
            formPrincipal.Cajas[2].Checkout = Convert.ToInt32(numCheckoutCaja3.Value);
            formPrincipal.Cajas[3].Checkout = Convert.ToInt32(numCheckoutCaja4.Value);
            formPrincipal.Cajas[4].Checkout = Convert.ToInt32(numCheckoutCaja5.Value);

            this.Close();
        }
    }
}
