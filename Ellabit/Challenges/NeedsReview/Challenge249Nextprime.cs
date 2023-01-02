namespace Ellabit.Challenges
{
    public class Challenge249Nextprime : IChallenge
    {
        public string? Header { get; set; } = "Next prime";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int NextPrime(int num) 
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
            sumResult = tmp.nextprime(12)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   13

,  $""returned: {sumResult}  expected: 13"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.nextprime(24)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   29

,   $""returned: {sumResult}  expected: 29"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.nextprime(11)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   11
//  11  is  a  prime,  so  we  return  the  number  itself.

,   $""returned: {sumResult}  expected: 11
//  11  is  a  prime,  so  we  return  the  number  itself."");
    }
}
";
        public string? Description { get; set; } = @"Given content  an  integer,  create  a  function  that  returns  the  next  prime.  if  the  number  is  prime,  return  the  number  itself.

examples
nextprime(12)  ➞  13

nextprime(24)  ➞  29

nextprime(11)  ➞  11
//  11  is  a  prime,  so  we  return  the  number  itself.

notes
n/a""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
