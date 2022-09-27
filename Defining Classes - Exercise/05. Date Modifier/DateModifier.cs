using System;
using System.Globalization;

namespace DefiningClasses
{
    public class DateModifier
    {
        public static int GetDateDifference(string first, string second)
        {
            DateTime firstDate = DateTime.ParseExact(first, "yyyy MM dd", CultureInfo.InvariantCulture);
            DateTime secondDate = DateTime.ParseExact(second, "yyyy MM dd", CultureInfo.InvariantCulture);
            TimeSpan dateDifference = firstDate - secondDate;
            return Math.Abs(dateDifference.Days);
        }
    }
}
