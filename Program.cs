using System;
using System.Collections.Generic;

namespace Obyek_Koleksi
{
    class Program
    {
        static class Constants
        {
            public const double Pi = 3.14159;
            public const int SpeedOfLight = 300000; // km per sec.
        }
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        static void Main(string[] args)
        {
            //enum
            Season A = Season.Autumn;
            Console.WriteLine($"Integral value of {A} is {(int)A}");  // output: Integral value of Autumn is 2

            var B = (Season)1;
            Console.WriteLine(B);  // output: Summer

            var C = (Season)4;
            Console.WriteLine(C);  // output: 4
            //konstanta
            double radius = 5.3;
            double area = Constants.Pi * (radius * radius);
            int secsFromSun = 149476000 / Constants.SpeedOfLight; // in km
            Console.WriteLine(secsFromSun);
            //List
            var rak = new List<string>();
            rak.Add("pensil");
            rak.Add("buku");
            rak.Add("laptop");
            Console.WriteLine("~~~~~List~~~~~");
            foreach (var barang in rak)
            {
                Console.Write(barang+"-");
            }
            Console.Write("\n"+rak[0] + "\n" + rak[1] + "\n" + rak[2]);
            Console.Write("\nJumlah Index Value : "+rak.Count);
            rak.RemoveAt(0);
            rak.Remove("buku");
            rak.Clear();

            //Dictionary
            var kamus = new Dictionary<string, string>();
            kamus.Add("hello", "halo");
            kamus.Add("hi", "hai");
            kamus.Add("go", "pergi");
            kamus["bye"] = "dadah";
            Console.WriteLine("\n\n~~~~~Dictionary~~~~~");
            foreach (var kata in kamus)
            {
                Console.Write(""+kata.Key +"-"+ kata.Value);
            }
            Console.Write(kamus["hello"]+"-");
            Console.Write(kamus["hi"]);

            //Delegate
            int a = 100;
            int b = 200;
            var c = Proses(a, b, Tambah);
            var d = Proses(a, b, Kurang);
            Console.WriteLine("\n\n~~~~~Delegate~~~~~");
            Console.WriteLine("|"+c +" || "+ d+"|");

            //Lambda
            var e = Proses(a, b, (x, y) => {return a ^ b; });
            var f = Proses(a, b, (x, y) => {return a * a + b + 1;});
            Hitung p = Tambah;
            Hitung q = Kurang;
            Hitung r = Tambah;
            Hitung s = Kurang;
            var result = p(q(1, 2), r(3, s(4, 5)));//q : 1 - 2 = -1, r : 3 - 1 = 2, p : 2 - 1 = 1;
            Console.WriteLine("\n~~~~~Lambda~~~~~");
            Console.WriteLine("Jumlah q : 1 - 2 = -1, r : 3 - 1 = 2, p : 2 - 1 = 1 Jadi Hasilnya " + result);
            Console.WriteLine(e+"||"+f);

        }
        //Delegate
        delegate int Hitung(int a, int b);
        static int Tambah(int a, int b)
        {
            return a + b;
        }
        static int Kurang(int a, int b)
        {
            return a - b;
        }
        static int Proses(int a, int b, Hitung operasi)
        {
            return operasi(a, b); //proses a dan b tergantung pada fungsi dari luar
        }
    }
}
