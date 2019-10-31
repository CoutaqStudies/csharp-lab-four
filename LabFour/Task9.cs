using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    internal class Task9
    {
        internal static void Execute()
        {
            Regex regex = new Regex(@"\b(abstract|as|base|bool|break|byte|case|catch|char|checked|class|const|continue|decimal|default|delegate|do|double|else|enum|event|explicit|extern|false|finally|fixed|float|for|foreach|goto|if|implicit|in|int|interface|internal|is|lock|long|namespace|new|null|object|operator|out|override|params|private|protected|public|readonly|ref|return|sbyte|sealed|short|sizeof|stackalloc|static|string|struct|switch|this|throw|true|try|typeof|uint|ulong|unchecked|unsafe|ushort|using|using|static|virtual|void|volatile|while)\b");
            String text = "fuck you abstract leatherman";
            foreach(String i in text.Split(" "))if (regex.IsMatch(i)) text = text.Replace(i,"");
            Console.WriteLine(text);
        }
    }
}