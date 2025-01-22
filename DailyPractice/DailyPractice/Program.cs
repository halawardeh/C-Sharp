using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;

namespace _19_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //6-	Write a program that prints the following number pattern using nested loops:
            Console.WriteLine("*********************************************************************");
            Console.WriteLine("Task 6");
            Console.WriteLine("Enter a number to create a pattern for: ");
            string number = Console.ReadLine();
            int numberAsInt = Convert.ToInt32(number);
            NumbersBattern(numberAsInt);


            //1-	Write a C# program that accepts a double input and converts it into an int. Display both values.

            //Console.WriteLine("write double number and will be converted to intger");
            //string x;
            //x = Console.ReadLine();
            //double y = double.Parse(x);
            //Console.WriteLine((int)y);


            //2-	Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.

            //Console.WriteLine("write a number and I will reprint it for you");
            //string userinput=Console.ReadLine();
            //Console.WriteLine("Your number is: "+userinput);

            //3 - Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.

            //Console.WriteLine("write a statments and I will reprint it in uppercase");
            //string userinput=Console.ReadLine();
            //string output = userinput.ToUpperInvariant();
            //Console.WriteLine(output);


            //  4 - Write a program that takes a user's full name as input and prints:

            //Console.WriteLine("enter your full name");
            //string userinput=Console.ReadLine();
            //int lnameindex=userinput.IndexOf(" ");
            //string fname=userinput.Substring(0, lnameindex);
            //string lname= userinput.Substring(lnameindex+1);
            //Console.WriteLine(fname+" "+ lname);

            //5-	Write a program that accepts two integers and prints the smaller of the two.
            //Console.WriteLine("enter two numbers and the smaller one");
            //string strnum1 = Console.ReadLine();
            //string strnum2 = Console.ReadLine();
            //int num1 = int.Parse(strnum1);
            //int num2 = int.Parse(strnum2);
            //Console.WriteLine("smaller number is " + Math.Min(num1, num2));


            //6- Write a method that converts kilometers per hour to miles per hour. Use this method in a program to convert and display the result
            //Console.WriteLine("inter a number in kilopermeter and I will convert it to milepermeter");
            //Console.WriteLine(ktom(15) + "mph");




            //7-	Write a method that takes hours and minutes as input and returns the total number of minutes.
            //Console.WriteLine("enter two values one for hours and another one for minuts");

            //string hoursasstr = Console.ReadLine();
            //int hoursasint = int.Parse(hoursasstr);

            //string minasstr = Console.ReadLine();
            //int minasint = int.Parse(minasstr);

            //Console.WriteLine( "the total minuts are :"+htom(hoursasint, minasint)+ " minuts");


            //8-	Write a method that accepts minutes as input and calculates the total number of hours and minutes.

            //Console.WriteLine("inter the number of minuts and will presents as hours and minuts");

            //string minutsasStr=Console.ReadLine();
            //int minutsasInt=int.Parse(minutsasStr);
            //mtoh(minutsasInt);

            //9-	Compare Two Numbers Write a program that prints:

            //Console.WriteLine("inter two numbers ");

            //string num1asstr = Console.ReadLine();
            //int num1sasInt = int.Parse(num1asstr);

            //string num2asstr = Console.ReadLine();
            //int num2sasInt = int.Parse(num2asstr);


            //compare(num1sasInt, num2sasInt);


            //9.5 write a number calculate the sum of the number indeces
            //Console.WriteLine("Inter a number to claculate th sum of its indeces");
            //string num1asstr = Console.ReadLine(); //take the number from the user as string
            //long num1sasInt = long.Parse(num1asstr); // convert the number to double

            //Console.WriteLine(Sum1(num1sasInt));



            //10-	Reverse a Number  Write a program that reverses a number using arithmetic operators and loops.
            //Console.WriteLine("Inter a number and the reverse will be returned");
            //string num = Console.ReadLine();
            //Console.WriteLine(rev(long.Parse(num)));



            // 11-	 Check Divisibility  
            // Write a program to check if a number is divisible by another number using logical and arithmetic operators.
            // Return a message "Divisible" or "Not Divisible".

            //Console.WriteLine("Inter two numbers to check if they are Divisibleor or not");
            //string num = Console.ReadLine();
            //string div = Console.ReadLine();

            //divisable(double.Parse(num) , double .Parse(div) );



            //12-	Find the Middle Value
            //Write a program to find the middle value of three numbers using arithmetic and comparison operators.


            //Console.WriteLine("Inter three numbers to return the middle one");
            //string num1 = Console.ReadLine();
            //string num2 = Console.ReadLine();
            //string num3 = Console.ReadLine();

            //middle(double.Parse(num1), double.Parse(num2) , double.Parse(num3));




        }

        // Method 6 
        static void NumbersBattern(int numberAsInt)
        {
            int copyI = 1;

            for (int i = 1; i <= numberAsInt; i++)
            {
                
                for (int j = 1; j <= i; j++)
                {

                    Console.Write(copyI++ + " ");
                }
                Console.WriteLine("\n");
               
            }


        }




        //static double ktom(double kilometer)
        //{
        //    return kilometer * 0.621371;
        //}

        //static double htom(int h, int min)
        //{
        //    return h * 60 + min;
        //}

        //static void mtoh(int min)
        //{

        //    double hoursasf = min / 60.0;
        //    long hoursasi = (long)hoursasf;
        //    double rest = (hoursasf - hoursasi) * 60;

        //    Console.WriteLine("the total time is " + hoursasi + " hours and " + rest + " minuts");
        //}

        //static void compare(int num1, int num2)
        //{
        //    if (num1 == num2)
        //    {
        //        Console.WriteLine("the first number is graeter");
        //    }
        //    else if (num1 > num2)

        //    {
        //        Console.WriteLine("the first number is graeter");
        //    }

        //    else
        //    {
        //        Console.WriteLine("the second number is graeter");
        //    }


        //}

        //static double Sum(double num) //for example: 123.0
        //{

        //    //double sum = 0;//sum of the indeces
        //    //long numAsInt = (long)num; // 123.0 ---> 123
        //    //string numAsStr = Convert.ToString(numAsInt);//3 three indeces "123"
        //    //double divresultAsF; //division result as float
        //    //long divresultAsLong; // division result as long
        //    //double lastIndex; //the number at the right of number
        //    //double suntractResultsAsFloat = 0; // the subtract between the two numbers

        //    //for (int i = 0; i < numAsStr.Length; i++) //in this example the length is three
        //    //{
        //    //    divresultAsF = num / 10.0; // 123.0 / 10.0 = 12.3
        //    //    divresultAsLong = (long)divresultAsF; // 12
        //    //    num = divresultAsLong; // num = 12
        //    //    suntractResultsAsFloat = divresultAsF - divresultAsLong; //12.3 - 12 = 0.3
        //    //    lastIndex = suntractResultsAsFloat * 10; // 0.3 * 10 = 3.0
        //    //    lastIndex = (int)lastIndex; // 3.0 --> 3
        //    //    sum += lastIndex; // 3

        //    //}

        //    //return sum;

        //}


        //static long Sum1(long num) //for example: 123
        //{

        //    double sum = 0;//sum of the indeces


        //    while (num > 0)
        //    {
        //        sum += num % 10;
        //        num /= 10;

        //    }


        //    return sum;

        //}






        //static string rev(long num) //for example: 123
        //{
        //    double sum = 0;
        //    string sumAsStr = "";
        //    long lastDigit;
        //    while (num > 0)
        //    {
        //        sum += num % 10; // Get the last digit for summation
        //        lastDigit = num % 10; // Get the last digit
        //        sumAsStr += lastDigit; // results as string
        //        num /= 10;       // Remove the last digit
        //    }

        //    return sumAsStr;
        //}


        //static void divisable(double num, double div)
        //{
        //    if (num % div == 0)
        //    { Console.WriteLine("Divisible"); }
        //    else
        //    {
        //        Console.WriteLine(" Not Divisible");
        //    }

        //}

        //static void middle(double num1, double num2, double num3)
        //{

        //    if (num2 > num1 && num2 < num3) // 1 2 3 or 3 2 1
        //        Console.WriteLine("the middle number is " + num2);

        //    else if (num1 > num2 && num1 < num3 || num1 > num3 && num1 < num2) // 2 1 3 // 2 3 1
        //    {
        //        Console.WriteLine("the middle number is " + num1);
        //    }
        //    else if (num3 > num2 && num3 < num1 || num3 > num1 && num3 < num2) // 3 1 2 // 1 3 2
        //    {
        //        Console.WriteLine("the middle number is " + num3);
        //    }


        //}









    }



}