namespace Ellabit.Challenges
{
    public class Challenge081Findthetotalnumberofdigitsthegivennumberhas : IChallenge
    {
        public string? Header { get; set; } = "Find the total number of digits the given number has";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  int FindDigitAmount(long num)
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
            sumResult = tmp.FindDigitAmount(123) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  3,  $""returned: {sumResult}  expected:  3"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindDigitAmount(56) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  2,   $""returned: {sumResult}  expected:  2"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindDigitAmount(7154) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  4,   $""returned: {sumResult}  expected:  4"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindDigitAmount(61217311514);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  11,   $""returned: {sumResult}  expected:  11"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.FindDigitAmount(0) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  1,   $""returned: {sumResult}  expected:  1"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that takes a number as an argument and returns the amount of digits it has.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
finddigitamount(123) ➞ 3

finddigitamount(56) ➞ 2

finddigitamount(7154) ➞ 4

finddigitamount(61217311514) ➞ 11

finddigitamount(0) ➞ 1
            </p>
        </code>

";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
