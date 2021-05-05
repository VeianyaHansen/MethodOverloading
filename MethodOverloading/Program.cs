using System;

namespace MethodOverloading
{
    class Program
    {
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = num1 + num2;

            if(isTrue == true && sum > 1 || sum < 1)
            {
                return $"{sum} dollars";
            }
            else if(isTrue == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            //else if(isTrue == true && sum < 1)
            //{
            //    return $"{sum} dollars";
            //}
            else
            {
                return sum.ToString();
            }    
        }

        static void Main(string[] args)
        {
            // Math.Pow(5, 2);

            // Console.WriteLine();

            var x = 29;
            var y = 55;

            var answer = Add(x, y);
            Console.WriteLine(answer);

            var a = 32.4m;
            var b = 45.2m;

            var decimalAnswer = Add(a, b);
            Console.WriteLine(decimalAnswer);

            var thirdAnswer = Add(1, 0, true);
            Console.WriteLine(thirdAnswer);
        }
    }
}
