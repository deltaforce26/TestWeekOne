using Newtonsoft.Json;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string json = File.ReadAllText("defenceStrategiesBalanced.json");

            List<DefenceModel> defenceModels = JsonConvert.DeserializeObject<List<DefenceModel>>(json);

            BST bST = new BST();
            foreach (DefenceModel model in defenceModels)
            {
                bST.Insert(model);
            }
            bST.preOrder(bST.Root);
        }
    }
}
