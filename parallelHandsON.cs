using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3
{
    public class parallelHandsON
    {

        public void ExtentionMethod()
        {

        }
    }


    public static class IntExtensions
    {
        public static bool IsGreterThan(this int i, int value)
        {
            return i > value;
        }

    }

    public static class StringExtensions
    {
        public static string MakeSrtingCamelCase(this string input)
        {
            return System.Threading.Thread
                .CurrentThread.CurrentCulture
                .TextInfo.ToTitleCase(input.ToLower()).ToString();
        }

    }
}
