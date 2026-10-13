using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Oyuncu Bilgi Sistemine Hoş Geldiniz! ****");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");


            while (true)
            {
                int playerId;
                string playerName;
                string mainChamp;
                decimal winRate;

                Console.WriteLine("1. Oyuncu Ekle");
                Console.WriteLine("2. Oyuncu Sil");
                Console.WriteLine("3. Oyuncu Güncelle");
                Console.WriteLine("4. Oyuncu Listele");

                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz:");
                string secim = Console.ReadLine();

                if (secim == "1")
                {
                    Console.Write("Oyuncu Adını giriniz:");
                    playerName = Console.ReadLine();
                    Console.Write("Ana Şampiyonu giriniz:");
                    mainChamp = Console.ReadLine();
                    Console.Write("Kazanma Oranını giriniz:");
                    winRate = Convert.ToDecimal(Console.ReadLine());

                    // Oyuncu ekleme işlemi burada yapılacak
                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GamerDB;Integrated Security=True");

                    connection.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO Players (NickName, MainChamp, WinRate) VALUES (@NickName, @MainChamp, @WinRate)", connection);
                    command.Parameters.AddWithValue("@NickName", playerName);
                    command.Parameters.AddWithValue("@MainChamp", mainChamp);
                    command.Parameters.AddWithValue("@WinRate", winRate);
                    command.ExecuteNonQuery();


                    Console.WriteLine("Oyuncu başarıyla eklendi!");

                    Console.Write("Devam etmek için bir tuşa basın...");
                    Console.ReadKey();
                    Console.Clear();

                    connection.Close();

                }
                else if (secim == "2")
                {
                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GamerDB;Integrated Security=True");
                    connection.Open();
                    SqlCommand commandList = new SqlCommand("SELECT * FROM Players", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(commandList);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    Console.WriteLine("id-nickName-mainChamp-winRate");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item.ToString() + " ");
                        }
                        Console.WriteLine();
                    }
                    connection.Close();

                    Console.Write("Silmek istediğiniz oyuncunun ID'sini giriniz:");
                    playerId = Convert.ToInt32(Console.ReadLine());

                    // Oyuncu silme işlemi burada yapılacak
                   
                    connection.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM Players WHERE PlayerId = @PlayerId", connection);
                    command.Parameters.AddWithValue("@PlayerId", playerId);
                    command.ExecuteNonQuery();
                    Console.WriteLine("Oyuncu başarıyla silindi!");

                    Console.Write("Devam etmek için bir tuşa basın...");

                    Console.ReadKey();
                    Console.Clear();


                    connection.Close();
                }

                else if (secim == "3")
                {
                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GamerDB;Integrated Security=True");
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Players", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    Console.WriteLine("id-nickName-mainChamp-winRate");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item.ToString() + " ");
                        }
                        Console.WriteLine();
                    }
                    connection.Close();


                    Console.Write("Güncellemek istediğiniz oyuncunun ID'sini giriniz:");
                    playerId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Yeni Oyuncu Adını giriniz:");
                    playerName = Console.ReadLine();
                    Console.Write("Yeni Ana Şampiyonu giriniz:");
                    mainChamp = Console.ReadLine();
                    Console.Write("Yeni Kazanma Oranını giriniz:");
                    winRate = Convert.ToDecimal(Console.ReadLine());
                    // Oyuncu güncelleme işlemi burada yapılacak

                    connection.Open();
                    SqlCommand updateCommand = new SqlCommand("UPDATE Players SET NickName = @NickName, MainChamp = @MainChamp, WinRate = @WinRate WHERE PlayerId = @PlayerId", connection);
                    updateCommand.Parameters.AddWithValue("@PlayerId", playerId);
                    updateCommand.Parameters.AddWithValue("@NickName", playerName);
                    updateCommand.Parameters.AddWithValue("@MainChamp", mainChamp);
                    updateCommand.Parameters.AddWithValue("@WinRate", winRate);
                    updateCommand.ExecuteNonQuery();
                    Console.WriteLine("Oyuncu başarıyla güncellendi!");

                    Console.Write("Devam etmek için bir tuşa basın...");
                    Console.ReadKey();
                    Console.Clear();

                    connection.Close();
                }

                else if (secim == "4")
                {
                    // Oyuncuları listeleme işlemi burada yapılacak
                    SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GamerDB;Integrated Security=True");
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT * FROM Players", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    Console.WriteLine("id-nickName-mainChamp-winRate");

                    foreach (DataRow row in dataTable.Rows)
                    {
                        foreach (var item in row.ItemArray)
                        {
                            Console.Write(item.ToString() + " ");
                        }
                        Console.WriteLine();
                    }
                    connection.Close();

                    Console.Write("Devam etmek için bir tuşa basın...");
                    Console.ReadKey();
                    Console.Clear();
                }


                else
                {
                    Console.WriteLine("Geçersiz bir seçenek girdiniz. Lütfen tekrar deneyin.");
                    Console.ReadKey();
                    Console.Clear();
                }

            }

        }
    } 
}
