namespace Ellabit.Challenges
{
    public class Challenge062Themodulusoperatorfunction : IChallenge
    {
        public string? Header { get; set; } = "The modulus operator function";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int Mod(int a, int b)
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
            sumResult = tmp.Mod(5, 2) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  1,  $""returned: {sumResult}  expected:  1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Mod(218, 5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  3,   $""returned: {sumResult}  expected:  3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.Mod(6, 3) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  0,   $""returned: {sumResult}  expected:  0"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that will work as the modulus operator % without using the modulus operator. the modulus operator is a way to determine the remainder of a division operation. instead of returning the result of the division, the modulo operation returns the whole number remainder.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
mod(5, 2) ➞ 1

mod(218, 5) ➞ 3

mod(6, 3) ➞ 0
            </p>
        </code>

notes
don't use the % operator to return the results";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
    }
}
