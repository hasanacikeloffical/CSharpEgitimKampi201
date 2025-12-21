using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Veri Tabaný Baðlantýsý

            //Ado.net

            string tableNumber;


            Console.WriteLine("****** c# Veri Tabanlý ürün - Kategori bilgisi Sistemi");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("********************");
            Console.WriteLine("1- Kategoriler");
            Console.WriteLine("1- Ürünler");
            Console.WriteLine("1- Sipariþler");
            Console.WriteLine("1- Çýkýþ Yap");
            Console.Write("1- Lütfen getirmek istediðiniz tablooyu no giriniz : ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("********************");
              // sql bðlantýsý için kod
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-KM10E7C;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            //  adaptar bana köprü görevi görür
            SqlCommand command = new SqlCommand("Select * From TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);  // göstermek için bu kod kullanýlýr.
            connection.Close();

            foreach(DataRow row in dataTable.Rows)   // DataRow : datatableden gelen bir sýnýf türüdür
            {   
                foreach(var item in row.ItemArray)
                {
                    Console.Write($" {item.ToString()}");
                }
                Console.WriteLine();
            }
            #endregion

            Console.Read();

        }

    }
}
