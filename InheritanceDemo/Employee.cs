using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class Employee
    {
        int id;
        string name;
        string address;
        public Employee()
        {

        }
        public Employee(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Address");
            address = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine(id + " " + name + " " + address);
        }
    }
}
