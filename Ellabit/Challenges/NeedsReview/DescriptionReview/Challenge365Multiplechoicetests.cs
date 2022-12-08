namespace Ellabit.Challenges
{
    public class Challenge365Multiplechoicetests : IChallenge
    {
        public string? Header { get; set; } = "Multiple choice tests";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Collections.Generic;
using System.Linq;

namespace MultipleChoiceTests
{
		public interface ITestpaper
		{
				string Subject { get; }
				string[] MarkScheme { get; }
				string PassMark { get; }
		}

		public interface IStudent
		{
				string[] TestsTaken { get; }
				void TakeTest(ITestpaper paper, string[] answers);
		}

		public class Testpaper
		{

		}

		public class Student
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
        public string? Description { get; set; } = @"Your content  task  is  to  write  a  program  which  allows  teachers  to  create  a  multiple  choice  test  in  a  class  called  testpaper  and  also  be  able  to  assign  a  minimum  pass  mark.  the  testpaper  class  should  implement  the  itestpaper  interface  given  in  the  code  template  which  has  the  following  properties:

string  subject
string[]  markscheme
string  passmark

interfaces  do  not  def""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
