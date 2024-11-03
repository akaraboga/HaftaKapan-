using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaftaKapanış
{
    public abstract class BaseMakine//Telefon ve Bilgisayar ın ortak ozelliklerini yazdığımız BaseClasımız.
    {
        //Üretim Tarihi, Seri Numarası, Ad, Açıklama, İşletim Sistemi ortak olan ozellikler.

        public DateTime UretimTarih { get; set; }//Bilgisayar ve telefon için ortak propertylerin tanımı
        public string SeriNum { get; set; }
        public string Ad { get; set; }
        public string Açıklama { get; set; }
        public string İsletimSistemi { get; set; }


        protected BaseMakine( string SeriNo, string ad, string acıklama, string İsletimS)//Parametre alan yapıcı metot
        {
            
            SeriNum = SeriNo;
            Ad = ad;
            Açıklama = acıklama;
            İsletimSistemi = İsletimS;

        }

        public  void uretim()//Uretim tarihini ayrı metot olarak aldık nesne olusturulunca otomatik yazılacak
        {
            UretimTarih=DateTime.Now;
        }
       public virtual void  BilgiYaz()//Bilgileri BilgiYAz metoduna yazıyoruz.BilgiYaz metoduna virtual diyerek miras verdiğimiz sınıfta override edicez.(polymorphism)
        {
            Console.WriteLine("Üretim tarihi : {0}",UretimTarih );
            Console.WriteLine("Seri numarası : {0}",SeriNum);
            Console.WriteLine("Adı : {0}",Ad);
            Console.WriteLine("Açıklama : {0}",Açıklama);
            Console.WriteLine("İşletim sistemi : {0}",İsletimSistemi);
        }

        public abstract void UrunADıGetir();//abstract metodumuz içeriğini miras aldığımız sınıfta dolduracağız.




    }


}
