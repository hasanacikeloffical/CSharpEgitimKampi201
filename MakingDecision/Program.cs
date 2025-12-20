using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If

            //Console.Write("Lütfen şifreyi giriniz :"); 
            //string password = Console.ReadLine();

            //if (password=="1234")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: "); capital = Console.ReadLine();
            //Console.Write("Ülke giriniz: "); country = Console.ReadLine();

            //if (capital =="ankara" & country=="Türkiye")
            //{
            //    Console.WriteLine("veriler doğru");
            //}
            //else
            //{
            //    Console.WriteLine("veriler yanlış"); 
            //}

            //int number;

            //Console.Write("Sayıyı giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5) {
            //    Console.WriteLine("doğru");
            //         } else {
            //    Console.WriteLine("yanlış");
            //}


            //int exam1, exam2, exam3 , average;
            //string result = "hata"; 

            //Console.Write("sınav 1: "); exam1 = int.Parse(Console.ReadLine());
            //Console.Write("sınav 2: "); exam2 = int.Parse(Console.ReadLine());
            //Console.Write("sınav 3: "); exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.Write($"Sınavların ortalaması : {average} "); 

            //if(average>0 & average<= 50)
            //{
            //    result = "sonuç vasat "; 
            //}
            //if (average>50 & average <= 70)
            //{
            //    result = "sonuç orta";
            //}

            //if (average > 70 & average <= 84)
            //{
            //    result = "sonuç iyi";
            //}

            //if (average > 84 & average <= 100)
            //{
            //    result = "sonuç başarılı";
            //}

            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: "); city = Console.ReadLine();

            //if (city=="adana" | city=="ankara" | city=="hatay" | city=="trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}

            #endregion


            #region Mod İşlemleri

            //int number = 26;
            //int result = number % 2;
            //Console.WriteLine(result);

            //Console.Write("lütfen 1.sayıyı giriniz: "); int number1 = int.Parse(Console.ReadLine());
            //Console.Write("lütfen 2.sayıyı giriniz: "); int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.Write($"1.sayının 2.sayıya bölümünden kalan : {result}");

            //Console.Write("Lütfen sayyı giriniz: "); int number = int.Parse(Console.ReadLine());

            //if(number % 2 == 0)
            //{
            //    Console.Write("sayı çifttir");
            //}else
            //{
            //    Console.Write("sayı tektir");
            //}

            //char team;
            //Console.Write("Lütfen takım sembolünü seçiniz : "); team = char.Parse(Console.ReadLine());



            //if (team == 'g')
            //{
            //    Console.Write("Galatasaray");
            //}
            //if(team == 'f')
            //{
            //    Console.Write("Fenerbahçe");
            //}
            //if (team == 'b')
            //{
            //    Console.Write("başiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması 

            //Console.WriteLine("***** C# Eğitim Kampı ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("---------------");
            //Console.WriteLine();


            //string menuItem;

            //Console.Write("deteyını görmek istediğiniz menü seçimi : ");
            //menuItem = Console.ReadLine();

            //if(menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Ana Yemekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk");
            //    Console.WriteLine("2-babagannuş");
            //    Console.WriteLine("1-patlıcan musakka");
            //    Console.WriteLine("1-fırında somon");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Çorbalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk çorbası");
            //    Console.WriteLine("2-babagannuş çorbası");
            //    Console.WriteLine("1-patlıcan musakka çorbası");
            //    Console.WriteLine("1-fırında somon çorbası");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Pizzalar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk pizza");
            //    Console.WriteLine("2-babagannuş pizaa");
            //    Console.WriteLine("1-patlıcan musakka pizza");
            //    Console.WriteLine("1-fırında somon pizza");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----İcecekler-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk içecek");
            //    Console.WriteLine("2-babagannuş içecek");
            //    Console.WriteLine("1-patlıcan musakka iççecel");
            //    Console.WriteLine("1-fırında somon içecek");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----Tatlılar-----");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri soslu tavuk tatlı");
            //    Console.WriteLine("2-küenefe");
            //    Console.WriteLine("1-patlıcan musakka tatlısı");
            //    Console.WriteLine("1-fırında somon tatlısı");
            //    Console.WriteLine();
            //}

            #endregion

            #region switch case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int mountNumber = int.Parse(Console.ReadLine());

            //switch (mountNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ocak"); break;
            //    case 9: Console.Write("Ocak"); break;
            //    case 10: Console.Write("Ocak"); break;
            //    case 11: Console.Write("Ocak"); break;
            //    case 12: Console.Write("Ocak"); break;

            //default: Console.Write("hata veri girişi"); break;
            //}


            #endregion

            #region Switch kullanarak hesap makinesi

            int number1, number2, result;

            char symbol;

            Console.Write("birinci sayısı giriniz: "); number1 = int.Parse(Console.ReadLine());
            Console.Write("ikinc sayısı giriniz: "); number2 = int.Parse(Console.ReadLine());

            Console.Write("lütfen yapmak istediğiniz işlemi giriniz : ");
            symbol = char.Parse(Console.ReadLine());

            switch (symbol)
            {
                case '+':
                    result = number1 + number2;
                    Console.WriteLine($"Toplam : {result}"); break;
                case '-':
                    result = number1 - number2;
                    Console.WriteLine($"çıktısı : {result}"); break;
                case '/':
                    result = number1 / number2;
                    Console.WriteLine($"bölmesi : {result}"); break;
                case '*':
                    result = number1 * number2;
                    Console.WriteLine($"çarpması : {result}"); break;
            }

            #endregion


            Console.Read();
            
            
            
            
        }

    }
}
