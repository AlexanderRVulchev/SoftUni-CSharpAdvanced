using System;
using System.Collections.Generic;


namespace Guild
{
    public class Guild
    {
        private readonly List<Player> roster;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return this.roster.Count; } }

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (this.roster.Count < this.Capacity)
                this.roster.Add(player);
        }

        public bool RemovePlayer(string name)
            => this.roster.Remove(this.roster.Find(p => p.Name == name));

        public void PromotePlayer(string name)
        {
            Player player = this.roster.Find(p => p.Name == name);
            if (player != null)
                player.Rank = "Member";
        }

        public void DemotePlayer(string name)
        {
            Player player = this.roster.Find(p => p.Name == name);
            if (player != null)
                player.Rank = "Trial";
        }

        public Player[] KickPlayersByClass(string @class)
        {
            Player[] players = this.roster.FindAll(p => p.Class == @class).ToArray();
            this.roster.RemoveAll(p => p.Class == @class);
            return players;
        }

        public string Report()
            => $"Players in the guild: {this.Name}" +
               Environment.NewLine +
               string.Join(Environment.NewLine, this.roster);
    }
}
