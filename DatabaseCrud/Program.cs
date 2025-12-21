using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD -> create-read-update-delete

            Console.WriteLine("****** Menü Sipariþ Ýþlem Bölümü ******");
            Console.WriteLine();

            Console.WriteLine("------------------");

            #region kategori ekleme iþlemi
            //Console.Write("Eklemek istediðiniz kategori adý : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KM10E7C;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@c1)", connection);
            //command.Parameters.AddWithValue("@c1", categoryName );
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Ekleme Ýþlemi Baþarýlý");

            #endregion

            #region  Ürün ekleme iþlemi 

            //string productName;
            //decimal productPrice;
            //// bool productStatus;

            //Console.Write("Ürün Adý: "); productName = Console.ReadLine();
            //Console.Write("Ürün Fiyatý: "); productPrice =decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KM10E7C;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, Productprice) values (@n1 , @p1)", connection);
            //command.Parameters.AddWithValue("@n1", productName);
            //command.Parameters.AddWithValue("@p1", productPrice);

            //command.ExecuteNonQuery();



            //connection.Close();

            //Console.WriteLine("ürün eklemesi baþarýlý");

            #endregion

            #region Ürün Listeleme Ýþlemi

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KM10E7C;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach(var item in row.ItemArray)
            //    {
            //        Console.Write($" {item.ToString()} {"-"}");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme Ýþlemi
            //Console.Write("Silmek istediðiniz ürünün ID'sini giriniz: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KM10E7C;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete from TblProduct where ProductID=@id", connection);
            //command.Parameters.AddWithValue("@id", productId);
            //command.ExecuteNonQuery();
            // connection.Close();

            //Console.WriteLine("Ürün silme iþlemi baþarýlý.");

            #endregion

            #region Ürün Güncelleme iþlemi

            Console.Write("Güncellenecek ürün ID : ");
            int productID = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek ürün Adý : ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek ürün Fiyatý : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KM10E7C;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();

            SqlCommand command = new SqlCommand("Update TblProduct Set productName=@productName, productPrice=@productPrice where productID=@productID", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productID", productID);
            command.ExecuteNonQuery();
             
            connection.Close();

            Console.WriteLine("güncelleme tamamlandý");

            #endregion

            Console.Read();

            #endregion

        }
    }
}
