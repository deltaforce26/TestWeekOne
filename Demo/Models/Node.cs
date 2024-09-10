using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWeekOne.Models
{
    internal class Node
    {
        public DefenceModel DefenceModel { get; set; }
        public Node? Left { get; set; }
        public Node? Right { get; set; }
        public Node(DefenceModel model)
        {
            DefenceModel = model;
            Left = Right = null;
        }

    }
}
