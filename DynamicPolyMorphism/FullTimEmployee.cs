using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class FullTimEmployee : Employee

    {
        string dept;
        string manager;
        public void GetFullTimeDetails()
        {

            Console.WriteLine("Enter dept");
            dept = Console.ReadLine();
            Console.WriteLine("Enter manager");
            manager =  Console.ReadLine();
        }
        public void DisplayFullTimeDetails()
        {
            Console.WriteLine(dept + " " + manager);
        }
    }
}
