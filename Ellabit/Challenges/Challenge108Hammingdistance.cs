namespace Ellabit.Challenges
{
    public class Challenge108Hammingdistance : IChallenge
    {
        public string? Header { get; set; } = "Hamming distance";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  int HammingDistance(string str1, string str2)
    {
    }
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HammingDistance(""abcde"", ""bcdef"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 5,  $""returned: {sumResult}  expected: 5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HammingDistance(""abcde"", ""abcde"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 0,   $""returned: {sumResult}  expected: 0"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HammingDistance(""strong"", ""strung"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 1,   $""returned: {sumResult}  expected: 1"");
    }
}
}";
        public string? Description { get; set; } = @"Hamming distance is the number of characters that differ between two strings.

To illustrate:

String1: ""abcbba""
String2: ""abcbda""

Hamming Distance: 1 - ""b"" vs. ""d"" is the only difference.
Create a function that computes the hamming distance between two strings.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
HammingDistance(""abcde"", ""bcdef"") ➞ 5

HammingDistance(""abcde"", ""abcde"") ➞ 0

HammingDistance(""strong"", ""strung"") ➞ 1
            </p>
        </code>

Notes
Both strings will have the same length.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
