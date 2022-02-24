using System;

namespace algoritmaSorusu2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Birinci Sayıyı Giriniz : ");
                       
           int x = int.Parse(Console.ReadLine());

           int[] sayıDizisi2 = new int[x]; 
           for (int i = 0; i < x; i++)
           {
               Console.WriteLine("Lütfen {0}. Sayıyı Giriniz",i+1);
               sayıDizisi2[i] = int.Parse(Console.ReadLine());
           }
           
           Console.Write("İkinci Sayıyı Giriniz : ");
           int y = int.Parse(Console.ReadLine());
           
           for (int i = 0; i < sayıDizisi2.Length; i++)
           {
                if (sayıDizisi2[i] % y == 0 || sayıDizisi2[i] % y == y )
                {
                    Console.WriteLine(sayıDizisi2[i]);
                }   
           }

            
        }
    }
}
