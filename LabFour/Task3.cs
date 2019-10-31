using System;

namespace LabFour
{
    internal class Task3
    {
        internal static void Execute()
        {
            String text = "Test tetetttttetetf dddda a.";
            String output = "";
            String[] words = (text.Substring(0, text.Length-1)).Split(" ");
            for(int i = words.Length-1; i>0; i--) output += " "+words[i];
            output += ".";
            output = output.TrimStart();
            Console.WriteLine(output);
        }
    }
}