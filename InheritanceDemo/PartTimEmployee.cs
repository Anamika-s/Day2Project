using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InheritanceDemo
{
    internal class PartTimEmployee :Employee
    {
        string duration;
        int chargesPerDay;
        //public void GetPartTimeDetails()
        public void GetDetails()
        {
             base.GetDetails();
            Console.WriteLine("Enter duration");
            duration = Console.ReadLine();
            Console.WriteLine("Enter chargesPerDay");
            chargesPerDay = int.Parse( Console.ReadLine());
        }
        public void DisplayDetails()
        {base.DisplayDetails();
            Console.WriteLine(duration + " " + chargesPerDay);
        }

    }
}
