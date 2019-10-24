using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    public class Task7
    {
        public static void Execute()
        {
            Regex regex = new Regex(@"\d\d[:]\d\d");
            Regex min = new Regex(@"\d\d\:");
            Regex sec = new Regex(@"\:\d\d");
            Regex timeMatch = new Regex(@"\:\d\d");
            String[] input = new String[10];
            String text = "1.Gentle Giant – Free Hand [6:15]|2.Supertramp – Child Of Vision[07:27]|3.Camel – Lawrence[10:46]|4.Yes – Don’t Kill The Whale[3:55]|5.10CC – Notell Hotel[04:58]|6.Nektar – King Of Twilight[4:16]|7.The Flower Kings – Monsters & Men[21:19]|8.Focus – Le Clochard[1:59]|9.Pendragon – Fallen Dream And Angel[5:23]|10.Kaipa – Remains Of The Day(08:02)";
            input = Regex.Split(text, "[|]");
            foreach(String s in input)
                Console.WriteLine(s);
            String timestamps = "";
            for(int i =0; i <input.Length; i++)
            {
                MatchCollection matches = regex.Matches(input[i]);
                MatchCollection timeMatches = null; 
                foreach (Match match in matches)
                    timeMatches = timeMatch.Matches(match.ToString());
                foreach (Match match in timeMatches)
                    timestamps += match.Value;
            }
            int minutes = 0;
            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection matches = min.Matches(timestamps);
                foreach (Match match in matches)
                    Console.Write($"mins: {match.Value};");
                    //minutes += int.Parse(match.Value);
            }
            int seconds = 0;
            for (int i = 0; i < input.Length; i++)
            {
                MatchCollection matches = regex.Matches(timestamps);
                foreach (Match match in matches)
                    seconds += int.Parse(match.Value);
            }
            Console.WriteLine($"Min: {minutes}");
        }
    }
}
