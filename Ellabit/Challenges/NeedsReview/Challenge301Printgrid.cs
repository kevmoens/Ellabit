namespace Ellabit.Challenges
{
    public class Challenge301Printgrid : IChallenge
    {
        public string? Header { get; set; } = "Print grid";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge
{
	public  int[,] PrintGrid(int rows, int cols) {
		
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
        int[,] sumResult;
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
        int[,] sumResult;
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
        int[,] sumResult;
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
        public string? Description { get; set; } = @"Write a method that accepts two integer parameters rows and cols. The output is a 2d array of numbers displayed in column-major order, meaning the numbers shown increase sequentially down each column and wrap to the top of the next column to the right once the bottom of the current column is reached.

Examples
PrintGrid(3, 6) ➞ new int[,] { 
  new int[] { 1, 4, 7, 10, 13, 16 },
  new int[] { 2, 5, 8, 11, 14, 17 },
  new int[] { 3, 6, 9, 12, 15, 18 }
]

PrintGrid(5, 3) ➞ new int[,] { 
  new int[] { 1, 6, 11 },
  new int[] { 2, 7, 12 },
  new int[] { 3, 8, 13 },
  new int[] { 4, 9, 14 },
  new int[] { 5, 10, 15 }
]

PrintGrid(4, 1) ➞ new int[,] { 
  new int[] { 1 },
  new int[] { 2 },
  new int[] { 3 },
  new int[] { 4 }
]
Notes
The return type of the function must be a 2 dimensional array of integers - int[,]";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
