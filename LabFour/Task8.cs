using System;
using System.Text.RegularExpressions;

namespace LabFour
{
    public class Task8
    {
        public static void Execute(String input)
        {
            String text = "To Sherlock Holmes she is palways the womangj. FBI have seldom heard himq mention her undexr any other zname. In his eyes she eclipses and predominates the whole of her sex. It was not that he felt any emotion akin to love for Irene Adler. All emotions, and that one particularly, were abhorrent to his cold, precise but admirably balanced mind. He was, I take it, the most perfect reasoning and observing machine that the world has seen, but as a lover he would have placed himself in a false position.";
            Char[,] key = GetNiceArray(text);
            String[] one = EncodeBookCipher("test tetst tetet", key);
            String one_decoded = DecodeBookCipher(one, key);
            Console.WriteLine(one_decoded);
            String two = EncodeGronsfeld(one_decoded, 2015);
            String two_decoded = DecodeGronsfeld(two, 2015);
            Console.WriteLine(two_decoded);
            int[] three = EncodePolybiusSquare(two_decoded);
            String three_decoded = DecodePolybiusSquare(three);
            Console.WriteLine(three_decoded);
        }
        private static int[] EncodePolybiusSquare(String input)
        {
            input.ToLower();
            int[] encoded = new int[input.Length];
            int[] index = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                index[i] = (int)input[i] % 32;
                if (index[i] >= 10) index[i] -= 1;
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (index[i] != 0)
                {
                    int column = index[i] % 5;
                    if (column == 0) column = 5;
                    int row = (int)Math.Ceiling((double)index[i] / 5);
                    encoded[i] = row + column * 10;
                }
                else
                    encoded[i] = 0;
            }

            return encoded;
        }
        private static String DecodePolybiusSquare(int[] input)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 0)
                    output += " ";
                else if (input[i] / 10 + ((input[i] % 10) - 1) * 5 <= 9)
                    output += (Char)(96 + input[i] / 10 + ((input[i] % 10) - 1) * 5);
                else
                    output += (Char)(96 + input[i] / 10 + ((input[i] % 10) - 1) * 5 + 1);
            }
            return output;
        }
        private static String EncodeGronsfeld(String input, int key)
        {
            String output = "";
            String sKey = key.ToString();
            int length = input.Length;
            while (sKey.Length != input.Length)
            {
                if (sKey.Length > input.Length)
                    sKey = sKey.Remove(input.Length);
                else
                    sKey += sKey;
            }
            for (int i = 0; i < input.Length; i++)
            {
                output += (char)((char)input[i] + (int)Char.GetNumericValue(sKey[i]));
            }
            return output;
        }
        private static String DecodeGronsfeld(String input, int key)
        {
            String output = "";
            String sKey = key.ToString();
            int length = input.Length;
            while (sKey.Length != input.Length)
            {
                if (sKey.Length > input.Length)
                    sKey = sKey.Remove(input.Length);
                else
                    sKey += sKey;
            }
            for (int i = 0; i < input.Length; i++)
            {
                output += (char)((char)input[i] - (int)Char.GetNumericValue(sKey[i]));
            }
            return output;
        }
        private static String[] EncodeBookCipher(String input, Char[,] key)
        {
            input.ToLower();
            String[] encoded = new String[input.Length];
            int[] index = new int[input.Length];
            Boolean found = false;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < Math.Sqrt(key.Length); j++)
                    {
                    if (found) break;
                        for (int k = 0; k < Math.Sqrt(key.Length); k++)
                        {
                        if (found) break;
                        if (input[i].Equals(key[j, k]))
                            {
                            encoded[i] = j.ToString()+(k).ToString();
                            found = true;
                                break;
                            }
                        }
                    }
                found = false;
            }
            return encoded;
        }
        private static String DecodeBookCipher(String[] input, Char[,] key)
        {
            String output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if(String.IsNullOrWhiteSpace(input[i]))
                    output += " ";
                else
                    output += key[int.Parse(input[i].Substring(0,1)), int.Parse(input[i].Substring(1))];
            }
            return output;
        }
        private static Char[,] GetNiceArray(String text)
        {
            Char[,] key = new Char[10, 10];
            text = Regex.Replace(text, @"\s+", "");
            text = Regex.Replace(text, @"\.+", "");
            text = Regex.Replace(text, @"\,+", "");
            int offset = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (Char.IsLetter(text[i * 10 + j]))
                    {
                        key[i, j] = Char.ToLower(text[i * 10 + j + offset]);
                        Console.Write(key[i, j] + " ");
                    }
                }
                Console.WriteLine();
            }
            return key;
        }
    } 
}
