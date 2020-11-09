using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSuperMercado
{
    public class Cliente
    {
        private int entrada;
        private int salida;
        private int delay;
        private int cantidadProductos;
        private int tiempoCaja;
        private int id;
        private int delayActual;
        
        public Cliente(int MaxCantidadProductos, int MaxCantidadDelay, int ID, int numentrada)
        {
            id = ID;
            cantidadProductos = MaxCantidadProductos;
            delay = MaxCantidadDelay;
            delayActual = 0;
            entrada = numentrada;
        }
        public void QuitarProductos(int cantidad) => cantidadProductos -= cantidad;

        public void AumentarDelay() => delayActual += 1;
        public int ID { get => id;}
        public int Entrada { get => entrada;}
        public int Salida { get => salida; set => salida = value; }
        public int TiempoCaja { get => tiempoCaja; set => tiempoCaja = value; }
        public int CantidadProductos { get => cantidadProductos; }
        public int Delay { get => delay; }
        public int DelayActual { get => delayActual; }


    }
}
