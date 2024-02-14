
using Entities.Concrete;
using Microsoft.VisualBasic;

namespace WorkAround
{
    class Program
    {
        static void Main(string[] args)
        {
            // Degiskenler();


            SelamVer(isim: "Engin");
            SelamVer(isim: "Ahmet");
            SelamVer(isim: "Ayşe");
            SelamVer();

            int sonuc = Topla(6, 58);

            //Arrays /Arrays

            //string ogrenci1 = "Engin";
            //string ogrenci2 = "Kerem";
            //string ogrenci3 = "Berkay";

            string[] ogrenciler = new string[3]; //ekrana sadece ilker basılıyor.
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";
            //defterin ust kısmında yazıyo.
            ogrenciler = new string[4];
            ogrenciler[3] = "İlker";       //new dedıgı an eskıyı bırakır yenı bır arrray olusturur orda da 0,1,2 null ama 3 de artık İlker vardır.**

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }

            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
            string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" }; //ankara,istanbul,izmir ,sonra ankarayı adana olarak degıstırıyorsun.***

            sehirler2 = sehirler1;
            sehirler1[0] = "Adana";
            Console.WriteLine(sehirler2[0]); 

            Person person1 = new Person();
            person1.FirstName = "Engin";

            Person person2=new Person();
            person2.FirstName= "Murat";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }

                List<string> yeniSehirler1 = new List<string> { "Ankara", "İstanbul", "İzmir"};
                yeniSehirler1.Add(item: "İzmir");
            

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz")
        {
            Console.WriteLine("Merhaba"+isim);
        }

        static int Topla(int sayi1=5,int sayi2 = 10)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : "+ sonuc.ToString());
            return sonuc;
        }
  
    }
}