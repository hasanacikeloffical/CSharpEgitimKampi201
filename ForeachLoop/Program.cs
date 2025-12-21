
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Döngüsü
            // foreach (1;2;3;4)
            // 1: Deðiþken türü
            // 2: Deðiþken Adý
            // 3: In
            // 4: Liste, koleksiyon , dizi

            //string[] cities = { "Ankara", "Ýstanbul", "Ýzmir", "Adana" };
            //foreach(string a in cities)
            //{
            //    Console.WriteLine(a);
            //}

            //int[] numbers = { 12, 465, 68, 3424, 797, 1654543, 48646, 86486, 68486, 64, 68, 121, };

            //foreach(int a in numbers)
            //{
            //    Console.WriteLine(a);
            //}

            //int[] numbers = { 12, 465, 68, 3424, 797, 1654543, 48646, 86486, 68486, 64, 68, 121, };
            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //        Console.WriteLine(number);
            //}

            //int[] numbers = { 12, 465, 68, 3424, 797, 1654543, 48646, 86486, 68486, 64, 68, 121, };

            //int total = 0; 

            //foreach(int a in numbers)
            //{
            //    total += a; 
            //}
            //Console.WriteLine(total);

            //List<int> numbers = new List<int>()
            //{
            //    1,2,3,4,5,6
            //};

            //foreach(int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //string word = "Merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}




            #endregion

            #region Örnek sýnav sistemi uygulamasý

            Console.Write("**** C# Eðitim Kampý SInav Uygulamasý *****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("************************");
            Console.WriteLine("Sýnýfýnýzda Kaç öðrenci var?");

            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("****************");

            // öðrenci isim ve ortalamalarýný saklýyacak diziler
            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for(int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{i + 1}. öðrencinin adýný giriniz: ");
                studentNames[i] = Console.ReadLine();

                double totalExamResult = 0; 

                // her öðrenci için 3 sýnav giriþi

                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öðrencinin {j + 1}. sýnav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value; 

                }
                studentExamAvg[i] = totalExamResult / 3;
            }

            // öðrencilerin ortalamasý
            for  (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"{studentNames[i]}. adlý öðrencinin ortalamasý : {studentExamAvg[i]}");

                if (studentExamAvg[i] > 50)
                {
                    Console.WriteLine($"{studentNames[i]}. adlý öðrenci geçti.");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]}. adlý öðrenci kaldý.");

                }
                Console.WriteLine("***********");
            }
                
            
            // öðrencilerin geçip kalma durumlarý


            #endregion


            Console.Read();
        }

    }
}
