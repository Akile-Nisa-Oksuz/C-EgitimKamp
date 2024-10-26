using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü[Elaman sayısı]

            //string[] colors = new string[4];
            //colors[0] = "kırmızı";
            //colors[1] = "mavi";
            //colors[2] = "siyah";
            //colors[3] = "mor";

            //Console.WriteLine(colors[3]);

            //indekse değer atamsı yapılmazsa dufalt değeri sıfır olur

            //string[] cities = { "prag", "roma", "atina", "ankara", "maraş" };
            //Console.WriteLine(cities[4]);
            #endregion

            #region Dizilerdeki Tüm elemanları sıralama

            //string[] colors = { "sarı", "mor", "kırmızı", "mavi", "yeşil", "turuncu", "pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] nums = { 4, 853, 563, 159, 246, 646, 1207, 547, 945, 51, 97 };

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] % 3 == 0)
            //    {
            //        Console.WriteLine(nums[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 56, 89, 157, 78, 35, 65, 456, 946 };
            //int maxNum = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNum)
            //    {
            //        maxNum = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNum);
            //yukarıda verilen array yapısında dizinin ilk elemanına değer atanır sonra
            //if döngüsü içerisinde eğer atanan değer ilk değerden büyükse 
            //büyük değer ile değiştirir dizideki en büyük değer gelince döngü biter
            #endregion

            #region Dizilerdeki metodlar

            //string[] person = { "ali", "ahmet", "ayşe", "buse", "nisa" };
            //Console.WriteLine(person.Length);
            //.length => dizideki eleman sayısı/dize uzunluğu

            //int[] num = { 56, 465, 159, 489, 45, 7837, 675, 8970 };
            //Array.Sort(num);
            //array.sort(); => küçükten büyüğe diziyi sıralar

            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] num = { 56, 465, 159, 489, 45, 7837, 675, 8970 };
            //Array.Reverse(num);
            // array.reverse -> diziyi tersten sıralar  <- <- <- <-
            //for (int i = 0; i < num.Length; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //Array.IndexOf(); => elemanı yazıp kaçıncı dizeye geldiği

            //değikenadı.Max() => en büyük değer değişkenAdı.Min() => en küçük değer



            #endregion

            #region Kullanıcadan Değer Alma

            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Griniz:");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("--------------");

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] nums = {10,20,30,40,50};
            //int sum = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}
            //Console.WriteLine(sum);

            //int[] num = { 654, 3254, 487, 65, 94, 31, 58, 27 };
            //Array.Sort(num);

            //Console.WriteLine("çift sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 == 0)
            //    {
            //        Console.WriteLine(num[i]);
            //    }
               
            //}
            
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 2 != 0)
            //    {
            //        Console.WriteLine(num[i]);
            //    }
            //}
            #endregion

            Console.Read();
        }
    }
}
