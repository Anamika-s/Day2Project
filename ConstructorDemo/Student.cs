using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
     class Student
    {
        int id;
        string name;
        string batch;
        int marks;
        public void GetDetails()
        {
            Console.WriteLine("Enter id");
            id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter BAtch");
            batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks =  Byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Id is {id}\n Name is {name}\n" +
                $"Batch is {batch}\n Marks are {marks}");
        }

        public Student(string name)
        {
            this.name = name;
            Console.WriteLine("Enter id");
            id = Byte.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter BAtch");
            batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());



        }

        public Student(int id)
        {
            this.id = id;

            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("Enter BAtch");
            batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());



        }
        public Student(int id, string name)
        {
            this.id = id;
            this.name = name;
            

            Console.WriteLine("Enter BAtch");
            batch = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = Byte.Parse(Console.ReadLine());



        }

        public Student(int id, string name , string batch, int marks)
        {
            this.id = id;

            this.name = name;
            this.batch = batch;
            this.marks= marks;


        }
         public Student()
        {

        }

        public Student(Student student)
        {
            Console.WriteLine("Enter id");
            id = Byte.Parse(Console.ReadLine());
            this.batch= student.batch;
            this.name = student.name;
            this.marks  = student.marks;
        }
    }

      static class ExtendingStudentClass
    {
        public static void AAA(this Student s)
        {
            System.Console.WriteLine("");
        }
    }
}
