using System;
namespace LabFour
{
    public class Task8
    {
        public static String Encrypt(String input)
        {
            return null;
        }
        private static int[] PolybiusSquare(String input)
        {
            int[] encoded = new int[input.Length];
            int[] index = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                index[i] = (int)input[i] % 32;
                if (index[i] >= 10) index[i] -= 1;
            }
            for (int i = 0; i < input.Length; i++)
            {
                int column = index[i] % 5;
                if (column == 0) column = 5;
                int row = (int)Math.Ceiling((double)index[i] / 5);
                encoded[i] = row + column * 10;
            }
            return encoded;
        }
        private static int[] Gronsfeld(String input, int key)
        { 
            String sKey = key.ToString();
            int length = input.Length;
            while (sKey.Length != input.Length)
            {
                if (sKey.Length > input.Length) sKey.Remove(input.Length);
                else
                {
                    if (input.Length - sKey.Length >= sKey.Length)
                    {

                    }
                }
            }
            string abc = "abcdefghijklmnopqrstuvwxyz", newKey = key, result = "";
            bool encode = true;
            int op = encode ? +1 : -1, offset, indexOf = 0;
            while (newKey.Length < text.Length)
            {
                newKey += key;
            }
            if (newKey.Length > text.Length)
            {
                newKey = newKey.Substring(0, newKey.Length - (newKey.Length - text.Length));
            }

            for (int i = 0; i < text.Length; i++)
            {
                indexOf = abc.IndexOf(text[i]);
                if (indexOf != -1)
                {
                    offset = abc.IndexOf(text[i]) + (Convert.ToInt32(newKey[i]) - 48) * op;
                    if (offset > abc.Length)
                        offset = offset - abc.Length;
                    else if (offset < 0)
                        offset = abc.Length + offset;
                    result += abc[offset];
                }
                else
                    result += text[i];
            }
        }
    }
}
