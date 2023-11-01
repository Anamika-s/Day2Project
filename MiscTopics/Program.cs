namespace MiscTopics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x=0;
            int y=0;
            int res = 0;
            int[] num = new int[2];
            try
            {
                Console.WriteLine("Enter x");
                x = Byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter Value of y");
                y = Byte.Parse(Console.ReadLine());
                  res = x / y;
                Console.WriteLine(res);
                num[10] = 10;
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Num is not in range");

            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(x);
            }
           
        }
    }
}