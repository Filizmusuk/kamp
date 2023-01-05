using System;
namespace kamp
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety -tip güvenliği
            string kategoriEtiketi = "Katagori";
            Console.WriteLine(kategoriEtiketi);


            //dizi - array
            string[] kurslar = new string[] { "a", "b", "c" }; 


            for (int i=0; i<3; i++)
            {
                Console.WriteLine(kurslar[i]);

            }
            Console.WriteLine("sayfa sonu -footer");
        }

    }


}
