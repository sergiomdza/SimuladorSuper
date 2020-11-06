using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSuperMercado
{
    public class ArrayQueue<T> : IQueue<T>
    {
        private T[] data;
        public T Head { get { return data[0]; } } 
        
        public T Tail { get { return data[Size - 1]; } }
        public int Size { get; set; }

        public ArrayQueue(int capacity)
        {
            data = new T[capacity];
            Size = 0;
        }
        public void Enqueue(T element) //PUSH
        {
            if (Size == data.Length)
            {
                T[] auxData = new T[data.Length + 1]; // Alerta !!!!! (tal vez se deba x1.5)
                Array.Copy(data, auxData, data.Length);
                data = auxData;
            }
            data[Size++] = element;
        }
        public T Dequeue() //POP
        {
            T begin = data[0];

            if (IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else
            {
                T[] aux = new T[Size - 1];
                Array.Copy(data, 1, aux, 0, Size - 1);
                Array.Resize<T>(ref data, --Size);
                Array.Copy(aux, data, Size);
            }

            return begin;
        }
        public bool IsEmpty() => Size == 0;

        public List<T> toString()
        {
            List<T> array = new List<T>();
            foreach (T element in data)
            {
                array.Add(element);
            }
            return array;
        }
    }
}
