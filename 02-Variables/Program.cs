using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region double değikenleri
            //double num;

            //num = 4.85;

            //Console.WriteLine(num);

            //Console.WriteLine("****Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePirce, orangePrice, strawberyPrice, patatoPrice, tomatoPrice;

            //applePirce = 15.67;
            //orangePrice = 20.90;
            //strawberyPrice = 70;
            //patatoPrice = 9.74;
            //tomatoPrice = 6.89;

            //Console.WriteLine("---> Elma Birim Fiyatı: " + applePirce + " TL" );
            //Console.WriteLine("---> Portakal Birim Fiyatı: " + orangePrice + " TL");
            //Console.WriteLine("---> Çilek Birim Fiyatı: " + strawberyPrice + " TL");
            //Console.WriteLine("---> Patates Birim Fiyatı: " + patatoPrice + " TL");
            //Console.WriteLine("---> Domates Birim Fiyatı: " + tomatoPrice + " TL");
            //Console.WriteLine();
            //Console.WriteLine();


            //double appleGram, orangeGram, stawberyGram, patatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.60;
            //stawberyGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.698;

            //double appleTotalPrice = appleGram * applePirce;

            //Console.WriteLine("Elmanın Toplam Fiyatı: " + appleTotalPrice);


            #endregion


            #region Char Değikenleri

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);


            #endregion


            #region Klavyeden veri girişler

            //Console.WriteLine("------ Nis Hava Yolları Yolcu Bilgisi -----");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge,
            //    passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("-------------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber + " / " + "Yolcu Ad Soyad: " + passengerName + passengerSurname + " / " +
            // " / "+ "Yaşadığı Yer: " + passengerDistrict + passengerCity + " " + "Yolcu Yaşı: " + passengerAge);


            #endregion


            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoePrice, computerPrice, chairPrice, tvPrice;

            //shoePrice = 2000;
            //computerPrice = 20000;
            //chairPrice = 500;
            //tvPrice = 12000;

            //int shoeCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız TV sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoeCount * shoePrice + computerCount * computerPrice + chairCount *
            //    chairPrice  + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: ");
            //Console.WriteLine(totalPrice);



            #endregion


            #region Klavyeden Ondalık Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav sonucunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav sonucunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav sonucunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.Write("Sınav Ortalamanız: ");
            //Console.WriteLine(result);

            #endregion


            #region klavyeden karakter girişi

            //char gender;
            //Console.Write("Lütfen cinsiyet seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion



            Console.Read();
        }
    }
}
