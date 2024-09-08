using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Node
    {
        public DefenceModel DefenceModel { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public Node(DefenceModel model)
        {
            this.DefenceModel = model;
            Left = Right = null; 
        }

    }
}
