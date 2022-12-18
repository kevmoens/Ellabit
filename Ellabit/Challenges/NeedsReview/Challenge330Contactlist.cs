namespace Ellabit.Challenges
{
    public class Challenge330Contactlist : IChallenge
    {
        public string? Header { get; set; } = "Contact list";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
		public  string[] SortContacts(string[] names, string sort)
		{
				return new string[0];
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
        string[] sumResult;
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
        string[] sumResult;
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
        string[] sumResult;
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
        public string? Description { get; set; } = @"Write a sorting function that takes in an array of names and sorts them by last name either alphabetically (ASC) or reverse-alphabetically (DESC).

Examples
SortContacts(new string[] {
  ""John Locke"",
  ""Thomas Aquinas"",
  ""David Hume"",
  ""Rene Descartes""
}, ""ASC"") ➞ {
  ""Thomas Aquinas"",
  ""Rene Descartes"",
  ""David Hume"",
  ""John Locke""
}

// Aquinas (A) < Descartes (D) < Hume (H) < Locke (L)

SortContacts(new string[] {
  ""Paul Erdos"",
  ""Leonhard Euler"",
  ""Carl Gauss""
}, ""DESC"") ➞ {
  ""Carl Gauss"",
  ""Leonhard Euler"",
  ""Paul Erdos""
}

// Gauss (G) > Erdos (ER) > Euler (EU)

SortContacts([], ""DESC"") ➞ {}

SortContacts(null, ""DESC"") ➞ {}
Notes
An array with a single name should be trivially returned.
An empty array, or an input of null should return an empty array.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
