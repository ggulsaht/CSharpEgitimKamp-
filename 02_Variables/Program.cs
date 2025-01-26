using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Double Degişkenler 

            //double number; 

            //number = 4.85;

            //Console.WriteLine(number); 

            //Console.WriteLine("******* Fiyat Listesi ******* ");

            //Console.WriteLine();

            //Double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //Console.WriteLine();
            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("--------- Elma Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("--------- Portakal Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("--------- Çilek Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("--------- Patates Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("--------- Domates Fiyatı:" + tomatoPrice + "TL");

            //Double appleGram , orangeGram , strawberryGram , patatoGram , tomatoGram ;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //patatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double patatoTotalPrice = patatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün : Elma - " + "Birim Fiyatı : " + applePrice + "Gramaj : " + appleGram + "Toplam tutar : " + appleTotalPrice); 
            //Console.WriteLine("Alınan Ürün : Portakal - " + "Birim Fiyatı : " + orangePrice + "Gramaj : " + orangeGram + "Toplam tutar : " + orangeTotalPrice); 
            //Console.WriteLine("Alınan Ürün : Çilek- " + "Birim Fiyatı : " + strawberryPrice + "Gramaj : " + strawberryGram + "Toplam tutar : " + strawberryTotalPrice); 
            //Console.WriteLine("Alınan Ürün : Patates - " + "Birim Fiyatı : " + potatoPrice + "Gramaj : " + patatoGram + "Toplam tutar : " + patatoTotalPrice); 
            //Console.WriteLine("Alınan Ürün : Domates - " + "Birim Fiyatı : " + tomatoPrice + "Gramaj : " + tomatoGram + "Toplam tutar : " + tomatoTotalPrice); 

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + tomatoTotalPrice + patatoTotalPrice + strawberryTotalPrice ;

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutar" + shoppingTotalPrice + "TL");






            #endregion

            #region Char Değişkenler 

            //ABCDEFG
            //DEF....
            //TOPLANTI SAAT 20:00'DE 
            // " ' 

            //char symbol;
            //symbol = 'a'; 

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler 

            //Console.WriteLine("******CSharp Hava Yolları Yolcu Bilgisi *******");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge ,passengerIdentityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.WriteLine("İlçe Bilgisi : ");
            //passengerDistrict = Console.ReadLine();

            //Console.WriteLine("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();

            //Console.WriteLine("Yaş bilgisi : ");
            //passengerAge = Console.ReadLine();

            //Console.WriteLine("Yolcu TC Kimlik No : ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("---------------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No : " + passengerIdentityNumber +" - Yolcu Ad Soyad:" + passengerName + " / " + passengerSurname + "/" +passengerDistrict + "/" + passengerCity + "/"  ) ;


            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler 

            //ABC12D

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount , computerCount , chairCount , tvCount ;

            //Console.WriteLine("Lütfen aldığınız ayakkabı sayısını giriniz : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız bilgisayar  sayısını giriniz : ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız sandalye  sayısını giriniz : ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen aldığınız televizyon  sayısını giriniz : ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount*shoesPrice + computerCount*computerPrice + chairCount*chairPrice + tvCount*tvPrice;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar : " + totalPrice );




            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri 

            //double exam1,exam2 ,exam3 , result ;

            //Console.WriteLine("Lütfen 1.sınav Notunu giriniz : ");
            //exam1 =double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 2.sınav Notunu giriniz : ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen 3.sınav Notunu giriniz : ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1+exam2 + exam3 )/ 3 ;
            //Console.WriteLine("Sınav Ortalamanız : " + result);


            #endregion

            #region Klavyeden Karakter Girişleri 

            //char gender;

            //Console.WriteLine("Lütfen cinsiyet seçiniz : ");
            //gender = char.Parse(Console.ReadLine());

            //Console.Write("Seçtiginiz Cinsiyet: " +gender);

            #endregion

            Console.Read();
        }
    }
}
