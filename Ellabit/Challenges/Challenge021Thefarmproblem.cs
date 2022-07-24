namespace Ellabit.Challenges
{
    public class Challenge021Thefarmproblem : IChallenge
    {
        public string? Header { get; set; } = "The farm problem";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  int animals(int chickens, int cows, int pigs)
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
        int sumResult = 0;
        try 
        {
            sumResult = tmp.animals(2, 3, 5);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 36,  $""returned: {sumResult}  expected: 36"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.animals(1, 2, 3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 22,   $""returned: {sumResult}  expected: 22"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.animals(5, 2, 8);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 50,   $""returned: {sumResult}  expected: 50"");
    }
}
";
        public string? Description { get; set; } = @"In this challenge, a farmer is asking you to tell him how many legs can be counted among all his animals. the farmer breeds three 2 4 4 legs

the farmer has counted his animals and he gives you a subtotal for each species. you have to implement a function that returns the total number of legs of all the animals.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
animals(2, 3, 5) ➞ 36

animals(1, 2, 3) ➞ 22

animals(5, 2, 8) ➞ 50
            </p>
        </code>

Notes
Don't forget to return the result.
The order of animals passed is animals(chickens, cows, pigs).
Remember that the farmer wants to know the total number of legs and not the total number of animals.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
