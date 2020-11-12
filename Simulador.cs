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
        private static System.Timers.Timer TimerSegundos;

        public int segundoActual = 0;
        private int ContadorClientes = 1;
        private int Iteraciones = 0;

        // Valores Default Configuración
        public int MAX_NUM_OF_CLIENTS = 5;
        public int MAX_NUM_OF_PRODUCTS = 10;
        public int MAX_CLIENT_DELAY = 6;
        public int EXPRESS_LANE_MAX_PRODUCTS = 5;
        public int[] CheckoutCajas = new int[5] {1, 1, 1, 1, 1};
        public int SegundosIteracion = 10;
        bool TimerCorriendo = false;

        List<Cliente> ListaClientes = new List<Cliente>();
        List<Cliente> ClientesSalidos= new List<Cliente>();
        ArrayQueue<Cliente> ClientesPendientes = new ArrayQueue<Cliente>(0);
        public List<Caja> Cajas = new List<Caja>();

        public formSuper()
        {
            InitializeComponent();
            inicio();
            Label.CheckForIllegalCrossThreadCalls = false;
        }

        private void inicio()
        {
            for (int i = 1; i <= 5; i++)
            {
                Caja caja;
                if (i == 1)
                {
                    caja = new Caja(checkout_num: CheckoutCajas[i - 1], maxproducts: EXPRESS_LANE_MAX_PRODUCTS);
                }
                else
                {
                    caja = new Caja(checkout_num: CheckoutCajas[i - 1]);
                }

                Cajas.Add(caja);
            }
            lblTimer.Text = String.Format($"Segundos para siguiente Iteración: {SegundosIteracion - segundoActual}");
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
            int noCliente = rnd.Next(1, MAX_NUM_OF_CLIENTS+1);
            for (int i = 0; i < noCliente; i++)
            {
                int delay = rnd.Next(1, MAX_CLIENT_DELAY+1);
                int prod = rnd.Next(1, MAX_NUM_OF_PRODUCTS+1);
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
                    for(int j = 0; j<array.Count(); j++)
                    {
                        Cliente e = array[j];
                        switch (i)
                        {
                            case 0:
                                //Quitar productos
                                if ( j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual-1)
                                {
                                    Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                }
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1 && Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Head.Salida = Iteraciones;
                                    ClientesSalidos.Add(Cajas[i].Queue.Dequeue());
                                    break;
                                }
                                ListViewItem Cliente = new ListViewItem(e.ID.ToString());
                                Cliente.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja1.Items.Add(Cliente);
                                break;

                            case 1:
                                //Quitar productos
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1)
                                {
                                    Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                }
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1 && Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Head.Salida = Iteraciones;
                                    ClientesSalidos.Add(Cajas[i].Queue.Dequeue());
                                    break;
                                }
                                ListViewItem Cliente2 = new ListViewItem(e.ID.ToString());
                                Cliente2.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja2.Items.Add(Cliente2);
                                break;

                            case 2:
                                //Quitar productos
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1)
                                {
                                    Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                }
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1 && Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Head.Salida = Iteraciones;
                                    ClientesSalidos.Add(Cajas[i].Queue.Dequeue());
                                    break;
                                }
                                ListViewItem Cliente3 = new ListViewItem(e.ID.ToString());
                                Cliente3.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja3.Items.Add(Cliente3);

                                break;

                            case 3:
                                //Quitar productos
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1)
                                {
                                    Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                }
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1 && Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Head.Salida = Iteraciones;
                                    ClientesSalidos.Add(Cajas[i].Queue.Dequeue());
                                    break;
                                }
                                ListViewItem Cliente4 = new ListViewItem(e.ID.ToString());
                                Cliente4.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja4.Items.Add(Cliente4);

                                break;

                            case 4:
                                //Quitar productos
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1)
                                {
                                    Cajas[i].Queue.Head.QuitarProductos(Cajas[i].Checkout);
                                }
                                if (j == 0 && Cajas[i].Queue.Head.Delay < Cajas[i].Queue.Head.DelayActual - 1 && Cajas[i].Queue.Head.CantidadProductos <= 0)
                                {
                                    Cajas[i].Queue.Head.Salida = Iteraciones;
                                    ClientesSalidos.Add(Cajas[i].Queue.Dequeue());
                                    break;
                                }

                                ListViewItem Cliente5 = new ListViewItem(e.ID.ToString());
                                Cliente5.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja5.Items.Add(Cliente5);

                                break;

                        }
                        e.AumentarDelay();
                    }
                }
            }
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            if (!TimerCorriendo)
            {
                lblDebug.Text = "";
                Configuracion configTab = new Configuracion(this);
                configTab.numMaxClient.Value = MAX_NUM_OF_CLIENTS;
                configTab.numMaxProduct.Value = MAX_NUM_OF_PRODUCTS;
                configTab.numMaxDelay.Value = MAX_CLIENT_DELAY;

                configTab.numMaxProductsExpressLane.Value = EXPRESS_LANE_MAX_PRODUCTS;
                configTab.numCheckoutCaja1.Value = Cajas[0].Checkout;
                configTab.numCheckoutCaja2.Value = Cajas[1].Checkout;
                configTab.numCheckoutCaja3.Value = Cajas[2].Checkout;
                configTab.numCheckoutCaja4.Value = Cajas[3].Checkout;
                configTab.numCheckoutCaja5.Value = Cajas[4].Checkout;
                configTab.numSeconds.Value = SegundosIteracion;

                configTab.Show();
            }
            else
            {
                lblDebug.Text = "Favor de Detener el Timer antes de acceder a configuración";
            }
            
        }

        private void IniciarTimer_Click(object sender, EventArgs e)
        {
            if (!TimerCorriendo)
            {
                TimerSegundos = new System.Timers.Timer(1000);
                TimerSegundos.Elapsed += Iteracion;
                TimerSegundos.AutoReset = true;
                TimerSegundos.Enabled = true;
                TimerCorriendo = true;
            }
        }

        private void Iteracion(object sender, System.Timers.ElapsedEventArgs e)
        {
            segundoActual += 1;
            lblTimer.Text = String.Format($"Segundos para siguiente Iteración: {SegundosIteracion - segundoActual}");

            if (checkBoxCliente.Checked && segundoActual == SegundosIteracion)
            {
                segundoActual= 0;
                aumentarIteracion();
                agregarCliente();
                elegirCaja();
                DibujarClientesCaja();
                DibujarClientesTienda();
            }
            else if (segundoActual == SegundosIteracion)
            {
                segundoActual = 0;
                aumentarIteracion();
                elegirCaja();
                DibujarClientesCaja();
                DibujarClientesTienda();
            }
        }

        private void btnDetenerTimer_Click(object sender, EventArgs e)
        {
            if (TimerCorriendo)
            {
                TimerSegundos.Stop();
                TimerCorriendo = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (TimerCorriendo)
            {
                TimerSegundos.Stop();
            }
            // Reset default Values:

            segundoActual = 0;
            ContadorClientes = 1;
            Iteraciones = 0;

            MAX_NUM_OF_CLIENTS = 5;
            MAX_NUM_OF_PRODUCTS = 10;
            MAX_CLIENT_DELAY = 6;
            EXPRESS_LANE_MAX_PRODUCTS = 5;
            CheckoutCajas = new int[5] { 1, 1, 1, 1, 1 };
            SegundosIteracion = 10;
            TimerCorriendo = false;

            //Reset Lists and Arrays
            ListaClientes.Clear();
            Cajas.Clear();
            ClientesSalidos.Clear();
            ClientesPendientes = new ArrayQueue<Cliente>(0);

            ListViewClientes.Items.Clear();
            ListViewCaja1.Items.Clear();
            ListViewCaja2.Items.Clear();
            ListViewCaja3.Items.Clear();
            ListViewCaja4.Items.Clear();
            ListViewCaja5.Items.Clear();

            lblTimer.Text = String.Format($"Segundos para siguiente Iteración: {SegundosIteracion - segundoActual}");
            lblInteracion.Text = "Iteración Actual: " + Iteraciones.ToString();

            inicio();
        }
    }
}