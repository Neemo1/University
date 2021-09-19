using System;

namespace ProgramCod
{
    class Program1
    {
        static void Main(string[] args)
        {
            /*
                        Console.WriteLine("Приклад 1. Коментарі");
                        string message = "Hello World!"; // лінійний коментар 
                        Console.WriteLine(message);
            *//*
                        багатолінійний коментар

            */
            /*   Console.ReadKey();

               Console.WriteLine("\nПриклад 2. Цілочислені типи даних");
               int a = 100;
               int b = 10;
               int c = a * b;
               Console.WriteLine($"a*b= {c}");
               Console.ReadKey();

               Console.WriteLine("\nПриклад 3. Типи даних з плавоючою комою");
               float f = 1.1f, fs = 1.0f;
               const double pi = 3.14;
               Console.WriteLine("f={0} pi={1} fs={2}", f, pi, fs);
               Console.ReadKey();*/

            /*Приклади запису типів з плавоючою комою
            decimal m = 0.10M; -вірно
            float f = 0.1f; -вірно
            double d = 0.1; -вірно
            decimal m_error = 0.10; -не вірно
            float f_error = 0.1; -не вірно
            double d_correct = 0.1; -ще один вірний запис для змінної double

*//*
            Console.WriteLine("\nПриклад 4.Символи");
            char char_literal = 'A';
            char hexadecimal = '\x0041';
            char integer = (char)65;
            char unicode = '\u0041';
            Console.WriteLine(char_literal + " " + hexadecimal + " " + integer + " " + unicode);
            Console.ReadKey();


            Console.WriteLine("\nПриклад 5. Логічний тип");
            bool b1 = true, b2 = false, b3 = b1, b4 = !b2; // поганий запис коду
            bool ba = true;
            bool bb = false;
            bool bc = ba;
            bool bd = !bb;
            Console.WriteLine($"ba={ba}\nbb={bb}\nbc={bc}\nbd={bd}");
            Console.ReadKey();
            Console.WriteLine("\nПриклад 6. Основні операції 1");
            string msg; // Оголошення змінних
            msg = "Hello"; // ініціалізація змінних
            string name = "Vasj"; // оголошення та ініціалізація змінних
            Console.WriteLine($"{msg}, {name}");
            Console.ReadKey();
            Console.WriteLine("\nПриклад 7. Основні операції 2");
            const string MSG = "HELLO";
            string NAME = "Vasj";
            NAME = "Petj";
            //MSG = "HELLO HELLO"; Не змінеться так як MSG прописана як константа, через це вона не змінеться
            Console.WriteLine($"{MSG}, {NAME}");
            Console.ReadKey();

            Console.WriteLine("\nПриклад 8. Операції з числами 1");
            int a = 1;
            a = a + 1;
            Console.WriteLine(a);
            a += 1;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(a);
            ++a;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
            --a;
            Console.WriteLine(a);
            Console.ReadKey();

            Console.WriteLine("\nПриклад 9. Операції з числами 2");
            int a = 1_003;
            Console.WriteLine($"a={a}");
            Console.WriteLine($"a / 10={a / 10}");// Not 100,3
            Console.WriteLine($"a % 10 ={a % 10}");
            Console.ReadKey();

            Console.WriteLine("\nПриклад 10. Неявні операції");
            byte b = 100;
            short s = b;
            int x = s;
            long y = x;
            Console.WriteLine(y);
            Console.ReadKey();

            Console.WriteLine("\nПриклад 10. Явні операції");
            long l = 2_000_000_000_002L;
            int i = (int)l;
            short s = (short)i;
            byte b = (byte)s;
            Console.WriteLine($"l={l}\ni={i}\ns={s}\nb={b}");
            Console.ReadKey();*/

            /*  Console.WriteLine("\nПриклад 10. Явні операції");
              string x = Console.ReadLine();
              int x1 = int.Parse(x);
              int x2 = Convert.ToInt32(x);
              Console.WriteLine($"x^2={x1 * x2}");
              Console.ReadKey();*/

            Console.WriteLine("\nПриклад 11. Алгоритм прикладу");
            string xString = Console.ReadLine();
            int x = Convert.ToInt32(xString);
            int y = x * x;
            Console.WriteLine($"x^2= {y}");
            double z = Math.Cos(y);
            Console.WriteLine($"cos(x^2)={z}");
            Console.ReadKey();
        }

    }
    
       
    
}
