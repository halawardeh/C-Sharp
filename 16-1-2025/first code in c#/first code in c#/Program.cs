using System;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;


namespace first_code_in_c_
{
    internal class Program
    {


        static void Main(string[] args)
        {

            //task #1 : 	Create console application that read string from user and print the same string

            //string name;
            //name=Console.ReadLine();
            //Console.WriteLine(name);





            //task #2 :     Define variables with kind of
            //a.Double
            //b.String
            //c.Char
            //d.Bool
            //e.Int
            //f.Const
            //Then display it in console application

            //double x = 123.4f;
            //Console.WriteLine(x);

            //string name = "Hala Bani Hamad";
            //Console.WriteLine(name);

            //char charactor= 'a';
            //Console.WriteLine(charactor);

            //bool isfemale= true;
            //Console.WriteLine(isfemale);

            //int age = 23;
            //Console.WriteLine(age);

            //const double number= 141088;
            //Console.WriteLine(number);

            //task #3 : 	Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            //string[] cars = { "Kia", "Volvo", "Honday" };
            //foreach (string car in cars) {
            //    Console.WriteLine(car);
            //}




            //task #4 : 	Write a program in C that reads a first name, Lastname and year of birth
            //and display the names and the year one after another sequentially. Go to the editor

            //•	Input your firstname: Sami
            //•	Input your lastname: Ali
            //•	Input your year of birth: 1999
            //•	Sami Ali 1999

            //string fname, lname, birthdate;
            //Console.WriteLine("Input your firstname:");
            //fname = Console.ReadLine();

            //Console.WriteLine("Input your lastname:");
            //lname = Console.ReadLine();

            //Console.WriteLine("Input your year of birth year:");
            //birthdate = Console.ReadLine();

            //Console.WriteLine(fname + " " + lname + " " + birthdate);

            //task #5 : 	Write a program in C # to store elements in an array and print it. 
            //•	Test Data :	
            //•	Input 10 elements in the array :
            //•	element - 0 : 1
            //•	element - 1 : 1
            //•	element - 2 : 2
            //•	.......
            //•	Expected Output :
            //•	Elements in array are: 1 1 2 3 4 5 6 7 8 9
            //•	Elements in array are: 1 1 2 3 4 5 6 7 8 9


            Console.WriteLine("Input 10 elements in the array :");

            int[] numbers = new int[10];
            

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
        }
    }
}
