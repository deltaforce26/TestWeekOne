using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestWeekOne.Models
{
    internal class BST
    {
        public Node? Root { get; set; }
        public BST()
        {
            Root = null;
        }

        public void Insert(DefenceModel model)
        {
            Node newNode = new Node(model);
            if (Root == null)
            {
                Root = newNode;
                return;
            }
            InsertRec(Root, newNode);
        }

        private void InsertRec(Node current, Node newNode)
        {
            if (current.DefenceModel.MinSeverity > newNode.DefenceModel.MinSeverity && current.Left == null)
            {
                current.Left = newNode;
                return;
            }
            else if (current.DefenceModel.MaxSeverity <= newNode.DefenceModel.MaxSeverity && current.Right == null)
            {
                current.Right = newNode;
                return;
            }
            if (current.DefenceModel.MinSeverity > newNode.DefenceModel.MinSeverity && current.Left != null)
            {
                InsertRec(current.Left, newNode);
            }
            else if (current.DefenceModel.MaxSeverity <= newNode.DefenceModel.MaxSeverity && current.Right != null)
            {
                InsertRec(current.Right, newNode);
            }
        }

        public virtual void preOrder(Node? node)
        {
            if (node == null)
            {
                return;
            }
            foreach (string defence in node.DefenceModel.Defenses)
            {
                Console.WriteLine(defence);
            }
            preOrder(node.Left);
            preOrder(node.Right);
        }

        public void PrintTree()
        {
            PrintTreeRec(Root, "", true, "Root");
        }
        private void PrintTreeRec(Node node, string indent, bool last, string position)
        {
            if (node != null)
            {
                Console.Write(indent);
                if (last)
                {
                    Console.Write("└──");
                    indent += " ";
                }
                else
                {
                    Console.Write("├──");
                    indent += "| ";
                }
                Console.WriteLine($"{position}: [{node.DefenceModel.MinSeverity}-{node.DefenceModel.MaxSeverity}] Defenses: {string.Join(", ", node.DefenceModel.Defenses)}");
                PrintTreeRec(node.Left, indent, false, "Left Child");
                PrintTreeRec(node.Right, indent, true, "Right Child");
            }
        }
    }
}
