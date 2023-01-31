using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
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
            string playerName = Console.ReadLine();

            var races = Enum.GetValues(typeof(Race));
            int index = 1;
            foreach (var race in races) { Console.WriteLine($"{index}) {race}"); index++; }
            Console.WriteLine("\n\nPlease select from the list, what race you want to be.");
            int userInput = int.Parse(Console.ReadLine()) - 1;
            Race userRace = (Race)userInput;

            var jobs = Enum.GetValues(typeof(Job));
            foreach (var job in jobs) {Console.WriteLine($"{index}) {job}"); index++; }

            Console.WriteLine("\n\nPlease select from the list, what Profession would you like to be.");
            int userJobInput = int.Parse(Console.ReadLine()) -1;
            Job userJob = (Job)userJobInput;
            //need weapon gerneration.
            Weapons playerweapons = Methods.Wpn()[17];

            Player player = new Player(playerName, 10, 10, 10, 10, 10, 0, 0, 0, 10, 10, 10, 10, 10, 10, userRace, playerweapons, userJob);
           
            bool gameRun = true;

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
                        string room = Methods.getRoom();
                        Console.WriteLine(room);
                        Monster monster = Methods.SpawnWeakEnemy();

                        Console.WriteLine($"You have found a {monster.Name}");
                        bool encounter = true;
                        do
                        {
                            Console.WriteLine("\n\nSelect your action, traveler.\n\n");

                            Console.WriteLine("Attack (a)");
                            Console.WriteLine("Run Away (r)");
                            Console.WriteLine("Character Info (c)");
                            Console.WriteLine("Monster Info (m)");
                            Console.WriteLine($"\n Floor: {floor}");

                            ConsoleKey eActions = new ConsoleKey();
                            eActions = Console.ReadKey().Key;
                            Console.Clear();

                            switch (eActions)
                            {
                                case ConsoleKey.A:
                                    Console.WriteLine($"You have attacked.");
                                    Methods.DoBattle(player, monster);
                                    if (monster.CHealth <= 0) 
                                    {
                                        floor++;
                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.WriteLine($"\nYou killed {monster.Name}!");
                                        Console.Beep(700, 500);
                                        Console.ResetColor();
                                        encounter = false;
                                    }

                                    if (player.CHealth <= 0)
                                    {
                                        Console.WriteLine("Dude.... You died!\a");
                                        gameRun = false;
                                    }

                                    break;

                                case ConsoleKey.R:

                                    Console.WriteLine($"You have run away. Your foe gets a free attack.");
                                    Methods.DoAttack(monster, player);
                                    encounter = false;
                                    break;

                                case ConsoleKey.C:
                                   Console.WriteLine($"Floor number: {floor}");

                                    break;

                                case ConsoleKey.M:
                                    break;

                                default:
                                   // Main(args); (for restart option)
                                    break;
                            }


                        } while (encounter == true);
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine($"Your Info is");
                        Console.WriteLine(player);
                        Console.WriteLine(new String('*', Console.WindowWidth));
                        break;



                    case ConsoleKey.Escape:

                        gameRun = false;
                        break;
                    default:
                        break;
                }



            } while (gameRun == true);

        }
        

    }//end Class
}//end Name


// {
//return $@"
//** MONSTER **
//{Name}
//Life: {Life} of {MaxLife}
//Damage: {MinDamage} to {MaxDamage}
//Block: {Block}
//Description:
//{Description}"; }
