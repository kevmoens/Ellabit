namespace Ellabit.Challenges
{
    public class Challenge060ChartoASCII : IChallenge
    {
        public string? Header { get; set; } = "Char-to-ASCII";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  int CharToASCII(char ch) 
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
            sumResult = tmp.CharToASCII('S') ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  83,  $""returned: {sumResult}  expected:  83"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CharToASCII('m') ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  109,   $""returned: {sumResult}  expected:  109"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CharToASCII('1') ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  49,   $""returned: {sumResult}  expected:  49"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.CharToASCII('a') ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  97,   $""returned: {sumResult}  expected:  97"");
    }
}
";
        public string? Description { get; set; } = @"Create a function that returns the ascii value of the passed in character.

examples
chartoascii('S') ➞ 83

chartoascii('m') ➞ 109

chartoascii('1') ➞ 49

chartoascii('a') ➞ 97

notes
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
    }
}
