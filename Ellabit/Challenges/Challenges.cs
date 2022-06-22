namespace Ellabit.Challenges
{
    public class Challenges : List<IChallenge>
    {
        public static Challenges GetChallenges()
        {
            var challenges = new Challenges();
            challenges.Add(new Challenge001SumTwoNumbers());
            challenges.Add(new Challenge002ConvertMinutesToSeconds());
            challenges.Add(new Challenge003ReturnNextNumber());
            challenges.Add(new Challenge004PowerCalculator());
            challenges.Add(new Challenge005ConvertAgeToDays());
            challenges.Add(new Challenge006Areaofatriangle());
            challenges.Add(new Challenge007Returntheremainderfromtwonumbers());
            challenges.Add(new Challenge008Isthenumberlessthanorequaltozero());
            challenges.Add(new Challenge009Lessthan100());
            challenges.Add(new Challenge010Arethenumbersequal());
            challenges.Add(new Challenge011Returnsomethingtome());
            challenges.Add(new Challenge012Fliptheboolean());
            challenges.Add(new Challenge013Converthoursintoseconds());
            challenges.Add(new Challenge014Sumofpolygonangles());
            challenges.Add(new Challenge015Arethenumbersequal());
            challenges.Add(new Challenge016Basicvariableassignment());
            challenges.Add(new Challenge017Usingthe());
            challenges.Add(new ChallengeColor001());
            return challenges;
        }
    }
}
