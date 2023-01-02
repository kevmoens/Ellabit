namespace Ellabit.Challenges
{
    public class Challenge370Genericbinarytree : IChallenge
    {
        public string? Header { get; set; } = "Generic binary tree";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;
using System.Collections.Generic;
using System.Linq;

public class Node<T> where T: IComparable 
{
    public Node(T data) 
	{
		// TODO - add constructor code here
	}

	// TODO - implement the following properties (they should be readonly)
    public Node<T> Left;
    public Node<T> Right;
    public T Data;

    public void Insert(T data)
    {
		// TODO - add code here to implement inserting new data into tree
    }

    public IEnumerable<T> GetTreeData()
    {
		// TODO - add code here to return an enumerable collection of tree
		// objects (of type 'T') in ascending order
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
        public string? Description { get; set; } = @"A content  binary  search  tree  is  a  node-based  tree  data  structure  which  has  the  following  properties:

the  left  subtree  of  a  node  contains  only  nodes  with  data  less  than  the  node's  data.
the  right  subtree  of  a  node  contains  only  nodes  with  data  greater  than  the  node’s  data.
the  left  and  right  subtree  each  must  also  be  a  binary  search  tree  (or  null).

create  a  generic  c""";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
