using Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archives_recorder_in_a_txt_file
{
    class Menu
    {
        public static void Chooser()
        {
            while (true)
            // Make a loop of choices until you type that you wanna get out of the execution of the program.
            {
                string message = "===============Record User or Client on Database===============\n" +
                "0 - Get out of execution of the program.\n" +
                "1 - Go to client registration.\n" +
                "2 - Go to user registration.\n";
                Console.WriteLine(message);
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 0) break;
                // Get out of the loop if the answer is 0;
                else if (answer == 1)
                {
                    PreMenu.ChooserClient();
                    // Show the menu to the choiches of client registration.
                }
                else if (answer == 2)
                {
                    PreMenu.ChooserUser();
                    // Show the menu to the choiches of user registration.
                }
                else Console.WriteLine("Invalid number, please type it again\n");
            }
        }
    }
}
