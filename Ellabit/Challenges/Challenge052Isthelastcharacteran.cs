namespace Ellabit.Challenges
{
    public class Challenge052Isthelastcharacteran : IChallenge
    {
        public string? Header { get; set; } = @"Is the last character an ""n""";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
	public  bool isLastCharacterN(string word) 
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
            sumResult = tmp.isLastCharacterN(""Aiden"");
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
            sumResult = tmp.isLastCharacterN(""Piet"");
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
            sumResult = tmp.isLastCharacterN(""Bert"");
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
            sumResult = tmp.isLastCharacterN(""Dean"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a string (a random name). If the last character of the name is an ""n"", return true, otherwise return false.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
isLastCharacterN(""Aiden"") ➞ true

isLastCharacterN(""Piet"") ➞ false

isLastCharacterN(""Bert"") ➞ false

isLastCharacterN(""Dean"") ➞ true
            </p>
        </code>

Notes
The function must return a boolean value(i.e. true or false).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
