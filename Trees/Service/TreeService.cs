using Sharprompt;
using Sharprompt.Fluent;
using Spectre.Console;
using Trees.Factory;
using Trees.Models;
using Trees.Models.Enums;
using Trees.Solution;

namespace Trees.Service
{
    public sealed class TreeService : ITreeService
    {
        private readonly Validation _validation;
        private readonly Creator _creator;
        private readonly TreeInfo _treeInput;
        public TreeService()
        {
            _validation = new Validation();
            _creator = new Creator();
            _treeInput = new TreeInfo();
        }

        /// <summary>
        /// Create a new plot.
        /// </summary>
        public void CreatePlot()
        {
            _treeInput.Capacity = _validation.CheckCapacity();

            ShowMainMenu();
        }

        /// <summary>
        /// Change capacity of plot.
        /// </summary>
        public void ChangeCapacityOfPlot()
        {
            _treeInput.Capacity = _validation.CheckCapacity();

            Console.WriteLine("Successfuly changed!");

            ShowMainMenu();
        }

        /// <summary>
        /// Create tree.
        /// </summary>
        public void CreateTree()
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

                _treeInput.Trees.Add(treeFactory);
            }

            ShowMainMenu();
        }

        /// <summary>
        /// Print total area, maximum average height, maximum years after all trees give fruits.
        /// </summary>
        public void PrintResult()
        {
            Calculator solution = new();
            var result = solution.GetResult(_treeInput.Trees);
            DrawTable(_treeInput.Capacity, result.TotalArea, result.MaxHeight, result.Year);

            Console.ForegroundColor = ConsoleColor.White;
            
            ShowMainMenu();
        }
        
        /// <summary>
        /// Show capacity.
        /// </summary>
        public void ShowCapacity()
        {
            Table table = new Table();
            table.AddColumn("Capacity");
            table.AddRow(_treeInput.Capacity.ToString() + "m2");
            AnsiConsole.Write(table);

            ShowMainMenu();
        }

        /// <summary>
        /// Show main menu.
        /// </summary>
        public void ShowMainMenu()
        {
            var menu = Prompt.Select<MainMenu>("Menu");

            switch (menu)
            {
                case MainMenu.AddTree:
                    CreateTree();
                    break;
                case MainMenu.ChangeCapacity:
                    ChangeCapacityOfPlot();
                    break;
                case MainMenu.ShowCapacity:
                    ShowCapacity();
                    break;
                case MainMenu.ShowAllTrees:
                    ShowAllTrees(); 
                    break;
                case MainMenu.ShowResult:
                    PrintResult();
                    break;
            }
        }

        /// <summary>
        /// Show all trees and counts.
        /// </summary>

        public void ShowAllTrees()
        {
            var table = new Table(); 

            Console.ForegroundColor = ConsoleColor.Green;

            table.AddColumn("Name of sort");
            table.AddColumn("Count of tree");

            var trees = _treeInput.Trees;
            foreach(var tree in trees.DistinctBy(x => x.SortName))
            {
                table.AddRow(tree.SortName, trees.Count(x => x.SortName.Equals(tree.SortName)).ToString());
            }

            AnsiConsole.Write(table);

            Console.ForegroundColor = ConsoleColor.White;

            ShowMainMenu();
        }

        private void DrawTable(double capacity, double area, double maxHeight, double year)
        {
            var table = new Table();

            Console.ForegroundColor = ConsoleColor.Green;
            table.AddColumn("Your area");
            table.AddColumn("Area, that takes your trees");
            table.AddColumn("Maximum average height");
            table.AddColumn("Maximum years after all trees give fruits");
            table.AddRow(capacity.ToString(), area.ToString(), maxHeight.ToString(), year.ToString());

            AnsiConsole.Write(table);
        }
    }
}
