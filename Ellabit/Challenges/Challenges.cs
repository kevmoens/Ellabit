namespace Ellabit.Challenges
{
    public class Challenges : Dictionary<int, IChallenge>
    {
        public static Challenges GetChallenges()
        {
            var challenges = new Challenges();
            challenges.Add(1, new Challenge001SumTwoNumbers());
            challenges.Add(2, new Challenge002ConvertMinutesToSeconds());
            challenges.Add(3, new Challenge003ReturnNextNumber());
            challenges.Add(4, new Challenge004PowerCalculator());
            challenges.Add(5, new Challenge005ConvertAgeToDays());
            return challenges;
        }
    }
}
