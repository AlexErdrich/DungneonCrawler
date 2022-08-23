using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tables;

namespace homework
{
    internal class DHM
    {
        static void Main(string[] args)
        {
            bool gameRun = true;
            bool encounter = true;
            do
            {
                Console.WriteLine("\n\nSelect your action, traveler.\n\n");

                Console.WriteLine("Explore");
                Console.WriteLine("Character Info");
                //Console.WriteLine($@" ");  
                Console.WriteLine("Exit");
                ConsoleKey actions = new ConsoleKey();
                actions = Console.ReadKey().Key;
                Console.Clear();

                switch (actions)
                {
                    case ConsoleKey.E:
                        string room = GetRoom();
                        Console.WriteLine($"You have explored a room and found... ");
                        Console.WriteLine(room);

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
        private static string GetRoom()
        {
            string[] rooms =
            {
                "As you enter the room, ",
            };
            string[] rooms2 = 
            {
                "the floor boards creak and you suddenly ",
            };
            string[] rooms3 =
            {
                $"spot a {Monster.monster} that looks to be eating the remains of the last adventurer",
            };
            string desc1 = rooms[new Random().Next(rooms.Length)];
            string desc2 = rooms2[new Random().Next(rooms2.Length)];
            string desc3 = rooms3[new Random().Next(rooms3.Length)];

            return desc1 + desc2 + desc3;
        }
    }//end Class
}//end Name


