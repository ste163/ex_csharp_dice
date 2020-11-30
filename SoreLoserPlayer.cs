using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player that throws an exception when they lose to the other player
    // Where might you catch this exception????
    public class SoreLoserPlayer : Player
    {
        public override void checkRoll(int myRoll, int otherRoll, Player other)
        {
            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            
            try
            {
                if (myRoll > otherRoll) Console.WriteLine($"{Name} Wins!");
                else if (myRoll < otherRoll)
                {
                    Console.WriteLine($"{other.Name} Wins!");
                    throw new System.ArgumentException("You can't win! I want to win!");
                }
                else Console.WriteLine("It's a tie");     
            }
            catch 
            {
                
            }
        }
    }
}