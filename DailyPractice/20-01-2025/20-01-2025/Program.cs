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




            ////1-	Write a C# program that accepts an integer and determines if the number is even or odd. Display the result.
            //Console.WriteLine("*********************************************************************");
            //Console.WriteLine("Task 1");
            //Console.WriteLine("Enter a number to determine if it is odd or even: ");
            //string x = Console.ReadLine();
            //int xAsInt = Int32.Parse(x);
            //even_odd(xAsInt);




            ////2-	Write a C# program that accepts five numbers and displays the  2nd smallest of the five.
            //Console.WriteLine("*********************************************************************"); 
            //Console.WriteLine("Task 2");
            //Console.WriteLine("Enter five numbers to display the second smaller one of them");
            //int[] numbers = new int[5];

            //for (int j = 0; j < 5; j++)
            //{
            //    string i = Console.ReadLine(); //take the input from user
            //    int iAsInt = Int32.Parse(i); //convert to int
            //    numbers[j] = iAsInt;
            //}

            //int secondSmallest = secondSmaller(numbers);
            //Console.WriteLine($"The second smallest number is: {secondSmallest}");


            ////3-	Write a program that calculates the factorial of a given number using a for loop.
            //Console.WriteLine("*********************************************************************"); 
            //Console.WriteLine("Task 3");
            //Console.WriteLine("Enter a number to find the factorial for");
            //string x4 = Console.ReadLine();
            //int xAsInt1 = Int32.Parse(x4);

            //Console.WriteLine(fact(xAsInt1));


            ////4-	Write a program that takes two integers as input and prints all the prime numbers between them using nested loops.
            //Console.WriteLine("*********************************************************************");
            //Console.WriteLine("Task 4");
            //Console.WriteLine("Enter you numbers to find prime numbers between :");
            //string num1 = Console.ReadLine();
            //string num2 = Console.ReadLine();
            //int num1AsInt = Int32.Parse(num1);
            //int num2AsInt = Int32.Parse(num2);

            //primBetween(num1AsInt, num2AsInt);


            ////5-	Create a program that initializes an integer array and finds the largest number in it using a foreach loop.
            //Console.WriteLine("*********************************************************************"); 
            //Console.WriteLine("Task 5");
            //Console.WriteLine("The largest number in this array  { 1, 2, 3, 4, 5 }  is ");
            //int[] numbers1 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(largestNum(numbers1));


            //6-	Write a program that prints the following number pattern using nested loops:
            Console.WriteLine("*********************************************************************"); 
            Console.WriteLine("Task 6");
            Console.WriteLine("Enter a number to create a pattern for: ");
            string number = Console.ReadLine();
            int numberAsInt = Convert.ToInt32(number);
            NumbersBattern(numberAsInt);


            //7-	Write a program that prints a pyramid pattern using stars (*) based on the input height. Use nested loops. (optional)
            Console.WriteLine("*********************************************************************"); 
            Console.WriteLine("Task 7");
            Console.WriteLine("Enter a number to create a stars pattern for: ");
            string number2 = Console.ReadLine();
            int numberAsInt2 = Convert.ToInt32(number2);
            Startpattern(numberAsInt2);


            //8-	Write a program that takes an array of integers and calculates the sum of even numbers and odd numbers separately using loops.  (optional)
            Console.WriteLine("*********************************************************************"); 
            Console.WriteLine("Task 8");
            Console.WriteLine("For this array  { 1, 2, 3, 4, 5 }  ");
            int[] numbers3 = { 1, 2, 3, 4, 5 };
            Odd_even(numbers3);



            //9- Write a program that compares two arrays and prints their common elements using loops. (optional)
            //Console.WriteLine("*********************************************************************"); 
            //Console.WriteLine("Task 9");
            //Console.WriteLine("for the two arrays  { 1, 2, 3, 4, 5 } and  { 1, 10, 20, 4, 5 } ");
            //int[] array1 = { 1, 2, 3, 4, 5 };
            //int[] array2 = { 1, 10, 20, 4, 5 };

            //CommonItems(array1, array2);







            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Task 10 (Class & Object");
            HotelReservationSystem hotelRoom1 = new HotelReservationSystem();
            Console.WriteLine("Enter a price per night");
            string price = Console.ReadLine();
            Console.WriteLine("Enter the hotel room type");
            string type = Console.ReadLine();



            long priceAsInt = Convert.ToInt64(price);
            hotelRoom1.PricePerNight = priceAsInt;
            hotelRoom1.RoomType = type;


            Console.WriteLine(HotelReservationSystem.welcome);

            Console.WriteLine("The Price per night is " + price);

            Console.WriteLine("and the type of room is " + type);



















        }

        // Method 1
        static void even_odd(int x)
        {
            if (x % 2 == 0)

                Console.WriteLine("The number is even");
            else

                Console.WriteLine("The number is odd");
        }



        // Method 2
        static int secondSmaller(int[] array)
        {

            Array.Sort(array);

            return array[1];

        }

        // Method 3
        static int fact(int num)
        {

            int sum = num;
            while (num > 1)
            {
                sum = sum * (num - 1);
                num--;
            }

            return sum;

        }


        // Method 4 
        static void primBetween(int num1, int num2)
        {
            int bet = num2 - num1, sum = 0, flag = 0;
            string[] array = new string[bet];

            for (int j = 0; j < bet; j++)
            {

                for (int i = 2; i <= num2 / 2; i++)
                {

                    if (num1 % i == 0)
                    {
                        flag = 0;
                        break;
                    }
                    flag = 1;

                }

                if (flag == 1)
                {
                    array[sum] = num1.ToString();
                    sum++;
                }
                num1++;
            }

            foreach (string s in array)
            {
                Console.WriteLine(s);
            }
        }
            //  Method 5
            static int largestNum(int[] numbers)
            {

                int larg = numbers[0];
                foreach (var item in numbers)
                {
                    if (item > larg)
                        larg = item;
                }
                return larg;
            }

            // Method 6 
            static void NumbersBattern(int numberAsInt)
            {
                int copyI = 0;

                for (int i = 1; i <= numberAsInt; ++i)
                {
                copyI++;
                for (int j = 1; j <= i; j++)
                    {

                        Console.Write(copyI++ + " ");
                    }
                    Console.WriteLine("\n");

                }


            }


            // Method 7
            static void Startpattern(int numberAsInt)
            {


                for (int i = 1; i <= numberAsInt; ++i)
                {

                    for (int j = 1; j <= i; j++)
                    {

                        Console.Write("*");
                    }
                    Console.WriteLine("\n");

                }


            }

            // Method 8 
            static void Odd_even(int[] numbers)
            {

                int odd = 0, even = 0;

                foreach (var item in numbers)
                {
                    if (item % 2 == 0)
                        even++;
                    else odd++;

                }

                Console.WriteLine("The Count of odd numbers is " + odd + " The Count of even numbers is " + even);

            }

            // Method 9
            //static void CommonItems(int[] array1, int[] array2)
            //{
            //    int[] commonArray;

            //    for (int i = 0; i < array1.Length; i++)
            //    {
            //        if (array1[i] == array2[i])
            //            commonArray = new int[array2[i]];
            //    }

            //    Console.WriteLine("the common items between are : ");
            //    foreach (var item in commonArray)
            //    {
            //        Console.Write(item + " , ");
            //    }

            //}




            //Class for Hotel
        public class HotelReservationSystem
        {
            public string RoomNumber;
            public string RoomType;
            public long PricePerNight;
            public bool IsBooked;

            public const string welcome = "Grand Stay Hotel";


        }





    }
}













