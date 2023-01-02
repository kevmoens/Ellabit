namespace Ellabit.Challenges
{
    public class Challenge323Musicalinstrumentnoteranges : IChallenge
    {
        public string? Header { get; set; } = "Musical instrument note ranges";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
  	public  bool InstrumentRange(string instr, string note) {
		
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
        bool sumResult;
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
        bool sumResult;
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
        public string? Description { get; set; } = @"Musical instruments have a range of notes to play, some instruments having a much larger range than others.

Given the following ranges for the instrument, create a function that returns true if a given note is within a given instrument's range. Otherwise, return false.
<table>
<tr><th>Instrument</th>	<th>Range</th></tr>
<tr><td>Piccolo</td><td>D4-C7</td></tr>
<tr><td>Tuba</td><td>D1-F4</td></tr>
<tr><td>Guitar</td><td>E3-E6</td></tr>
<tr><td>Piano</td><td>A0-C8</td></tr>
<tr><td>Violin</td><td>G3-A7</td></tr>
</table>
Examples
InstrumentRange(""Piccolo"", ""A3"") ➞ false

InstrumentRange(""Violin"", ""G6"") ➞ true

InstrumentRange(""Piano"", ""C8"") ➞ true
Notes
Tests will only include natural notes (i.e. you will only deal with letters and numbers, no special characters).
The musical scale follows this pattern: ... A1, B1, C1, D1, E1, F1, G1, A2, B2 ...
You don't need to worry about invalid inputs.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
