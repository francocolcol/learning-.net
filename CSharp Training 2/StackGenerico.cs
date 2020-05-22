using System;
using System.Collections;
using System.Collections.Generic;

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
                cantidadEnStack--;
                T ultimoEnStack = stack[cantidadEnStack];
                stack[cantidadEnStack] = null;
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

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = cantidadEnStack - 1; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        public IEnumerable<T> TopToBottom
        {
            get { return stack; }
        }

        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (int index = 0; index <= cantidadEnStack - 1; index++)
                {
                    if(EstaVacio())
                    {
                        throw new MyStackUnderFlowException();
                    }
                    else
                    {
                        yield return stack[index];
                    }
                }
            }
        }

        public IEnumerable<T> TopN(int itemsFromTop)
        {
            int startIndex = itemsFromTop >= cantidadEnStack ? 0 : cantidadEnStack - itemsFromTop;

            for (int index = cantidadEnStack - 1; index >= startIndex; index--)
            {
                yield return stack[index];
            }
        }
    }
}
