using System.Security.Cryptography;

namespace Assignment
{
    internal class Program
    {
        static int SumArray(params int[] arr)
        {
            int sum = 0;
            //arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < arr?.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int SumArray(ref int[] arr)
        {
            int sum = 0;
            //arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < arr?.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void SumSub(int x, int y, out int sum, out int sub)
        {
            sum = x + y;
            sub = x - y;

        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        static bool IsPrime(int number)
        {
            if (number <= 1) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }

            return true;
        }
        static int Factorial(int number)
        {
            if (number <= 0) return 0;

            int result = 1;

            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
        static void MaxMinArray(ref int[] arr, out int max, out int min)
        {
            max = arr[0];
            min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }
        }
        static string ChangeChar(ref string input, int index, char letter)
        {
            if (index < 0 || index >= input.Length)
            {
                Console.WriteLine("Invalid index!");
                return "";
            }
            char[] newStr = input.ToCharArray();
            newStr[index] = letter;
            return new string(newStr);

        }
        static void DisplayArray(int[] arr)
        {
            for (int i = 0; i < arr?.Length; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
        }
        static int[] MergeSortArray(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i];
                newArr[i + arr1.Length] = arr2[i]; //Tow array are the same size
            }
            //Sorting
            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = 0; j < newArr.Length - 1; j++)
                {
                    if (newArr[j] > newArr[j + 1])
                    {
                        //swap
                        int temp = newArr[j];
                        newArr[j] = newArr[j + 1];
                        newArr[j + 1] = temp;
                    }
                }
            }
            return newArr;
        }
        static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        //swap
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static int Distance(int[] arr)
        {
            int distance = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && distance < (j - i - 1))
                        distance = j - i - 1;
                }
            }
            return distance;
        }
        static void Main(string[] args)
        {
            #region Q1
            // Passing Parameter Value Type
            // 1. Passing By Value
            // int a = 5, b = 7;
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");
            //SWAP(a, b); //passin by value
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");

            // 2. Passing By Reference
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");
            //SWAP(ref a, ref b); //passin by refernce
            //Console.WriteLine($"a = {a}");
            //Console.WriteLine($"b = {b}");  
            #endregion

            #region Q2
            // Passing Parameter Reference Type
            // 1. Passing By Value
            //int[]number = { 1, 2, 3 };
            //int sum = SumArray(number);
            //Console.WriteLine(sum);


            // 2. Passing By Reference
            //int[] number = { 1, 2, 3 };
            //int sum = SumArray(ref number);
            //Console.WriteLine(sum); 
            #endregion

            #region Q3
            //int x = 7, y = 4,sum,sub;
            //SumSub(x, y, out sum, out sub);
            //Console.WriteLine($"Sun: {sum}");
            //Console.WriteLine($"Sub: {sub}"); 
            #endregion

            #region Q4
            //int x = 25;
            //Console.WriteLine(SumOfDigits(x)); 
            #endregion

            #region Q5
            //int x = 4;
            //int y = 7;
            //int z = 11;

            //Console.WriteLine($"{x} is prime: {IsPrime(x)}");
            //Console.WriteLine($"{y} is prime: {IsPrime(y)}");
            //Console.WriteLine($"{z} is prime: {IsPrime(z)}"); 
            #endregion

            #region Q6
            //int[] arr = { 1, 2, 3, 4, 5 };
            //MaxMinArray(ref arr, out int max, out int min);
            //Console.WriteLine($"Max: {max}");
            //Console.WriteLine($"Min: {min}"); 
            #endregion

            #region Q7
            //Console.WriteLine(Factorial(5)); 
            #endregion

            #region Q8
            //string input = "Abdelrahman";
            //Console.WriteLine(ChangeChar(ref input,4,'L')); 
            #endregion

            #region Q9
            //int value;
            //do
            //{
            //    Console.Write("Enter the value of matrix: ");
            //}
            //while (!int.TryParse(Console.ReadLine(), out value) || !(value > 0));

            //for (int i = 0; i < value; i++)
            //{
            //    for (int j = 0; j < value; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Q10
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //Console.WriteLine(SumArray(arr));
            //Console.WriteLine(SumArray( 1, 2, 3, 4, 5, 6, 7, 8, 9, 10)); 
            #endregion

            #region Q11
            //int[] arr1 = { 1, 3, 2, 5, 4 };
            //int[] arr2 = { 10, 8, 7, 9, 6 };

            //int[] arr3 = MergeSortArray(arr1, arr2);
            //DisplayArray(arr3); 
            #endregion

            #region Q12
            //Time Complexity O(n)
            //int[] arr = { 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 1 };
            //Dictionary<int, int> frequency = new Dictionary<int, int>();
            //for (int i = 0;i < arr.Length;i++)
            //{
            //    if (frequency.ContainsKey(arr[i]))
            //    {
            //        frequency[arr[i]]++;
            //    }else
            //    {
            //        frequency[arr[i]] = 1;
            //    }
            //}

            //foreach (var i in frequency)
            //{
            //    Console.WriteLine($"{i.Key} : {i.Value}");
            //}

            #endregion

            #region Q13
            //int[] arr = { 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 4, 1 };
            //MaxMinArray(ref arr,out int max, out int min);
            //Console.WriteLine($"Max: {max}");
            //Console.WriteLine($"Min: {min}"); 
            #endregion

            #region Q14
            //int[] arr = { 10, 23, 13, 12, 34, 45, 36, 32, 23, 44 };
            //int first = arr[0];
            //int second = arr[0];
            //for (int i = 1; i < arr.Length; i++)
            //{
            //    if (arr[i] > first) first = arr[i];
            //    if ((arr[i] > second) && (arr[i] != first)) second = arr[i];
            //}
            //Console.WriteLine(first);
            //Console.WriteLine(second); 
            #endregion

            #region Q15
            //int[] arr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 }; //8
            //int[] arr2 = { 1, 1, 1, 1, 1, 1, 1 }; //5

            ////int distance = 0;
            ////for (int i = 0; i < arr.Length - 1; i++)
            ////{
            ////    for (int j = i + 1; j < arr.Length; j++)
            ////    {
            ////        if (arr[i] == arr[j] && distance < (j - i - 1))
            ////            distance = j - i - 1;
            ////    }
            ////}
            //Console.WriteLine(Distance(arr));
            //Console.WriteLine(Distance(arr2)); 
            #endregion

            #region Q17
            //Console.Write("Enter the string: ");
            //string input = Console.ReadLine();
            //string[] revers = input.Split();
            //for (int i = revers.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{revers[i]} ");
            //} 
            #endregion

            #region Q18
            //int rows;
            //do
            //{
            //    Console.Write("Enter The number of Rows: ");
            //} while (!int.TryParse(Console.ReadLine(), out rows) || rows <= 0);

            //int column;
            //do
            //{
            //    Console.Write("Enter The number of Columns: ");
            //} while (!int.TryParse(Console.ReadLine(), out column) || column <= 0);

            //int[,] firstArr = new int[rows, column];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write($"Element [{i}, {j}]: ");
            //        while (!int.TryParse(Console.ReadLine(), out firstArr[i, j]))
            //        {
            //            Console.WriteLine($"Invalid input. Element [{i}, {j}]:");
            //        }
            //    }
            //}

            //int[,] secondArr = new int[rows, column];
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        secondArr[i, j] = firstArr[i, j];
            //    }
            //}
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < column; j++)
            //    {
            //        Console.Write($"{secondArr[i, j]} ");
            //    }
            //    Console.WriteLine();
            //} 
            #endregion

            #region Q19
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = arr.Length-1; i >=0; i--)
            //{
            //    Console.Write($"{arr[i]}, ");
            //} 
            #endregion

        }
    }
}
