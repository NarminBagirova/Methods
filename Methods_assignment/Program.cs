namespace Methods_assignment
{
    internal class Program
    {
        #region Task1
        static void Main(string[] args)
        {
            int number = 12;
            int sum=SumEvenNumbers(number);
            Console.WriteLine($"The sum of even numbers from 0 to {number} is {sum}");

            int number1 = 9;
            PrintEvenNumbersSum(number1);
            string input = "Narmin Bagirova";
            string result = RemoveSpaces(input);
            Console.WriteLine(result);
        }
        
        static int SumEvenNumbers(int number)
        {
            int sum = 0;
            for(int i=0; i<=number; i++) 
            {
                if(i%2==0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        static void PrintEvenNumbersSum(int number1)
        {
            int sum = 0;
            int i = 0;
            while (i <= 10)
            {
                sum += i;
                i += 2;
            }
            Console.WriteLine($"The sum of even number from 0 to {number1} is {sum}");
        }
        #endregion

        #region Task2
        static string RemoveSpaces(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != ' ')
                {
                    result += input[i];
                }
            }
            return result;
        }
        #endregion
    }

}