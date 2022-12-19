namespace Ellabit.Challenges
{
    public class Challenge333Validname : IChallenge
    {
        public string? Header { get; set; } = "Valid name";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
	public  bool ValidName(string name) 
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
        public string? Description { get; set; } = @"For this exercise, keep in mind the following definitions:

A term is either an initials or word.
initials = 1 character
words = 2+ characters (no dots allowed)
A valid name is a name written in one of the following ways:

H. Wells
H. G. Wells
Herbert G. Wells
Herbert George Wells
The following names are invalid:

Herbert or Wells (single names not allowed)
H Wells or H. G Wells (initials must end with dot)
h. Wells or H. wells or h. g. Wells (incorrect capitalization)
H. George Wells (middle name expanded, while first still left as initial)
H. G. W. (last name is not a word)
Herb. G. Wells (dot only allowed after initial, not word)
Rules
Both initials and words must be capitalized.
Initials must end with a dot.
A name must be either 2 or 3 terms long.
If the name is 3 words long, you can expand the first and middle name or expand the first name only. You cannot keep the first name as an initial and expand the middle name only.
The last name must be a word (not an initial).
Your task is to write a function that determines whether a name is valid or not. Return true if the name is valid, false otherwise.

Examples
validName(""H. Wells"") ➞ true

validName(""H. G. Wells"") ➞ true

validName(""Herbert G. Wells"") ➞ true

validName(""Herbert"") ➞ false
// Must be 2 or 3 words

validName(""h. Wells"") ➞ false
// Incorrect capitalization

validName(""H Wells"") ➞ false
// Missing dot after initial

validName(""H. George Wells"") ➞ false
// Cannot have: initial first name + word middle name

validName(""H. George W."") ➞ false
// Last name cannot be initial

validName(""Herb. George Wells"") ➞ false
// Words cannot end with a dot (only initials can)
Notes
A term is either an initial or word.
Initials and words are disjoint sets.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
