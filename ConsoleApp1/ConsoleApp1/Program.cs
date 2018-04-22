using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesel
{
    class Program
    {
        static void Main(string[] args)
        {

            string Pesel0;
            string Data;
            string Plec;
            bool Odp1;
            bool Odp2;
            bool Odp3;
            bool Odp4;

            Console.WriteLine("Podaj Pesel... ");
            Pesel0 = Console.ReadLine();
            Console.WriteLine("Podaj date urodzenia...");
            Console.WriteLine("Wzór rrrr/mm/dd");
            Data = Console.ReadLine();
            Console.WriteLine("Podaj Płęć...");
            Plec = Console.ReadLine();
            Class1 check = new Class1();

            //check.CheckPesel(Pesel, Data);
            Odp1 = check.CheckData(DellSpace(Pesel0), Data);
            Odp2 = check.CheckDigits(DellSpace(Pesel0));
            Odp3 = check.Sex(DellSpace(Pesel0), Plec);
            Odp4 = check.ControlSum(DellSpace(Pesel0));
            if (check.ControlSum(DellSpace(Pesel0)) == true && check.Sex(DellSpace(Pesel0), Plec) == true && check.CheckDigits(DellSpace(Pesel0)) == true && check.CheckData(DellSpace(Pesel0), Data) == true)
            {
                Console.WriteLine("Prawidłowy Pesel");
            }
            else
            {
                Console.WriteLine("Błędny Pesel");


            }


            //  PeselNr = Int32.Parse(Pesel);





            Console.ReadKey();
            // Pesel = Int32.Parse(Console.ReadLine());
        }
        static String DellSpace(string Pesel0) // usuwanie spacji w peslu
        {
            string Pesel = "";
            /*   Pesel = "";
               for(int i = 0; i<Pesel0.Length -1; i++)
               {
                   if(Pesel0[i] != (char)32)
                   {
                       Pesel = Pesel + Pesel0;
                   }
               }*/
            Pesel = Pesel0;
            return Pesel;
        }
    }
}
