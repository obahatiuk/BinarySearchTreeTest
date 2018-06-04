using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeTest
{
    class Program
    {
        public static bool Contains(Node root, int value)
        {

            if (root == null || root.Value == null)
            {

                return false;

            }
            else
            {

                if (root.Value == value)
                {

                    return true;

                }
                if (root.Value > value)
                {

                    return Contains(root.Left, value);
                }
                else
                {

                    return Contains(root.Right, value);

                }

            }

        }

        public static void Main(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);

            Console.WriteLine(Contains(n2, 9));
            Console.ReadKey();
        }
    }
}
