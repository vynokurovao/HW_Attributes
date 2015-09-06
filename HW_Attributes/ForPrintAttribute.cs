using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Attributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ForPrintAttribute : Attribute
    {
        public ConsoleColor Color { get; set; }
    }
}
