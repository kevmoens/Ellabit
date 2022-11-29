namespace Ellabit.Challenges
{
    public class Challenge136Istheaverageofallelementsawholenumber : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Is the average of all elements a whole number?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  bool IsAvgWhole(int[] arr)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.IsAvgWhole(new int[] {1,  3})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsAvgWhole(new int[] {1,  2,  3,  4})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   false,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsAvgWhole(new int[] {1,  5,  6})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsAvgWhole(new int[] {1,  1,  1})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test5()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.IsAvgWhole(new int[] {9,  2,  2,  5})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   false,   $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  as  an  argument  and  returns  true  or  false  depending  on  whether  the  average  of  all  elements  in  the  array  is  a  whole  number  or  not.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
isavgwhole([1,  3])  ➞  true

isavgwhole([1,  2,  3,  4])  ➞  false

isavgwhole([1,  5,  6])  ➞  true

isavgwhole([1,  1,  1])  ➞  true

isavgwhole([9,  2,  2,  5])  ➞  false
            </p>
        </code>

notes
n/a""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Array", "Index"},{ "Comparison", "=="},{ "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
