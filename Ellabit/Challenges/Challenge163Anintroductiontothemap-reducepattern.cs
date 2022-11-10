using static MudBlazor.CategoryTypes;

namespace Ellabit.Challenges
{
    public class Challenge163Anintroductiontothemapreducepattern : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "An introduction to the map-reduce pattern";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge 
{
    public  double Magnitude(int[] arr) 
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
        double sumResult;
        try 
        {
            sumResult = tmp.Magnitude(new int[] {3,  4})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   5,  $""returned: {sumResult}  expected: 5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.Magnitude(new int[] {0,  0,  -10})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   10,   $""returned: {sumResult}  expected: 10"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.Magnitude(new int[] {})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   0,   $""returned: {sumResult}  expected: 0"");
    }
    public (bool pass, string message) Test4()
    {
        var tmp = new Challenge();
        double sumResult;
        try 
        {
            sumResult = tmp.Magnitude(new int[] {2,  3,  6,  1,  8})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==  10.6770782520313,   $""returned: {sumResult}  expected: 0"");
    }
}
}";
        public string? Description { get; set; } = @"You content  will  be  implementing  a  basic  case  of  the  map-reduce  pattern  in  programming.  given  a  vector  stored  as  an  array  of  numbers,  find  the  magnitude  of  the  vector.  use  the  standard  distance  formula  for  n-dimensional  cartesian  coordinates.


        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
magnitude([3,  4])  ➞  5

magnitude([0,  0,  -10])  ➞  10

magnitude([])  ➞  0

magnitude([2,  3,  6,  1,  8]  )  ➞  10.6770782520313""
            </p>
        </code>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {{ "Math", "Magnitude" }, { "Level", "3" }};
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
