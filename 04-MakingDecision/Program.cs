using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.Write("Lütfen Şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Tekrar deneyiniz");
            //}


            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz veri yanlış");
            //}

            //int num;
            //Console.Write("Sayıyı Giriniz: ");
            //num = int.Parse(Console.ReadLine());

            //if (num == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Tekrar deneyiniz");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "Değerleri giriniz";

            //Console.Write("Sınav1: ");
            //exam1= int.Parse(Console.ReadLine());

            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);

            //if (average> 0 & average<= 50)
            //{
            //    result = "Sınavdan kaldın";
            //}
            //if (average>50 & average<=70)
            //{
            //    result = "Sınav vasat";
            //}
            //if (average > 70 & average <= 100)
            //{
            //    result = "Sınav çok iyi";
            //}
            //    Console.WriteLine(result);
            //Console.WriteLine("Lütfen Kullanıcı adı giriniz: ");
            //string  userName = Console.ReadLine();

            //if (userName != "admin")
            //{
            //    Console.WriteLine("bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("kullanıcı adı doğrudur");
            //}



            #endregion

            #region Mod İşlemleri

            //int num;
            //num = 26;
            //int result = num % 5;
            //Console.WriteLine(result);

            //Console.Write("1. sayıyı giriniz: ");
            //int num1 = int.Parse(Console.ReadLine());

            //Console.Write("2. sayıyı giriniz: ");
            //int num2 = int.Parse(Console.ReadLine());   

            //int result = num1 % num2;

            //Console.Write("1. sayının 2. sayıya bölümünden kalan: " +result);

            //Console.Write("sayı giriniz: ");
            //int num = int.Parse(Console.ReadLine());

            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("sayı çift");
            //}
            //else
            //{
            //    Console.WriteLine("sayı tek");
            //}
            #endregion

            #region Char karar yapıları ile uygulama

            //char team;
            //Console.Write("Lütfen takımın ilk harfini giriniz: ");
            //team = char.Parse(Console.ReadLine());
            //string result = "Takım bulunamadı";

            //if (team == 'g' | team == 'G')
            //{
            //    result = "Galatasaray";
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    result = "Fenerbahçe";
            //}
            //if(team == 'b' | team == 'B')
            //{
            //    result = "Beşiktaş";
            //}
            //if (team == 't' | team == 'T')
            //{
            //    result = "Trabzon";
            //}
            //Console.WriteLine(result);
            #endregion

            #region örnek uygulamalar

            //Console.WriteLine("****** Restorant ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pideler");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");

            //string menuItem;

            //Console.WriteLine("Menü detay içerikleri: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine("Ana Yemekler");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Lahmacun");
            //    Console.WriteLine("2-Izgara Köfte");
            //    Console.WriteLine("3-Tavuk Kanat Izgara");
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine("Çorbalar");
            //    Console.WriteLine();
            //    Console.WriteLine("1-mercimake");
            //    Console.WriteLine("2-Tahrana");
            //    Console.WriteLine("3-Analı Kıazlı");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("Pideler");
            //    Console.WriteLine();
            //    Console.WriteLine("1-kuşbaşılı");
            //    Console.WriteLine("2-Kaşarlı");
            //    Console.WriteLine("3-Yumurtalı Ispanaklı");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine("İçecekler");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Çay");
            //    Console.WriteLine("2-ayran");
            //    Console.WriteLine("3-Şalgam");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine("Tatlılar");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Şekerpare");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("3-timusu");
            //}
            //else
            //{
            //    Console.WriteLine("Lütfen var olan dışına çıkmayınız.");
            //}



            #endregion

            #region Switch Case

            //int monthNum;
            //Console.Write("Lütfen ay girin: ");
            //monthNum = int.Parse(Console.ReadLine());

            //switch (monthNum)
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("mayıs"); break;
            //    case 6: Console.Write("haziran"); break;
            //    case 7: Console.Write("temmuz"); break;
            //    case 8: Console.Write("ağustos"); break;
            //    case 9: Console.Write("eylül"); break;
            //    case 10: Console.Write("ekim"); break;
            //    case 11: Console.Write("kasım"); break;
            //    case 12: Console.Write("aralık"); break;
            //    default: Console.Write("hatalı veri girişi"); break ;
            //}

            #region Hesap Makinesi

            //int num1, num2, result;
            //char symbol;

            //Console.Write("1.sayı: ");
            //num1 = int.Parse(Console.ReadLine());


            //Console.Write("2.sayı: ");
            //num2 = int.Parse(Console.ReadLine());

            //Console.Write("İşelem:  ");
            //symbol= char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        Console.WriteLine("toplam: " + result);
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        Console.WriteLine("fark: " + result);
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        Console.WriteLine("çarpım: " + result);
            //        break;
            //    case '/':
            //        result = num1 / num2;
            //        Console.WriteLine("bölüm: " + result);
            //        break;

            //        default: Console.WriteLine("geçerli bir işlem giriniz"); break;
            //}


            #endregion

            #endregion
            Console.Read();
            
        }
    }
}
