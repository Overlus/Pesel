using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesel
{
    class Class1 : Program
    {



        public Boolean CheckData(string Pesel, string rok, string miesiac, string dzien)
        {
            int dzienInt = Int32.Parse(dzien);
            int miesiacInt = Int32.Parse(miesiac);
            char miesiacChar;
            if (miesiac.Length == 2)
            {
                miesiacChar = miesiac[1];
            }
            else miesiacChar = miesiac[0];

            int rokInt = Int32.Parse(rok);
        
            int[] trzydziescdni = new int[] { 4, 6, 9, 11 };
            int[] trzydziesci_jeden = new int[] { 1, 3, 5, 7, 8, 10, 12 };

            if (rokInt % 4 == 0 && miesiacInt < 10 && miesiacChar == '2' && dzienInt > 29)
            {
                return false;
            }
            else if (rokInt % 4 != 0 && miesiacInt < 10 && miesiacChar == '2' && dzienInt > 28)
            {
                return false;
            }
            else if (rokInt % 4 != 0 && miesiacInt == 4 || miesiacInt == 6 || miesiacInt == 9 || miesiacInt == 11 && dzienInt > 30)
            {
                return false;
            }
            else if (rokInt % 4 != 0 && miesiacInt == 1 || miesiacInt == 3 || miesiacInt == 5 || miesiacInt == 7 || miesiacInt == 8 || miesiacInt == 10 || miesiacInt == 12 && dzienInt > 31) 
            {
                return false;
            }
            else
            {
                return true;
            }
                
        }
            public Boolean ControlSum(string Pesel)
            {
                int[] tabela = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
                int prawidlowaSuma;
                int wynik = 0;
                char liczbaPesel;
                int odejm;
                bool spr = true;
                prawidlowaSuma = (int)char.GetNumericValue(Pesel[Pesel.Length - 1]);
                for (int i = 0; i < 10; i++)
                {
                    liczbaPesel = Pesel[i];
                    wynik += tabela[i] * (int)char.GetNumericValue(liczbaPesel);

                }
                odejm = wynik % 10;


                if (odejm == 0 && (int)char.GetNumericValue(Pesel[Pesel.Length - 1]) == 0)
                {
                    return spr;
                }
                else if (10 - odejm == prawidlowaSuma)
                {
                    return spr;
                }
                else
                

                return false;
            }
            public Boolean CheckDigits(string Pesel) // spr ilości liczb
            {
                bool spr = true;
                if (Pesel.Length == 11)
                {
                    return spr;
                }
                else
                {
                    spr = false;
                    return spr;
                }
            }
            public Boolean Sex(string Pesel, string Plec)
            {
                bool spr = false;
                char SexLetter;
                SexLetter = Plec[0];
                if (SexLetter == 'K' || SexLetter == 'k')
                {
                    if ((int)char.GetNumericValue(Pesel[Pesel.Length - 2]) % 2 == 0)//Kobieta
                    {
                        spr = true;
                        return true;

                    }
                }
                if (SexLetter == 'M' || SexLetter == 'm')
                {
                    if ((int)char.GetNumericValue(Pesel[Pesel.Length - 2]) % 2 == 1)//Mężczyzna 
                    {
                        spr = true;

                        return true;

                    }
                }

                return spr;
            }

        }
}   
