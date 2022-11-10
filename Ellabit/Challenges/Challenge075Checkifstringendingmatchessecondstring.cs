namespace Ellabit.Challenges
{
    public class Challenge075Checkifstringendingmatchessecondstring : IChallenge, IChallengeBlockly, IChallengeTestCode
    {
        public string? Header { get; set; } = "Check if string ending matches second string";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  bool CheckEnding(string str1, string str2)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEnding(""abc"", ""bc"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEnding(""abc"", ""d"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEnding(""samurai"", ""zi"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEnding(""feminine"", ""nine"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.CheckEnding(""convention"", ""tio"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes two strings and returns true if the first string ends with the second string; otherwise return false.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
CheckEnding(""abc"", ""bc"") ➞ true

CheckEnding(""abc"", ""d"") ➞ false

CheckEnding(""samurai"", ""zi"") ➞ false

CheckEnding(""feminine"", ""nine"") ➞ true

CheckEnding(""convention"", ""tio"") ➞ false
            </p>
        </code>
Notes
All test cases are valid one word strings.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase){ { "String", "Compare" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
    }
} 
