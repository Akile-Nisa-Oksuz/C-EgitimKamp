using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            string tableNumber;

            Console.WriteLine("------Ürün-Kategori-------");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.Write("Getirmek istediğiniz tablo numarası: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------");

            SqlConnection conneection = new SqlConnection("Data Source=NISADESKTOP\\SQLEXPRESS;initial Catalog=EgitimKampiDB;integrated security=true");
            conneection.Open();
            SqlCommand command = new SqlCommand("Select * From Table_1Category", conneection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dateTable = new DataTable();
            adapter.Fill(dateTable);
            conneection.Close();

            foreach (DataRow row in dateTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
