namespace Ellabit.Challenges
{
    public class Challenge140Hashesandpluses : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Hashes and pluses";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  int[] HashPlusCount(string s)
	{
		
	}
}

}";
        public string? TestCode { get; set; } = @"
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.HashPlusCount(""###+"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual( new int[] {3, 1}.ToList()) ,  $""returned: {sumResult}  expected: [3, 1]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.HashPlusCount(""##+++#"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual( new int[] {3, 3}.ToList()) ,  $""returned: {sumResult}  expected: [3, 3]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.HashPlusCount(""#+++#+#++#"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual( new int[] {4, 6}.ToList()) ,  $""returned: {sumResult}  expected: [4, 6]"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.HashPlusCount("""");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual( new int[] {0, 0}.ToList()) ,  $""returned: {sumResult}  expected: [0, 0]"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  returns  the  number  of  hashes  and  pluses  in  a  string.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
hashpluscount(""###+"") ➞ [3, 1] 
hashpluscount(""##+++#"") ➞ [3, 3]
hashpluscount(""#+++#+#++#"") ➞ [4, 6] 
hashpluscount("""") ➞ [0, 0] 
            </p>
        </code>
notes return for an empty string. in the order of [hashes, pluses].""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Loop", "For" }, { "Level", "1"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
