using Trees.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        ITreeService treeService = new TreeService();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\t\t\t\tWelcome!");
        Console.ForegroundColor = ConsoleColor.White;
        treeService.CreatePlot();
    }
}