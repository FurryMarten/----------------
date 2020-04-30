using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{   
    class MyStack<T>
    {
        T[] mass;
        int count = 0;

        public MyStack (int length)
        {
            mass = new T[length];
        }

        public void Push (T value)
        {
            if (count>=mass.Length)throw new Exception ("Стек переполнен");
            mass [count++]=value;
        }

        public T Pop()
        {
            if (count == 0)
                throw new Exception("Стек пуст,данных нет");
            return mass[--count];
        }

        public T Top()
        {
            return mass[count-1];
        }

        public bool IsEmpty()
        {
            //if (count == 0) return true;
            //else return false;
            return (count == 0);
        }
    }
}
