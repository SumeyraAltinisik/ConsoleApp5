using System.Collections;
namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {          
        }
    }

    public class Sirket
    {
        public int Id { get; set; }
        public string Unvani { get; set; }
        public List<Personel> PersonelListesi
            = new List<Personel>();
        public Personel NewPersonel()
        {
            Personel personel = new Personel();
            personel.SirketId = this.Id;
            personel.Sirket = this;
            PersonelListesi.Add(personel);
            return personel;
        }
        public Personel NewPersonel(string adSoyad)
        {
            Personel p = NewPersonel();
            p.AdSoyad = adSoyad;
            return p;
        }
    }
    public class Personel
    {
        internal Personel() { }
        public Personel(Sirket s)
        {
            this.Sirket = s;
            this.SirketId = s.Id;
        }
        public int Id { get; set; }
        public int SirketId { get; set; }
        public Sirket Sirket { get; set; }
        public string SicilNo { get; set; }
        public string AdSoyad { get; set; }
        public string Bolum { get; set; }

    }

    class Test
    {
        List<Sirket> sirketler = new List<Sirket>();
        void PrintPersonelInfo(Personel p)
        {
            Console.Write(p.SicilNo);
            Sirket s = sirketler.FirstOrDefault(x => x.Id == p.SirketId);
            Console.WriteLine(s.Unvani);
        }
    }
}