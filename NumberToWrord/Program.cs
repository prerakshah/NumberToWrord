using System;

namespace NumberToWrord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jay Shree Krushna!");
            long number = Convert.ToInt32(Console.ReadLine());
            string str = numberToWords(number);
            Console.WriteLine(str);
            Console.ReadKey();

        }

        public static string numberToWords(long number)
        {
            var onesMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            string words = "";

            if (number == 0)
                return onesMap[0];

            if (number < 0)
                return "minus " + numberToWords(Math.Abs(number));

            if ((number / 1000000) > 0)
            {
                words += numberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += numberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += numberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                if (number < 20)
                    words += onesMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number %= 10) > 0)
                        words += onesMap[number % 10];
                }
            }
            return words;
        }
    }
}