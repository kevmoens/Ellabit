namespace Ellabit.Challenges
{
    public class Challenge036Numberofstickers : IChallenge
    {
        public string? Header { get; set; } = "  \"Number of stickers\"  ";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

using System;
public class Challenge
{
	public  int HowManyStickers(int n)
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
            sumResult = tmp.HowManyStickers(1) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  6,  $""returned: {sumResult}  expected:  6"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HowManyStickers(2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 24,   $""returned: {sumResult}  expected: 24"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.HowManyStickers(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 54,   $""returned: {sumResult}  expected: 54"");
    }
}
}";
        public string? Description { get; set; } = @"Given a Rubik's Cube with a side length of n, return the number of individual stickers that are needed to cover the whole cube.

Pictures of Rubik's Cubes

The Rubik's cube of side length 1 has 6 stickers.
The Rubik's cube of side length 2 has 24 stickers.
The Rubik's cube of side length 3 has 54 stickers.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >

HowManyStickers(1) ➞ 6

HowManyStickers(2) ➞ 24

HowManyStickers(3) ➞ 54
            </p>
        </code>

Notes

Keep in mind there are 6 faces to keep track of.
Expect only positive whole numbers.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
