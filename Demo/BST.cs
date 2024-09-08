using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWeekOne.Enums;
using TestWeekOne.Models;

namespace Demo
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
            foreach(string defence in node.DefenceModel.Defenses)
            {
                Console.WriteLine(defence);
            }
            preOrder(node.Left);
            preOrder(node.Right);
        }

        public int CalcSeverity()
        {
            int severity = (Volume * Sophistication) + TargetValueEnum;
            return severity;
        }
    }
}
