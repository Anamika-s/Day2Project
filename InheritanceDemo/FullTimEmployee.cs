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
        //public void GetFullTimeDetails()
        public void GetDetails()
        {
            base.GetDetails();

            Console.WriteLine("Enter dept");
            dept = Console.ReadLine();
            Console.WriteLine("Enter manager");
            manager =  Console.ReadLine();
        }
        //public void DisplayFullTimeDetails()
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine(dept + " " + manager);
        }
    }
}
