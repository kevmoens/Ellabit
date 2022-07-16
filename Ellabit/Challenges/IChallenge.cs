namespace Ellabit.Challenges
{
    public interface IChallenge
    {
        string? Header { get; set; }
        string? Description { get; set; }
        string? Code { get; set; } 
        string? TestCode { get; set; } 
        List<string> Tests { get; set; }
        Dictionary<string, string> Tags { get; set; }
    }
}
