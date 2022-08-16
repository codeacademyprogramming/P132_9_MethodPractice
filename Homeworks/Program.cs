using System;

namespace Homeworks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(EdediOrta(45,10,5,60));

            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8};
            Console.WriteLine(CutEded(array));
        }

        static int EdediOrta(int num1,int num2,int num3,int num4)
        {
            int result = (num1 + num2 + num3 + num4) / 4;
            return result;
        }

        static int CutEded(int[] array)
        {
            int count = 0;
            int sum = 0;
            int result = 0;
            for (int a = 0; a < array.Length; a++)
            {
                if (array[a]%2==0)
                {
                    sum += array[a];
                    count++;
                } 
            }
            if (count != 0)
            {
                result = sum / count;
            }
            return result;
        }

        static int PositiveCount(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                    count++;
            }
            return count;
        }

        static int FindMin(int[] numbers)
        {
            int min = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < min)
                    min = numbers[i];
            }

            return min;
        }

    }
}
