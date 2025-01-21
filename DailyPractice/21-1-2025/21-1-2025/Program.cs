using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_1_2025
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //HotelReservationSystem hotelRoom1 = new HotelReservationSystem();
            //Console.WriteLine("enter a price per night");
            //string price = Console.ReadLine();
            //Console.WriteLine("enter the hotel room type");
            //string type = Console.ReadLine();



            //long priceAsInt = Convert.ToInt64(price);
            //hotelRoom1.PricePerNight = priceAsInt;
            //hotelRoom1.RoomType = type;


            //Console.WriteLine(HotelReservationSystem.welcome);

            //Console.WriteLine(price);

            //Console.WriteLine(type);


            //HotelReservationSystem hotelReservationSystem = new HotelReservationSystem();
            //Console.WriteLine(hotelReservationSystem.RoomNumber);



            HotelReservationSystem hotelRoom1 = new HotelReservationSystem("one", "Single", 250, true);
            Console.WriteLine(hotelRoom1.RoomNumber + " "+  hotelRoom1.RoomType ) ;






        }




        public class HotelReservationSystem
        {
            public string RoomNumber{get; set;}
            public string RoomType { get; set; }
            public long PricePerNight { get; set; }
            public bool IsBooked { get; set; }

            public const string welcome = "Grand Stay Hotel";

            public HotelReservationSystem()
            {
                RoomNumber = "one";
            }

            public HotelReservationSystem(string roomNumber, string roomType, long pricePerNight, bool isBooked)
            {
                RoomNumber = roomNumber;
                RoomType = roomType;
                PricePerNight = pricePerNight;
                IsBooked = isBooked;
            }

            ~HotelReservationSystem()
            {
                Console.WriteLine("distroyed");
            }
        }




    }



}
