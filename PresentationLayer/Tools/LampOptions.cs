using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Tools
{
    public static class LampOptions
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
            Console.WriteLine("\nTurn on/off - 1 " +
                              "\nLightness factor - 2" +
                              "\nQuit the tool - 0"
                              );

            int function = int.Parse(Console.ReadLine());
            return function;
        }

        public static int? LightnessFactor()
        {
            Console.Write("Please enter whether you want to edit the lightness factor : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Enter the lightness factor of the lamp: ");
                int lf = int.Parse(Console.ReadLine());
                return lf;
            }
            return null;
        }

        public static bool? On()
        {
            Console.Write("Please enter whether you want to edit if the lamp is on or off : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the lamp on (true) or off (false) : ");
                bool isOn = bool.Parse(Console.ReadLine());
                return isOn;
            }
            return null;

        }
    }
}
