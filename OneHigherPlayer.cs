namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always roles one higher than the other player
    public class OneHigherPlayer : Player
    {

        public int Roll(int previousRoll)
        {
            return ++previousRoll;
        }
    }
}