using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTopics
{
    internal class User
    {
        static void Main()
        {
            string name;
            int age;
            try {
                Console.WriteLine("Enter name");
                name = Console.ReadLine();
                if (name.Length < 10)
                    throw new CustomException("Min 10 characters are needed");
                Console.WriteLine("Enter age");
                age = Byte.Parse(Console.ReadLine());
                if (age < 20 || age > 50)
                    throw new CustomException("Range is 20 to 50");
            }
            catch (CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            }
    }

}
