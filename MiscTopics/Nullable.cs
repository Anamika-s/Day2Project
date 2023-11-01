using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiscTopics
{
    internal class Nullable
    {
        static void Main()
        {
            byte y;
            Console.WriteLine("enter y");
            //y = Byte.Parse(Console.ReadLine());
            Byte.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("Value of y is " + y);


            int? x = null;
            if(x.HasValue)
            {
               Console.WriteLine(x.Value);
            }
            else
            { Console.WriteLine("It is null");
            }

        }
    }
}
