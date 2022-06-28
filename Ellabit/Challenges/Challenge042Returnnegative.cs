namespace Ellabit.Challenges
{
    public class Challenge042Returnnegative : IChallenge
    {
        public string? Header { get; set; } = "Return negative";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int ReturnNegative(int n)
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
            sumResult = tmp.ReturnNegative(4) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  -4,  $""returned: {sumResult}  expected:  -4"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.ReturnNegative(15) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  -15,   $""returned: {sumResult}  expected:  -15"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.ReturnNegative(-4) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  -4,   $""returned: {sumResult}  expected:  -4"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.ReturnNegative(0) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  0,   $""returned: {sumResult}  expected:  0"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that takes a number as an argument and returns negative of that number. return negative numbers without any change.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
returnnegative(4) ➞ -4

returnnegative(15) ➞ -15

returnnegative(-4) ➞ -4

returnnegative(0) ➞ 0
            </p>
        </code>
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
    }
}
