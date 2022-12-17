namespace Ellabit.Challenges
{
    public class Challenge310Needhelpwithyourpacking : IChallenge
    {
        public string? Header { get; set; } = "Need help with your packing?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Collections.Generic;
using System.Linq;

public class Challenge
{
  	public  bool CanFit(int[] weights, int bags) 
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
        public string? Description { get; set; } = @"You arrive at the supermarket checkout and you've only got a limited number of shopping bags with you. Miser that you are, you hate buying extra bags when you've got dozens at home that you forgot to bring with you!! Can you fit all your shopping into the bags you've got with you?

Each bag can carry a maximum of 10kg and each item you've purchased weighs between 1 and 10kg.

Create a function that takes two parameters, a list of the weights of each item and the number of bags you are carrying. Return True if there are enough bags to contain all the items, otherwise False.

Example
CanFit(new int[] { 2, 1, 2, 5, 4, 3, 6, 1, 1, 9, 3, 2 }, 4) ➞ True
// Bag 1 = [2, 1, 2, 5] (10kg)
// Bag 2 = [4, 3, 3] (10kg)
// Bag 3 = [6, 2, 1, 1] (10kg)
// Bag 4 = [9] (9kg)

CanFit(new int[] { 2, 7, 1, 3, 3, 4, 7, 4, 1, 8, 2 ], 4) ➞ False
// Bag 1 = [2, 8] (10kg)
// Bag 2 = [3, 7] (10kg)
// Bag 3 = [2, 4, 4] (10kg)
// Bag 4 = [7, 3] (10kg)
// two 1kg items left over!
Notes
All weights will be integers between 1 and 10kg inclusive
Items can be packed in any order
There may be more than one way to fit all the items in the available bags";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
