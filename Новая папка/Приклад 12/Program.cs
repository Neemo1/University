using System;

namespace ProgramCod
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nПриклад 12. Оператори перетворення");
            string x = Console.ReadLine();
            int x1 = int.Parse(x);
            int x2 = Convert.ToInt32(x);
            Console.WriteLine($"x^2={x1 * x2}");
            Console.ReadKey();


        }

    }
    
       
    
}
