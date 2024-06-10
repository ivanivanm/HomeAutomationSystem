using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Tools
{
    public static class AirConditioningOptions
    {
        public static string WelcomeFirstTime()
        {
            Console.WriteLine("Enter the name of your tool: ");
            string toolName = Console.ReadLine();
            return toolName;
        }

        public static void Welcome(string toolName)
        {
            Console.WriteLine(toolName);
        }

        public static int Functions()
        {
            Console.WriteLine("Choose a function:");
            Console.WriteLine("\n Temperature - 1 " +
                              "\n Turn on/off - 2" +
                              "\n Direction - 3" +
                              "\n Mode - 4" +
                              "\n Speed - 5" +
                              "\n Late start - 6" +
                              "\n Late stop - 7" +
                              "\n Turbo - 8" +
                              "\n Self cleaning - 9" +
                              "\n Quit the tool - 0"
                              );

            int function = int.Parse(Console.ReadLine());
            return function;
        }
        public static bool? On()
        {
            Console.Write("Please enter whether you want to edit if the AC is on or off : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the AC on (true) or off (false) : ");
                bool isOn = bool.Parse(Console.ReadLine());
                return isOn;
            }
            return null;

        }
        public static bool? SelfCleaning()
        {
            Console.Write("Please enter whether you want to edit the self cleaning mode or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the self cleaning mode on (true) or off (false) : ");
                bool selfClean = bool.Parse(Console.ReadLine());
                return selfClean;
            }
            return null;

        }
        public static bool? Turbo()
        {
            Console.Write("Please enter whether you want to edit the turbo mode or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the turbo mode on (true) or off (false) : ");
                bool turbo = bool.Parse(Console.ReadLine());
                return turbo;
            }
            return null;

        }

        public static int? Temperature()
        {
            Console.Write("Please enter whether you want to edit the temperature or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.WriteLine("Enter the temperature: ");
                int temperature = int.Parse(Console.ReadLine());
                return temperature;
            }
            return null;
        }

        public static int? Speed()
        {
            Console.Write("Please enter whether you want to edit the speed or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.WriteLine("Enter the speed: ");
                int speed = int.Parse(Console.ReadLine());
                return speed;
            }
            return null;

        }

        public static int? Direction()
        {
            Console.Write("Please enter whether you want to edit the direction mode or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.WriteLine("Enter the direction: ");
                Console.WriteLine("Up - 1 " +
                                  "\nCenter - 2" +
                                  "\nDown - 3" +
                                  "\nAuto - 4"
                                  );
                int direction = int.Parse(Console.ReadLine());
                return direction;
            }
            return null;
        }
        public static int? Mode()
        {
            Console.Write("Please enter whether you want to edit the general mode or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Enter the mode: ");
                int mode = int.Parse(Console.ReadLine());
                return mode;
            }
            return null;
        }

        public static int? LateStart()
        {
            Console.Write("Please enter whether you want to edit the late start mode or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.WriteLine("Enter the minutes to the late start:");
                int minutes = int.Parse(Console.ReadLine());
                return minutes;
            }
            return null;

        }
        public static int? LateStop()
        {
            Console.Write("Please enter whether you want to edit the late stop mode or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.WriteLine("Enter the minutes to the late stop:");
                int minutes = int.Parse(Console.ReadLine());
                return minutes;
            }
            return null;
        }
    }
}
