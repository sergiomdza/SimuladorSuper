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
        int ContadorClientes = 0;
        int Iteraciones = 0;
        int MaxClientes = 5;
        List<Cliente> ListaClientes = new List<Cliente>();
        ArrayQueue<Cliente> ClientesPendientes = new ArrayQueue<Cliente>(2);
        List<Caja> Cajas = new List<Caja>();
        public formSuper()
        {
            InitializeComponent();

            for(int i =1; i<=5; i++){
                Caja caja = new Caja(checkout_num: 2);
                Cajas.Add(caja);
            }
        }

        private void btnSiguienteIteracion_Click(object sender, EventArgs e)
        {
            aumentarIteracion();
            agregarCliente();
            DibujarClientesTienda();
            elegirCaja();
            DibujarClientesCaja();
        }

        private void btnSinCliente_Click(object sender, EventArgs e)
        {
            aumentarIteracion();
            DibujarClientesTienda();
            elegirCaja();
            DibujarClientesCaja();
        }

        private void aumentarIteracion()
        {
            Iteraciones += 1;
            lblInteracion.Text = "Iteración Actual: " + Iteraciones.ToString();

            foreach(Cliente e in ListaClientes){
                e.AumentarDelay();
                if (e.DelayActual == e.Delay)
                {
                    ClientesPendientes.Enqueue(e);
                }
            }
        }
        private void agregarCliente()
        {
            Random rnd = new Random();
            int noCliente = rnd.Next(1, MaxClientes);
            for (int i = 0; i < noCliente; i++)
            {
                int delay = rnd.Next(1, 10);
                int prod = rnd.Next(1, 10);
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
            for (int j = 0; j < ClientesPendientes.Size; j++)
            {
                if (ClientesPendientes.IsEmpty())
                {
                    continue;
                }
                Cliente e = ClientesPendientes.Dequeue();
                ListaClientes.Remove(e);

                //Buscar Mejor Caja
                int min = 0;
                int minindice = 0;
                for (int i = 0; i < Cajas.Count(); i++)
                {
                    if (Cajas[i].Queue.IsEmpty())
                    {
                        minindice = i;
                        break;
                    }
                    if (i == 0)
                    {
                        min = Cajas[i].Queue.Size;
                    }
                    else if (min < Cajas[i].Queue.Size)
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
            for (int i=0; i<Cajas.Count(); i++)
            {
                if (Cajas[i].Queue.Size > 0) {
                    List<Cliente> array = Cajas[i].Queue.toString();
                    foreach (Cliente e in array)
                    {
                        switch (i)
                        {
                            case 0:
                                ListViewItem Cliente = new ListViewItem(e.ID.ToString());
                                Cliente.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja1.Items.Add(Cliente);
                                break;

                            case 1:
                                ListViewItem Cliente2 = new ListViewItem(e.ID.ToString());
                                Cliente2.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja2.Items.Add(Cliente2);
                                break;

                            case 2:
                                ListViewItem Cliente3 = new ListViewItem(e.ID.ToString());
                                Cliente3.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja3.Items.Add(Cliente3);
                                break;

                            case 4:
                                ListViewItem Cliente4 = new ListViewItem(e.ID.ToString());
                                Cliente4.SubItems.Add(e.CantidadProductos.ToString());
                                ListViewCaja4.Items.Add(Cliente4);
                                break;
                        }
                    }
                }
            }
        }
    }
}