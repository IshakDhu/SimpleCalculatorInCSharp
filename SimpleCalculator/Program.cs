

namespace SimpleCalculator
{
    internal class SimpleCalculator
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter First Number: ");
            string num1 = Console.ReadLine();
            Console.Write("Please Enter Second Number: ");
            string num2 = Console.ReadLine();
            Console.Write("Please Enter Wanted Operator: ");
            string stringOperator = Console.ReadLine();

            double parsedNum1 = double.Parse(num1);
            double parsedNum2 = double.Parse(num2);

            if (stringOperator.Trim().ToLower() == "+")
            {
                Console.WriteLine("Your Answer is " +  (parsedNum1 + parsedNum2));
            } else if (stringOperator.Trim().ToLower() == "-")
            {
                Console.WriteLine("Your Answer is " +  (parsedNum1 - parsedNum2));
            } else if (stringOperator.Trim().ToLower() == "x")
            {
                Console.WriteLine("Your Answer is " + (parsedNum1 * parsedNum2));
            } else if (stringOperator.Trim().ToLower() == "/")
            {
                Console.WriteLine("Your Answer is " + (parsedNum1 / parsedNum2));
            }


        }
    }

}