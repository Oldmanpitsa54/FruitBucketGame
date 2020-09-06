using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Players;
using static DL.Validation;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            string input;
            var rand = new Random();
            var bucketWeight = rand.Next(40, 140);
            Console.WriteLine("Bucket weight: " + bucketWeight);
            do
            {
                Console.Write("1) Play \n2) Exit \n\nYour choice: ");
                input = Console.ReadLine();
                int cases;
                Int_Digits_check(input, out cases);
                switch (cases)
                {
                    case 1:
                        Console.WriteLine("Starting");
                        Console.WriteLine("Enter the amount of players");

                        input = Console.ReadLine();
                        Borders(2, 8, input, out size);
                        Player[] playersList = new Player[size];

                        for (int i = 0; i < size; i++)
                        {
                            Console.Write("Enter the type of player:\n 1) Simple player \n2) Note player \n3) Uber-player \n4) Cheater \n5) Uber-cheater \n6 Exit \n\nYour choice: ");
                            input = Console.ReadLine();
                            Int_Digits_check(input, out cases);
                            switch (cases)
                            {
                                case 1:
                                    Console.WriteLine("Simple player. Give him a name.");
                                    playersList[i] = new SimplePlayer(Console.ReadLine());
                                    break;

                                case 2:
                                    Console.WriteLine("Note player. Give him a name. ");
                                    playersList[i] = new NotePlayer(Console.ReadLine());
                                    break;
                                case 3:
                                    Console.WriteLine("Uber-player. Give him a name. ");
                                    playersList[i] = new UberPlayer(Console.ReadLine());
                                    break;
                                case 4:
                                    Console.WriteLine("Cheater. Give him a name. ");
                                    playersList[i] = new Cheater(Console.ReadLine());
                                    break;
                                case 5:
                                    Console.WriteLine("Uber-cheater. Give him a name. ");
                                    playersList[i] = new UberCheater(Console.ReadLine());
                                    break;
                                case 6:
                                    Console.WriteLine("Exit");
                                    return;
                                default:
                                    Console.WriteLine("Error. Choose the menu item again.");
                                    break;
                            }
                        }
                        for(int i = 0; i < 100; i++)
                        {
                            foreach( Player s in playersList)
                            {
                                s.Guess(bucketWeight);
                            }
                        }
                        int nearestValue = playersList[size - 1].niceTry;

                        foreach (Player s in playersList)
                        {
                            if(Math.Abs(nearestValue - bucketWeight) > Math.Abs(s.niceTry - bucketWeight))
                            {
                                nearestValue =  s.niceTry;
                            }
                        }
                        for(int i = 0; i < size; i++)
                        {
                            if (playersList[i].niceTry == nearestValue)
                            {
                                Console.WriteLine($"{playersList[i].Name} has won the game!");
                            }
                        }


                        break;
                   
                    case 2:
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Error. Choose the menu item again.");
                        break;
                }
            } while (true);
        }
    }
}
