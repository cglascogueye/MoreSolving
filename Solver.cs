
using System.Collections.Generic;



namespace MoreSolving
{
    public class Solver
    {
        public int Sum(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            int i = 0;
            if (numbers == null)
            {
                return 0;
            }

            for (i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public double AverageEvens(int[] numbers)
        {
            double sum = 0;
            int count = 0;

            if (numbers == null)
            {
                return 0;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                    count++;
                }
            }
            if (count == 0)
            {
                return 0;
            }
            return sum / count;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum % 2 == 1 || sum % 2 == -1;
        }

        public int SumNegativeNumbers(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (int number in numbers)
            {
                if (number < 0)
                {
                    sum += number;
                }
            }
            return sum;
        }

        public bool ContainsTrue(bool[] values)
        {
            if (values == null)
            {
                return false;
            }
            foreach (bool value in values)
            {
                if (value)
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsEven(int[] numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    return true;
                }
            }
            return false;
        }

        public string[] MakeElementsUppercase(string[] values)
        {
            if (values == null)
            {
                return null;
            }


            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] != null)
                {
                    values[i] = values[i].ToUpper();
                }
            }
            return values;
        }
    }
}

