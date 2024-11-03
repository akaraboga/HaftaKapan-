using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaftaKapanış
{
    internal class Bilgisayar : BaseMakine//BaseClasdan kalıtım alıyoruz.
    {
        public Bilgisayar(string SeriNo, string ad, string acıklama, string İsletimS) : base(SeriNo, ad, acıklama, İsletimS)//BaseClas ın yapıcı metoduna parametrelerini veriyoruz.Bunlar ortak parametreler.
        {
        }



        public  string Model { get; set; }//Bu proplar da Bilgisayara ozel olan ozellikler.
        public string Bluetooth { get; set; }
        private int usbSayi { get; set; }
        public int usb//usb sayısını kapsulleyerek 2 veya 4 dısında değer girerse hata vermesini istiyoruz.
        {


            get
            {
                return usbSayi;
            }


            set
            {
                if (value == 2 || value == 4)
                {
                    usbSayi = value;
                }
                else
                {
                    Console.WriteLine("usb sayisi yalnızca 2 veya 4 olabilir");
                    usbSayi = -1;
                }

            }



        }







        public override void BilgiYaz()//virtual dedğimiz Bilgiyaz metodunu override ediyoruz ve pc ye ozel olan ozellikleri ekliyoruz
        {
            base.BilgiYaz();//ortak olan ozellikleri baseClas dan cekiyoruz.
            Console.WriteLine("usb sayisi : {0}",usb);
            Console.WriteLine("Bluetooth durumu : {0}",Bluetooth);
            Console.WriteLine("Bilgisayarın modeli : {0}",Model);

        }




        public override void UrunADıGetir()//abstract metodumuz buna da cihazon adını bastırıyoruz.
        {
            Console.WriteLine("Bilgisayarınızın adı -------> : {0}", Ad);
        }


    }

}
