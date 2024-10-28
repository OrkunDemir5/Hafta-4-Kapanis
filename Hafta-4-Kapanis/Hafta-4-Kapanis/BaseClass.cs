using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafta_4_Kapanis
{
    abstract class BaseMakine
    {
        public string SeriNumarasi { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public string IsletimSistemi { get; set; }
        public DateTime UretimTarihi { get; private set; }

        public BaseMakine()
        {
            UretimTarihi = DateTime.Now;
        }

        public virtual void BilgileriYazdir()
        {
            Console.WriteLine($"Seri Numarası: {SeriNumarasi}");
            Console.WriteLine($"Ad: {Ad}");
            Console.WriteLine($"Açıklama: {Aciklama}");
            Console.WriteLine($"İşletim Sistemi: {IsletimSistemi}");
            Console.WriteLine($"Üretim Tarihi: {UretimTarihi}");
        }

        public abstract void UrunAdiGetir();
    }

    class Telefon : BaseMakine
    {
        public bool TrLisansli { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"TR Lisanslı mı: {(TrLisansli ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
        }
    }

    class Bilgisayar : BaseMakine
    {
        private int _usbGirisSayisi;
        public int UsbGirisSayisi
        {
            get { return _usbGirisSayisi; }
            set
            {
                if (value == 2 || value == 4)
                    _usbGirisSayisi = value;
                else
                {
                    Console.WriteLine("Uyarı: Usb Giriş Sayısı sadece 2 veya 4 olabilir. Geçersiz değer atandı, Usb Giriş Sayısı -1 olarak ayarlandı.");
                    _usbGirisSayisi = -1;
                }
            }
        }
        public bool Bluetooth { get; set; }

        public override void BilgileriYazdir()
        {
            base.BilgileriYazdir();
            Console.WriteLine($"USB Giriş Sayısı: {UsbGirisSayisi}");
            Console.WriteLine($"Bluetooth Var mı: {(Bluetooth ? "Evet" : "Hayır")}");
        }

        public override void UrunAdiGetir()
        {
            Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
        }
    }
}
