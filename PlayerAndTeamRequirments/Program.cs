using BusinessLogicLayerClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAndTeamRequirments
{
    public class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam oneDayTeam = new OneDayTeam();
            while (true)
            {
                Console.WriteLine("Enter 1: Add Player, 2: Remove Player by Id, 3: Get Player By Id, 4: Get Player By Name, 5: Get All Players: ");
                //Console.WriteLine("1: To Add Player");
                //Console.WriteLine("2: Remove Player by Id");
                //Console.WriteLine("3: Get Player By Id");
                //Console.WriteLine("4: Get Player By Name");
                //Console.WriteLine("5: Get All Players");
                //Console.WriteLine("6: Exit");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            // Add Player
                            Player newPlayer = new Player();
                            Console.Write("Enter Player Id: ");
                            newPlayer.PlayerId = int.Parse(Console.ReadLine());
                            Console.Write("Enter Player Name: ");
                            newPlayer.PlayerName = Console.ReadLine();
                            Console.Write("Enter Player Age: ");
                            newPlayer.PlayerAge = int.Parse(Console.ReadLine());
                            oneDayTeam.Add(newPlayer);
                            break;

                        case 2:
                            // Remove Player by Id
                            Console.Write("Enter Player Id to remove: ");
                            int playerIdToRemove = int.Parse(Console.ReadLine());
                            oneDayTeam.Remove(playerIdToRemove);
                            break;

                        case 3:
                            // Get Player By Id
                            Console.Write("Enter Player Id : ");
                            int playerIdToRetrieve = int.Parse(Console.ReadLine());
                            Player playerById = oneDayTeam.GetPlayerById(playerIdToRetrieve);
                            if (playerById != null)
                            {
                                Console.WriteLine($"{playerById.PlayerId}: {playerById.PlayerName}, {playerById.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;

                        case 4:
                            // Get Player By Name
                            Console.Write("Enter Player Name: ");
                            string playerNameToRetrieve = Console.ReadLine();
                            Player playerByName = oneDayTeam.GetPlayerByName(playerNameToRetrieve);
                            if (playerByName != null)
                            {
                                Console.WriteLine($"{playerByName.PlayerId}: {playerByName.PlayerName}, {playerByName.PlayerAge}");
                            }
                            else
                            {
                                Console.WriteLine("Player not found.");
                            }
                            break;
                        case 5:
                            // Get All Players
                            List<Player> allPlayers = oneDayTeam.GetAllPlayers();
                            Console.WriteLine("All Players in the One-Day Team:");
                            foreach (var player in allPlayers)
                            {
                                Console.WriteLine($"{player.PlayerId}: {player.PlayerName}, {player.PlayerAge}");
                            }
                            break;

                        case 6:
                            // Exit the program
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                }

                Console.Write("Do you want to continue (Yes/No): ");
                string continueResponse = Console.ReadLine().Trim();
                if (continueResponse.ToLower() != "yes")
                {
                    break;
                }

                Console.WriteLine();
            }
        }
    }
}
