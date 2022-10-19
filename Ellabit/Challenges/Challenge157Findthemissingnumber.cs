namespace Ellabit.Challenges
{
    public class Challenge157Findthemissingnumber : IChallenge
    {
        public string? Header { get; set; } = "Find the missing number";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
    public  int MissingNum(int[] arr)
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
        int sumResult;
        try 
        {
            sumResult = tmp.MissingNum(new int[] {1,  2,  3,  4,  6,  7,  8,  9,  10})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   5,  $""returned: {sumResult}  expected: 5"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.MissingNum(new int[] {7,  2,  3,  6,  5,  9,  1,  4,  8})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==   10,   $""returned: {sumResult}  expected: 10"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult;
        try 
        {
            sumResult = tmp.MissingNum(new int[] {10,  5,  1,  2,  4,  6,  8,  3,  9})  ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult ==   7,   $""returned: {sumResult}  expected: 7"");
    }
}
}";
        public string? Description { get; set; } = @"Create content  a  function  that  takes  an  array  of  numbers  between  1  and  10  (excluding  one  number)  and  returns  the  missing  number.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
missingnum([1,  2,  3,  4,  6,  7,  8,  9,  10])  ➞  5

missingnum([7,  2,  3,  6,  5,  9,  1,  4,  8])  ➞  10

missingnum([10,  5,  1,  2,  4,  6,  8,  3,  9])  ➞  7
            </p>
        </code>

notes
the  array  of  numbers  will  be  unsorted  (not  in  order).
only  one  number  will  be  missing.""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Array", "Iteration"}, { "Level", "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
