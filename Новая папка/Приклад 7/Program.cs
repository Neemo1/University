using System;

namespace ProgramCod
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nПриклад 7. Основні операції 2");
            const string MSG = "HELLO";
            string NAME = "Vasj";
            NAME = "Petj";
            //MSG = "HELLO HELLO"; Не змінеться так як MSG прописана як константа, через це вона не змінеться
            Console.WriteLine($"{MSG}, {NAME}");
            Console.ReadKey();

        }

    }
    
       
    
}
