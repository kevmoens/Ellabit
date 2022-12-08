namespace Ellabit.Challenges
{
    public class Challenge368Romannumerals : IChallenge
    {
        public string? Header { get; set; } = "Roman numerals";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

 using System;

 public class Challenge
 {
     public  int ParseRomanNumeral(string num)
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
        int sumResult;
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
        int sumResult;
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
        int sumResult;
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
        public string? Description { get; set; } = @"Create content  a  function  that  takes  in  a  roman  numeral  as  a  string  and  converts  it  to  an  integer,  returning  the  result.  the  function  should  work  for  all  roman  numerals  representing  positive  integers  less  than  4000.

the  following  table  shows  how  digits  will  be  represented  in  roman  numeral  notation:

place  value  |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9
---  |  ---  |  ---  |  --""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
