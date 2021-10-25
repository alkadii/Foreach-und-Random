using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " Khaled Alkadi";
            char[] c = str.ToCharArray();
            foreach(char d in str)
            {
                Console.Write(d+" ");
            }


        }
    }
}
