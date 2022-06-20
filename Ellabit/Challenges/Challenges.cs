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
            challenges.Add(6, new Challenge006Areaofatriangle());
            challenges.Add(7, new Challenge007Returntheremainderfromtwonumbers());
            challenges.Add(8, new Challenge008Isthenumberlessthanorequaltozero());
            challenges.Add(9, new Challenge009Lessthan100());
            challenges.Add(10, new Challenge010Arethenumbersequal());
            challenges.Add(11, new Challenge011Returnsomethingtome());
            challenges.Add(12, new Challenge012Fliptheboolean());
            challenges.Add(13, new Challenge013Converthoursintoseconds());
            challenges.Add(14, new Challenge014Sumofpolygonangles());
            challenges.Add(15, new Challenge015Arethenumbersequal());
            return challenges;
        }
    }
}
