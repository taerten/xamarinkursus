using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_08_2016_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vektor3d v = new Vektor3d(10, 10, 10);
            // Console.WriteLine(v.Length);
            string Temp;

            Person Peter = new Person();
            Peter.PersonNavn = "Peter";
            Temp = Peter.Hentnavn();
            Console.WriteLine(Temp);
           
            Dyreart Cruella = new Dyreart();
            Cruella.øjne = 2;

            Kæledyr Hans = new Kæledyr();
            Hans.Art = Cruella;

            Person Jens = new Person();
            Jens.Kæledyr_Art = Hans;

            Console.WriteLine(Jens.HentKæledyrØjne());

            Console.ReadKey();
        }
    }
    // 3D vektor
    public class Vektor3d
    {
        public double X, Y, Z;

        public double Length
        {
            get
            {
                return Math.Sqrt((X * X) + (Y * Y) + (Z * Z));
            }
        }
        public Vektor3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }
    // dyreklasser
    public class Dyreart
    {
        string Navn;
        public int Ben, øjne;
    }
    public class Kæledyr
    {
        public Dyreart Art;
        public string Navn;
    }
    public class Person
    {
        public string PersonNavn;
        public int Fødselsår;
        public Kæledyr Kæledyr_Art;
        public string Navn; 

        public string Hentnavn()
        {
            return this.PersonNavn;
        }

        public int HentKæledyrØjne()
        {
            return Kæledyr_Art.Art.øjne;
        }

    }

}

