using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[] numbers = { 1, 4, 56, -3, 90 ,4};

            numbers = MakePositive(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("============");

            numbers = Add(numbers, 55);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.WriteLine("============");


            bool finished=false;
            do
            {
                Console.WriteLine("1. Arraydeki axtaris et");
                Console.WriteLine("2. Arrayin ededi ortasini hesabla");
                Console.WriteLine("3. Arraydeki en boyuk ededi tap");
                Console.WriteLine("0. Menudan cix");


                string input = Console.ReadLine();
                finished = false;

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Axtarilan deyeri daxil edin:");
                        string numStr = Console.ReadLine();
                        int num = Convert.ToInt32(numStr);
                        Console.WriteLine(FindIndex(numbers,num));
                        break;
                    case "2":
                        Console.WriteLine(AvgNums(numbers));
                        break;
                    case "3":
                        Console.WriteLine(FindMax(numbers));
                        break;
                    case "0":
                        finished = true;
                        break;
                    default:
                        Console.WriteLine("Dogru secim edin!");
                        break;
                }
            } while (!finished);
           




        }

        //Verilmis arraydeki n ededinin indexini tapan metod
        static int FindIndex(int[] arr,int value)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == value)
                {
                    return i;
                }
            }

            return -1;
        }

        static int AvgNums(int[] array)
        {
            int sum = 0;
            
            for (int i = 0;i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum/ array.Length;
        }
        static bool IsDigit (char x)
        {
            char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i<digits.Length; i++)
            {
                if(digits[i] == x)
                {
                    return true;
                }
            }
            return false; 
        }

        static int FindMax(int[] numbers)
        {
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                    max = numbers[i];
            }

            return max;
        }

        

        //Verilmis arraye verilmis ededi elave edib yeni bir array olaraq qyattaran metod
        static int[] Add(int[]arr,int value)
        {
            int[] newArr = new int[arr.Length + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                newArr[i] = arr[i];
            }

            newArr[newArr.Length - 1] = value;

            return newArr;
        }

        // Verilmis arrayini eks sekilde qaytaran metod

        static int[] Reverse(int[] arr)
        {
            int[] newArr = new int[arr.Length];

            //for (int i = 0;i < arr.Length; i++)
            //{
            //    newArr[newArr.Length-1-i] = arr[i];
            //}

            for (int i = arr.Length-1;i >=0;i--)
            {
                newArr[arr.Length-i-1] = arr[i];
            }
            return newArr;
        }

        static int[] MakePositive(int[] arr)
        {

            ////Version1
            //int count = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //        count++;
            //}

            //int[] newArr = new int[count];

            //int index = 0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] > 0)
            //    {
            //        newArr[index] = arr[i];
            //        index++;
            //    }
            //}

            ////Version2
            int[] newArr = new int[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    newArr = Add(newArr, arr[i]);
                }
            }

            return newArr;

        }

    }
}
