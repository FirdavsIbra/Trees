using Sharprompt;

namespace Trees
{
    public sealed class Validation
    {
        public bool CheckCapacity(double capacity)
        {
            if (capacity <= 0)
                return false;
            return true;
        }
        
        public int CheckAmountOfTrees(string sortOfTree)
        {
            string amount1;
            var amount = Prompt.Input<int>($"Enter amount of {sortOfTree}");
            while (amount < 0)
            {
                Console.WriteLine("Value must be greater than zero! Try again!");
                Console.Write($"Enter amount of {sortOfTree}: ");
                amount1 = Console.ReadLine();
                amount = int.Parse(amount1);
            }
            return amount;
        }
    }
}
