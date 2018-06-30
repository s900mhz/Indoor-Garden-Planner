using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenPlanner_CLI
{
    public class CLI
    {
        public static void WelcomeHeader()
        {
            Console.WriteLine("Welcome to the Garden Planner!");
            Console.WriteLine("Choose Your option below!");
        }
        public static int MainMenuOptions()
        {
            //Dictionary of Menu Options
            Dictionary<int, String> DicOfOptions = new Dictionary<int, string>();
            DicOfOptions[1] = "Find Companion Plants";

            //Foreach loop to build the menu
            foreach (var option in DicOfOptions)
            {
                Console.WriteLine($"{option.Key}  {option.Value}");
            }

            int selection = CLIHelper.GetInteger("Choose your option!");
            return selection;

        }
    }
}
