namespace Ellabit.Challenges
{
    public class Challenge277TripleSomuchtrouble : IChallenge
    {
        public string? Header { get; set; } = "Triple + So much trouble";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
    public  bool Trouble(long num1, long num2)
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
            sumResult = tmp.trouble(451999277,  41177722899)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   true

,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.trouble(1222345,  12345)  ;
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
            sumResult = tmp.trouble(666789,  12345667)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   true

,   $""returned: {sumResult}  expected: true"");
    }
}
";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  two  integers  and  returns  true  if  a  number  repeats  three  times  in  a  row  at  any  place  in  num1  and  that  same  number  repeats  two  times  in  a  row  in  num2.

examples
trouble(451999277,  41177722899)  ➞  true

trouble(1222345,  12345)  ➞  false

trouble(666789,  12345667)  ➞  true

trouble(33789,  12345337)  ➞  false

notes
you  can  expect  every  test  c""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
