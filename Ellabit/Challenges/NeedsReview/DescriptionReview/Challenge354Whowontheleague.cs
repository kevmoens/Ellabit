namespace Ellabit.Challenges
{
    public class Challenge354WhoWontheLeague : IChallenge, IChallengeTestCode
    {
        public string? Header { get; set; } = "Who won the league?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit
{

using System;

public class Challenge
{
    public  string EPLResult(string[] table, string team) {
			
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
        string sumResult;
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
        string sumResult;
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
        string sumResult;
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
}
";
        public string? Description { get; set; } = @"<div><p><span>The 2019/20 season of the English Premier League (EPL) saw Liverpool FC win the title for the first time despite their bitter rivals, Manchester United, having won 13 titles! </span></p><p><span>Create a function that receives an alphabetically sorted array of the results achieved by each team in that season and the name of one of the teams. The function should return a string giving the final position of the team, the number of points achieved and the goal difference (see examples for precise format).</span></p><p><span>The results table is given in the following format:</span></p><table><thead><tr><th style=""text-align: left;""><span>Team</span></th><th><span>Played</span></th><th><span>Won</span></th><th><span>Drawn</span></th><th><span>Lost</span></th><th><span>G/Diff</span></th></tr></thead><tbody><tr><td style=""text-align: left;""><span>Arsenal</span></td><td><span>38</span></td><td><span>14</span></td><td><span>14</span></td><td><span>10</span></td><td><span>8</span></td></tr><tr><td style=""text-align: left;""><span>Aston Villa</span></td><td><span>38</span></td><td><span>9</span></td><td><span>8</span></td><td><span>21</span></td><td><span>-26</span></td></tr><tr><td style=""text-align: left;""><span>Bournemouth</span></td><td><span>38</span></td><td><span>9</span></td><td><span>7</span></td><td><span>22</span></td><td><span>-26</span></td></tr><tr><td style=""text-align: left;""><span>Brighton</span></td><td><span>38</span></td><td><span>9</span></td><td><span>14</span></td><td><span>15</span></td><td><span>-15</span></td></tr><tr><td style=""text-align: left;""><span>Burnley</span></td><td><span>38</span></td><td><span>15</span></td><td><span>9</span></td><td><span>14</span></td><td><span>-7</span></td></tr><tr><td style=""text-align: left;""><span>Chelsea</span></td><td><span>38</span></td><td><span>20</span></td><td><span>6</span></td><td><span>12</span></td><td><span>15</span></td></tr><tr><td style=""text-align: left;""><span>Crystal Palace</span></td><td><span>38</span></td><td><span>11</span></td><td><span>10</span></td><td><span>17</span></td><td><span>-19</span></td></tr><tr><td style=""text-align: left;""><span>Everton</span></td><td><span>38</span></td><td><span>13</span></td><td><span>10</span></td><td><span>15</span></td><td><span>-12</span></td></tr><tr><td style=""text-align: left;""><span>Leicester City</span></td><td><span>38</span></td><td><span>18</span></td><td><span>8</span></td><td><span>12</span></td><td><span>26</span></td></tr><tr><td style=""text-align: left;""><span>Liverpool</span></td><td><span>38</span></td><td><span>32</span></td><td><span>3</span></td><td><span>3</span></td><td><span>52</span></td></tr><tr><td style=""text-align: left;""><span>Manchester City</span></td><td><span>38</span></td><td><span>26</span></td><td><span>3</span></td><td><span>9</span></td><td><span>67</span></td></tr><tr><td style=""text-align: left;""><span>Manchester Utd</span></td><td><span>38</span></td><td><span>18</span></td><td><span>12</span></td><td><span>8</span></td><td><span>30</span></td></tr><tr><td style=""text-align: left;""><span>Newcastle</span></td><td><span>38</span></td><td><span>11</span></td><td><span>11</span></td><td><span>16</span></td><td><span>-20</span></td></tr><tr><td style=""text-align: left;""><span>Norwich</span></td><td><span>38</span></td><td><span>5</span></td><td><span>6</span></td><td><span>27</span></td><td><span>-49</span></td></tr><tr><td style=""text-align: left;""><span>Sheffield Utd</span></td><td><span>38</span></td><td><span>14</span></td><td><span>12</span></td><td><span>12</span></td><td><span>0</span></td></tr><tr><td style=""text-align: left;""><span>Southampton</span></td><td><span>38</span></td><td><span>15</span></td><td><span>7</span></td><td><span>16</span></td><td><span>-9</span></td></tr><tr><td style=""text-align: left;""><span>Tottenham</span></td><td><span>38</span></td><td><span>16</span></td><td><span>11</span></td><td><span>11</span></td><td><span>14</span></td></tr><tr><td style=""text-align: left;""><span>Watford</span></td><td><span>38</span></td><td><span>8</span></td><td><span>10</span></td><td><span>20</span></td><td><span>-28</span></td></tr><tr><td style=""text-align: left;""><span>West Ham</span></td><td><span>38</span></td><td><span>10</span></td><td><span>9</span></td><td><span>19</span></td><td><span>-13</span></td></tr><tr><td style=""text-align: left;""><span>Wolves</span></td><td><span>38</span></td><td><span>15</span></td><td><span>14</span></td><td><span>9</span></td><td><span>11</span></td></tr></tbody></table><h3><span>Examples</span></h3><pre><code>string[] table = [
  ""Arsenal, 38, 14, 14, 10, 8"",
  ""Aston Villa, 38, 9, 8, 21, -26"",
    ...
    ...
  ""West Ham, 38, 10, 9, 19, -1"",
  ""Wolves, 38, 15, 14, 9, 11""
]

EPLResult(table, ""Liverpool"")
  ➞ ""Liverpool came 1st with 99 points and a goal difference of 52!""

EPLResult(table, ""Manchester Utd"")
  ➞ ""Manchester Utd came 3rd with 66 points and a goal difference of 30!""

EPLResult(table, ""Norwich"")
  ➞ ""Norwich came 20th with 21 points and a goal difference of -49!""</code></pre><h3><span>Notes</span></h3><ul><li><span>Each result in the source table is a comma separated string.</span></li><li><span>Score 3 points for a win and 1 point for a draw.</span></li><li><span>If teams are tied on points, their position is determined by better goal difference.</span></li><li><span>The input table should be considered immutable - do not make any changes to it!</span></li></ul></div>";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();

        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
