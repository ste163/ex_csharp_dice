using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _allTaunts = new List<String>()
        {
            "Loser! ",
            "I'm the best! ",
            "You're the worst! ",
            "Yo mamma! ",
            "You smell! ",
        };

        public override int Roll()
        {
            Random r = new Random();
            int tauntIndex = r.Next(0, _allTaunts.Count);
            string randomTaunt = _allTaunts[tauntIndex];
            
            Console.WriteLine($"{Name} says: {randomTaunt}");
            return base.Roll();
        }
    }
}