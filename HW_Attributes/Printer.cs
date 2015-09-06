using System;
using System.Collections.Generic;
using System.Reflection;

namespace HW_Attributes
{
    public static class Printer
    {
        public static void Print<T>(T obj)
        {
            PropertyInfo[] properties = typeof(T).GetProperties();
            
            foreach (PropertyInfo property in properties)
            {
                foreach (object attribute in property.GetCustomAttributes(typeof(ForPrintAttribute), true))
                {
                    ForPrintAttribute printAttr = attribute as ForPrintAttribute;
                    Console.ForegroundColor = printAttr.Color;
                    Console.WriteLine(property.GetValue(obj));
                }
            }
        }
    }
}
