namespace Ellabit.Challenges
{
    public class Challenge082Missingthirdangle : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Missing third angle";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  string MissingAngle(int angle1, int angle2) 
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
        string sumResult;
        try 
        {
            sumResult = tmp.MissingAngle(27, 59);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""obtuse"",  $""returned: {sumResult}  expected: obtuse"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.MissingAngle(135, 11);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""acute"",   $""returned: {sumResult}  expected: acute"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.MissingAngle(45, 45);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""right"",   $""returned: {sumResult}  expected: right"");
    }
}
}";
        public string? Description { get; set; } = @"You are given 2 out of 3 angles in a triangle, in degrees.

write a function that classifies the missing angle as either  ""acute"", ""right"", or ""obtuse"" based on its degrees.

An acute angle is less than 90 degrees.
A right angle is exactly 90 degrees.
An obtuse angle is greater than 90 degrees(but less than 180 degrees).
For example: MissingAngle(11, 20) should return ""obtuse"", since the missing angle would be 149 degrees, which makes it obtuse.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
MissingAngle(27, 59) ➞ ""obtuse""

MissingAngle(135, 11) ➞ ""acute""

MissingAngle(45, 45) ➞ ""right""
            </p>
        </code>

Notes
The sum of angles of any triangle is always 180 degrees.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Logic", "If"}, { "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
}
