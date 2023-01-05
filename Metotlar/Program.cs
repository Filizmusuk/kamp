using Metotlar;

internal class Program
{
    private static void Main(string[] args)
    {

        string[] pandora = new string[] { };

        Urun urun1 = new Urun();
        urun1.Adi = "Bileklik";
        urun1.Fiyati = 2600;
        urun1.Aciklama = "Saf Gümüş";

        Urun urun2 = new Urun();
        urun2.Adi = "Kolye";
        urun2.Fiyati = 5600;
        urun2.Aciklama = "Saf Altın";
        Urun[] urunler = new Urun[] { urun1, urun2 };

        foreach (Urun urun in urunler)
        {
            Console.WriteLine(urun.Adi);
            Console.WriteLine(urun.Fiyati);
            Console.WriteLine(urun.Aciklama);
            Console.WriteLine("------------------");





            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2 );

            sepetmanager.Ekle2("Bileklik", "Saf Gümüş", 2600 ,10);
            sepetmanager.Ekle2("Kolye", "Saf Altın", 5600,20);




        }






        Console.WriteLine();
    }
}