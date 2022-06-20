namespace Ellabit.Challenges
{
    public class Challenge012Fliptheboolean : IChallenge
    {
        public string? Header { get; set; } = "Flip the boolean";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool Reverse(bool boolean)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.Reverse(true) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,  $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.Reverse(false) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true,   $""returned: {sumResult}  expected:  true"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that reverses a boolean value.

examples
reverse(true) ➞ false

reverse(false) ➞ true

notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2" }.ToList();
    }
}
