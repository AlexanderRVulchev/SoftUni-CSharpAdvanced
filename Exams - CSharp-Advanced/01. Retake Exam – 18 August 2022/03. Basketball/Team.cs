using System;
using System.Collections.Generic;
using System.Linq;

namespace Basketball
{
    public class Team
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public int OpenPositions { get; set; }
        public char Group { get; set; }
        public int Count { get { return this.Players.Count; } }

        public Team(string name, int openPositions, char group)
        {
            this.Name = name;
            this.OpenPositions = openPositions;
            this.Group = group;
            this.Players = new List<Player>();
        }

        public string AddPlayer(Player player)
        {
            if (player.Name == null || player.Name == string.Empty ||
                player.Position == null || player.Position == string.Empty)
                return "Invalid player's information.";
            if (this.OpenPositions == 0)
                return "There are no more open positions.";
            if (player.Rating < 80)
                return "Invalid player's rating.";

            this.Players.Add(player);
            this.OpenPositions--;
            return $"Successfully added {player.Name} to the team. Remaining open positions: {this.OpenPositions}.";
        }

        public bool RemovePlayer(string name)
        {
            if (this.Players.Any(p => p.Name == name))
            {
                this.OpenPositions++;
                this.Players.Remove(this.Players.First(p => p.Name == name));
                return true;
            }
            else
                return false;
        }

        public int RemovePlayerByPosition(string position)
        {
            int removedPlayers = this.Players.RemoveAll(p => p.Position == position);
            this.OpenPositions += removedPlayers;
            return removedPlayers;
        }

        public Player RetirePlayer(string name)
        {
            if (this.Players.Any(p => p.Name == name))
            {
                Player retiredPlayer = this.Players.Find(p => p.Name == name);
                retiredPlayer.Retired = true;
                return retiredPlayer;
            }
            return null;
        }

        public List<Player> AwardPlayers(int games)
        {
            return this.Players.Where(p => p.Games >= games).ToList();
        }

        public string Report()
            => $"Active players competing for Team {this.Name} from Group {this.Group}:" + Environment.NewLine +               
               string.Join(Environment.NewLine, this.Players.Where(p => !p.Retired));
    }
}