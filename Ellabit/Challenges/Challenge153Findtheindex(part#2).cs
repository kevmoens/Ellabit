namespace Ellabit.Challenges
{
    public class Challenge153Findtheindexpart2 : IChallenge
    {
        public string? Header { get; set; } = "Find the index (part #2)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  int Search(int[] arr, int item)
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
        int sumResult;
        try 
        {
            sumResult = tmp.Search(new int[] {1,  2,  3,  4},  3)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   2,  $""returned: {sumResult}  expected: 2"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.Search(new int[] {2,  4,  6,  8,  10},  8)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   3,   $""returned: {sumResult}  expected: 3"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.Search(new int[]{1,  3,  5,  7,  9},  11)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   -1,   $""returned: {sumResult}  expected: -1"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  searches  for  the  index  of  a  given  item  in  an  array  using  recursion.  if  the  item  is  present,  it  should  return  the  index,  otherwise,  it  should  return  -1.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
search({1,  2,  3,  4},  3)  ➞  2

search({2,  4,  6,  8,  10},  8)  ➞  3

search({1,  3,  5,  7,  9},  11)  ➞  -1
            </p>
        </code>

notes
use  recursion.
avoid  using  linq.
if  the  item  is  not  present,  return  -1.
the""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
