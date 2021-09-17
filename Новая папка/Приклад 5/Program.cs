using System;

namespace ProgramCod
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nПриклад 5. Логічний тип");
            bool b1 = true, b2 = false, b3 = b1, b4 = !b2; // поганий запис коду
            bool ba = true;
            bool bb = false;
            bool bc = ba;
            bool bd = !bb;
            Console.WriteLine($"ba={ba}\nbb={bb}\nbc={bc}\nbd={bd}");
            Console.ReadKey();
        }

    }
    
       
    
}
