using System;

namespace ProgramCod
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nПриклад 11. Явні операції");
            long l = 2_000_000_000_002L;
            int i = (int)l;
            short s = (short)i;
            byte b = (byte)s;
            Console.WriteLine($"l={l}\ni={i}\ns={s}\nb={b}");
            Console.ReadKey();

        }

    }
    
       
    
}
