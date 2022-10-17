namespace Ellabit.Challenges
{
    public class Challenge048Drinksallowed : IChallenge
    {
        public string? Header { get; set; } = "Drinks allowed?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge
{
	public  bool ShouldServeDrinks(int age, bool on_break)
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
        bool sumResult;
        try 
        {
            sumResult = tmp.ShouldServeDrinks(17, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  false,  $""returned: {sumResult}  expected:  false"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.ShouldServeDrinks(19, false);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == true,   $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        bool sumResult;
        try 
        {
            sumResult = tmp.ShouldServeDrinks(30, true);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == false,   $""returned: {sumResult}  expected: false"");
    }
}
}";
        public string? Description { get; set; } = @"A bartender is writing a simple program to determine whether he should serve drinks to someone. he only serves drinks to people 18 and older and when he's not on break.

given the person's age, and whether break time is in session, create a function which returns whether he should serve drinks.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >

ShouldServeDrinks(17, true) ➞ false

ShouldServeDrinks(19, false) ➞ true

ShouldServeDrinks(30, true) ➞ false
            </p>
        </code>

Notes
Return true or false.
Some countries have a slightly higher drinking age, but for the purposes of this challenge, it will be 18.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Expression", "<=" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
