﻿using System.Text;
using System.Globalization;

namespace QuickFix.Fields.Converters
{
    /// <summary>
    /// Convert DateTime to/from String
    /// </summary>
    public static class DateTimeConverter
    {
        public const string DATE_TIME_FORMAT_WITH_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss.fff}";
        public const string DATE_TIME_FORMAT_WITHOUT_MILLISECONDS = "{0:yyyyMMdd-HH:mm:ss}";
        public const string DATE_ONLY_FORMAT = "{0:yyyyMMdd}";
        public const string TIME_ONLY_FORMAT_WITH_MILLISECONDS = "{0:HH:mm:ss.fff}";
        public const string TIME_ONLY_FORMAT_WITHOUT_MILLISECONDS = "{0:HH:mm:ss}";
        public static string[] DATE_TIME_FORMATS = { "yyyyMMdd-HH:mm:ss.fff", "yyyyMMdd-HH:mm:ss" };
        public static DateTimeStyles DATE_TIME_STYLES = DateTimeStyles.AssumeUniversal | DateTimeStyles.AdjustToUniversal;
        public static CultureInfo DATE_TIME_CULTURE_INFO = CultureInfo.InvariantCulture;

        /// <summary>
        /// Convert string to DateTime
        /// </summary>
        /// <exception cref="BadConversionException"/>
        public static System.DateTime Convert(string str)
        {
            try
            {
                return System.DateTime.ParseExact(str, DATE_TIME_FORMATS, DATE_TIME_CULTURE_INFO, DATE_TIME_STYLES);
            }
            catch (System.Exception e)
            {
                throw new FieldConvertError("Could not convert string (" + str + ") to DateTime: " + e.Message, e);
            }
        }
       
        /// <summary>
        /// Convert DateTime to string in FIX Format
        /// </summary>
        /// <param name="dt">the DateTime to convert</param>
        /// <param name="includeMilliseconds">if true, include milliseconds in the result</param>
        /// <returns>FIX-formatted DataTime</returns>
        public static string Convert(System.DateTime dt, bool includeMilliseconds)
        {
            if(includeMilliseconds)
                return string.Format(DATE_TIME_FORMAT_WITH_MILLISECONDS, dt);
            return string.Format(DATE_TIME_FORMAT_WITHOUT_MILLISECONDS, dt);
        }

        /// <summary>
        /// Convert DateTime to string in FIX Format, with milliseconds
        /// </summary>
        /// <param name="dt">the DateTime to convert</param>
        /// <returns>FIX-formatted DateTime</returns>
        public static string Convert(System.DateTime dt)
        {
            return DateTimeConverter.Convert(dt, true);
        }

        public static string ConvertDateOnly(System.DateTime dt)
        {
            return string.Format(DATE_ONLY_FORMAT, dt);
        }

        public static string ConvertTimeOnly(System.DateTime dt)
        {
            return DateTimeConverter.ConvertTimeOnly(dt, true);
        }

        public static string ConvertTimeOnly(System.DateTime dt, bool includeMilliseconds)
        {
            if (includeMilliseconds)
                return string.Format(TIME_ONLY_FORMAT_WITH_MILLISECONDS, dt);
            return string.Format(TIME_ONLY_FORMAT_WITHOUT_MILLISECONDS, dt);
        }
    }
}
