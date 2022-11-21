namespace Ellabit.Challenges
{
    public class Challenge258Clearbrackets : IChallenge
    {
        public string? Header { get; set; } = "Clear brackets";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool Brackets(string str)
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
            sumResult = tmp.brackets("" (a*(b-c)..... )"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true ,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.brackets("")(a-b-45 7*(a-34))"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false ,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.brackets(""sin(90...)+.............cos1)"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  notes the string may not contain ,   $""returned: {sumResult}  expected: notes the string may not contain"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  brackets()  that  takes  a  string  and  checks  that  the  brackets  in  the  math  expression  are  correct.  the  function  should  return  true  or  false.

examples
brackets("" (a*(b-c)..... )"") ➞ true brackets("")(a-b-45 7*(a-34))"") false brackets(""sin(90...)+.............cos1)"") notes the string may not contain brackets, then return true. m""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
