namespace Ellabit.Challenges
{
    public class Challenge398Unravelallthepossibilities : IChallenge
    {
        public string? Header { get; set; } = "Unravel all the possibilities";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

// you may find some or all of these libraries useful
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Challenge
{
	public  string[] Unravel(string txt)
	{
		return new string[]{};
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
        string[] sumResult;
        try 
        {
            sumResult = tmp.unravel("" a[b|c]"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  { ""ab"", ""ac"" } ,  $""returned: {sumResult}  expected: { ab, ac }"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.unravel(""a[b|c]de[f|g]"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""abdef"", ""acdef"", ""abdeg"", ""acdeg"" ,   $""returned: {sumResult}  expected: abdef, acdef, abdeg, acdeg"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string[] sumResult;
        try 
        {
            sumResult = tmp.unravel(""a[b]c[d]"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""abcd"" ,   $""returned: {sumResult}  expected: abcd"");
    }
}
";
        public string? Description { get; set; } = @"Write content  a  function  that  takes  in  a  string  and  returns  all  possible  combinations.  return  the  final  result  in  alphabetical  order  as  a  string[].

examples
unravel("" a[b|c]"") ➞ { ""ab"", ""ac"" } unravel(""a[b|c]de[f|g]"") ""abdef"", ""acdef"", ""abdeg"", ""acdeg"" unravel(""a[b]c[d]"") ""abcd"" unravel(""a[b|c|d|e]f"") ""abf"", ""acf"", ""adf"", ""aef"" unravel(""apple [pe""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
