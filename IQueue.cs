using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorSuperMercado
{
    public interface IQueue<T>
    {
        int Size { get; } // Devuelve el numero de elementos
        T Head { get; } // Devolver el Primero en entrar/primero en salir -- Peek/Top
        T Tail { get; } //Devuelve el último en entrar/ultimo en salir -- Peek/Bottom
        void Enqueue(T element); // Agrega un elemento al final -- Push
        T Dequeue(); // Retorna el primer elemento y lo remuve -- Pop
        bool IsEmpty(); // Devuelve un true si esta vacio y false si no  
    }
}
