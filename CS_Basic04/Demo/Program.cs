using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Dynamic;
using System.Security.Claims;
using System.Diagnostics;
using System.Collections;
using System.Security.Cryptography;
using System.Reflection;
using System.Drawing;
using System.Numerics;

namespace Demo
{
    internal class Program
    {

        static void SWAP(ref int x, ref int y)
        {
            int Temp = x;
            x = y;
            y = Temp;
        }
        static void PrintShape(int count = 10, string pattern = "^_^")
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(pattern);
            }
        }
        //static int SumArray(int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr?.Length;i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //static int SumArray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr[0] = 100;
        //    for (int i = 0; i < arr?.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        //static int SumArray( int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 4, 5, 6 };
        //    for (int i = 0; i < arr?.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        static int SumArray(params int[] arr)
        {
            int sum = 0;
            arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < arr?.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        static int SumArray(ref int[] arr)
        {
            int sum = 0;
            arr = new int[] { 4, 5, 6 };
            for (int i = 0; i < arr?.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void SumMul(int x, int y, out int sum, out int mul)
        {
            sum = x + y;
            mul = x * y;
        }
        static void Main(string[] args)
        {

            #region one D Array
            //int[] numbers;
            //Declare for reference (pointer) from type 'Array of Integers'
            // numbers : can refere to object from type 'Array of Integers'
            // numbers : refere to null

            //Will Be Allocated At Stack For The Reference 'Numbers'
            //Witt Be Allocated At Heap


            //numbers= new int[Size];
            //numbers = new int[5];
            //new
            //1.Allocate The Number of Required Bytes For The Object At HEAP(4 Bytes * 5)
            //2.Initialized The Allocated Bytes With The Default Value Of The Datatypes
            //3.Call User—Defined Constrcutor if Exists
            //4.Assign The Object To The Reference 'numbers' 
            #endregion

            #region Tow D Array
            //Tow D Array
            //Rectangle
            //int[,] marks = new int[3, 4];
            //marks[0, 0] = 34;
            //marks[0, 1] = 34;
            //marks[0, 2] = 34;
            //marks[0, 3] = 34;

            //marks[1, 0] = 34;
            //marks[1, 1] = 34;
            //marks[1, 2] = 34;
            //marks[1, 3] = 34; 

            //for (int i = 0;i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.Write($"Enter marks[{i},{j}]: ");
            //        marks[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.Write(marks[i,j]);
            //    }
            //   Console.WriteLine();
            //}



            //Jaddged Array

            //int[][] marks = new int[3][];
            //marks[0] = new int[2];
            //marks[1] = new int[4];
            //marks[2] = new int[1];


            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks[i].Length; j++)
            //    {
            //        Console.Write($"Enter marks[{i},{j}]: ");
            //        marks[i][j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks[i].Length; j++)
            //    {
            //        Console.Write($"{marks[i][j]} ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Fuction prototype
            //Functions Block Of Code That Have Name if U Need To Execute This Code
            //U Need To Call The Function By The Name
            //// DRY
            //Function Prototype
            //1.Signature
            //1.1.Name
            //1.2.Retrun Type
            //1.3.Parameters(Inputs)
            //2.Body(Code)

            //Calling For The Functions
            //PrintShape();

            // Calling For The Functions
            // PrintShape(3);
            // PrintShape(5,"0_0"); // Passin By Order
            // PrintShape(Pattern: Count: 3); // Passin By Name
            // PrintShape(Pattern:"#_#", Count: 3); // Passin By Name

            // Methods
            // 1. Class Memeber Method (Static Method)
            // 2. Object Memeber Method (Non Static Method) 
            #endregion

            #region StackFrame
            //StackTrace trace = new StackTrace();
            //StackFrame[] frames = trace.GetFrames();
            //for (int i = 0; i < frames?.Length; i++)
            //{
            //    Console.WriteLine(frames[i].GetMethod().Name);
            //} 
            #endregion

            #region Passing parameter value type

            // Passing By Value
            // Passing By Reference


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

            #region Passing parameter Reference type

            // Passing By Value
            // Passing By Reference


            // Passing Parameter Reference Type
            // 1. Passing By Value
            //int[]number = { 1, 2, 3 };
            //int sum = SumArray(number);
            //Console.WriteLine(sum);


            // 2. Passing By Reference
            //int[] number = { 1, 2, 3 };
            //int sum = SumArray(ref number);
            //Console.WriteLine(sum);


            //EX2
            //int[] number = { 1, 2, 3 };
            //Console.WriteLine(SumArray(number));
            //Console.WriteLine(number[0]);

            //Console.WriteLine(SumArray(ref number));
            //Console.WriteLine(number[0]);
            #endregion

            #region Pass by out

            ////Pass by out

            //int num1 = 3, num2 = 4, sum, mul;

            //SumMul(num1, num2, out sum, out mul);
            //Console.WriteLine(sum);
            //Console.WriteLine(mul);
            #endregion

            #region Params
            //int[] numbers = { 1, 2, 3 };
            //Console.WriteLine(SumArray(numbers));
            //Console.WriteLine(SumArray(1,2,4,6,7,8,8,9)); 
            #endregion


        }
    }
}
