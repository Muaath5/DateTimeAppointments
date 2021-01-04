using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConverter
{
    public static class Helper
    {
        public static DateTime ConvertHijriToGregorian(DateTime hijriDateTime)
        {
            DateTimeFormatInfo formatInfo;
            formatInfo = new CultureInfo("en-us", false).DateTimeFormat;
            formatInfo.Calendar = new GregorianCalendar();
            string result = hijriDateTime.ToString("d:M:yyyy", formatInfo);
            return GetDateTimeFromString(result, formatInfo.Calendar);
        }

        public static DateTime GetDateTimeFromString(string dateTime, Calendar calendar)
        {
            string[] dataArray = dateTime.Split(':');
            int length = dataArray.Length;
            int[] numberArray = new int[length];

            for (int i = 0; i < length; i++)
            {

            }
        }

        public static T[] ConvertTo<T>(this string[] data) where T : IConvertible
        {
            int length = data.Length;
            T[] result = new T[length];
            for (int i = 0; i < length; i++)
            {

            }
        }
    }
}
