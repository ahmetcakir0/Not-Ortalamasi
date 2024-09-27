using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Not_Ortalaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yazili1;
            double yazili2;
            double yazili3;
            double ortalama = 0;
            Console.WriteLine("Yazılı 1 Notu=");
            yazili1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yazılı 2 Notu=");
            yazili2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yazılı 3 Notu=");
            yazili3 = Convert.ToDouble(Console.ReadLine());
            ortalama = (yazili1 + yazili2 + yazili3) / 3;
            Console.WriteLine("Öğrencinin Ortalaması=");
            Console.WriteLine(ortalama);
            if (ortalama < 101 && ortalama >= 84)
            {
                Console.WriteLine("Öğrencinin not karşılığı aldığı harf= A");
            }
            else if (ortalama < 84 && ortalama >= 79)
            {
                Console.WriteLine("Öğrencinin not karşılığı aldığı harf= B");
            }
            else if (ortalama < 79 && ortalama > 69)
            {
                Console.WriteLine("Öğrencinin not karşılığı aldığı harf= C");
            }
            else if (ortalama < 54 && ortalama > 45)
            {
                Console.WriteLine("Öğrencinin not karşılığı aldığı harf= D");
            }
            else if (ortalama < 44 && ortalama >= 25)
            {
                Console.WriteLine("Öğrencinin not karşılığı aldığı harf= F");
            }
            else if (ortalama < 24 && ortalama >= 0)
            {
                Console.WriteLine("Öğrencinin not karşılığı aldığı harf= G");
            }
            Console.WriteLine();
            Console.WriteLine("Kapatmak için bir tuşa basınız.");
            Console.ReadLine();
        }
    }
}
