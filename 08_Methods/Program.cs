using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Metotlar
            //Geriye değer döndürmeyen Met.
            //Customer --> listeler,ekle,sil,güncelle
            //void

            //void CustomerList()
            //{
            //    Console.WriteLine("nisa");
            //    Console.WriteLine("kayran");
            //    Console.WriteLine("elam");
            //    Console.WriteLine("selma");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void Sum()
            //{
            //    int x = 2;
            //    int y = 3;
            //    int z = x * y;
            //    Console.WriteLine(z);
            //}
            //Sum();




            #endregion

            #region Geriye.Değer.Döndürmeyen.StringParametreli.Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}
            //WriteMethod("Naber Dünya?");

            //void customerName(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: "+name+ " "+ surName);

            //}
            //customerName("Akile Nisa", "Öksüz");
            //customerName("Büşra İrem", "Çakır");

            #endregion

            #region Geriye.Değer.Döndürmeyen.İntParametreli.Metotlar

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}
            //Sum(20,30,50);


            #endregion

            #region Geriye Değer döndüren metotlar

            //string CustomerName()
            //{
            //    return "Akile Nisa Öksüz"; --> 'return ile kullanılır'
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "nisa";
            //    string surName = "yıldız";
            //    return name + "  " + surName;   
            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer döndüren String Parametreli metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "ülke: " + countryName +" "+ " Başkent: " + capital + " "+ 
            //        "bayrak renk: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;
            //Console.Write("Ülke adı: ");
            //x = Console.ReadLine();

            //Console.Write("Başkent: ");
            //y = Console.ReadLine();

            //Console.Write("Renk: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z)); 

            #endregion

            #region  Geriye Değer döndüren İnt Parametreli metotlar

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}
            //Console.WriteLine(Sum(56,96));
            //Console.WriteLine(Sum(78,23));
            //Console.WriteLine(Sum(49,57));
            //Console.WriteLine(Sum(123,524));
            #endregion

            #region Örnek uygulama

            //string ExamResult(string studentName, int exam1, int exam2, int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return studentName+ " isimli Öğrenci Sınavı Geçti " + " ortalam: "+ result;

            //    }
            //    else
            //    {
            //        return studentName + " isimli Öğrenci Sınavdan kaldı " + " ortalam: " + result;
            //    }
            //}
            //Console.WriteLine(ExamResult("Nisa", 65,35,48));
            //Console.WriteLine(ExamResult("kalender", 65,14,23));
            //Console.WriteLine(ExamResult("selma", 96,78,45));
            //Console.WriteLine(ExamResult("esin", 46,48,79));


            #endregion


            Console.Read();
        }
    }
}
