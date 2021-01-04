using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeConverter
{
    public static class Gregorian
    {
        private static Calendar gCalendar = new GregorianCalendar();
        private static CultureInfo gregorianCulture = new CultureInfo("ar-SA");

        public static string GetDateTime(string format)
        {
            gregorianCulture.DateTimeFormat.Calendar = gCalendar;
            return DateTime.Now.ToString(format, gregorianCulture);
        }

        public static short GetYear()
        {
            gregorianCulture.DateTimeFormat.Calendar = gCalendar;
            return short.Parse(DateTime.Now.ToString("yyyy", gregorianCulture));
        }

        public static short GetShortYear()
        {
            gregorianCulture.DateTimeFormat.Calendar = gCalendar;
            return short.Parse(DateTime.Now.ToString("yy", gregorianCulture));
        }

        public static short GetMonth()
        {
            gregorianCulture.DateTimeFormat.Calendar = gCalendar;
            return short.Parse(DateTime.Now.ToString("M", gregorianCulture));
        }

        public static short GetDay()
        {
            gregorianCulture.DateTimeFormat.Calendar = gCalendar;
            return short.Parse(DateTime.Now.ToString("d", gregorianCulture));
        }
    }
}
