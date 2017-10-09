using System;
using System.Text;

namespace SA.Cop.Extensions
{
    public static class StringExtensions
    {
        public static string ToBase64(this string text)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(text);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}