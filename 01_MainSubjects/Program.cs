using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları

            //Console.Write("Ekrana Yazdırır");
            //Console.WriteLine("Ekrana Yazdırır ve aşağı satıra geçer");
            //Console.Read();//ekran çıktısını okumanı sağlar.

            #endregion

            #region Değişkenler 

            //string (Değişken_türü değişken_adı)

            //string name;
            //name = "Bora";
            //Console.Write(name);
            //Console.Read();

            //int (Değişken_türü değişken_adı)

            //int sayi1, sayi2;

            //sayi1 = 12;
            //sayi2 = 4;

            //int Toplam = sayi1 + sayi2;
            //int Fark = sayi1 - sayi2;
            //int Çarpım = sayi1 * sayi2;
            //int Bölüm = sayi1 / sayi2;

            //Console.WriteLine("12 + 4 : " +Toplam);
            //Console.WriteLine("12 - 4 : " + Fark);
            //Console.WriteLine("12 x 4 : " + Çarpım);
            //Console.WriteLine("12 / 4 : " + Bölüm);

            #endregion

            #region Hesap Makinesi Denemesi if-else

            //string secim;


            //Console.WriteLine("yapmak istediğiniz işlemi seçiniz : + , - , * , / ");

            //Console.WriteLine();

            //Console.Write("Seçiminiz : ");
            //secim = Console.ReadLine();


            //if  (secim == "+")
            //{ 
            //    Console.Write("1.Sayıyı Giriniz : ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("2.Sayıyı Giriniz : ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 + sayi2;
            //    Console.WriteLine("Sonuç : " + sonuc);

            //}
            //else if  (secim == "-")
            //{ 
            //    Console.Write("1.Sayıyı Giriniz : ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("2.Sayıyı Giriniz : ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 - sayi2;
            //    Console.WriteLine("Sonuç : " + sonuc);
            //}
            //else if  (secim == "*")
            //{ 
            //    Console.Write("1.Sayıyı Giriniz : ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("2.Sayıyı Giriniz : ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 * sayi2;
            //    Console.WriteLine("Sonuç : " + sonuc);
            //}
            //else if  (secim == "/")
            //{ 
            //    Console.Write("1.Sayıyı Giriniz : ");
            //    int sayi1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("2.Sayıyı Giriniz : ");
            //    int sayi2 = Convert.ToInt32(Console.ReadLine());

            //    int sonuc = sayi1 / sayi2;
            //    Console.WriteLine("Sonuç : " + sonuc);
            //}

            //else { Console.WriteLine("HATALI İŞLEM SEÇİMİ!!!"); }


            #endregion

            #region Hesap Makinesi Switch case

            //Console.WriteLine("İşlem Seçiminizi Yapınız : + , - , * , / ");
            //string secim = Console.ReadLine();

            //int sonuc = 0;

            //Console.WriteLine("1.Sayıyı Giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2.Sayıyı Giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //switch (secim)
            //{
            //    case "+":
            //        sonuc = sayi1 + sayi2;
            //        Console.WriteLine("Sonuç : " + sonuc);
            //        break;
            //    case "-":
            //        sonuc = sayi1 - sayi2;
            //        Console.WriteLine("Sonuç : " + sonuc);
            //        break;
            //    case "*":
            //        sonuc = sayi1 * sayi2;
            //        Console.WriteLine("Sonuç : " + sonuc);
            //        break;
            //    case "/":
            //        sonuc = sayi1 / sayi2;
            //        Console.WriteLine("Sonuç : " + sonuc);
            //        break;

            //    default:
            //        Console.WriteLine("HATALI İŞLEM");
            //        break;
            //}

            #endregion

            #region Döngüler

            //for(x;y;z) x=başlangıç , y=bitiş , z=artış-azalış
            //for (int i = 1; i < 5; i++(i+=3))
            //{
            //    Console.WriteLine(i);

            //}
            //Console.Read();

            //while(x<y)  x&y=şart değeri
            //{
            //z işlem
            //}



            #endregion

            #region Örnek Soru

            //Console.Write("sayı giriniz : ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int birler, onlar, yuzler, toplam=0;

            //birler = sayi % 10;
            //onlar = (sayi % 100) / 10;
            //yuzler = sayi / 100;

            //toplam = birler + onlar + yuzler;
            //Console.Write(toplam);



            #endregion

            #region Diziler

            //Değişke Türü [] Dizi adı =new Değişken türü[eleman sayısı]

            //string[] mevsimler = new string[4];

            //mevsimler[0] = "ilkbahar";
            //mevsimler[1] = "yaz";
            //mevsimler[2] = "sonbahar";
            //mevsimler[3] = "kış";

            //Console.WriteLine(mevsimler[0]);
            //Console.WriteLine(mevsimler[1]);
            //Console.WriteLine(mevsimler[2]);
            //Console.WriteLine(mevsimler[3]);
            //Console.Read();

            #endregion

            #region foreach döngüsü

            //foreach (1;2;3;4)
            //{
            //1=değişken türü
            //2=değişken adı
            //3=in
            //4=liste,koleksiyon,dizi
            //}

            //int[] numbers = {1,2,3,4,5,6,7,8,9 };

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            //foreach (int number in numbers)
            //{
            //    if(number%2 == 0) { Console.WriteLine(number); }
            //}

            #endregion

            #region Metotlar

            //Metotlar ikiye ayrılır
            //1-Geriye değer döndürmeyen metotlar
            //Customer--> Listele,ekle,sil,güncelle
            //void

            //void eleman()
            //{
            //    Console.WriteLine("eleman1");
            //    Console.WriteLine("eleman2");
            //    Console.WriteLine("eleman3");
            //    Console.WriteLine("eleman4");
            //}

            //eleman();
            //Console.Read();

            //parametreli geriye değer döndürmeyen metot

            //void kayit (string isim,string soyisim)
            //{
            //    Console.WriteLine("Müşteri : "+ isim + " " + soyisim);
            //}

            //kayit("Bora","İrgin");
            //kayit("Barış","İrgin");
            //kayit("Hüseyin","İrgin");
            //kayit("Gülseren","İrgin");


            ///////////////////////////////////////////////////////////////

            //Geriye Değer Döndüren Metotlar

            //string OgrenciKarti()
            //{
            //    string name = "Bora";
            //    string surName = "İrgin";

            //    return name + " " + surName;
            //}

            //Console.WriteLine(OgrenciKarti());

            //Console.Read();

            //Geriye Değer Döndüren Parametreli Metotlar

            //string secimler (string item, string silah, string karakter)
            //{
            //    string info = "İtem: " + item + " Silah: " + silah + " karakter: " + karakter;
            //    return info;
            //}

            //string x, y, z;

            //Console.Write("İtem adı giriniz: ");
            //x = Console.ReadLine();
            //Console.Write("Silah adı giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("Karakter adı giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(secimler(x,y,z));
            //Console.Read();

            #endregion

        }
    }
}
