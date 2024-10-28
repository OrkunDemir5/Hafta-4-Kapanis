using Hafta_4_Kapanis;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2'ye basın:");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Telefon telefon = new Telefon();
                BilgileriAl(telefon);
                Console.Write("TR Lisanslı mı? (Evet için 'e', Hayır için 'h'): ");
                telefon.TrLisansli = Console.ReadLine().ToLower() == "e";

                telefon.BilgileriYazdir();
                telefon.UrunAdiGetir();
                Console.WriteLine("Telefon başarıyla üretildi.");
            }
            else if (secim == "2")
            {
                Bilgisayar bilgisayar = new Bilgisayar();
                BilgileriAl(bilgisayar);
                Console.Write("USB Giriş Sayısı: ");
                bilgisayar.UsbGirisSayisi = int.Parse(Console.ReadLine());
                Console.Write("Bluetooth var mı? (Evet için 'e', Hayır için 'h'): ");
                bilgisayar.Bluetooth = Console.ReadLine().ToLower() == "e";

                bilgisayar.BilgileriYazdir();
                bilgisayar.UrunAdiGetir();
                Console.WriteLine("Bilgisayar başarıyla üretildi.");
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                continue;
            }

            Console.Write("Başka bir ürün üretmek istiyor musunuz? (Evet için 'e', Hayır için 'h'): ");
            if (Console.ReadLine().ToLower() != "e")
            {
                Console.WriteLine("İyi günler!");
                break;
            }
        }
    }

    static void BilgileriAl(BaseMakine urun)
    {
        Console.Write("Seri Numarası: ");
        urun.SeriNumarasi = Console.ReadLine();
        Console.Write("Ad: ");
        urun.Ad = Console.ReadLine();
        Console.Write("Açıklama: ");
        urun.Aciklama = Console.ReadLine();
        Console.Write("İşletim Sistemi: ");
        urun.IsletimSistemi = Console.ReadLine();
    }
}