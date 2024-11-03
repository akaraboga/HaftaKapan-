using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaftaKapanış
{
    internal class Program
    { //Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi, 
        static void Main(string[] args)
        {

            tekrar:
            Console.WriteLine("Hangisini kayıt edeceksiniz? 1-Telefon 2-Bilgisayar");
            int secim = Convert.ToInt32(Console.ReadLine());
            // Telefon tel =new Telefon();
            Console.Clear();
            
            if (secim == 1)
            {

                Console.WriteLine("Kayıt etmek istediğiniz telefonun ozelliklerini giriniz");

                Console.Write("Seri no : ");
                string SeriNo = Console.ReadLine();
                Console.Write("Adı : ");
                string Ad = Console.ReadLine();
                Console.Write("Urun acıklaması : ");
                string Açıklama = Console.ReadLine();
                Console.Write("Urun isletim sistemi : ");
                string İsletimSistemi = Console.ReadLine();
                Console.Write("Modeli : ");
                string model = Console.ReadLine();


                Console.Write("Tr lisansı : ");
                string lisans = Console.ReadLine();



                Telefon tel = new Telefon(SeriNo, Ad, Açıklama, İsletimSistemi);
                Console.Write("Uretim tarihi : ");
                tel.uretim();

                tel.Model = model;
                tel.TrLisans = lisans;
                tel.UrunADıGetir();

                Console.Clear();
                tel.BilgiYaz();
                tel.UrunADıGetir();


                Console.WriteLine("Tekrar cihaz kaydetmek istiyor musunuz? E || H");
                string sec = Console.ReadLine().ToUpper();

                if (sec == "E")
                {
                    Console.Clear();
                    goto tekrar;
                }
                else if (sec == "H")
                {
                    Console.WriteLine("Teşekkür ederiz");
                }

            }
            else if(secim == 2)
            {
                Console.WriteLine("Kayıt etmek istediğiniz bilgisayarın ozelliklerini giriniz");

                Console.Write("Seri no : ");
                string SeriNo = Console.ReadLine();
                Console.Write("Adı : ");
                string Ad = Console.ReadLine();
                Console.Write("Urun acıklaması : ");
                string Açıklama = Console.ReadLine();
                Console.Write("Urun isletim sistemi : ");
                string İsletimSistemi = Console.ReadLine();
                Console.Write("Modeli : ");
                string model = Console.ReadLine();
                Console.Write("Usb sayisi ");
                int sayi=Convert.ToInt32(Console.ReadLine());
                Console.Write("Bluetooth durumu : ");
                string bluettoth=Console.ReadLine();

                Bilgisayar pc = new Bilgisayar(SeriNo, Ad, Açıklama, İsletimSistemi);

                Console.Write("Uretim tarihi : ");
                pc.uretim();
                //  pc.UretimTarih = DateTime.Now;
                Console.Clear();
                pc.usb = sayi;
                pc.Bluetooth = bluettoth;
                pc.Model = model;

                

                pc.BilgiYaz();
                pc.UrunADıGetir();

                Console.WriteLine("Tekrar cihaz kaydetmek istiyor musunuz? E || H");
                string sec=Console.ReadLine().ToUpper();

                if(sec == "E")
                {
                    Console.Clear();
                    goto tekrar;
                }else if (sec == "H")
                {
                    Console.WriteLine("Teşekkür ederiz");
                }

            }
            else
            {
                Console.WriteLine("yanlış secim yaptınız lutfen 1 veya 2 ye basınız");
                goto tekrar;
            }

            Console.ReadLine();
        }
    }
}
