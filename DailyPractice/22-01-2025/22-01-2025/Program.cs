using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_01_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //// Create a myPhone object
            //Phone myPhone = new Phone();
            //myPhone.type = "Phone";
            //myPhone.Notification = "Call"; //set value for Notification field

            //myPhone.notification(); // get the notification method to display the notifaction

            //// Display the value of the type field (from the ElectronicDevices class)
            //// and the value of the model from the ElectronicDevices  class
            //Console.WriteLine("The device is " + myPhone.type + ",  model is " + myPhone.phonModel);

            //creat object of class vehicle
            Vehicle Bike = new Vehicle();
            

            Bike.Brand = "bikeBrand";
            Bike.Model = "2024";
            Bike.Start();
            Bike.description();

            //create object of class car
            Car BMW = new Car();
            BMW.NumberOfDoors = 4;
            BMW.Model = "2020";
            BMW.Start1();
            BMW.description();
            BMW.Details();








        }


        //class ElectronicDevices  // base class (parent) 
        //{
        //    public string type;  // Eelectronic_devices type field
        //    public string Notification;  // Eelectronic_devices Notification field
        //    public void notification()             // Eelectronic_devices notification method 
        //    {
        //        Console.WriteLine($"You have a " +  $"{Notification}");
        //    }
        //}

        //class Phone : ElectronicDevices  // derived class (child)
        //{

        //    public string phonModel = "SAMSONG";  // phonModel field
        //}


        class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public void Start()
            {
                Console.WriteLine("Vehicle is starting.");
            }

            public void description()
            {
                Console.WriteLine($"Model id {Model}");
            }

        }
         class Car : Vehicle 
        {

            public void Start1()
            {
                Console.WriteLine("Car is starting.");
            }
            public int NumberOfDoors;


            public void Details()
            {
                Console.WriteLine($"The number of doors are {NumberOfDoors}");
            }
        }








    }
}
