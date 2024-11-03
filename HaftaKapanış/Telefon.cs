using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HaftaKapanış
{
    public class Telefon : BaseMakine
    {

        
        public Telefon( string SeriNo, string ad, string acıklama, string İsletimS) : base(  SeriNo, ad, acıklama, İsletimS )//Bilgiayar calssında ki işlemlerin aynısı yapılmıştır.
        {
        }

        public string Model { get; set; }
        public string TrLisans { get; set; }

        public override void BilgiYaz()
        {
            base.BilgiYaz();
            Console.WriteLine("Modeli : {0}",Model);
            Console.WriteLine("Tr lisans durumu : {0}",TrLisans);

        }

        public override void UrunADıGetir()
        {
            Console.WriteLine("Telefonuzun adı ----> adı : {0}",Ad);
        }

        
    }

}
