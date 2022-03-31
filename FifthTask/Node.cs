using System.Collections.Generic;

namespace FifthTask
{
    /// <summary>
    /// Provides mechanism for calculating nodes and traversing a tree
    /// </summary>
    public class Node
    {
        public int Value { get; set; }
        public Node LeftTree { get; set; }
        public Node RightTree { get; set; }
        public Node(int value)
        {
            Value = value;
        }

        /// <summary>
        /// Adds new node to the tree
        /// </summary>
        /// <param name="node">New node in the tree</param>
        public void Add(Node node)
        {
            if (node.Value < Value)
            {
                if (LeftTree != null)
                {
                    LeftTree.Add(node);
                }
                else
                {
                    LeftTree = node;
                }
            }
            else
            {
                if (RightTree != null)
                {
                    RightTree.Add(node);
                }
                else
                {
                    RightTree = node;
                }
            }
        }

        /// <summary>
        /// Converts tree to sorted array
        /// </summary>
        /// <param name="array">Empty list for sorting array</param>
        /// <returns>Returns Sorted array</returns>
        public int[] Traverse(List<int> array = null)
        {
            if (array == null)
            {
                array = new List<int>();
            }

            if (LeftTree != null)
            {
                LeftTree.Traverse(array);
            }
            array.Add(Value);

            if (RightTree != null)
            {
                RightTree.Traverse(array);
            }
            return array.ToArray();
        }
    }
}
