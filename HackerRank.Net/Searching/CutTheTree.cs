using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Net.Searching
{
    public class Node
    {
        public Node(int data)
        {
            Data = data;
        }
        public int Data { get; set; }
        public List<Node> Adjacencies { get; set; } = new List<Node>();
    }
    public class CutTheTree
    {
        
    }

    public class BigComparer : IComparer
    {
        // Call CaseInsensitiveComparer.Compare with the parameters reversed.
        public int Compare(Object x, Object y)
        {
            var bx = BigInteger.Parse(x.ToString());
            var by = BigInteger.Parse(y.ToString());
            return bx.CompareTo(by);
        }
    }
}
