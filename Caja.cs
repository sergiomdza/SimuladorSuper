using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSuperMercado
{
    public class Caja
    {
        private int maxProducts;
        private int checkout;
        public ArrayQueue<Cliente> Queue = new ArrayQueue<Cliente>(0);

        public Caja(int checkout_num)
        {
            Checkout = checkout_num;
        }
        public Caja(int checkout_num, int maxproducts)
        {
            Checkout = checkout_num;
            MaxProducts = maxproducts;
        }
        
        public int MaxProducts { get => maxProducts; set => maxProducts = value; }
        public int Checkout { get => checkout; set => checkout = value; }
    }
}
