using Newtonsoft.Json;
using TestWeekOne.Models;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string defences = File.ReadAllText("defenceStrategiesBalanced.json");

            List<DefenceModel> defenceModels = JsonConvert.DeserializeObject<List<DefenceModel>>(defences);

            BST bST = new BST();
            foreach (DefenceModel model in defenceModels)
            {
                bST.Insert(model);
            }

            string threats = File.ReadAllText("threats.json");
            List<Threat> thraetModels = JsonConvert.DeserializeObject<List<Threat>>(threats);
            bST.PrintTree();
            
        }
    }
}
