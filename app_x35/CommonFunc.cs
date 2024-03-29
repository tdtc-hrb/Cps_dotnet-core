﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cps_x35
{
    public class CommonFunc
    {
        /// <summary>
        /// https://learn.microsoft.com/en-us/dotnet/api/system.globalization.datetimeformatinfo?view=net-6.0#changing-the-short-date-pattern
        /// </summary>
        /// <param name="date"></param>
        /// <param name="separator"></param>
        /// <returns></returns>
        public String GetDateFormat(DateTime date, String separator)
        {
            DateTimeFormatInfo dtfi = CultureInfo.CreateSpecificCulture("en-US").DateTimeFormat;

            dtfi.DateSeparator = separator;
            dtfi.ShortDatePattern = @"yyyy/MM/dd";

            return date.ToString("d", dtfi);
        }

        /// <summary>
        /// Determines whether the argument string can be represented with the ASCII (<see cref="Encoding.ASCII"/>) encoding.
        /// </summary>
        /// <param name="value">The value to check.</param>
        /// <returns>
        /// <c>true</c> if the specified value is ASCII; otherwise, <c>false</c>.
        /// </returns>
        public bool IsASCII(String value)
        {
            // ASCII encoding replaces non-ascii with question marks, so we use UTF8 to see if multi-byte sequences are there
            return Encoding.UTF8.GetByteCount(value) == value.Length;
        }
    }
}
