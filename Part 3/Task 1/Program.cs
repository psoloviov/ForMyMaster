using System;
using System.Linq;

namespace Task_1
{
    internal class Program
    {
        private const int NumberCardLength = 16;

        public static void Main(string[] args)
        {
            TestCard();
        }

        public static void Check(long cardNumber) //for int 
        {
            var intList = cardNumber.ToString().Select(digit => int.Parse(digit.ToString())).ToList();
            if (intList.Count == NumberCardLength)
            {
                var sum = new int();
                for (int i = 0; i < NumberCardLength; i++)
                {
                    intList[i] = i % 2 == 0 ? (intList[i] * 2) > 9 ? (intList[i] * 2 - 9) : intList[i] * 2 : intList[i];
                    sum += intList[i];
                }

                Console.WriteLine(sum % 10 == 0 ? "Valid" : "Invalid");
            }
            else
            {
                Console.WriteLine("Incorrect input! " + cardNumber);
            }
        }

        public static void Check(string cardNumber) // for string 
        {
            cardNumber = cardNumber.Replace(" ", "");
            var intList = cardNumber.Select(digit => int.Parse(digit.ToString())).ToList();
            if (intList.Count == NumberCardLength)
            {
                var sum = new int();
                for (int i = 0; i < NumberCardLength; i++)
                {
                    intList[i] = i % 2 == 0 ? (intList[i] * 2) > 9 ? (intList[i] * 2 - 9) : intList[i] * 2 : intList[i];
                    sum += intList[i];
                }

                Console.WriteLine(sum % 10 == 0 ? "Valid" : "Invalid");
            }
            else
            {
                Console.WriteLine("Incorrect input! " + cardNumber);
            }
        }

        public static void TestCard()
        {
            Check(4111111111111111);
            Check(30569309025904);
            Check(8451235498845652);
            Check(6011111111111117);
            Check(4848128412114423);
            Check(4428444824512245);
            Check(5105105105105100);
            Check(5019717010103742);
            Check(371449635398431);
            Check(4488564856589848);
            Check(8458546884598213);
            Check(6011000990139424);
            Check(1485674805610484);
            Check(5610591081018250);
            Check(4012888888881881);
            Check(1744350545026012);

            /* outputs:
             * Valid
             * Incorrect input! 30569309025904
             * Invalid
             * Valid
             * Invalid
             * Invalid
             * Valid
             * Valid
             * Incorrect input! 371449635398431
             * Invalid
             * Invalid
             * Valid
             * Invalid
             * Valid
             * Valid
             * Invalid
             */
        }
    }
}