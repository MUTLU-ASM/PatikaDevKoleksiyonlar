using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyon4
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collection.generic
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10,"Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(28, "Özcan Coşar");

            //Dizinin elemanlarına Erişim
            Console.WriteLine("**** elemanlara erişim *****");
            Console.WriteLine(kullanicilar[12]);

            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Count;
            Console.WriteLine("**** count *****");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("**** contains *****");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Zikriye Ürkmez"));

            //Remove
            Console.WriteLine("**** remove *****");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Keys
            Console.WriteLine("**** Keys *****");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);
            //Value
            Console.WriteLine("**** Value *****");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);
        }
    }
}
