using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSuperMercado2
{
    public class Cliente
    {
        private int entrada;
        private int salida;
        private int delay;
        private int cantidadProductos;
        private int tiempoCaja;
        private int id;
        private int productoActual;
        private int delayActual;

        public Cliente(int MaxCantidadProductos, int MaxCantidadDelay, int ID)
        {
            Random rnd = new Random();
            id = ID;
            cantidadProductos = rnd.Next(1, MaxCantidadProductos);
            delay = rnd.Next(1, MaxCantidadDelay);
            productoActual = cantidadProductos;
            delayActual = 0;
            //Entrada = 0;
        }
        public void QuitarProductos(int cantidad) => productoActual -= cantidad;

        public void AumentarDelay() => delayActual += 1;
        public int ID { get => id;}
        public int Entrada { get => entrada; set => entrada = value; }
        public int Salida { get => salida; set => salida = value; }
        public int TiempoCaja { get => tiempoCaja; set => tiempoCaja = value; }
        public int CantidadProductos { get => cantidadProductos; }
        public int Delay { get => delay; }

        
    }
}
