namespace Ellabit.Challenges
{
    public class Challenge027BuggycodePart4 : IChallenge
    {
        public string? Header { get; set; } = "Buggy code (part 4)";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit {

public class Challenge {
	public  string greeting(string name) {
			return ""Hello, "" + name + ""!"";
			  if(name == ""Mubashir"") {
					return ""Hello, my Love!"";
				}
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
        string sumResult;
        try 
        {
            sumResult = tmp.greeting(""Matt"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Hello, Matt!"",  $""returned: {sumResult}  expected: Hello, Matt!"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.greeting(""Helen"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == ""Hello, Helen!"",  $""returned: {sumResult}  expected: Hello, Helen!"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.greeting(""Mubashir"");
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == ""Hello, my Love!"",  $""returned: {sumResult}  expected: Hello, my Love!"");
    }
}
}";
        public string? Description { get; set; } = @"Emmy has written a function that returns a greeting to users. however, she's in love with mubashir, and would like to greet him slightly differently. she added a special case in her function, but she made a mistake.

can you help her?

        <h5>Examples</h5>
        <code>
            <p style = ""border:1px solid grey; padding: 10px;"" >
greeting(""Matt"") ➞ ""Hello, Matt!""

greeting(""Helen"") ➞ ""Hello, Helen!""

greeting(""Mubashir"") ➞ ""Hello, my Love!""
            </p>
        </code>

Notes
READ EVERY WORD CAREFULLY, CHARACTER BY CHARACTER!
Don't overthink this challenge; it's not supposed to be hard.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { { "Bug", "Logic" }, { "Level", "2" } };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => true; }
        public string BlocklyXML { get => @"<xml>
              <block type=""procedures_defreturn"">
                <mutation>
                  <arg name=""name""/>
                </mutation>
                <field name=""NAME"">greeting</field>
                <statement name=""STACK"">
                  <block type=""procedures_ifreturn"">
                    <mutation value=""1""></mutation>
                    <value name=""CONDITION"">
                      <block type=""logic_boolean"">
                        <field name=""BOOL"">TRUE</field>
                      </block>
                    </value>
                    <value name=""VALUE"">
                      <block type=""text_join"">
                        <mutation items=""2""></mutation>
                        <value name=""ADD0"">
                          <block type=""text"">
                            <field name=""TEXT"">Hello, </field>
                          </block>
                        </value>
                        <value name=""ADD1"">
                          <block type=""text_join"">
                            <mutation items=""2""></mutation>
                            <value name=""ADD0"">
                              <block type=""variables_get"">
                                <field name=""VAR"">name</field>
                              </block>
                            </value>
                            <value name=""ADD1"">
                              <block type=""text"">
                                <field name=""TEXT"">!</field>
                              </block>
                            </value>
                          </block>
                        </value>
                      </block>
                    </value>
                    <next>
                      <block type=""procedures_ifreturn"">
                        <mutation value=""1""></mutation>
                        <value name=""CONDITION"">
                          <block type=""logic_compare"">
                            <field name=""OP"">EQ</field>
                            <value name=""A"">
                              <block type=""variables_get"">
                                <field name=""VAR"" id=""v-Hc|C(l[Nn2$a%C+5-9"">name</field>
                              </block>
                            </value>
                            <value name=""B"">
                              <block type=""text"">
                                <field name=""TEXT"">Mubashir</field>
                              </block>
                            </value>
                          </block>
                        </value>
                        <value name=""VALUE"">
                          <block type=""text"">
                            <field name=""TEXT"">Hello, my Love!</field>
                          </block>
                        </value>
                      </block>
                    </next>
                  </block>
                </statement>
                <value name=""RETURN"">
                  <block type=""variables_get"">
                    <field name=""VAR"">name</field>
                  </block>
                </value>
              </block>
            </xml>"; 
        }
    }
}
