using Sharprompt;
using Trees.Base;
using Trees.Solution;
using Trees.TypesOfSorts.Apples;
using Trees.TypesOfSorts.Grapes;
using Trees.TypesOfSorts.Pears;

internal class Program
{
    private static void Main(string[] args)
    {
        IList<ITree> trees = new List<ITree>();

        Console.WriteLine("\t\t\t\tWelcome!");
        var plotSize = Prompt.Input<double>("Enter total area of your plot, where you want to plant trees");
        Console.WriteLine(plotSize);

        var tree = Prompt.MultiSelect("Select your tree that you want to plant", new[] { "Apple", "Grape", "Pear" });

        if (tree.Contains("Apple"))
        {
            var sortOfApple = Prompt.MultiSelect("Select sort of apple that you want to plant", new[] { "Golden", "Semerenko", "Saltanat", "GrannySmith", "PinkLady" });

            if (sortOfApple.Contains("Golden"))
            {
                var amount = Prompt.Input<int>("Enter amount of Golden trees");

                for (int i = 0; i < amount; i++)
                {
                    var golden = new Golden();

                    trees.Add(golden);
                }
            }
            if (sortOfApple.Contains("Semerenko"))
            {
                var amount = Prompt.Input<int>("Enter amount of Semerenko trees");

                for (int i = 0; i < amount; i++)
                {
                    var semerenko = new Semerenko();

                    trees.Add(semerenko);
                }
            }
            if (sortOfApple.Contains("Saltanat"))
            {
                var amount = Prompt.Input<int>("Enter amount of Saltanat trees");

                for (int i = 0; i < amount; i++)
                {
                    var saltanat = new Saltanat();

                    trees.Add(saltanat);
                }
            }
            if (sortOfApple.Contains("GrannySmith"))
            {
                var amount = Prompt.Input<int>("Enter amount of GrannySmith trees");

                for (int i = 0; i < amount; i++)
                {
                    var grannySmith = new GrannySmith();

                    trees.Add(grannySmith);
                }
            }
            if (sortOfApple.Contains("PinkLady"))
            {
                var amount = Prompt.Input<int>("Enter amount of PinkLady trees");

                for (int i = 0; i < amount; i++)
                {
                    var pinkLady = new PinkLady();

                    trees.Add(pinkLady);
                }
            }
        }
        if (tree.Contains("Grape"))
        {
            var sorts = Prompt.MultiSelect("Select sort of grape that you want to plant", new[] { "Kishmish", "Xusein" });

            if (sorts.Contains("Kishmish"))
            {
                var amount = Prompt.Input<int>("Enter amount of Kishmish trees");

                for (int i = 0; i < amount; i++)
                {
                    var kishmish = new Kishmish();

                    trees.Add(kishmish);
                }
            }
            if (sorts.Contains("Xusein"))
            {
                var amount = Prompt.Input<int>("Enter amount of Xusein trees");

                for (int i = 0; i < amount; i++)
                {
                    var xusein = new Xusein();

                    trees.Add(xusein);
                }
            }
        }

        if (tree.Contains("Pear"))
        {
            var sorts = Prompt.MultiSelect("Select sort of pear that you want to plant", new[] { "Gvidon" });

            if (sorts.Contains("Gvidon"))
            {
                var amount = Prompt.Input<int>("Enter amount of Gvidon trees");

                for (int i = 0; i < amount; i++)
                {
                    var gvidon = new Gvidon();

                    trees.Add(gvidon);
                }
            }
        }

        Calculator solution = new Calculator();
        var result = solution.GetResult(trees);

        Console.WriteLine($"\nYour area: {plotSize} m^2 \n\nTotal area your trees take: {result.TotalArea} m^2");
        Console.WriteLine($"\nMaximum average height: {result.MaxHeight} m");
        Console.WriteLine($"\nMaximum years after all trees give fruits: {result.Year}");
    }
}