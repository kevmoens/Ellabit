namespace Ellabit.Challenges
{
    public class Challenge025Maximumedgeofatriangle : IChallenge
    {
        public string? Header { get; set; } = "Maximum edge of a triangle";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
  public  int NextEdge(int side1, int side2) 
  {
	 
  }
}

}";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit {

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.NextEdge(8, 10);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  17,  $""returned: {sumResult}  expected:  17"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.NextEdge(5, 7);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  11,   $""returned: {sumResult}  expected:  11"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.NextEdge(9, 2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  10,   $""returned: {sumResult}  expected:  10"");
    }
}
}";
        public string? Description { get; set; } = @"Create a function that finds the maximum range of a triangle's third edge, where the side lengths are all integers.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
nextedge(8, 10) ➞ 17

nextedge(5, 7) ➞ 11

nextedge(9, 2) ➞ 10
            </p>
        </code>

notes
(side1 + side2) - maximum range of third edge.
the side lengths of the triangle are positive integers.
don't forget to return the result.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Addition" }, { "Math:2", "Subtraction"}, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
    }
}
