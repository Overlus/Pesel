using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesel
{
    class Class1 : Program
    {



        public Boolean CheckData(string Pesel, string Data)
        {
            char liczbaPesel;
            char liczbaData;
            int tmp = 0;
            bool spr = true;
            string tmpData = "";
            for (int i = 0; i < Data.Length; i++)
            {
                liczbaPesel = Data[i];
                if (char.IsDigit(liczbaPesel))
                {
                    tmpData = tmpData + liczbaPesel;
                }
            }
            for (int i = 2; i <= 7; i++)
            {

                liczbaPesel = Pesel[tmp];
                liczbaData = tmpData[i];

                if (tmp < 5)
                { tmp = tmp + 1; }
                if (liczbaPesel == liczbaData)
                {
                    spr = true;

                }
                else spr = false;
            }
            return spr;
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
            {
                spr = false;

                return spr;

            }


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
