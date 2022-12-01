namespace Ellabit.Challenges
{
    public class Challenge350Palindromesequence : IChallenge
    {
        public string? Header { get; set; } = "Palindrome sequence";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge 
{
  	public  int[] PalSeq(int n) 
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
        int[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"A content  palindrome  is  a  number  that  is  the  same  when  reversed,  2770772  for  example.  a  palindrome  can  often  be  formed  by  adding  a  number  to  it's  reverse:  641  + 787 146  (a  palindrome).  using  78  as  the  seed,  it  takes  4  steps  to  produce  a  palindrome:

78  + 165
165 87  + 726
726 561  + 1353
1353 627  + 4884 3531  (a  palindrome)

about  97%  of  integers  less  than  10,0""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
