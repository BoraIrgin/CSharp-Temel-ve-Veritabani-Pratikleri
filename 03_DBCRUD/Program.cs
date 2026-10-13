using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_DBCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CRUD-->Create-Read-Update-Delete
            #region Kategori Ekleme İşlemi
            Console.WriteLine("**** Menü Sipariş İşlem Paneli ****");
            Console.WriteLine();

            //Console.WriteLine("------------------------------");
            //Console.Write("Eklemek İstediğiniz kategori Adı : ");
            //string categoryname = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Database=EgitimKampıDB;Integrated Security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("INSERT INTO TBCategory (CategoryName) VALUES (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryname);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori Ekleme İşlemi Başarılı");
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.Write("Eklemek İstediğiniz Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Eklemek İstediğiniz ürünün Fiyatı : ");
            //productPrice = Convert.ToDecimal(Console.ReadLine());
            //// Console.Write("Eklemek İstediğiniz ürünün Durumu : ");
            //// productStatus = Convert.ToBoolean(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Database=EgitimKampıDB;Integrated Security=true");
            //connection.Open();

            //SqlCommand command = new SqlCommand("INSERT INTO TBProduct (ProductName, ProductPrice, ProductStatus) VALUES (@ProdutctName, @ProductPrice, @ProductStatus)", connection);
            //command.Parameters.AddWithValue("@ProdutctName", productName);
            //command.Parameters.AddWithValue("@ProductPrice", productPrice);
            //command.Parameters.AddWithValue("@ProductStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Ekleme İşlemi Başarılı");
            #endregion

            #region Ürün Listeleme İşlemi

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Database=EgitimKampıDB;Integrated Security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("SELECT * FROM TBProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silmek istediğiniz ürünün ID'sini giriniz : ");
            //int productId = Convert.ToInt32(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Database=EgitimKampıDB;Integrated Security=true");

            //connection.Open();

            //SqlCommand command = new SqlCommand("DELETE FROM TBProduct WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Silme İşlemi Başarılı");
            #endregion

            #region Ürün Güncelleme İşlemi
            

            //Console.Write("Güncellemek istediğiniz ürünün ID'sini giriniz : ");
            //int productId = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Güncellemek istediğiniz ürünün yeni adını giriniz : ");
            //string productName = Console.ReadLine();
            //Console.Write("Güncellemek istediğiniz ürünün yeni fiyatını giriniz : ");
            //decimal productPrice = Convert.ToDecimal(Console.ReadLine());
           
            //SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Database=EgitimKampıDB;Integrated Security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("UPDATE TBProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Ürün Güncelleme İşlemi Başarılı");


            #endregion

            Console.Read();
        }
    }
}
