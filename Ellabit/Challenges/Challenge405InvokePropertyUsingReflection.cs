namespace Ellabit.Challenges
{
    public class Challenge405Reflection
    {
        public string? Header { get; set; } = "Invoke the property of the class by using Reflection!";
        public string? Code { get; set; } = @"

using System;

using System.Reflection;

namespace Ellabit;

using system;

namespace Program
{
    public Class Challenge
    {
        public string InvokeProperty()
        {

        }
    }
    public class TestClass1
    {
        public string School {get; set;}
        public string Name {get; set;}
        public string Course {get; set;}

    }   
}
";
        public string? TestCode { get; set; } = @"

using system;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string Value;
        try
        {
           Value = tmp.InvokeProperty();
        }catch(Exception ex)
        {
           return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (Value = ""Havard University"" $""returned: {Value} expected: ""Havard University"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string Value;
        try
        {
           Value = tmp.InvokeProperty();
        }catch(Exception ex)

        {
           return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (Value = ""Havard"" $""returned: {Value} expected: ""Massi"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try
        {
           sumResult = tmp.InvokeProperty();
        }catch(Exception ex)
        {
           return (false, ex.ToString() + ""/n"" + ex.Message);
        }
        return (Value = ""Havard"" $""returned: {Value} expected: ""Computer Science"");
    } 
}
";
        public string? Description { get; set; } = @"Create a function and invoke the property from the second class by using Reflection.

Examples
InvokeProperty(""Havard University"") ➞ ""Havard University""

InvokeProperty(""Massi"") ➞ ""Massi""

InvokeProperty(""Computer Science"") ➞ ""Computer Science""

You can expect a valid string for each test case.
";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"Refection", "string" }, {"Level", "3" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value;}
        public bool ShowBlockly { get => false; }

    }
}
