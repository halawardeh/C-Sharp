using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static _20_01_2025.Program;

namespace _20_01_2025
{


    internal class Program
    {
        static void Main(string[] args)
        {




            //1-	Write a C# program that accepts an integer and determines if the number is even or odd. Display the result.

            //    Console.WriteLine("inter a number please");
            //    string x = Console.ReadLine();
            //    int xAsInt = Int32.Parse(x);
            //    even_odd(xAsInt);




            //2-	Write a C# program that accepts five numbers and displays the  2nd smallest of the five.

            //Console.WriteLine("inter five numbers please");
            //int[] numbers=new int[5];

            //for (int j = 0; j < 5; j++)
            //{
            //    string i = Console.ReadLine(); //take the input from user
            //    int  iAsInt = Int32.Parse(i); //convert to int
            //    numbers[j] = iAsInt;
            //}

            //int secondSmallest = secondSmaller(numbers);
            //Console.WriteLine($"The second smallest number is: {secondSmallest}");


            //3-	Write a program that calculates the factorial of a given number using a for loop.
            //Console.WriteLine("inter a number to find the factorate");
            //string x = Console.ReadLine();
            //int xAsInt = Int32.Parse(x);

            //Console.WriteLine( fact(xAsInt));


            //4-	Write a program that takes two integers as input and prints all the prime numbers between them using nested loops.

            //Console.WriteLine("inter ywo numbers to find prime numbers between :");
            //string num1 = Console.ReadLine();
            //string num2 = Console.ReadLine();
            //int num1AsInt = Int32.Parse(num1);
            //int num2AsInt = Int32.Parse(num2);

            //primBetween(num1AsInt, num2AsInt);


            //5-	Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
            // Console.WriteLine("the largest number in this array  { 1, 2, 3, 4, 5 }  is ");
            // int[] numbers = { 1, 2, 3, 4, 5 };
            //Console.WriteLine( largestNum(numbers));


            //6-	Write a program that prints the following number pattern using nested loops:
            // For n = 5, the output should be:
            //Console.WriteLine("Enter a number to create a pattern for: ");
            //string number = Console.ReadLine();
            //int numberAsInt = Convert.ToInt32(number);

            //NumbersBattern(numberAsInt);

            //7-	Write a program that prints a pyramid pattern using stars (*) based on the input height. Use nested loops. (optional)


            //Console.WriteLine("Enter a number to create a pattern for: ");
            //string number = Console.ReadLine();
            //int numberAsInt = Convert.ToInt32(number);
            //NumbersBattern(numberAsInt);


            //8-	Write a program that takes an array of integers and calculates the sum of even numbers and odd numbers separately using loops.  (optional)
            //Console.WriteLine("for this array  { 1, 2, 3, 4, 5 }  ");
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //Odd_even(numbers);



            //9- Write a program that compares two arrays and prints their common elements using loops. (optional)
            //Console.WriteLine("for the two arrays  { 1, 2, 3, 4, 5 } and  { 1, 10, 20, 4, 5 } ");
            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 1, 10, 20, 4, 5 };

            //CommonItems(array1, array2);


            HotelReservationSystem hotelRoom1 = new HotelReservationSystem();
            Console.WriteLine("enter a price per night");
            string price = Console.ReadLine();
            Console.WriteLine("enter the hotel room type");
            string type = Console.ReadLine();



            long priceAsInt = Convert.ToInt64(price);
            hotelRoom1.PricePerNight = priceAsInt;
            hotelRoom1.RoomType = type;

         
            Console.WriteLine(HotelReservationSystem.welcome);

            Console.WriteLine(price);
            
            Console.WriteLine(type);



















        }

        //1
        //static void even_odd(int x)
        //{
        //    if (x % 2 == 0)

        //        Console.WriteLine("the number is even");
        //    else

        //        Console.WriteLine("the number is odd");
        //}

        //2
        //static int secondSmaller(int[] array)
        //{

        //    Array.Sort(array);

        //    return array[1];

        //}

        //3
        //static int fact(int num)
        //{

        //    int sum = num;
        //    while (num > 1)
        //    {
        //        sum = sum * (num - 1);
        //        num--;
        //    }

        //    return sum;

        //}


        //4 
        //static void primBetween(int num1, int num2)
        //{
        //    int bet = num2 - num1, sum = 0, flag = 0;
        //    string[] array = new string[bet];

        //    for (int j = 0; j < bet; j++)
        //    {

        //        for (int i = 2; i <= num2 / 2; i++)
        //        {

        //            if (num1 % i == 0)
        //            {
        //                flag = 0;
        //                break;
        //            }
        //            flag = 1;

        //        }

        //        if (flag == 1)
        //        {
        //            array[sum] = num1.ToString();
        //            sum++;
        //        }
        //        num1++;
        //    }

        //    foreach (string s in array)
        //    {
        //        Console.WriteLine(s);
        //    }

        // 5
        //static int largestNum(int[] numbers)
        //{

        //    int larg = numbers[0];
        //    foreach (var item in numbers)
        //    {
        //        if (item > larg)
        //            larg = item;
        //    }
        //    return larg;
        //}

        //6 
        //static void NumbersBattern(int numberAsInt)
        //{
        //    int copyI = 0;

        //    for (int i = 1; i <= numberAsInt; ++i)
        //    {
        //        copyI = i;
        //        for (int j = 1; j <= i; j++)
        //        {

        //            Console.Write(copyI++ + " " ); 
        //        }
        //        Console.WriteLine("\n");

        //    }


        //}


        //7
        //static void NumbersBattern(int numberAsInt)
        //{


        //    for (int i = 1; i <= numberAsInt; ++i)
        //    {

        //        for (int j = 1; j <= i; j++)
        //        {

        //            Console.Write("*");
        //        }
        //        Console.WriteLine("\n");

        //    }


        //}

        //8 
        //static void Odd_even(int[] numbers)
        //{

        //    int odd = 0, even = 0;

        //    foreach (var item in numbers)
        //    {
        //        if (item % 2 == 0)
        //            even++;
        //        else odd++;

        //    }

        //    Console.WriteLine("The Number of odd number is " + odd + " The Number of even numbers is " + even);

        //}

        //9
        //static void CommonItems(int[] array1, int[] array2)
        //{
        //    int[] commonArray;

        //    for(int i=0; i<array1.Length; i++)
        //    {
        //        if(array1[i] == array2[i]) 
        //            commonArray = new int[array2[i]];
        //    }

        //    Console.WriteLine("the common items between are : ");
        //    foreach (var item in commonArray)
        //    {
        //        Console.Write(item + " , ");
        //    }

        //}

        public class HotelReservationSystem
        {
            public string RoomNumber;
            public string RoomType;
            public long PricePerNight;
            public bool IsBooked;
            
            public const string welcome ="Grand Stay Hotel";
            

        }

       



    }
}













