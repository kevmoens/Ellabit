namespace Ellabit.Challenges
{
    public class Challenge405ConvertMeterToCentimeter 
    {
        public string? Header { get; set; } = "Convert meter to centimeter";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

    public class Challenge
    {
        public int convert(int meter)
        {
            return 0;
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
            sumResult = tmp.convert(1);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 100,  $""returned: {sumResult}  expected: 100"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.convert(2);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == 200, $""returned: {sumResult}  expected: 200"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        int sumResult = 0;
        try 
        {
            sumResult = tmp.convert(3);
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == 300,   $""returned: {sumResult}  expected: 300"");
    }
}

";
        public string? Description { get; set; } = @"
Write a function that takes an integer meter and converts it to centimeter.

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
                convert(1) ➞ 100
                <br />
                convert(2) ➞ 200
                <br />
                convert(3) ➞ 300
            </p>
        </code>
        <h5>Notes</h5>
        <ul>
            <li>Don't forget to <strong>return</strong> the result.</li>
        </ul>";

        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Math", "Multiplication" }, { "Level", "1" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyToolboxXML { get => @"<xml id=""toolbox"" style=""display: none"">
    <block type=""math_arithmetic"">
        <value name=""A"">
            <shadow type=""math_number"">
                <field name=""NUM"">1</field>
            </shadow>
        </value>
        <value name=""B"">
            <shadow type=""math_number"">
                <field name=""NUM"">1</field>
            </shadow>
        </value>
    </block>
    <block type=""variables_get"">
        <field name=""VAR"">meter</field>
    </block>
</xml>"; }
    }
}
