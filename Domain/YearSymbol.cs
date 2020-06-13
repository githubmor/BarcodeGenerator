using System;

namespace Domain
{
    internal class YearSymbol
    {
        private int today = new PersianDateTime(DateTime.Today).DayOfYear;

        public string getYearSymbol(int roz)
        {
            var p = new PersianDateTime(DateTime.Today);

            return getSymbol(p.Year - (roz > today ? 1 : 0));
        }

        private string getSymbol(int year)
        {
            switch (year)
            {
                case 1398:
                    return "K";

                case 1399:
                    return "L";

                case 1400:
                    return "M";

                default:
                    return "";
            }
        }
    }
}