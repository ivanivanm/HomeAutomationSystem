using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Home
{
    public class HomeClass
    {
        public static string WelcomeHomeFirstTime()
        {
            Console.WriteLine("Welcome to ...");
            Console.WriteLine("Enter the name of your home: ");
            string homeName = Console.ReadLine();
            return homeName;
        }

        public static void WelcomeHome(string homeName)
        {
            Console.WriteLine("Welcome to ...");
            Console.WriteLine(homeName);
        }

        public static int Choice()
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("Choose a room - 1 " +
                "\nAdd a room - 2 " +
                "\nDelete a room - 3" +
                "\nQuit the app - 0");

            int choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public static Tuple<string, int> AddRoom()
        {
            Console.WriteLine("Choose a room to add:");
            Console.WriteLine("Living Room - 1 " +
                              "\nKitchen - 2" +
                              "\nBathroom - 3" +
                              "\nBedroom - 4"
                              );

            int newRoomType = int.Parse(Console.ReadLine());
            Console.Write("Please enter the name of the room : ");
            string name = Console.ReadLine();
            return new Tuple<string, int>(name, newRoomType);
        }
    }
}
