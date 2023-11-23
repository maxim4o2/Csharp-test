using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Да се направи алгоритъм за намиране на лице на правоъгълник( S = a*b )//
            
            //Даваме на потребителя право да зададе параметри на 'a'//
            Console.WriteLine("Задайте стойност на a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            //Даваме на потребителя право да зададе параметри на 'b'//
            Console.WriteLine("Задайте стойност на b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            
            //Изписване на крайният резултат//
            int sum = a * b;
            Console.WriteLine("Лицето на правоъгълника е: ");
            Console.WriteLine(sum);

            //Втори алгоритъм//
            Console.WriteLine("Задайте стойност на c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задайте стойност на d: ");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Задайте стойност на e: ");
            int e = Convert.ToInt32(Console.ReadLine());

            int sim = d * d - 4 * c * e;
            
            if ( sim < 0)
            {
                Console.WriteLine("Няма корени!");
            }
            else
            {
                Console.WriteLine("Има корени");
            }







        }
    }
}
