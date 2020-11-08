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
    
    public partial class formSuper : Form
    {
        private int ContadorClientes = 1;
        private int Iteraciones = 0;

        // Valores Default Configuración
        int MAX_NUM_OF_CLIENTS = 10;
        int MAX_NUM_OF_PRODUCTS = 5;
        int MAX_CLIENT_DELAY = 5;
        int EXPRESS_LANE_MAX_PRODUCTS = 5;
 

        List<Cliente> ListaClientes = new List<Cliente>();
        ArrayQueue<Cliente> ClientesPendientes = new ArrayQueue<Cliente>(0);
        List<Caja> Cajas = new List<Caja>();
        public formSuper()
        {
            InitializeComponent();

            for(int i =1; i<=5; i++){
                Caja caja;
                if (i == 1)
                {
                    caja = new Caja(checkout_num: 3, maxproducts: EXPRESS_LANE_MAX_PRODUCTS);
                }
                else
                {
                    caja = new Caja(checkout_num: 2);
                }

                Cajas.Add(caja);
            }
        }

        private void btnSiguienteIteracion_Click(object sender, EventArgs e)
        {
            aumentarIteracion();
            agregarCliente();
            elegirCaja();
            DibujarClientesCaja();
            DibujarClientesTienda();
        }

        private void btnSinCliente_Click(object sender, EventArgs e)
        {
            aumentarIteracion();
            elegirCaja();
            DibujarClientesCaja();
            DibujarClientesTienda();
        }

        private void aumentarIteracion()
        {
            Iteraciones += 1;
            lblInteracion.Text = "Iteración Actual: " + Iteraciones.ToString();

            foreach(Cliente e in ListaClientes){
                e.AumentarDelay();
                if (e.DelayActual > e.Delay)
                {
                    ClientesPendientes.Enqueue(e);
                }
            }
        }
        private void agregarCliente()
        {
            Random rnd = new Random();
            int noCliente = rnd.Next(1, MAX_NUM_OF_CLIENTS);
            for (int i = 0; i < noCliente; i++)
            {
                int delay = rnd.Next(1, MAX_CLIENT_DELAY);
                int prod = rnd.Next(1, MAX_NUM_OF_PRODUCTS);
                Cliente cliente = new Cliente(MaxCantidadDelay: delay, MaxCantidadProductos: prod, ID: ContadorClientes, numentrada: Iteraciones);
                ListaClientes.Add(cliente);
                ContadorClientes += 1;
            }
        }

        private void DibujarClientesTienda()
        {
            ListViewClientes.Items.Clear();
            foreach(Cliente e in ListaClientes)
            {
                ListViewItem Cliente = new ListViewItem(e.ID.ToString());
                Cliente.SubItems.Add(e.CantidadProductos.ToString());
                Cliente.SubItems.Add(e.Delay.ToString());
                Cliente.SubItems.Add(e.DelayActual.ToString());
                ListViewClientes.Items.Add(Cliente);
            }
        }

        private void elegirCaja()
        {
            int cantidad = ClientesPendientes.Size;
            for (int j = 0; j < cantidad; j++)
            {
                if (ClientesPendientes.IsEmpty())
                {
                    continue;
                }
                Cliente e = ClientesPendientes.Dequeue();
                ListaClientes.Remove(e);

                int min = 0;
                int minindice = 0;
                if (e.CantidadProductos <= Cajas[0].MaxProducts){
                    Cajas[0].Queue.Enqueue(e);
                    continue;
                }
                //Buscar Mejor Caja
                for (int i = 1; i < Cajas.Count(); i++)
                {
                    if (Cajas[i].Queue.IsEmpty())
                    {
                        minindice = i;
                        break;
                    }
                    if (i == 1)
                    {
                        min = Cajas[i].Queue.Size;
                        minindice = i;
                    }
                    if (min > Cajas[i].Queue.Size)
                    {
                        min = Cajas[i].Queue.Size;
                        minindice = i;
                    }
                }
                Cajas[minindice].Queue.Enqueue(e);
            }
        }

        private void DibujarClientesCaja()
        {
            ListViewCaja1.Items.Clear();
            ListViewCaja2.Items.Clear();
            ListViewCaja3.Items.Clear();
            ListViewCaja4.Items.Clear();
            ListViewCaja5.Items.Clear();
            for (int i=0; i<Cajas.Count(); i++)
            {
                if (Cajas[i].Queue.Size > 0) {
                    List<Cliente> array = Cajas[i].Queue.toString();
                    foreach (Cliente e in array)
                    {
                        switch (i)
                        {
                            case 0:
                                //Quitar productos
                                if (Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Dequeue();
                                    break;
                                }

                                ListViewItem Cliente = new ListViewItem(e.ID.ToString());
                                Cliente.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja1.Items.Add(Cliente);
                                Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                
                                break;

                            case 1:
                                //Quitar productos
                                if (Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Dequeue();
                                    break;
                                }
                                ListViewItem Cliente2 = new ListViewItem(e.ID.ToString());
                                Cliente2.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja2.Items.Add(Cliente2);
                                Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                
                                break;

                            case 2:
                                //Quitar productos
                                if (Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Dequeue();
                                    break;
                                }
                                ListViewItem Cliente3 = new ListViewItem(e.ID.ToString());
                                Cliente3.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja3.Items.Add(Cliente3);
                                Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                
                                break;

                            case 3:
                                //Quitar productos
                                if (Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Dequeue();
                                    break;
                                }
                                ListViewItem Cliente4 = new ListViewItem(e.ID.ToString());
                                Cliente4.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja4.Items.Add(Cliente4);

                                Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                break;

                            case 4:
                                //Quitar productos
                                if (Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Dequeue();
                                    break;
                                }
                                ListViewItem Cliente5 = new ListViewItem(e.ID.ToString());
                                Cliente5.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja5.Items.Add(Cliente5);

                                Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                break;

                        }
                    }
                }
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            Configuracion configTab = new Configuracion();
            MAX_NUM_OF_CLIENTS = Convert.ToInt32(configTab.numMaxClient.Value);
            MAX_NUM_OF_PRODUCTS = Convert.ToInt32(configTab.numMaxProduct.Value);
            MAX_CLIENT_DELAY = Convert.ToInt32(configTab.numMaxDelay.Value);
        }
    }
}