using System;

namespace ShootingDice
{
    // A player that prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            int roll = 0;

            while(true)
            {
                string rollMsg = $"Enter number between 1-{DiceSize} that you rolled: ";
                Console.Write(rollMsg);
                string entered = Console.ReadLine();
                try 
                {
                    roll = Int32.Parse(entered);
                }
                // Empty catch because while loop resets our message
                // This allows the program to continue if user enters a non-int
                catch (FormatException) { }

                if (roll >= 1 && roll <= DiceSize) break;
            }

            return roll;
        }
    }
}