namespace Ellabit.Challenges
{
    public class Challenge386Maxieandminnie : IChallenge
    {
        public string? Header { get; set; } = "Maxie and minnie";
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

public class Challenge 
{
	  		public  long[] MaxMin(long n)
        {						
            return new long[] { n, n };					
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.maxmin(12340) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  new long[] { 42310, 10342 },  $""returned: {sumResult}  expected:  new long[] { 42310, 10342 }"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.maxmin(98761) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  new long[] { 98761, 18769 },   $""returned: {sumResult}  expected:  new long[] { 98761, 18769 }"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.maxmin(9000) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  new long[] { 9000, 9000 },   $""returned: {sumResult}  expected:  new long[] { 9000, 9000 }"");
    }
}
";
        public string? Description { get; set; } = @"Maxie is the largest number that can be obtained by swapping two digits, minnie is the smallest. write a function that takes a number and returns an array of length 2, maxie and minnie. leading zeros are not permitted.

examples
maxmin(12340) ➞ new long[] { 42310, 10342 }

maxmin(98761) ➞ new long[] { 98761, 18769 }

maxmin(9000) ➞ new long[] { 9000, 9000 }
s";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
