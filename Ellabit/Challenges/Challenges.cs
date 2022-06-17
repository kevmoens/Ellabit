namespace Ellabit.Challenges
{
    public class Challenges : Dictionary<int, IChallenge>
    {
        public static Challenges GetChallenges()
        {
            var challenges = new Challenges();
            challenges.Add(1, new Challenge001SumTwoNumbers());
            return challenges;
        }
    }
}
