using System;
using System.Numerics;

namespace SumStringsAsInteger
{
    class Program
    {
        //static string AddStrings(string num1, string num2)
        //{
        //    BigInteger firstNumber = 0, secondNumber = 0;

        //    for (int i = 0; i < num1.Length; i++)
        //    {
        //        int tempI = Convert.ToInt32(num1[i].ToString());
        //        firstNumber += tempI * Convert.ToInt64(Math.Pow(10, num1.Length-1 - i));

        //    }

        //    for(int i=0; i<num2.Length;i++){
        //        int tempI = Convert.ToInt32(num2[i].ToString());
        //        secondNumber += tempI * Convert.ToInt64(Math.Pow(10, num2.Length-1 - i));

        //    }

        //    BigInteger sum = firstNumber + secondNumber;
        //    return sum.ToString();


        //}


        static string AddStrings(string num1, string num2)
        {
            string masterNum = "";
            if (num1.Length > num2.Length)
            {
                masterNum = num1;
            }
            else if (num2.Length > num1.Length)
            {
                masterNum = num2;
            }
            else masterNum = num1;

            string reverseNum1 = reverseString(num1);
            string reverseNum2 = reverseString(num2);

            int carry = 0;
            string finalSum = "";
            for (int i = 0; i < masterNum.Length; i++)
            {
                int temp1 = 0;
                int temp2 = 0;

                if (i<=reverseNum1.Length-1)
                {
                    temp1=Convert.ToInt32(reverseNum1[i].ToString());
                }


                if (i <= reverseNum2.Length-1)
                {
                    temp2 = Convert.ToInt32(reverseNum2[i].ToString());
                }

                int tempSum = temp1 + temp2+carry;

                if (tempSum >= 10)
                {
                    tempSum = tempSum % 10;
                    carry = 1;
                }
                else carry = 0;

                finalSum = string.Concat(finalSum, tempSum.ToString());

            }

            string sum = carry !=0 ? string.Concat(carry.ToString(), reverseString(finalSum)) : reverseString(finalSum);

            return sum.ToString();


        }

        private static string reverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("6913259244", "71103343");
            Console.WriteLine(AddStrings("11", "123"));
            Console.WriteLine("3876620623801494171", "6529364523802684779");
            Console.WriteLine("401716832807512840963", "167141802233061013023557397451289113296441069");
            Console.WriteLine(AddStrings("3876620623801494171", "6529364523802684779"));


            Console.ReadKey();
        }
    }
}
