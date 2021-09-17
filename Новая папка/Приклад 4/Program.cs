using System;

namespace ProgramCod
{
    class Program1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nПриклад 4.Символи");
            char char_literal = 'A';
            char hexadecimal = '\x0041';
            char integer = (char)65;
            char unicode = '\u0041';
            Console.WriteLine(char_literal + " " + hexadecimal + " " + integer + " " + unicode);
            Console.ReadKey();

        }

    }
    
       
    
}
