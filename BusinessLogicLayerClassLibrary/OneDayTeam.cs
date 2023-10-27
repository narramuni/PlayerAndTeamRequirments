using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerClassLibrary
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < oneDayTeam.Capacity)
            {
                oneDayTeam.Add(player);
                Console.WriteLine($"{player.PlayerName} added to the One-Day Team.");
            }
            else
            {
                Console.WriteLine("One-Day Team is already full. Cannot add more players.");
            }
        }
        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine($"{playerToRemove.PlayerName} removed from the One-Day Team.");
            }
            else
            {
                Console.WriteLine("Player not found in the One-Day Team.");
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return oneDayTeam.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return oneDayTeam.Find(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
