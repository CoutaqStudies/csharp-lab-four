using System;
namespace LabFour
{
    public class Task8
    {
        public static String Encrypt(String input)
        {
            //Console.WriteLine(DecodePolybiusSquare(EncodePolybiusSquare("fuck you leatherman")));
            //Console.WriteLine(DecodePolybiusSquare(EncodePolybiusSquare("abcdefghijklmnopqrstuvwxyz")));
            Console.WriteLine(DecodeGronsfeld(EncodeGronsfeld("GRONSFELD", 2015), 2015));
            return null;
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
           for(int i =0; i < input.Length; i++)
            {
                if (input[i] == 0)
                    output += " ";
                else if(input[i] / 10 + ((input[i] % 10) - 1) * 5<=9)
                    output += (Char)(96 +input[i]/10+((input[i]%10)-1)*5);
                else
                    output += (Char)(96 + input[i] / 10 + ((input[i] % 10) - 1) * 5+1);
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
            for (int i = 0; i<input.Length;i++)
            {
                output += (char)((char)input[i] +(int)Char.GetNumericValue(sKey[i]));
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
    }
}
