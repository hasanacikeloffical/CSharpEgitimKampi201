using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //()
            // Geriye deðer döndürmeyen metotlar
            //customer --> listele , ekle, sil , güncelle

            //void customerList()
            //{
            //    Console.WriteLine("Ali Açýkel");
            //    Console.WriteLine("Muhammed Açýkel");
            //    Console.WriteLine("Hasan Açýkel");
            //}
            //customerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();






            #endregion

            #region Geriye deðer döndürmeyen parametreli metodlar

            //void writeMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //writeMethod("Ali Açýkel");

            //void CustomerCard(string name , string surName)
            //{
            //    Console.WriteLine($"Müþteri {name} {surName}");
            //}

            //CustomerCard("Hasan", "açýkel");
            //CustomerCard("Ali", "açýkel");
            #endregion

            #region Geriye deðer döndürmeyen int parametreli metotlar

            //void Sum(int number1, int number2, int number3)
            //{
            //    int result = number1 + number2 + number3;
            //    Console.WriteLine(result);
            //}
            //Sum(3, 4, 5);

            #endregion

            #region Geri deðer döndüren metotlar

            //string customerName()
            //{
            //    return "Hasan Açýkel";
            //}
            //customerName();

            //string StudentCard()
            //{
            //    string name = "Ali";
            //    string surName = "Açýkel";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(StudentCard());




            #endregion

            #region Geriye deðer string döndüren parametreli metotlar

            //string CountryCard(string countryName , string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- baþkent: " + capital + "- bayrak rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adýný giriniz: ");  x = Console.ReadLine();
            //Console.Write("Baþkent adýný giriniz: "); y = Console.ReadLine();
            //Console.Write("Yaprak rengi adýný giriniz: "); z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            #endregion



            Console.Read();
        }
    }
}
