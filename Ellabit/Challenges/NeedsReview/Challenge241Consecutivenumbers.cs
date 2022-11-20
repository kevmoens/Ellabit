namespace Ellabit.Challenges
{
    public class Challenge241Consecutivenumbers : IChallenge
    {
        public string? Header { get; set; } = "Consecutive numbers";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  bool Cons(int[] arr)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.cons([5,  1,  4,  3,  2])  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true
//  can  be  re-arranged  to  form  [1,  2,  3,  4,  5]

,  $""returned: {sumResult}  expected: true
//  can  be  re-arranged  to  form  [1,  2,  3,  4,  5]"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.cons([5,  1,  4,  3,  2,  8])  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   false

,   $""returned: {sumResult}  expected: false"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.cons([5,  6,  7,  8,  9,  9])  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   false
//  9  appears  twice

,   $""returned: {sumResult}  expected: false
//  9  appears  twice"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  determines  whether  elements  in  an  array  can  be  re-arranged  to  form  a  consecutive  list  of  numbers  where  each  number  appears  exactly  once.

examples
cons([5,  1,  4,  3,  2])  ➞  true
//  can  be  re-arranged  to  form  [1,  2,  3,  4,  5]

cons([5,  1,  4,  3,  2,  8])  ➞  false

cons([5,  6,  7,  8,  9,  9])  ➞  false
//  9  appears  twice

notes
n/a""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
