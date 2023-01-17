using Trees;
using Trees.Base;

internal class Program
{
    private static void Main(string[] args)
    {
        IList<ITree> trees = new List<ITree>();

        Menu menu = new Menu();
        Console.WriteLine("\t\t\t\tWelcome!");

        menu.ShowMenu(trees);
    }
}