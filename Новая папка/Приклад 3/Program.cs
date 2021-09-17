using System;

namespace ProgramCod
{
    class Program1
    {
        static void Main(string[] args)
        {
            onsole.WriteLine("\nПриклад 3. Типи даних з плавоючою комою");
            float f = 1.1f, fs = 1.0f;
            const double pi = 3.14;
            Console.WriteLine("f={0} pi={1} fs={2}", f, pi, fs);
            Console.ReadKey();

            /*Приклади запису типів з плавоючою комою
            decimal m = 0.10M; -вірно
            float f = 0.1f; -вірно
            double d = 0.1; -вірно

            decimal m_error = 0.10; -не вірно
            float f_error = 0.1; -не вірно
            double d_correct = 0.1; -ще один вірний запис для змінної double
*/

        }

    }
    
       
    
}
