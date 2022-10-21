namespace Ellabit.Challenges
{
    public class Challenge179ATMpincodevalidation : IChallenge
    {
        public string? Header { get; set; } = "ATM pin code validation";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{
    public class Challenge 
    {
        public  bool ValidatePIN(string pin) 
        {
            
        }
    }
}
";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit
{
    public class TestChallenge
    {
        public (bool pass, string message) Test1()
        {
            var tmp = new Challenge();
            bool sumResult;
            try 
            {
                sumResult = tmp.ValidatePIN(""1234"") ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult ==  true ,  $""returned: {sumResult}  expected: true"");
        }
        public (bool pass, string message) Test2()
        {
            var tmp = new Challenge();
            bool sumResult;
            try 
            {
                sumResult = tmp.ValidatePIN(""12345"");
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult ==  false ,   $""returned: {sumResult}  expected: false"");
        }
        public (bool pass, string message) Test3()
        {
            var tmp = new Challenge();
            bool sumResult;
            try 
            {
                sumResult = tmp.ValidatePIN(""a234"");
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult ==  false,   $""returned: {sumResult}  expected: false"");
        }
        public (bool pass, string message) Test4()
        {
            var tmp = new Challenge();
            bool sumResult;
            try 
            {
                sumResult = tmp.ValidatePIN("""");
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + ""\n"" + ex.Message);
            }
            return (sumResult ==  false,   $""returned: {sumResult}  expected: false"");
        }
        public (bool pass, string message) Test5()
        {
            var tmp = new Challenge();
            bool sumResult;
            try 
            {
                sumResult = tmp.ValidatePIN(""123456"") ;
            } catch (Exception ex) 
            {
                return (false, ex.ToString() + "" "" + ex.Message);
            }
            return (sumResult ==  true ,  $""returned: {sumResult}  expected: true"");
        }
    }
}
";
        public string? Description { get; set; } = @"ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits or exactly 6 digits. Your task is to create a function that takes a string and returns true if the PIN is valid and false if it's not.

        <h5>Examples</h5>
        <code>
ValidatePIN(""1234"") ➞ true

ValidatePIN(""12345"") ➞ false

ValidatePIN(""a234"") ➞ false

ValidatePIN("""") ➞ false

ValidatePIN(""123456"") ➞ true
            </p>
        </code>
Notes
Some test cases contain special characters.
Empty strings must return false.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3", "Test4", "Test5" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) { {"String", "Sort"}, { "Level" , "2"} };
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
        public bool ShowBlockly { get => false; }
        public string BlocklyXML { get => string.Empty; }
        public string BlocklyToolboxXML { get => string.Empty; }
    }
}
