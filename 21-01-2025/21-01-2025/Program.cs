using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _21_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {







            // o Create an object from the Student class with the following values:
            //	Name: "Ahmad"
            //	Age: 22
            //	Student ID: 1001
            //o Call the GetDetails method for the object.

            //Console.WriteLine("get method with creating class for ahmed");
            //Student student1 = new Student();
            //student1.studentName = "Ahmed";
            //student1.studentAge = 22;
            //student1.studentId = 1001;

            //student1.GetDetails();

            //	Accepts the name, age, and student ID as parameters.
            //	Updates the class fields with the given values
            Student student2 = new Student("hala", 12, 141088);
            student2.GetDetails();






        }











        class Student //create the student class
        {


            const int MinAge = 18; //o Add a constant named MinAge to represent the minimum allowed age for a student(18 years).
            const int MaxAge = 40; //o Add a constant named MaxAge to represent the maximum allowed age for a student(40 years).

            private string Name; //field
            private string studentName //property
            {
                get { return Name; }
                set { Name = value; }
            }

            private int Age;//field

            private int studentAge //proprty
            {
                get { return Age; }
                set
                {

                    if (Age <= MinAge)
                    {
                        Age = MinAge;
                    }
                    else if (Age > MaxAge)
                    {
                        Age = MaxAge;
                    }

                    else
                        Age = value;
                }

            }

            private long Id;

            private long studentId
            {
                get { return Id; }
                set { Id = value; }

            }
            private string Email { get; set; }  //	Add an auto property named Email to represent the student’s email.











            //o Add a method named GetDetails that displays a message containing the student’s name, age, and ID.
            //GetDetails(); // displays a message containing the student’s name, age, and ID.
            public void GetDetails()
            {
                //Student student = new Student();

                Console.WriteLine("The student name is " + studentName + " and  the age is " + studentAge + " and the ID is " + studentId);
            }



            //  o Add a constructor to the Student class that :
            //	Accepts the name, age, and student ID as parameters.
            //	Updates the class fields with the given values.

            public Student(string name, int age, long id)
            {
                studentName = name;
                studentAge = age;
                studentId = id;
            }

            ~Student()

            {
                Console.WriteLine("finished");
            }
        }












    }
}
