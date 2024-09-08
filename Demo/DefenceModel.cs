using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class DefenceModel
    {
        public int MinSeverity { get; set; }
        public int MaxSeverity { get; set; }
        public List<string> Defenses { get; set; }
    }

    internal class DefenceModelList
    {
        public List<DefenceModel> ListOfModels { get; set; }
    }
}
