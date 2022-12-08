namespace Ellabit.Challenges
{
    public class Challenge221Reaftheabacuspart1 : IChallenge
    {
        public string? Header { get; set; } = "Read the Abacus (Part 1: Russian Schoty)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  int NumberOfDays(int[] coordinates) 
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
        public string? Description { get; set; } = @"The Russian schoty is type of abacus (counting tool) that is used by sliding threaded beads along horizontal wires. An example schoty would have 7 wires, each holding 10 beads. Each bead, when moved to the left, would count as 1 unit. Starting from the bottom wire and moving up, the units increase by a factor of 10. If we use ""O"" for a bead and ""-"" to show the wire, we can represent the schoty as follows:

---OOOOOOOOOO  millions
---OOOOOOOOOO  hundred-thousands
---OOOOOOOOOO  ten-thousands
---OOOOOOOOOO  thousands
---OOOOOOOOOO  hundreds
---OOOOOOOOOO  tens 
---OOOOOOOOOO  ones
To read the number, we count the beads on the left-hand side of each wire. In the example below, the number is 501264:

---OOOOOOOOOO  0
OOOOO---OOOOO  5
---OOOOOOOOOO  0
O---OOOOOOOOO  1
OO---OOOOOOOO  2
OOOOOO---OOOO  6
OOOO---OOOOOO  4
Given an array of strings representing each wire in the schoty, return the number being displayed.

Examples
Schoty({
  ""---OOOOOOOOOO"",
  ""---OOOOOOOOOO"",
  ""---OOOOOOOOOO"",
  ""OOO---OOOOOOO"",
  ""O---OOOOOOOOO"",
  ""OOOOOOOOO---O"",
  ""OO---OOOOOOOO""
}) ➞ 3192

Schoty({
  ""OO---OOOOOOOO"",
  ""O---OOOOOOOOO"",
  ""OOOOO---OOOOO"",
  ""---OOOOOOOOOO"",
  ""---OOOOOOOOOO"",
  ""---OOOOOOOOOO"",
  ""---OOOOOOOOOO""
}) ➞ 2150000
Notes
For more info on how to use a schoty, please see the resources section. This challenge ignores the traditional 4-bead wires used for quarter-ruble and quarter-kopek calculations";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        public Dictionary<string, string> Tags { get; set; } = new Dictionary<string, string>(StringComparer.InvariantCultureIgnoreCase);
    }
}
