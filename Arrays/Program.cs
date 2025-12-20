using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel dizi örnekleri

            // deðiþken türü [] diziAdý = new deðiþken türü[eleman sayýsý];

            //string[] colors = new string[4];
            //colors[0] = "Kýrmýzý";
            //colors[1] = "Mavi";
            //colors[2] = "Yeþil";
            //colors[3] = "Sarý";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Hatay";
            //cities[1] = "Ankara";
            //cities[2] = "Ankara";
            //cities[3] = "Ankara";
            //cities[4] = "Ankara";

            //Console.WriteLine(cities[4]);

            // eðer belirtilen indexs içerisinde olmayan elemaný çaðýrdýðýn zaman o deðerini çevirir.

            //string[] cities = { "Hatay", "Ankara", "istanbul" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki tüm eleanlarý listeleme
            //string[] colors = { "kýrmýzý", "mavi", "yeþil", "beyaz" };

            //for(int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 45, 68, 34252, 790890, 5231, 899687, 24234, };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 3 == 0)
            //    Console.WriteLine(numbers[i]);
            //}

            //char[] symbols = {'a', 'b', 'c', 'd', 'e' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 34, 567, 89, 12, 56, 76, 23, 76 };

            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //        maxNumber = myArray[i];
            //}
            //Console.WriteLine(maxNumber);

            // int[] numbers = { 23, 56, 3, 909, 45 };
            // Array.Sort(numbers); küçükten büyüðe sýralama yapar.
            // Array.Reverse(numbers); tersten sýralýyor

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            #endregion

            #region Dizi Metotlarý

            //string[] customers = { "Ali", "Muhammed", "Ahmet", "Süleyman" };
            //int index = Array.IndexOf(customers, "Muhammed"); kaçýncý index olduðunu belirtir.

            //int[] numbers = { 45, 23, 56, 78, 08, 2, 34, 45 };
            //Console.WriteLine($"Dizinin en büyük elemaný {numbers.Max()} dizini en küçük elemaný {numbers.Min()}");



            #endregion

            #region Kullanýcýdan deðer alma
            //string[] cities = new string[5];

            //for(int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. þehri giriniz : ");
            //    cities[i] = Console.ReadLine();

            //}
            //Console.WriteLine();
            //Console.WriteLine("-----------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 24, 567, 67834, 54 };
            //int sum = 0;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            int[] numbers = { 1, 3, 4, 6, 8, 9, 0 };
            Console.WriteLine("çift sayýlar");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Tek sayýlar");
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    Console.WriteLine(numbers[i]);
                }
            }


            #endregion
            Console.Read();
        }
    }
}
