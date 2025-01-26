using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Calcualtor cal = new Calcualtor();
            ////Console.WriteLine(cal.CalTwoInt(5, 6,3));
            //Console.WriteLine(cal.CalThrDoubles(5,5,1.5));

            //Shape triangle = new Shape();
            //Shape circle1 = new Circle();
            //Shape rectangle1 = new Rectangle();

            //triangle.Draw();
            //circle1.Draw();
            //rectangle1.Draw();


            //Cat cat1 = new Cat();
            //cat1.makeSound();
            //cat1.sleep();


            Guitar guitar1 = new Guitar();
            guitar1.play();

        }



        //examples for overloading
        class Calcualtor
        {


            public int CalTwoInt(int num1, int num2)
            {
                return num1 + num2;
            }

            public int CalThrInt(int num1, int num2, int num3)
            {
                return num1 + num2 + num3;
            }
            public double CalThrDoubles(double num1, double num2, double num3)
            {
                return num1 + num2 + num3;
            }


            //method overloading. with changing the return value and type of parameter
            public double CalThrDoubles(double num1, double num2, float num3)
            {
                return num1 + num2;
            }

            //method overloading by changing the number of parameters
            public int CalTwoInt(int num1, int num2, int num3)
            {
                return num1 + num2 * num3;
            }

            //method overloading by changing the data type
            public float CalThrInt(float num1, int num2, int num3)
            {
                return num1 + num2 + num3;
            }



        }




        //examples for overriding

        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a Shap! ");
            }



        }
        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle ");
            }

        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Rectangle ");
            }

        }







        // examples on abstract class (parent and child)

        abstract class Animal
        {
            public abstract void makeSound();

            public void sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }

        }

        // Derived class (inherit from Animal)
        class Dog: Animal 
        {
            public override void makeSound()
            {
                Console.WriteLine("Dog barks.");
            }

        }

        class Cat : Animal
        {
            public override void makeSound()
            {
               Console.WriteLine("Cat meows");
            }
        }



        // examples on Interfaces



        interface Playable {

           void play();


        }
        class Guitar : Playable
        {
          public void play()
            {
                Console.WriteLine("Playing the guitar");
            }

        }


        class Piano : Playable
        {
            public void play()
            {
                Console.WriteLine("Playing the piano.");
            }
        }





    }
}
