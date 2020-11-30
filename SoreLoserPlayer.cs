using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // Wrap this .Play() in a TRY block in Program, and CATCH the error after
    public class SoreLoserPlayer : Player
    {
        public override void Play(Player other)
        {
            int myRoll = Roll();
            int otherRoll = other.Roll();

            if (myRoll < otherRoll)
            {
                throw new RageQuitException();
            }

            checkRoll(myRoll, otherRoll, other);
        }
    }
}