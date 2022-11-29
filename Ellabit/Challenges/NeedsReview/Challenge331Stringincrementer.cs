namespace Ellabit.Challenges
{
    public class Challenge331Stringincrementer : IChallenge
    {
        public string? Header { get; set; } = "String incrementer";
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
	public  string IncrementString(string txt)
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
            sumResult = tmp.incrementstring("" foo"") ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  ""foo1"" ,  $""returned: {sumResult}  expected: foo1"");
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
        public string? Description { get; set; } = @"Write content  a  function  which  increments  a  string  to  create  a  new  string.

if  the  string  ends  with  a  number,  the  number  should  be  incremented  by  1.
if  the  string  doesn't  end  with  a  number,  1  should  be  added  to  the  new  string.
if  the  number  has  leading  zeros,  the  amount  of  digits  should  be  considered.

examples
incrementstring("" foo"") ➞ ""foo1"" incrementstring(""foobar0""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
