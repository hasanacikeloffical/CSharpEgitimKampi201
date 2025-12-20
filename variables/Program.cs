using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region  DoubleDeðiþkenler

            ////double a = 3.14; 
            ////Console.WriteLine($"Pi deðeri : {a}");
            //string al = "Alýnan Ürün ";
            //string e = "elma", o = "portakal", s = "Çilek", p = "Patates", t = "domates";
            //Console.WriteLine("**** FÝyat Listesi *****");
            //Console.WriteLine();


            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice; 
            //applePrice = 20.4;
            //orangePrice = 32.5;
            //strawberryPrice = 66.4;
            //potatoPrice = 12.4;
            //tomatoPrice =  45.3;

            //Console.WriteLine($"Elma Birim Fiyatý : {applePrice} TL");
            //Console.WriteLine($"Portakal Birim Fiyatý : {orangePrice} TL");
            //Console.WriteLine($"Çilek Birim Fiyatý : {strawberryPrice} TL");
            //Console.WriteLine($"Patates Birim Fiyatý : {potatoPrice} TL");
            //Console.WriteLine($"Domates Birim Fiyatý : {tomatoPrice} TL");

            //double appleGram, orangeGram , strawberryGram,potatoGram, tomatoGram;
            //appleGram = 1.234;
            //orangeGram = 4.563;
            //strawberryGram = 0.123;
            //potatoGram = 9.345;
            //tomatoGram = 3.124;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine($"{al} {e} birim fiyatý : {applePrice} - gramaj : {appleGram} - toplam tutar : {appleTotalPrice}");
            //Console.WriteLine($"{al} {o} birim fiyatý : {orangePrice} - gramaj : {orangeGram} - toplam tutar : {orangeTotalPrice}");
            //Console.WriteLine($"{al} {s} birim fiyatý : {strawberryPrice} - gramaj : {strawberryGram} - toplam tutar : {strawberryTotalPrice}");
            //Console.WriteLine($"{al} {p} birim fiyatý : {potatoPrice} - gramaj : {potatoGram} - toplam tutar : {potatoTotalPrice}");
            //Console.WriteLine($"{al} {t} birim fiyatý : {tomatoPrice} - gramaj : {potatoGram} - toplam tutar : {tomatoTotalPrice}");
            //Console.WriteLine();
            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + tomatoTotalPrice + potatoTotalPrice;  
            //Console.WriteLine($"Aliþveriþ Toplam Tutarý : {shoppingTotalPrice}");

            #endregion

            #region CharDeðiþkenler

            //char symbol = 'a';


            //Console.WriteLine(symbol); 


            #endregion

            #region KlavyedenVeriGiriþleri

            //Console.WriteLine("****CSharp Hava Yollarý Yolcu Bilgisi ****");
            //Console.WriteLine();


            //string passengerName, passengerSurname , passengerDistrict, passengerCity , passengerAge, passengerIdentityNumber;
            //Console.Write("Yolcu Adý : "); passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadý : "); passengerSurname = Console.ReadLine();
            //Console.Write("Ýlçe Bilgisi : "); passengerDistrict = Console.ReadLine();
            //Console.Write("Þehir : "); passengerCity = Console.ReadLine();
            //Console.Write("Yaþ : "); passengerAge = Console.ReadLine();
            //Console.Write("TC Kimlik No : "); passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine("-------------------------");
            //Console.WriteLine();
            //Console.WriteLine($"Yolcu Tc Kimlik No : {passengerIdentityNumber} adý : {passengerName} soyadý : {passengerSurname} ilçesi : {passengerDistrict} þehri : {passengerCity} yaþý : {passengerAge}");

            #endregion

            #region Klavyeden tam sayý giriþi ve dönüþümleri

            //int shoePrice, computerPrice, chairPrice, tvPrice, shoeCount, computerCount, chairCount, tvCount;

            //shoePrice = 1000;
            //computerPrice = 140000;
            //chairPrice = 560;
            //tvPrice = 22000;


            //Console.Write("Lütfen aldýðýnýz ayakkabý sayýsýný giriniz: "); shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldýðýnýz bilgisayar sayýsýný giriniz: "); computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldýðýnýz sandalye sayýsýný giriniz: "); chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldýðýnýz tv sayýsýný giriniz: "); tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoePrice * shoeCount + computerPrice * computerCount + chairPrice * chairCount + tvPrice * tvCount;

            //Console.WriteLine($"Toplam ödemeniz gereken tutar : {totalPrice}");


            #endregion

            #region Klavyeden ondalýklý sayý iþlemleri
            //double exam1, exam2, exam3, exam4, result;

            //Console.Write("lütfen 1.sýnav notunu giriniz: "); exam1 = double.Parse(Console.ReadLine());
            //Console.Write("lütfen 2.sýnav notunu giriniz: "); exam2 = double.Parse(Console.ReadLine());
            //Console.Write("lütfen 3.sýnav notunu giriniz: "); exam3 = double.Parse(Console.ReadLine());
            //Console.Write("lütfen 4.sýnav notunu giriniz: "); exam4 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3 + exam4) / 4;

            //Console.WriteLine();
            //Console.WriteLine($"Sýnav ortalmanýz: {result}");



            #endregion

            #region Klavyeden karakter Giriþi 
            // bu deðiþken sadece bir karakter alabilir.

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine($"Seçtiðiniz cinsiyet : {gender}"); 
            #endregion
            Console.Read();
        }
    }
}
