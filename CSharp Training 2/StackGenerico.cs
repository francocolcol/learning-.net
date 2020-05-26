using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Training_2
{
    public class StackGenerico <T> : IEnumerable <T> where T : class
    {
        private T[] stack;
        public int cantidadEnStack { get; private set; }
        private int maximo;

        public StackGenerico(int maximo)
        {
            this.stack = new T[maximo];
            cantidadEnStack = -1;
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
                stack[++cantidadEnStack] = objeto;
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
                stack[cantidadEnStack--] = null;
                return ultimoEnStack;
            }
        }

        public bool EstaVacio()
        {
            if(cantidadEnStack <= -1)
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
            for (int i = cantidadEnStack; i >= 0; i--)
            {
                yield return stack[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public IEnumerable<T> TopToBottom
        {
            get { return this; }
        }

        public IEnumerable<T> BottomToTop
        {
            get
            {
                for (int index = 0; index <= cantidadEnStack; index++)
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
            int startIndex = --itemsFromTop >= cantidadEnStack ? 0 : cantidadEnStack - itemsFromTop;

            for (int index = cantidadEnStack; index >= startIndex; index--)
            {
                yield return stack[index];
            }
        }

    }
}
