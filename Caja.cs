using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSuperMercado
{
    public class Caja
    {
        private int checkout;
        public ArrayQueue<Cliente> Queue = new ArrayQueue<Cliente>(0);

        public Caja(int checkout_num)
        {
            checkout = checkout_num;
        }
        public int Checkout { get => checkout; }
        
    }
}
