using Sharprompt;
using Trees.Models;

namespace Trees
{
    public sealed class Validation
    {
        public double CheckCapacity()
        {
            TreeInfo treeInfo = new();
            treeInfo.Capacity = Prompt.Input<double>("Enter total area of your plot, where you want to plant trees");
            if (treeInfo.Capacity > 0)
            {
                return treeInfo.Capacity;
            }
            else
            {
                do
                {
                    Console.WriteLine("Invalid input! Please try again!");
                    treeInfo.Capacity = Prompt.Input<double>("Enter area of your plot");
                }
                while (treeInfo.Capacity <= 0);

                return treeInfo.Capacity;
            }
        }

        public int CheckAmountOfTrees(string sortOfTree)
        {
            var amount = Prompt.Input<int>($"Enter amount of {sortOfTree}");

            if (amount >= 0)
                return amount;

            else
            {
                do
                {
                    Console.WriteLine("Invalid input! Please try again!");
                    amount = Prompt.Input<int>($"Enter amount of {sortOfTree}");
                }
                while (amount < 0);

                return amount;
            }
            
        }
    }
}
