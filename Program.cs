using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, toplam;

            Console.Write("İlk değeri giriniz : ");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("İkinci değeri giriniz : ");
            b = Convert.ToInt16(Console.ReadLine());

            toplam = a + b ;
            Console.WriteLine();

            Console.WriteLine("{0} ve {1} sayıların toplamı : {2}", a, b, (a + b));

            Console.ReadKey();
        }
    }
}
