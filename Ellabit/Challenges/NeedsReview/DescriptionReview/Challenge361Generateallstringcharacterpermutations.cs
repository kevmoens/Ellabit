namespace Ellabit.Challenges
{
    public class Challenge361Generateallstringcharacterpermutations : IChallenge
    {
        public string? Header { get; set; } = "Generate all string character permutations";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

class Program
{
	public  string Permutations(string s)
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
        string sumResult;
        try 
        {
            sumResult = tmp.permutations("" ab"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""ab ba"" ,  $""returned: {sumResult}  expected: ab ba"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.permutations(""cd"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""cd dc"" ,   $""returned: {sumResult}  expected: cd dc"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.permutations(""ef"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""ef fe"" ,   $""returned: {sumResult}  expected: ef fe"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  to  generate  all  string  character  permutations.

examples
permutations("" ab"") ➞ ""ab ba"" permutations(""cd"") ""cd dc"" permutations(""ef"") ""ef fe"" permutations(""not"") ""not nto ont otn tno ton"" permutations(""ram"") ""amr arm mar mra ram rma"" permutations(""yaw"") ""awy ayw way wya yaw ywa"" notes sort your results in alphabetical order befo""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
