using System;
using System.Collections.Generic;
using System.Linq;


namespace HackerRank.Net.Searching
{

    public class KnightLOnChessboard
    {

        class Node
        {
            public Node(int x, int y, int step = 0)
            {
                X = x;
                Y = y;
                Step = step;
            }
            public int X { get; set; }
            public int Y { get; set; }
            public int Step { get; set; }
            public bool Equals(Node other)
            {
                if (this == other) return true;
                // if (!(other instanceof Position)) return false;

                if (X != other.X || Y != other.Y) return false;
                return true;
            }

            public override int GetHashCode()
            {
                int hash = 17;
                hash = hash * 31 + X;
                hash = hash * 31 + Y;
                return hash;
            }
            public HashSet<Node> GenerateChildren(int moveX, int moveY)
            {
                HashSet<Node> hs = new HashSet<Node>();

                AddNextMoveToHashset(moveX, moveY, hs);
                AddNextMoveToHashset(moveX, -moveY, hs);
                AddNextMoveToHashset(-moveX, moveY, hs);
                AddNextMoveToHashset(-moveX, -moveY, hs);
                
                AddNextMoveToHashset(moveY, moveX, hs);
                AddNextMoveToHashset(moveY, -moveX, hs);
                AddNextMoveToHashset(-moveY, moveX, hs);
                AddNextMoveToHashset(-moveY, -moveX, hs);
                
                return hs;
            }

            private void AddNextMoveToHashset(int moveX, int moveY, HashSet<Node> hs)
            {
                Node newPos = moveBy(moveX, moveY);
                if (newPos != null) hs.Add(newPos);
            }


            private Node moveBy(int moveX, int moveY)
            {
                int newX = X + moveX;
                int newY = Y + moveY;
                if (newX < n && newY < n && newX >= 0 && newY >= 0)
                {
                    Node newPos = new Node(newX, newY);
                    newPos.Step = Step + 1;
                    return newPos;
                }
                return null;
            }
        }
        static int[,] board;
        static int n;
        static int UN_REACHABLE = -1;
        static Node BEGIN = new Node(0, 0);
        static Node END ;
        static HashSet<int> visited = new HashSet<int>();

        public static void KnightL(int n1)
        {
            n = n1;
            board = new int[n, n];
            END = new Node(n - 1, n - 1);
            // your code goes here
            for (int x = 1; x < n; x++)
            {
                for (int y = x; y < n; y++)
                {
                    board[x, y] = ShotestReachableCount(x, y, END);
                    board[y, x] = board[x, y];
                }
            }
            for (int x = 1; x < n; x++)
            {
                for (int y = 1; y < n; y++)
                {
                    Console.Write(board[x, y] + " ");
                }
                Console.WriteLine();
            }
        }

        static int ShotestReachableCount(int x, int y, Node node)
        {
            Queue<Node> q = new Queue<Node>();
            visited.Add(node.GetHashCode());
            q.Enqueue(node);
            while (q.Any())
            {
                var n = q.Dequeue();
                if (n.Equals(BEGIN))
                    return n.Step;

                var neighbors = n.GenerateChildren(x, y);
                foreach (var neighbor in neighbors)
                {
                    if (!visited.Contains(neighbor.GetHashCode()))
                    {
                       // Console.WriteLine($"(x:{neighbor.X}, y: {neighbor.Y}, hashCode: {neighbor.GetHashCode()})");
                        visited.Add(neighbor.GetHashCode());
                        q.Enqueue(neighbor);
                    }
                }
            }
            return UN_REACHABLE;
        }
    }
}
