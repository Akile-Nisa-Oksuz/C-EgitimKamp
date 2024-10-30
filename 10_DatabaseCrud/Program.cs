using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create-Read-Update-Delete

            Console.WriteLine("**** Menü Sipariş Paneli ****");
            Console.WriteLine();

            Console.WriteLine("-------------------------------");

            #region SQL Kategory Ekleme
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName = Console.ReadLine(); 

            //SqlConnection connection = new SqlConnection("Data Source=NISADESKTOP\\SQLEXPRESS;initial catalog=EgitimKampiDB; integrated security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into Table_1Category (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Kategory başarıyla eklendi.");
            #endregion

            #region SQL ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("ürün fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=NISADESKTOP\\SQLEXPRESS;initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TDB_Product (ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklme başarılı");


            #endregion

            #region Ürün listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=NISADESKTOP\\SQLEXPRESS;initial catalog=EgitimKampiDB; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TDB_Product",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row  in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " / ");
            //    }
            //    Console.WriteLine();
            //    Console.WriteLine();
            //}

            //connection.Close();



            #endregion

            #region Ürün silme işlemi

            //Console.Write("Ürün id ile silme işlemi: ");
            //int productId = int.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=NISADESKTOP\\SQLEXPRESS;initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TDB_Product Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();
            //Console.WriteLine("Silme işlemi yapıldı.");

            #endregion

            #region güncelleme işemli

            //Console.Write("güncellenecek id: ");
            //int productId= int.Parse(Console.ReadLine());

            //Console.Write("güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("güncellenecek ürün fiyat: ");
            //decimal productPrice = decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=NISADESKTOP\\SQLEXPRESS;initial catalog=EgitimKampiDB; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TDB_Product Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery(); 

            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı.");

            #endregion




            Console.Read();
        }
    }
}
