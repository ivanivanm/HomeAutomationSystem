using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Tools
{
    public static class TVOptions
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
            Console.WriteLine(
                              "\n Turn on/off - 1" +
                              "\n Volume - 2" +
                              "\n Lightness Factor - 3" +
                              "\n Night mode - 4" +
                              "\n Quit the tool - 0"
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
                Console.Write("Please enter the volume of lightness factor (0-100) : ");
                int lf = int.Parse(Console.ReadLine());
                return lf;
            }
            return null;

        }
        public static bool? On()
        {
            Console.Write("Please enter whether you want to edit if the TV is on or off : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the lamp on (true) or off (false) : ");
                bool isOn = bool.Parse(Console.ReadLine());
                return isOn;
            }
            return null;

        }
        public static bool? NightMode()
        {
            Console.Write("Please enter whether you want to edit the night mode : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.Write("Please enter if you want to turn the night mode on (true) or not (false): ");
                bool nm = bool.Parse(Console.ReadLine());
                return nm;
            }
            return null;

        }

        public static int? Volume()
        {
            Console.Write("Please enter whether you want to edit the volume : ");
            bool choice = bool.Parse(Console.ReadLine());
            if (choice)
            {
                Console.WriteLine("Enter volume:");
                int volume = int.Parse(Console.ReadLine());
                return volume;
            }
            return null;
        }

    }
}
