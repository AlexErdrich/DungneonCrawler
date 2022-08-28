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
            Console.WriteLine("Tower Fantasy!");

            int floor = 0;
            Console.WriteLine("\n\nPlease, Tell us your name, great hero... ");
            string username = Console.ReadLine();

            var races = Enum.GetValues(typeof(Race));
            int index = 1;
            foreach (var race in races) { Console.WriteLine($"{index}) {race}"); index++; }
            Console.WriteLine("Please select from the list, what race you want to be.");
            int userInput = int.Parse(Console.ReadLine()) - 1;
            Race userRace = (Race)userInput;


            bool gameRun = true;
            bool encounter = true;
            do
            {
                Console.WriteLine("\n\nSelect your action, traveler.\n\n");

                Console.WriteLine("Explore (e)");
                Console.WriteLine("Character Info (c)");
                //Console.WriteLine($@" ");  
                Console.WriteLine("Exit (esc)");
                ConsoleKey actions = new ConsoleKey();
                actions = Console.ReadKey().Key;
                Console.Clear();

                switch (actions)
                {
                    case ConsoleKey.E:
                        string room = GetRoom();
                        Console.WriteLine(room);

                        do
                        {
                            Console.WriteLine("\n\nSelect your action, traveler.\n\n");

                            Console.WriteLine("Attack (a)");
                            Console.WriteLine("Run Away (r)");
                            Console.WriteLine("Character Info (c)");
                            Console.WriteLine("Monster Info (m)");

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
               "As you enter the room, ", "The air in the room is smoky, ", "A draft blow throughout the room, ", 
            };
            string[] rooms2 =
             {
               "the floor boards creak with your every step. ", "a thick smell of urine permeates the air. ","chiming can be heard as bones rattle from the rafters. ", "the rotted and dried remains of three humans lie strewn in the room. ","the body of a dwarf, dead for several weeks, lies upon the floor, it's head crushed in and it's body stripped of everything. ", "twenty iron hooks and pegs have been hammered into one wall at a height of four to six feet off the floor. Laying along one wall is a partially intact medium sized humanoid skeleton. "
           };
            string[] rooms3 =
             {
                $"You suddenly spot a {Monster.SpawnWeakEnemy} that looks to be eating the remains of the last adventurer.",
            };
            string desc1 = rooms[new Random().Next(rooms.Length)];
            string desc2 = rooms2[new Random().Next(rooms2.Length)];
            string desc3 = rooms3[new Random().Next(rooms3.Length)];

            return desc1 + desc2 + desc3;

        }

    }//end Class
}//end Name


