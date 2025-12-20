using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //Döngüler
            // for (x;y;z)
            // x: baþlangýç deðeri
            // y: koþul
            // z: artýþ/azalýþ deðeri   

            //int i;

            //for (i=1; i<=5; i++)
            //{
            //    Console.WriteLine($"{i}.Merhaba Dünya!");
            //}

            //for (int i=3; i <= 50; i += 3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Ekrana yazýlmasýný istediðiniz adeti giriniz: ");
            //int finshValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finshValue; i++)
            //{
            //    Console.WriteLine($"{i}. Yaþasýn Cumhuriyet");
            //}












            #endregion

            #region For Döngüsü ile karar yapýlarý

            //for (int i = 1; i <= 100; i++)
            //{
            //      if ( i % 5 == 0) {

            //        Console.WriteLine(i);
            //     }
            //}

            //int totalvalue = 0;

            //for (int i = 1; i <= 10; i++)
            //{
            //    totalvalue += i;
            //}

            //Console.WriteLine(totalvalue);


            //int totalvalue = 0; 
            //for(int i = 0; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalvalue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("-------");
            //Console.WriteLine(totalvalue);


            //int count = 0;
            //for (int i = 1; i <= 50; i++)
            //{

            //    if (i % 6 == 0)
            //    {
            //        count++;
            //    } 
            //}

            //Console.WriteLine(count);

            //int bacterium = 1;

            //for (int i = 0; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine($"{i}. saat sonunda : {bacterium}");
            //}

            #endregion

            #region While Döngüsü

            //int i = 0; 
            //while (i <= 10)
            //{
            //    Console.WriteLine("merhaba dünya");
            //    ++i;

            //}


            #endregion

            #region Örnek sýnav sorusu

            //// Klavyeden girilen 3 basamaklý sayýnýn basamaklarý toplamýný hesaplayan kodu yazýnýz

            //Console.Write("sayý giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10;
            //tens = (number % 100)/10;
            //hundreds = number / 100;

            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum); 

            #endregion




            Console.Read();
        }
    }
}
