using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_02_Inheritance.Entities
{
    internal class PartTimeEmployee :Employee
    {
        public int CountOfHours { get; set; }
        public decimal HourRate { get; set; }

    }
}
