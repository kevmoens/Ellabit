namespace Ellabit.Challenges
{
    public class Challenge097Findtheindex : IChallenge
    {
        public string? Header { get; set; } = "Find the index";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  int FindIndex(string[] arr, string str) 
    {
		
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindIndex(new string[] {""hi"", ""ellabit"", ""fgh"", ""abc""}, ""fgh"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 2,  $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindIndex(new string[] {""Red"", ""blue"", ""Blue"", ""Green""}, ""blue"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 1,   $""returned: {sumResult}  expected: 1"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindIndex(new string[] {""a"", ""g"", ""y"", ""d""}, ""d"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 3,   $""returned: {sumResult}  expected: 3"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindIndex(new string[] { ""Pineapple"", ""Orange"", ""Grape"", ""Apple"" }, ""Pineapple"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 0,   $""returned: {sumResult}  expected: 0"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes an array and a string as arguments and returns the index of the string.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
FindIndex(new string[] {""hi"", ""ellabit"", ""fgh"", ""abc""}, ""fgh"") ➞ 2

FindIndex(new string[] {""Red"", ""blue"", ""Blue"", ""Green""}, ""blue"") ➞ 1

FindIndex(new string[] {""a"", ""g"", ""y"", ""d""}, ""d"") ➞ 3

FindIndex(new string[] { ""Pineapple"", ""Orange"", ""Grape"", ""Apple"" }, ""Pineapple"") ➞ 0
            </p>
        </code>
Notes
Don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
    }
}
