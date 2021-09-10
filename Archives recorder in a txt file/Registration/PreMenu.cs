using Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    class PreMenu
    {
        public static void ChooserClient()
        {
            while (true)
            // Make a loop of choices until you type that you wanna get out of the execution of the program.
            {
                string message = "===============Client Registration===============\n" +
                "0 - Get out of execution of the program.\n" +
                "1 - Registrate a client in a .txt archive.\n" +
                "2 - Show wich clients are registrated.\n";
                Console.WriteLine(message);
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 0) break;
                // Get out of the loop if the answer is 0;
                else if (answer == 1)
                {
                    var client = new Client().Read();

                    var client2 = new Client();
                    Console.Write("Write the name of the client: ");
                    client2.Name = Console.ReadLine();
                    Console.Write("Write the telephone of the client: ");
                    client2.Telephone = Console.ReadLine();
                    Console.Write("Write the id of the client: ");
                    client2.ID = Console.ReadLine();
                    client2.Record();
                    // You define the name, telephone and id and record them into your .txt file.
                    Console.WriteLine("=============================");
                }
                else if (answer == 2)
                {
                    var client = new Client().Read();

                    var client3 = new Client();
                    int i = 0;
                    foreach (Client c in client)
                    {
                        i++;
                        Console.WriteLine($"==================Client {i}================\n");
                        Console.WriteLine($"Name: {c.Name}\n");
                        Console.WriteLine($"Telephone: {c.Telephone}\n");
                        Console.WriteLine($"ID: {c.ID}\n");
                        // You print all the clients that were record.
                    }
                }
                else Console.WriteLine("Invalid number, please type it again\n");
            }
        }
        public static void ChooserUser()
        {
            while (true)
            // Same observations from the client.
            {
                string message = "===============User Registration===============\n" +
                "0 - Get out of execution of the program.\n" +
                "1 - Registrate a user in a .txt archive.\n" +
                "2 - Show wich users are registrated.\n";
                Console.WriteLine(message);
                int answer = Convert.ToInt32(Console.ReadLine());

                if (answer == 0) break;
                else if (answer == 1)
                {
                    var user1 = new User().Read();

                    var user2 = new User();
                    Console.Write("Write the name of the client: ");
                    user2.Name = Console.ReadLine();
                    Console.Write("Write the telephone of the client: ");
                    user2.Telephone = Console.ReadLine();
                    Console.Write("Write the id of the client: ");
                    user2.ID = Console.ReadLine();
                    user2.Record();

                    Console.WriteLine("=============================");
                }
                else if (answer == 2)
                {
                    var user = new User().Read();

                    var user3 = new User();
                    int i = 0;
                    foreach (User u in user)
                    {
                        i++;
                        Console.WriteLine($"==================User {i}================\n");
                        Console.WriteLine($"Name: {u.Name}\n");
                        Console.WriteLine($"Telephone: {u.Telephone}\n");
                        Console.WriteLine($"ID: {u.ID}\n");
                    }
                }
                else Console.WriteLine("Invalid number, please type it again\n");
            }
        }

    }
}
