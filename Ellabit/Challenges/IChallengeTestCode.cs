using System;
namespace Ellabit.Challenges
{
    public interface IChallengeTestCode
    {
        string? TestCode { get; set; }
        List<string> Tests { get; set; }
    }
}

