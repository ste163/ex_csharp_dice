using System;
using System.Collections.Generic;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> taunts = new List<String>();

        public override int Roll()
        {
            string taunt1 = $"{Name} says: Loser! ";
            string taunt2 = $"{Name} says: I'm the best! ";
            string taunt3 = $"{Name} says: You're the worst! ";
            string taunt4 = $"{Name} says: Yo mamma! ";
            string taunt5 = $"{Name} says: You smell! ";

            taunts.Add(taunt1);
            taunts.Add(taunt2);
            taunts.Add(taunt3);
            taunts.Add(taunt4);
            taunts.Add(taunt5);

            Random r = new Random();
            int tauntInt = r.Next(0, taunts.Count);
            string randomTaunt = taunts[tauntInt];
            
            Console.WriteLine(randomTaunt);
            return base.Roll();
        }
    }
}