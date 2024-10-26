using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Foreach Loops
            // foreach döngüsü 4 parametre alır
            // Foreach(1;2;3;4)
            //1: Değişken türü (int,string,..)
            //2: değişken adı
            //3: In
            //4: Liste veya kolksiyon veya Dizi

            //string[] cities = { "maraş", "bursa", "budapeşte", "çarşamba", "konya" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] nums = { 56, 34, 987, 1567, 3453, 22, 98, 49, 3247, 6 };

            //foreach (int num in nums) {
            //    Console.WriteLine(num);
            //}

            //int[] nums = { 56, 34, 987, 1564, 3453, 22, 98, 49, 3247, 6 };

            //foreach (int num in nums) {
            //    if (num%2 == 0)
            //    {
            //        Console.WriteLine(num);
            //    }
            //}

            //int[] nums = { 56, 34, 987, 1567, 3453, 22, 98, 49, 3247, 6 };

            //int total = 0;

            //foreach (int num in nums) {
            //    total += num;
            //}
            //Console.WriteLine(total);

            // list<değişken türü> değişken adı = new List<değişken türü>();
            //List<int> number = new List<int>()
            //{
            //    1,2,3,4,5,6,7,8,9
            //};
            //foreach (int num in number)
            //{
            //    Console.Write(num);
            //}

            //string word = "merhaba";

            //foreach (char c in word) 
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            //Console.WriteLine("Sınav Uygulaması");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("-------------------------");
            //Console.Write("Sınıftaki Öğrenci Sayısı: ");
            //int studentCount = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------");

            //string[] studentNames = new string[studentCount];
            //double[] studentExamAvg = new double[studentCount];
            //Console.WriteLine();

            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.Write($"{i+1}. öğrencinin ismini giriniz: ");
            //    studentNames[i] = Console.ReadLine();

            //    double totalExamResult = 0;

            //    //her öğrenci için 3 sınav notu girişi
            //    Console.WriteLine();
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"{studentNames[i]} adlı öğrencinin {j +1}. sınav notunu giriniz: ");
            //        double value = double.Parse( Console.ReadLine() );
            //        totalExamResult+= value; //notların toplama
            //    }
            //    Console.WriteLine();
            //    studentExamAvg[i] = totalExamResult / 3;
            //}
            //Console.WriteLine();
            ////sınav ortalamaları
            //for (int i = 0; i < studentCount; i++)
            //{
            //    Console.WriteLine($"{studentNames[i]} adlı öğrencinin ortalamsı: {studentExamAvg[i]}");


            //    //öğrencilerin ortalaması ve geçip/kalma
            //    if (studentExamAvg[i] >= 50)
            //    {
            //        Console.WriteLine("-----------");
            //        Console.WriteLine($"{studentNames[i]} Dersi Geçti");
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("-----------");
            //        Console.WriteLine($"{studentNames[i]} Dersten kaldı");
            //        Console.WriteLine();
            //    }
            //}


            #endregion

            Console.Read();
        }
    }
}
