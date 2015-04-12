using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateProject
{
    public class Date
    {
        public int Dan;
        public int Mjesec;
        public int Godina;
        
        public Date()
        {
            Dan = 1;
            Mjesec = 1;
            Godina = 2015;
        }

        public Date(int dan, int mjesec, int godina)
        {
            Godina = godina;

            if (mjesec < 1 || mjesec > 12)
            {
                Mjesec = 0;
            }

            else Mjesec = mjesec;

            if (Mjesec == 4 || Mjesec == 6 || Mjesec == 9 ||  Mjesec == 11)
            {
                if (dan < 1  || dan > 30)
                {
                    Dan = 0;
                }

                else Dan = dan;
            }
            else if (Mjesec == 2)
            {
                if (isLeapYear())
                {
                    if (dan < 1 || dan > 29)
                        Dan = 0;
                    else
                        Dan = dan;
                }
                else
                {
                    if (dan < 0 || dan > 28)
                        Dan = 0;
                    else
                        Dan = dan;
                }
            }
            else
            {
                if (dan < 1 || dan > 31)
                {
                    Dan = 0;
                }

                else Dan = dan;
 
            }
 
        }

        public bool isLeapYear()
        {
            if (Godina % 4 == 0)
            {
                if (Godina % 400 == 0)
                    return true;
                else if (Godina % 100 == 0)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        public string getMonthName()
        {
            string[] Mjeseci = { "Sijecanj", "Veljaca", "Ozujak", "Travanj", "Svibanj", "Lipanj", "Srpanj", "Kolovoz", "Rujan", "Listopad", "Studeni", "Prosinac" };

            return Mjeseci[Mjesec - 1];
        }

        public int getNumberOfRemainingDaysInMonth()
        {
            if (Mjesec == 4 || Mjesec == 6 || Mjesec == 9 || Mjesec == 11)
            {
                return 30 - Dan;
            }
            else if (Mjesec == 2)
            {
                if (isLeapYear())
                    return 29 - Dan;
                else
                    return 28 - Dan;
            }
            else
                return 31 - Dan;
        }
    }
}
