using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "calculus";
            kurs1.egitmenAdi = "furkan";
            kurs1.izlenmeSayisi = 55;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "programming";
            kurs2.egitmenAdi = "sufi";
            kurs2.izlenmeSayisi = 90;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "physic";
            kurs3.egitmenAdi = "özlem";
            kurs3.izlenmeSayisi = 45;


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " " + kurs.egitmenAdi);


            }
         
        }
    }

    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmenAdi { get; set; }
        public int izlenmeSayisi { get; set; }
    }
}
