using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass("1red", "2black", "3green", "4black", "5blue");
            Printer.Print(my);
            Console.ReadKey();
        }
    }
}
