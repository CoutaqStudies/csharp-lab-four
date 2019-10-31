using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    internal class Task10
    {
        internal static void Execute()
        {
            String text = "we meet at the docks in 12:55:10. there will also be a picnic tommorow at 10:15:00";
            Regex regex = new Regex(@"\d\d:\d\d:\d\d");
            MatchCollection matches = regex.Matches(text);
            foreach (Match match in matches)
                Console.WriteLine(match.ToString());
        }
    }
}