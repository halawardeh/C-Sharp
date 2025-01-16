//int x = 1;
//     string Name = "Bilal";
//     float Num = 12.5f;
//     char C1 = 'E';
//     bool IsActive = true;

//     int [] Arr = {1,2,3,4,5,6,7};

//     Console.WriteLine("Hello World!");
//     Console.ReadLine();



using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your username and press enter
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
        }
    }
}
