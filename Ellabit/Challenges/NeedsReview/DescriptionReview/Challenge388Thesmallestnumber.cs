namespace Ellabit.Challenges
{
    public class Challenge388Thesmallestnumber : IChallenge
    {
        public string? Header { get; set; } = "The smallest number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

// Its possible to solve using some or all of these librarys.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public class Challenge 
{
			public  string Smallest(int n)
			{
					return n.ToString();
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
            sumResult = tmp.smallest(1)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   "" 1"" ,  $""returned: {sumResult}  expected:  1"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.smallest(5) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""60"" ,   $""returned: {sumResult}  expected: 60"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.smallest(10);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  ""2520"" ,   $""returned: {sumResult}  expected: 2520"");
    }
}
";
        public string? Description { get; set; } = @"Given content  a  positive  integer  n,  implement  a  function  that  finds  the  smallest  number  that  is  evenly  divisible  by  the  integers  1  through  n  inclusive.  return  value  as  a  string.

examples
smallest(1)  ➞  "" 1"" smallest(5) ➞ ""60"" smallest(10) ""2520"" smallest(20) ""232792560"" notes you will need to cope with numbers larger than int64.maxvalue (see resources).""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
