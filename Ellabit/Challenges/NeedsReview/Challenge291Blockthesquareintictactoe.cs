namespace Ellabit.Challenges
{
    public class Challenge291Blockthesquareintictactoe : IChallenge
    {
        public string? Header { get; set; } = "Block the square in tic tac toe";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge {
	public  int BlockPlayer(int a, int b) {
		
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
        public string? Description { get; set; } = @"Create a function that returns a number which can block the player from reaching 3 in a row in a game of Tic Tac Toe. The number given as an argument will correspond to a grid of Tic Tac Toe: topleft is 0, topright is 2, bottomleft is 6, and bottomright is 8.

Create a function that takes two numbers a, b and returns another number.
This number should be the final one in a line to block the player from winning.
Examples
BlockPlayer(0, 3) ➞ 6

BlockPlayer(0, 4) ➞ 8

BlockPlayer(3, 5) ➞ 4
Notes
The values given will always have two filled squares in a line.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
