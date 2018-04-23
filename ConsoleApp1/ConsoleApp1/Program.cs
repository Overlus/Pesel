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
            //Naprawić Spr Daty !!!

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
            string CorektaPesel = DellSpace(Pesel0);
            //check.CheckPesel(Pesel, Data);
            Odp1 = check.CheckData(CorektaPesel, Data);
            Odp2 = check.CheckDigits(CorektaPesel);
            Odp3 = check.Sex(CorektaPesel, Plec);
            Odp4 = check.ControlSum(CorektaPesel);
            if (check.ControlSum(CorektaPesel) == true && check.Sex(CorektaPesel, Plec) == true && check.CheckDigits(CorektaPesel) == true && check.CheckData(CorektaPesel, Data) == true)
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
        static String DellSpace(string Pesel0) // usuwanie znakow w peslu
        {
            if (Pesel0.Length > 11)
            {
                string Pesel = "";
                
                char Peselchar;
                for (int i = 0; i < Pesel0.Length - 1; i++)
                {
                    Peselchar = Pesel0[i];
                    if (char.IsDigit(Peselchar))
                    {
                        Pesel = Pesel + Peselchar;
                    }
                }
                
                return Pesel;
            }
            else return Pesel0;
        }
    }
}
