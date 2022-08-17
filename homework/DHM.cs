using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class DHM
    {
        static void Main(string[] args)
        {
            bool gameRun = true;
            bool encounter = true;
            do {
                Console.WriteLine("\n\nSelect your action, traveler.\n\n");

                Console.WriteLine("Explore");
                Console.WriteLine("Character Info");
                Console.WriteLine("Exit");
                ConsoleKey actions = new ConsoleKey();
                actions = Console.ReadKey().Key;
                Console.Clear();
                
                switch (actions)
                    {

                    case ConsoleKey.E:
                        Console.WriteLine($"You have explore a room and found ");
                        do
                        {
                            Console.WriteLine("\n\nSelect your action, traveler.\n\n");

                            Console.WriteLine("Attack");
                            Console.WriteLine("Run Away");
                            Console.WriteLine("Character Info");
                            Console.WriteLine("Monster Info");

                            ConsoleKey eActions = new ConsoleKey();
                            eActions = Console.ReadKey().Key;
                            Console.Clear();

                            switch (eActions)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine($"You have attacked.");
                                    break;

                                case ConsoleKey.R:
                                    Console.WriteLine($"You have Run Away.");
                                    encounter = false;
                                    break;

                                case ConsoleKey.C:
                                    break;

                                case ConsoleKey.M:
                                    break;

                                default:
                                    break;
                            }


                        } while (encounter == true);
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine($"Your Info is");
                        break;
                    


                    case ConsoleKey.Escape:

                        gameRun = false;
                        break;
                    default:
                        break;
                }
                           


            } while (gameRun == true);

        }
    }
}


