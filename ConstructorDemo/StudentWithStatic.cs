using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVDemo
{
     class Student
    {
        readonly int id;
        string name;
          static string batch;
        const string companyName = "AVL";

        int marks;
        public void GetDetails()
        {
            //Console.WriteLine("Enter id");
            //id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter BAtch");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks =  Byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Id is {id}\n Name is {name}\n" +
                $"Marks are {marks}");
        }

        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Enter id");
            id = Byte.Parse(Console.ReadLine());
            
            //Console.WriteLine("Enter BAtch");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());



        }

        public Student(int id)
        {
            this.id = id;

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            //Console.WriteLine("Enter BAtch");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());



        }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            

            //Console.WriteLine("Enter BAtch");
            //batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());



        }

        public Student(int id, string name , int marks)
        {
            this.id = id;

            this.name = name;
            //this.batch = batch;
            this.marks= marks;


        }
         public Student()
        {

        }

        public Student(Student student)
        {
            Console.WriteLine("Enter id");
            id = Byte.Parse(Console.ReadLine());
            //this.batch= student.batch;
            this.name = student.name;
            this.marks  = student.marks;
        }

        public static void DispplayBatch()
        {
            //batch = "B001";
            Console.WriteLine("Batch is " + batch);
        }

         static Student()
        {
            batch = "B001";
        }
    }
}
