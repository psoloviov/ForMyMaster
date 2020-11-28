using System;

namespace Task_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(CaesarEncryption("summer"));
            Console.WriteLine(CaesarEncryption("summer", 12));
            Console.WriteLine(VigenereEncryption("summer"));
            Console.WriteLine(VigenereEncryption("summer", "overprice"));
        }

        public static char[] CaesarEncryption(string str, int key = 5)
        {
            var l = str.ToUpper().ToCharArray();
            for (var i = 0; i < l.Length; i++)
                l[i] = (char) (l[i] + key > 90 ? l[i] + key - 26 : l[i] + key);
            return l;
        }

        public static char[] VigenereEncryption(string str, string Key = "master")
        {
            char[] massage = str.ToUpper().ToCharArray();
            char[] key = Key.ToUpper().ToCharArray();

            char[] alphabet =
            {
                'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U',
                'V', 'W', 'X', 'Y', 'Z'
            };

            int alphabetLength = 26;

            for (int i = 0; i < massage.Length; i++)
            {
                int j;
                for (j = 0; j < alphabet.Length; j++)
                {
                    if (massage[i] == alphabet[j])
                    {
                        break;
                    }
                }

                if (j != alphabetLength)
                {
                    var number = j;

                    int t = 0;
                    if (t > key.Length - 1)
                    {
                        t = 0;
                    }

                    int f;
                    for (f = 0; f < alphabet.Length; f++)
                    {
                        if (key[t] == alphabet[f])
                        {
                            break;
                        }
                    }

                    t++;

                    int d; // displacement
                    if (f != 33)
                    {
                        d = number + f;
                    }
                    else
                    {
                        d = number;
                    }

                    if (d > alphabetLength - 1)
                    {
                        d -= alphabetLength;
                    }

                    massage[i] = alphabet[d];
                }
            }

            return massage;
        }
    }
}