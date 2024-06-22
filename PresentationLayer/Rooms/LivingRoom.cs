using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Rooms
{
    public  class LivingRoom
    {
        public static string WelcomeFirstTime()
        {
            Console.WriteLine("Enter the name of your room: ");
            string roomName = Console.ReadLine();
            return roomName;
        }

        public static void Welcome(string roomName)
        {
            Console.WriteLine(roomName);
        }

        public static int Choice()
        {
            Console.WriteLine("What would you like to do today?");
            Console.WriteLine("Choose a tool - 1 " +
                "\nAdd a tool - 2 " +
                "\nDelete a tool - 3" +
                "\n Quit the room - 0");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public static Tuple<string,int> DeleteTool()
        {
            Console.Write("Please enter the type of tool you want to delete (tv,f,l,ac) : ");
            string type = Console.ReadLine();
            Console.Write("Please enter the id of the tool you want to delete : ");
            int id = int.Parse(Console.ReadLine());
            return new Tuple<string, int>(type,id);
        }
        public static int AddTool()
        {
            Console.WriteLine("Choose a tool to add:");
            Console.WriteLine("Air Conditioning - 1 " +
                              "\nFridge - 2" +
                              "\nLamps - 3" +
                              "\nTV - 4" +
                              "\nMicrowave - 5" +
                              "\nOven - 6"
                              );

            int newTool = int.Parse(Console.ReadLine());
            return newTool;
        }
    }
}
