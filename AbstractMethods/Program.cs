class Program
{
    static void Main(string[] args)
    {
        // HATA: Arac a = new Arac("X", "Y", 10)-> Abstract sınıflar doğrudan new'lenemez!

        // Alt sınıflar üzerinden nesne üretimi (Polymorphism kullanarak Arac referansıyla tutabiliriz)
        Arac araba = new Araba("BMW", "320i", 240, 4);
        Arac ucak = new Ucak("Boeing", "737", 900, 34.3);
        Arac bisiklet = new Bisiklet("Bianchi", "MTB", 30, true);

        // Listeye atarak toplu işlemler yapalım
        List<Arac> araclar = new List<Arac> { araba, ucak, bisiklet };

        foreach (var arac in araclar)
        {
            Console.WriteLine("-----------------------------------");
            arac.BilgiVer();       // Ortak metot
            arac.HareketeGec();    // Abstract'tan gelen ve ezilen (override) zorunlu metot
            arac.Durdur();         // Ortak metot

            // Türe özel metotlara erişmek için tip kontrolü (Type Casting) yapabiliriz:
            if (arac is Araba a)
            {
                a.VitesDegistir(3);
            }
            else if (arac is Ucak u)
            {
                u.YukseklikAyarla(35000);
            }
        }
    }

    public abstract class Arac
    {
        // Ortak Özellikler (Properties)
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Hiz { get; set; }

        // Constructor (Yapıcı Metot)
        protected Arac(string marka, string model, int hiz)
        {
            Marka = marka;
            Model = model;
            Hiz = hiz;
        }

        // Ortak Gövdeli Metot (Tüm alt sınıflar bunu doğrudan kullanabilir veya ezebilir)
        public virtual void BilgiVer()
        {
            Console.WriteLine($"Araç: {Marka} {Model} | Hız: {Hiz} km/s");
        }

        // Ortak Gövdeli Başka Bir Metot
        public void Durdur()
        {
            Console.WriteLine($"{Marka} {Model} durduruldu.");
        }

        // SOYUT METOT (Abstract Method): Gövdesi yoktur. 
        // Bu sınıftan türeyen HER ALT SINIF bu metodu kendine göre doldurmak ZORUNDADIR.
        public abstract void HareketeGec();
    }

    public class Araba : Arac
    {
        public int KapiSayisi { get; set; }

        public Araba(string marka, string model, int hiz, int kapiSayisi) : base(marka, model, hiz)
        {
            KapiSayisi = kapiSayisi;
        }

        public override void HareketeGec()
        {
            Console.WriteLine($"{Marka} {Model}, 4 tekerleği üzerinde karada sürülüyor 🚗.");
        }

        // Arabaya özel bir metot
        public void VitesDegistir(int vites)
        {
            Console.WriteLine($"{Marka} {Model} vites {vites}'e geçirildi.");
        }
    }

    public class Ucak : Arac
    {
        public double KanatAcikligi { get; set; }

        public Ucak(string marka, string model, int hiz, double kanatAcikligi) : base(marka, model, hiz)
        {
            KanatAcikligi = kanatAcikligi;
        }

        public override void HareketeGec()
        {
            Console.WriteLine($"{Marka} {Model}, pistten kalkış yaparak gökyüzüne süzülüyor ✈️.");
        }

        // Uçağa özel bir metot
        public void YukseklikAyarla(int rakim)
        {
            Console.WriteLine($"{Marka} {Model} {rakim} feet yüksekliğe çıkıyor.");
        }
    }

    public class Bisiklet : Arac
    {
        public bool VteliMi { get; set; }
        public Bisiklet(string marka, string model, int hiz, bool vitesliMi) : base(marka, model, hiz)
        {
            VteliMi = vitesliMi;
        }
        public override void HareketeGec()
        {
            Console.WriteLine($"{Marka} {Model}, insan gücüyle pedallar çevrilerek sürülüyor 🚲.");
        }
    }
}