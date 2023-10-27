using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayerClassLibrary
{
    public class Team : ITeam
    {
        private List<Player> players = new List<Player>();

        public void Add(Player player)
        {
            players.Add(player);
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = players.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
            }
        }
        public Player GetPlayerById(int playerId)
        {
            return players.Find(p => p.PlayerId == playerId);
        }

        public Player GetPlayerByName(string playerName)
        {
            return players.Find(p => p.PlayerName == playerName);
        }

        public List<Player> GetAllPlayers()
        {
            return players;
        }


    }
}
