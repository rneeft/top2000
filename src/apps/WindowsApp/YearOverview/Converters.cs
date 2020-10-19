﻿using System;
using System.Globalization;

namespace Chroomsoft.Top2000.WindowsApp.YearOverview
{
    public static class Converters
    {
        private static IFormatProvider formatProvider = DateTimeFormatInfo.InvariantInfo;

        public static string ToShortLocalTime(DateTime dateTime) => dateTime.ToLocalTime().ToString("dd MMM yyyy HH:mm", formatProvider);
    }
}
