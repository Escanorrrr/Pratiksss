using System;

namespace algoritmaSorusu3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen Bir Kelime Giriniz : ");
            int x = int.Parse(Console.ReadLine());           
            string[] yenidizi =  new string[x];
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
                yenidizi[i] = Convert.ToString(Console.ReadLine());

            }
            foreach (var item in yenidizi)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}

