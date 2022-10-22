namespace Ellabit.Challenges
{
    public class Challenge166Arrayofmultiples : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Array of multiples";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {


	public class Challenge {
		public  int[] ArrayOfMultiples(int num, int length) {
			
		}
	}

}";
        public string? TestCode { get; set; } = @"
using System;
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
            sumResult = tmp.ArrayOfMultiples(7,  5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {7,  14,  21,  28,  35}),  $""returned: [{string.Join("", "", sumResult)}]  expected: [7,  14,  21,  28,  35]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.ArrayOfMultiples(12,  10)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {12,  24,  36,  48,  60,  72,  84,  96,  108,  120}),   $""returned: [{string.Join("", "", sumResult)}]  expected: [12,  24,  36,  48,  60,  72,  84,  96,  108,  120]"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int[] sumResult;
        try 
        {
            sumResult = tmp.ArrayOfMultiples(17, 6);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult.SequenceEqual(new int[] {17,34,51,68,85,102}),   $""returned: [{string.Join("", "", sumResult)}]  expected: <rep.test.result3Val>"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  two  numbers  as  arguments  (num,  length)  and  returns  an  array  of  multiples  of  num  until  the  array  length  reaches  length.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
ArrayOfMultiples(7,  5)  ➞  [7,  14,  21,  28,  35]

ArrayOfMultiples(12,  10)  ➞  [12,  24,  36,  48,  60,  72,  84,  96,  108,  120]

ArrayOfMultiples(17,  6)  ➞  [17,  34,  51,  68,  85,  102]
            </p>
        </code>

notes
notice  that  num  is  also  incl""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}