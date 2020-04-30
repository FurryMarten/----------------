using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> st = new MyStack<int>(5);
            //st.Push(15);
            //st.Push(36);
            //st.Push(55);
            //Console.WriteLine(st.Top());
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Top());
            //Console.WriteLine(st.Pop());

            MyStack<char> st1 = new MyStack<char>(15);
            String s = Console.ReadLine();
            bool error = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '{' || s[i] == '[')
                    st1.Push(s[i]);
                if (s[i] == ')' || s[i] == '}' || s[i] == ']')
                {
                    
                    if (st1.IsEmpty())  
                    {
                        Console.WriteLine("Лишняя закрывающая!");
                        error = true;
                        break;
                    }
                    
                    char tmp = st1.Pop();
                    if (tmp == '{' && s[i] != '}')
                    {
                        Console.WriteLine("Типы скобок не совпадают!");
                        error = true;
                        break;
                    }
                    if (tmp == '[' && s[i] != ']')
                    {
                        Console.WriteLine("Типы скобок не совпадают!");
                        error = true;
                        break;
                    }
                    if (tmp == '(' && s[i] != ')')
                    {
                        Console.WriteLine("Типы скобок не совпадают!");
                        error = true;
                        break;
                    }
                }
            }
            if (st1.IsEmpty() && !error)  Console.WriteLine("Все верно");
            else Console.WriteLine("Не верно");
        }
    }
}
