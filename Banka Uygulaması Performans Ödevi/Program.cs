using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Banka_Uygulaması_Performans_Ödevi
{
    public class Banka
    {
         int bakiye = 1000;
         int paracek;
         int parayatır;
         int havale;
         string adsoyad;
         int sifre;
         int secim;
         string isim;
         string kullanıcıadı;

        public void Kayıt()
        {
            bas2:
        giris:
            Console.Clear();
            Console.Write("İsminizi Giriniz: ");
            kullanıcıadı = Convert.ToString(Console.ReadLine());
            Console.Write("Şifrenizi Giriniz: ");
            int sifre;
            try
            {
                sifre = Convert.ToInt32(Console.ReadLine());

                if (sifre > 999 && sifre < 10000)
                {
                    Console.WriteLine("Giriş Başarılı");
                    Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("");
                bas1: 
                    Console.WriteLine("                                                                                                     Bakiyeniz: " + bakiye + " TL");
                    Console.WriteLine("                                             Para Çekmek İçin '1'");
                    Console.WriteLine("                                             Para Yatırmak İçin '2'");
                    Console.WriteLine("                                             Havale İçin '3'");
                    Console.WriteLine("                                             Çıkış Yapmak İçin '4'");
                    int secim1 = Convert.ToInt32(Console.ReadLine());
                    if (secim1 == 1)
                    {
                        Console.Clear();
                        paracekk();
                        Console.WriteLine("Ana Menüye Dönülüyor");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto bas1;
                    }
                    else if (secim1 == 2)
                    {
                        Console.Clear();
                        parayatir();
                        Console.WriteLine("Ana Menüye Dönülüyor");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto bas1;
                    }
                    else if (secim1 == 3)
                    {
                        Console.Clear();
                        havalee();
                        Console.WriteLine("Ana Menüye Dönülüyor");
                        Thread.Sleep(1000);
                        Console.Clear();
                        goto bas1;
                    }
                    else if (secim1 == 4)
                    {
                        
                        Console.WriteLine("Çıkış Yapılıyor...");
                        Thread.Sleep(1000);
                        goto bas2;
                    }
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Şifre 4 Haneli Olmalıdır");
                    Console.WriteLine("Devam Etmek İçin Herhangi Bir Tuşa Basınız");
                    Console.ReadKey();
                    goto giris;
                }
                Console.ReadKey();
            }

            catch
            {
                Console.WriteLine("Lütfen Doğru Şekilde Şifre Girişi Yapınız ");
                Console.WriteLine("Devam Etmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadKey();
                goto giris;
            }
            
        }
        
        public void paracekk()
        {
            try
            {
                Console.Write("Kaç TL Para Çekmek İstiyorsunuz: ");
                paracek = Convert.ToInt32(Console.ReadLine());
                
                if (paracek > bakiye)
                {
                    Console.WriteLine("Paranız Yetersiz");
                    Console.ReadKey();

                }
                else if(bakiye<0)
                {
                    Console.WriteLine("Lütfen Doğru Şekilde Giriş Yapınız!");
                    Console.ReadKey();
                }
                else
                {
                    bakiye -= paracek;
                    Console.WriteLine("Bakiyeniz: " + bakiye + " TL");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Lütfen Çekmek İstediğiniz Tutarı Giriniz ");
                Console.WriteLine("Devam Etmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadKey();
            }
            
        }

        public void parayatir()
        {
            try
            {
                Console.Write("Kaç TL Para Yatırmak İstiyorsunuz: ");
                parayatır = Convert.ToInt32(Console.ReadLine());
                if (parayatır > 0)
                {
                    bakiye += parayatır;
                    Console.WriteLine("Bakiyeniz: " + bakiye + " TL");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Lütfen Doğru Şekilde Giriş Yapınız!");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Lütfen Çekmek İstediğiniz Tutarı Giriniz ");
                Console.WriteLine("Devam Etmek İçin Herhangi Bir Tuşa Basınız");
                Console.ReadKey();
            }

           


        }

        public void havalee()
        {

            Console.WriteLine("Paranın Yatırılacağı İsmi Giriniz: ");
            adsoyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Kaç TL Havale Yapmak İstiyorsunuz: ");
            havale = Convert.ToInt32(Console.ReadLine());
            if (havale > 0)
            {
                bakiye -= havale;
                Console.WriteLine(kullanıcıadı + " Adlı Kişiden " + adsoyad + " Adlı Kişiye Havale Yapılıyor...");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("Bakiyeniz: " + bakiye + " TL");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Lütfen Doğru Şekilde Giriş Yapınız!");
                Console.ReadKey();
            }
        }
       
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Banka banka = new Banka();
            banka.Kayıt();
            Console.ReadKey();
        }
    }
}