using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Tools
{
    public static class FridgeOptions
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
            Console.WriteLine(" Temperature - 1 " +
                              "\n Turn on/off - 2" +
                              "\n Energy effectiveness - 3" +
                              "\n Smart cooling - 4" +
                              "\n Quit the tool - 0"
                              );

            int function = int.Parse(Console.ReadLine());
            return function;
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


        public static bool? On()
        {
            Console.Write("Please enter whether you want to edit if the fridge is on or off : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the fridge on (true) or off (false) : ");
                bool isOn = bool.Parse(Console.ReadLine());
                return isOn;
            }
            return null;

        }
        public static bool? EnergyEffectiveness()
        {
            Console.Write("Please enter whether you want to edit the energy effectiveness or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the energy effectiveness on (true) or off (false) : ");
                bool energyOn = bool.Parse(Console.ReadLine());
                return energyOn;
            }
            return null;

        }
        public static bool? SmartCooling()
        {
            Console.Write("Please enter whether you want to edit the smart cooling mode or not : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the smart cooling on (true) or off (false) : ");
                bool smartCool = bool.Parse(Console.ReadLine());
                return smartCool;
            }
            return null;
        }
    }
}
