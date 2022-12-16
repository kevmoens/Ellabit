namespace Ellabit.Challenges
{
    public class Challenge305Longestabecedarianword : IChallenge
    {
        public string? Header { get; set; } = "Longest abecedarian word";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
	public  string LongestAbecedarian(string[] arr) {
		
	}
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"An abecedarian word is a word where all of its letters are arranged in alphabetical order. Examples of these words include:

Empty
Forty
Almost
Given an array of words, create a function which returns the longest abecedarian word. If no word in an array matches the criterea, return an empty string.

Examples
LongestAbecedarian(new string[] { ""ace"", ""spades"", ""hearts"", ""clubs"" }) ➞ ""ace""

LongestAbecedarian(new string[] { ""forty"", ""choppy"", ""ghost"" }) ➞ ""choppy""

LongestAbecedarian(new string[] { ""one"", ""two"", ""three"" }) ➞ """"
Notes
All words will be given in lowercase.
If two abecedarian words have the same length, return the word which appeared first in the array.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
