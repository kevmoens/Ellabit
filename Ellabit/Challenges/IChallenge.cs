namespace Ellabit.Challenges
{
    public interface IChallenge
    {
        string? Description { get; set; }
        string? Code { get; set; } 
        string? TestCode { get; set; } 
        List<ITest> Tests { get; set; }
    }
}
