using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

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

            Dyreart hundebasse = new Dyreart("Cruella", 4, 2);


            Kæledyr Hans = new Kæledyr();
            Hans.Art = hundebasse;

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
        /*
                public Vektor3d(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        */

        //Consructor:
        public Vektor3d(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = y;
        }
        //proporties:
        public double xx
        {
            get
            {
                return X;
            }
            set
            {
                X = value;
            }
        }

        public double yy
        {
            get
            {
                return Y;
            }
            set
            {
                Y = value;
            }
        }


        public double ZZ
        {
            get
            {
                return Z;
            }
            set
            {
                Z = value;
            }
        }

    }
    // dyreklasser
    public class Dyreart
    {
        private string Navn;
        private int Ben, øjne;

        //constructor
        public Dyreart(string Navn2, int Ben2, int øjne2)
        {
            this.Navn = Navn2;
            this.Ben = Ben2;
            this.øjne = øjne2;
        }

        public int Get_øjne
        {
            get
            {
                return øjne;
            }
        }
    }
    public class Kæledyr
    {
        public Dyreart Art;
        public string Navn;
    }
    public class Person : INotifyPropertyChanged
    {
        public string PersonNavn;
        public int Fødselsår;
        public Kæledyr Kæledyr_Art;
        public string Navn;
        //Events:
        public event EventHandler<string> Namechanged;
        private void OnNameChanged()
        {
            Namechanged?.Invoke(this, this.PersonNavn);
            {
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }



        //Consructors:
        public Person()
        {
            this.PersonNavn = PersonNavn;
        }
        public Person(string PersonNavn)
        {
            this.PersonNavn = PersonNavn;
        }
        public Person(string PersonNavn, string Navn)
        {
            this.PersonNavn = PersonNavn;
            this.Navn = Navn;
        }
        public Person(string PersonNavn, string Navn, Kæledyr Kæledyr_Art)
        {
            this.PersonNavn = PersonNavn;
            this.Kæledyr_Art = Kæledyr_Art;
            this.Navn = Navn;
        }
        //Metoder:
        public string GetSetPersonNavn
        {
            get
            {
                return PersonNavn;
            }
            set
            {
                PersonNavn = value;
                OnNameChanged();
                OnPropertyChanged(nameof(GetSetPersonNavn));
            }
        }

        public int YearOfBirth
        {
            get
            {
                return this.Fødselsår;
            }
            set
            {
                this.Fødselsår = value;
                OnPropertyChanged(nameof(YearOfBirth));
            }
        }
        /*
        public Kæledyr Kæledyr_Art
        {
            get
            {
                return Kæledyr_Art;

            }
        }
        */

        public string Hentnavn()
        {
            return this.PersonNavn;
        }

        public int HentKæledyrØjne()
        {
            return Kæledyr_Art.Art.Get_øjne;
        }

    }

}

