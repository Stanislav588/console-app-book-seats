using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] seats = { 23, 4, 68, 10 };
            bool isRightOption = true;

            while (isRightOption) {
                Console.SetCursorPosition(0, 20);

                for (int i = 0; i < seats.Length; i++)
                {
                    Console.WriteLine( $"In sector {i + 1} are available {seats[i]} seats");
                }
                Console.SetCursorPosition(0, 0);


                Console.WriteLine("1 - Book the seats");
                Console.WriteLine("2 - End the app");
                Console.Write("Choose your option : ");

                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                
                        Console.WriteLine("\nWhich sector you would like to book ? ");
                        int userSector;
                        int userSeats;
                        userSector = Convert.ToInt32(Console.ReadLine());
                        if (userSector < 1 || userSector > seats.Length) {
                            Console.WriteLine(" \nIncorrect seats value");
                       
                        }
           
                        Console.WriteLine("\nHow many seats do you need ?");
                        userSeats = Convert.ToInt32(Console.ReadLine());

                        if(userSeats < 1 || userSeats > seats[userSector - 1])
                        {
                            Console.WriteLine("Wrong value, try again !");
                            isRightOption = false;
                        }
                        else
                        {
                            seats[userSector - 1] -= userSeats;
                            Console.WriteLine($"\nYou successfully booked {userSeats} seats");
                           
                        }
                        break;
                       case 2:
                            isRightOption = false;
                        Console.WriteLine("\nThanks for using our app !");
                        break;
                }



            }



        }
    }
}
