using Sharprompt;
using Sharprompt.Fluent;
using Trees.Base;
using Trees.Enums;
using Trees.Factory;
using Trees.Solution;

namespace Trees
{
    public sealed class Menu
    {
        private readonly Validation _validation;
        private readonly Creator _creator;
        public Menu()
        {
            _validation = new Validation();
            _creator = new Creator();
        }

        public void ShowMenu(IList<ITree> trees)
        {
            var plotSize = Prompt.Input<double>("Enter total area of your plot, where you want to plant trees");
            if (_validation.CheckCapacity(plotSize))
            {
                UserInput(trees);

                var answer = Prompt.Confirm("Do you want to plant more tree?");
                while (answer)
                {
                    UserInput(trees);
                    answer = Prompt.Confirm("Do you want to plant more tree?");
                }
                PrintResult(trees, plotSize);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        public void ShowMainMenu(IList<ITree> trees)
        {
            var menu = Prompt.Select<MainMenu>("Menu");
            
            switch (menu)
            {
                case MainMenu.CreateNewField:
                    ShowMenu(trees);
                    break;
                case MainMenu.DeleteTree:
                    ShowMenu(trees);
                    break;
                case MainMenu.AddTree:
                    UserInput(trees);
                    break;
            }
        }

        private void UserInput(IList<ITree> trees)
        {
            var treeType = Prompt.Select<string>(o => o.WithMessage("Select your tree")
                                 .WithItems(new[] { "Apple", "Grape", "Pear" }));

            var typesOfTree = _creator.TreeFactory(Enum.Parse<TypeOfTree>(treeType));

            var sortOfTree = Prompt.Select<string>(o => o.WithMessage("Select your sort of tree")
                                           .WithItems(typesOfTree));

            var amount = _validation.CheckAmountOfTrees(sortOfTree);
            
            for (int index = 0; index < amount; index++)
            {
                var treeFactory = _creator.TreeFactory(Enum.Parse<SortOfTree>(sortOfTree));

                trees.Add(treeFactory);
            }
        }

        private void PrintResult(IList<ITree> trees, double plotSize)
        {
            Calculator solution = new();
            var result = solution.GetResult(trees);

            Console.WriteLine($"\n\nYour area: {plotSize} m^2 \n\nTotal area your trees take: {result.TotalArea} m^2");
            Console.WriteLine($"\nMaximum average height: {result.MaxHeight} m");
            Console.WriteLine($"\nMaximum years after all trees give fruits: {result.Year}");
        }

        private void GetAllTrees(IList<ITree> trees)
        {
            foreach(var tree in trees)
            {
                Console.WriteLine(tree.SortName.Distinct().Count());
            }
        }

    }
}

