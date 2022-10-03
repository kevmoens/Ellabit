namespace Ellabit.Challenges
{
    public class Challenge184Acircleandtwosquares : IChallenge
    {
        public string? Header { get; set; } = "A circle and two squares";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge 
    {
	    public  int square_areas_difference(int radius) 
        {
		    
	    }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{
public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.square_areas_difference(5)  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   50,  $""returned: {sumResult}  expected: 50"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.square_areas_difference(6);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 72,   $""returned: {sumResult}  expected: 72"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.square_areas_difference(7);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 98,   $""returned: {sumResult}  expected: 98"");
    }
}
}
";
        public string? Description { get; set; } = @"Imagine content  a  circle  and  two  squares:  a  smaller  and  a  bigger  one.  for  the  smaller  one,  the  circle  is  a  circumcircle  and  for  the  bigger  one,  an  incircle.

scale

create  a  function,  that  takes  an  integer  (radius  of  the  circle)  and  returns  the  difference  of  the  areas  of  the  two  squares.

        <h5>Examples</h5>
        <code>
square_areas_difference(5)  ➞  50

square_areas_difference(6)  ➞  72

square_areas_difference(7)  ➞  98
            </p>
        </code>

Notes
Use only positive integer parameters.
""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
    }
}
