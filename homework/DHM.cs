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


                "The room is dark and musty with the smell of lost souls.",
                "You enter a pretty pink powder room and instantly get glitter on you.",
                "You arrive in a room filled with chairs and a ticket stub machine...DMV",
                "You enter a quiet library... silence... nothing but silence....",
                "As you enter the room, you realize you are standing on a platform surrounded by sharks",
                "Oh my.... what is that smell? You appear to be standing in a compost pile",
                "You enter a dark room and all you can hear is hair band music blaring.... This is going to be bad!",
                "Oh no.... the worst of them all... Oprah's bedroom....",
                "The room looks just like the room you are sitting in right now... or does it?",
            };


            return rooms[new Random().Next(rooms.Length)];
        }
    }//end Class
}//end Name


