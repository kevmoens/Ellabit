namespace Ellabit.Challenges
{
    public class Challenge385Pokerhandranking : IChallenge
    {
        public string? Header { get; set; } = "Poker hand ranking";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Linq;

public class Challenge
{
	public  string PokerHandRanking(string[] hand)
	{
		return string.Empty;
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
        string sumResult;
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
        string sumResult;
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
        public string? Description { get; set; } = @"In content  this  challenge,  you  have  to  establish  which  kind  of  poker  combination  is  present  in  a  deck  of  five  cards.  every  card  is  a  string  containing  the  card  value  (with  the  upper-case  initial  for  face-cards)  and  the  lower-case  initial  for  suits,  as  in  the  examples  below:

"" ah"" ➞ ace of hearts ""ks"" king spades ""3d"" three diamonds ""qc"" queen clubs ""10c""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
