namespace Ellabit.Challenges
{
    public class Challenge392Alonelyclassforlonelynumbers : IChallenge
    {
        public string? Header { get; set; } = "A lonely class for lonely numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Collections.Generic;
using System.Linq;

public class Challenge
{
		public  string LoneliestNumber(int lo, int hi)
		{
				// write you code here
			
				return $""number: {ln}, distance: {d}, closest: {c}"";
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
        public string? Description { get; set; } = @"In content  this  challenge,  write  a  funcion  loneliestnumber  to  find  the  last  lonely  number  inside  a  sequence.  a  number  is  lonely  if  the  distance  from  its  closest  prime  sets  a  new  record  of  the from sequence.

sequence  0  to  3

//  any  number  lower  than  3  doesn't  have  a  prime  preceding  it...
//  ...so  that  you'll  consider  only  its  next  closest  prime.

0  has  distance  2  fr""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
