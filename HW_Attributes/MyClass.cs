using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Attributes
{
    public class MyClass
    {
        public MyClass(string myString1, string myString2, string myString3, string myString4, string myString5)
        {
            MyString1 = myString1;
            MyString2 = myString2;
            MyString3 = myString3;
            MyString4 = myString4;
            MyString5 = myString5;
        }

        [ForPrint]
        public string MyString1 { get; set; }

        public string MyString2 { get; set; }

        [ForPrint(Color = ConsoleColor.Green)]
        public string MyString3 { get; set; }

        public string MyString4 { get; set; }

        [ForPrint(Color = ConsoleColor.Blue)]
        public string MyString5 { get; set; }
    }
}
