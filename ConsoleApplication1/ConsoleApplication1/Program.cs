using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave_0();
            //Opgave_1_5();
            //Opgave_1_6();
            //Opgave_2_02();
            //Opgave_2_03();
            //Opgave_2_04();
            //Opgave_2_05();
            Opgave_2_06();
        }

        public static void Opgave_0()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Gris");
            Console.WriteLine(12 + 13);
            Console.WriteLine(24 / 5);
            Console.WriteLine("((-1)+3)*5:");
            Console.WriteLine(((-1) + 3) * 5);
            Console.WriteLine("(24 + 5) % 5:");
            Console.WriteLine((24 + 5) % 5);
            Console.WriteLine("15 + (-4)*6 / 11:");
            Console.WriteLine(15 + (-4) * 6 / 11);
            Console.ReadKey();
        }

        public static void Opgave_1_5()
        {
            Console.WriteLine("Opgave_1_5:");
            int Tal_1, Tal_2, Resultat;
            Tal_1 = System.Convert.ToInt32(System.Console.ReadLine());
            Tal_2 = System.Convert.ToInt32(System.Console.ReadLine());
            Resultat = Tal_1 + Tal_2;
            Console.WriteLine("Resultat:");
            Console.WriteLine(Resultat);
            Console.ReadKey();
        }
        public static void Opgave_1_6()
        {
            Console.WriteLine("Opgave_1_6:");
            int Tal_1, Tal_2, Tal_3, Resultat;
            Console.WriteLine("Enter the first number to multiply:");
            Tal_1 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Enter the second number to multiply:");
            Tal_2 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Enter the third number to multiply:");
            Tal_3 = System.Convert.ToInt32(System.Console.ReadLine());
            Resultat = Tal_1 + Tal_2 + Tal_3;
            Console.WriteLine(Resultat);
            Console.ReadKey();
        }
        public static void Opgave_2_02()
        {
            Console.WriteLine("Opgave_2_02:");
            int Tal_1, Tal_2, Resultat;
            Console.WriteLine("Indtast tal 1:");
            Tal_1 = System.Convert.ToInt32(System.Console.ReadLine());
            if (Tal_1 != 0)
            {
                Console.WriteLine("Indtast tal 2:");
                Tal_2 = System.Convert.ToInt32(System.Console.ReadLine());
                Resultat = Tal_1 + Tal_2;
                Console.WriteLine(Resultat);
                Console.ReadKey();
            }
            else
                Console.WriteLine("0");
            Console.ReadKey();

        }
        public static void Opgave_2_03()
        {
            Console.WriteLine("Opgave_2_03:");
            int Tal_1, Tal_2, Resultat;
            Console.WriteLine("Indtast tal 1:");
            Tal_1 = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Indtast tal 2:");
            Tal_2 = System.Convert.ToInt32(System.Console.ReadLine());
            if (Tal_2 != 0)
            {

                Resultat = Tal_1 / Tal_2;
                Console.WriteLine(Resultat);
                Console.ReadKey();
            }
            else
                Console.WriteLine("I cannot divide ");
            Console.ReadKey();
        }
        public static void Opgave_2_04()
        {
            Console.WriteLine("Opgave_2_04:");
            Console.WriteLine("See solution in Opgave_2_03:");
            Console.ReadKey();
        }
        public static void Opgave_2_05()
        {
            Console.WriteLine("Opgave_2_05:");
            Console.WriteLine("\"");
            int highest = 0;
            int[] array1 = new int[3];
            Console.WriteLine("Enter the first number:");
            array1[0] = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            array1[1] = System.Convert.ToInt32(System.Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            array1[2] = System.Convert.ToInt32(System.Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                //Console.WriteLine(array1[i]);
                if (array1[i] > highest)
                highest = array1[i];
               
            }
            Console.WriteLine("THe higst number is: ");
            Console.WriteLine(highest);
            Console.ReadKey();
        }
        public static void Opgave_2_06()
        {
            Console.WriteLine("Opgave_2_06:");

        }

    }
}





