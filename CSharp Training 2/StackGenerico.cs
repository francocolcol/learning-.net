using System;

namespace CSharp_Training_2
{
    public class StackGenerico <T> where T : class
    {
        private T[] stack;
        private int cantidadEnStack;
        private int maximo;

        public StackGenerico(int maximo)
        {
            this.stack = new T[maximo];
            cantidadEnStack = 0;
            this.maximo = maximo;
        }

        public void Push(T objeto)
        {
            if (EstaLleno())
            {
                throw new MyStackOverflowException();
            }
            else
            {
                stack[cantidadEnStack] = objeto;
                cantidadEnStack++;
            }
        }

        public T Pop()
        {
            if (EstaVacio())
            {
                throw new MyStackUnderFlowException();
            }
            else
            {
                T ultimoEnStack = stack[cantidadEnStack];
                stack[cantidadEnStack] = null;
                cantidadEnStack--;
                return ultimoEnStack;
            }
        }

        public bool EstaVacio()
        {
            if(cantidadEnStack <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool EstaLleno()
        {
            if (cantidadEnStack >= maximo-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
