using System;

namespace OOPAssignment010T2
{
    public static class Util
    {
        public static string LongDateToString(long date)
        {
            return new DateTime(date).ToString();
        }
    }
}